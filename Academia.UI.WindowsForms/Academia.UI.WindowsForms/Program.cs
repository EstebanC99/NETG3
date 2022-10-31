using Business.Utils;
using Cross.Exceptions;
using Cross.Labels;
using System;
using System.Diagnostics;
using System.Threading;
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
            Application.ThreadException += new ThreadExceptionEventHandler(MyHandler);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            RegisterDependencyResolver();

            Application.Run(new MenuPrincipal());
        }

        static void RegisterDependencyResolver()
        {
            IoCContainer = IoCContainer.Instance;

            IoCContainer.Register();

        }

        static void MyHandler(object sender, ThreadExceptionEventArgs args)
        {
            if (args.Exception is ValidationException)
            {
                EventLog.WriteEntry("Academia", $"{args.Exception.Message} - {args.Exception.StackTrace}", EventLogEntryType.Information);
                MessageBox.Show(args.Exception.Message, Labels.Error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                EventLog.WriteEntry("Academia", $"{args.Exception.Message} - {args.Exception.StackTrace}", EventLogEntryType.Error);
                MessageBox.Show("Ocurrió un error inesperado...", Labels.Error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
