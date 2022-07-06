﻿using Business.Logic;
using Business.Utils;
using System;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    static class Program
    {
        public static IoCContainer IoCContainer;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RegisterDependencyResolver();

            Application.Run(new Usuarios(IoCContainer.TryResolve<IUsuarioLogic>()));
        }

        static void RegisterDependencyResolver()
        {
            IoCContainer = IoCContainer.Instance;

            IoCContainer.Register();

        }
    }
}
