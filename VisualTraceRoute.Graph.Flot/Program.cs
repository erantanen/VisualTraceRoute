﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VisualTraceRoute.Graph.Flot
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Flot());
        }
    }
}
