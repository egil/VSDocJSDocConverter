using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSDocJSDocConverter
{
    public partial class Main : Form
    {
        private const string Preamble = "/**";
        private const string Postamble = " */";

        public Main()
        {
            InitializeComponent();
            InitProcessClipboardData();
        }

        private void pasteTextBox_DoubleClick(object sender, EventArgs e)
        {
            pasteTextBox.SelectAll();
        }

        private void InitProcessClipboardData()
        {
            // subscribe to clipboard events process input...
            var clipboardText = Observable.FromEventPattern<ClipboardEventArgs>(h => pasteTextBox.Pasted += h, h => pasteTextBox.Pasted -= h)
                // clear previous results
                .Do(_ => pasteTextBox.Clear())
                // get clipboard text
                .Select(evt => evt.EventArgs.ClipboardText)
                // remove spaces in front of all lines
                .Select(text => Regex.Replace(text, @"^\s*", string.Empty, RegexOptions.Multiline))
                // remove /// from all lines
                .Select(text => Regex.Replace(text, @"///\s", string.Empty, RegexOptions.Multiline))
                // rewrite <remarks /> and <summary />
                .Select(text =>
                {
                    var remarkssplit = Regex.Split(text, @"<remarks>\r\n(.*)\r\n</remarks>\s*", RegexOptions.Singleline);
                    var remarksSummary = remarkssplit.Length > 1
                                             ? string.Format("$1{0}Remarks: {1}{0}", Environment.NewLine, remarkssplit[1])
                                             : "$1";
                    var res = Regex.Replace(Regex.Replace(text, @"<remarks>.*</remarks>", string.Empty, RegexOptions.Singleline),
                            @"<summary>\r\n(.*)</summary>", remarksSummary,
                            RegexOptions.Singleline);
                    return res;
                })
                // rewrite paramters
                .Select(text => Regex.Replace(text, @"<param name=\""([^\""]+)\""(?: type=\""([^\""]+)\"")?>[\r\n\s]*(.+)[\r\n]*?</param>", "@param {$2} $1 $3", RegexOptions.Multiline))
                // remove weird text string from jsdoc in rx, replace with spaces
                .Select(text => Regex.Replace(text, " *&#10;", "    ", RegexOptions.Multiline))
                // rewrite return 
                .Select(text => Regex.Replace(text, @"<returns(?: type=\""([^\""]+)\"")?\s*(?:/>|>(.+)</returns>)", "@return {$1} $2"))
                // remove any trailing spaces and newlines before and after parsed text
                .Select(text => text.Trim())
                // add jsdoc * to each line
                .Select(text => Regex.Replace(text, "^", " * ", RegexOptions.Multiline))
                // add preamble and postamble
                .Select(text => string.Format("{1}{0}{2}{0}{3}", Environment.NewLine, Preamble, text, Postamble));

            clipboardText.Subscribe(text =>
            {
                pasteTextBox.Text = text;
                Clipboard.SetText(text);
            },
                                    exception =>
                                    {
                                        MessageBox.Show(exception.Message, "Error during processing!",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Error);
                                    });
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WindowMaximised)
            {
                WindowState = FormWindowState.Maximized;
                Location = Properties.Settings.Default.WindowLocation;
                Size = Properties.Settings.Default.WindowSize;
            }
            else
            {
                Location = Properties.Settings.Default.WindowLocation;
                Size = Properties.Settings.Default.WindowSize;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.WindowLocation = RestoreBounds.Location;
                Properties.Settings.Default.WindowSize = RestoreBounds.Size;
                Properties.Settings.Default.WindowMaximised = true;
            }
            else
            {
                Properties.Settings.Default.WindowLocation = Location;
                Properties.Settings.Default.WindowSize = Size;
                Properties.Settings.Default.WindowMaximised = false;
            }
            Properties.Settings.Default.Save();
        }

        private void clearStripMenuItem1_Click(object sender, EventArgs e)
        {
            pasteTextBox.Clear();

        }

        private void copyStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pasteTextBox.Text);
        }

        private void pasteStripMenuItem3_Click(object sender, EventArgs e)
        {
            pasteTextBox.Text = Clipboard.GetText();
        }

        private void selectAllStripMenuItem4_Click(object sender, EventArgs e)
        {
            pasteTextBox.SelectAll();            
        }
    }
}
