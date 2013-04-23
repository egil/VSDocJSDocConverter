using System;
using System.Drawing;
using System.Reactive.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VSDocJSDocConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var main = new Main();                 
            Application.Run(main);            
        }
    }
}
