﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestHarness
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Тестовый комментарий
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new Form1() );
        }
    }
}
