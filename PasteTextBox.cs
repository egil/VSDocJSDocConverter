using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSDocJSDocConverter
{
    public class ClipboardEventArgs : EventArgs
    {
        public string ClipboardText { get; set; }
        public ClipboardEventArgs(string clipboardText)
        {
            ClipboardText = clipboardText;
        }
    }

    public class PasteTextBox : TextBox
    {
        public event EventHandler<ClipboardEventArgs> Pasted;

        private const int WM_PASTE = 0x0302;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE)
            {
                var evt = Pasted;
                if (evt != null)
                {
                    evt(this, new ClipboardEventArgs(Clipboard.GetText()));
                }
            }

            base.WndProc(ref m);
        }
    }
}
