using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace WhoisGet
{
    public class Log
    {
        public static RichTextBox rt;

        public static void write(string vaule)
        {
            rt.Text += vaule + "\r\n";

            rt.SelectionStart = rt.TextLength;
            rt.ScrollToCaret();

            Application.DoEvents();
        }

        public static void clear()
        {
            rt.Text = "";
        }

    }
}
