﻿
using System;

using System.Windows.Forms;

namespace QLKhachSan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI.frmLogin());
            // Application.Run(new BUS.Form1());

        }
    }
}
