﻿using System;

using System.Collections.Generic;
using System.Windows.Forms;

namespace ML_Forest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new CoutingTable());
        }
    }
}