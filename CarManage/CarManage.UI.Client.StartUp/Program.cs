﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CarManage.UI.Client.Common;

namespace CarManage.UI.Client.StartUp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ClassLibrary.Configuration.ConfigurationManager.Instance.Init();
            Application.Run(new Login());
        }
    }
}
