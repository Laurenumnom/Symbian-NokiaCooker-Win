using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Firmware;
using System.Threading;
using System.Reflection;
using System.IO;


namespace FuzzyByte.NokiaCooker
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            string appGuid = Assembly.GetExecutingAssembly().GetType().GUID.ToString();

            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
            {
                using (Form1 form = new Form1(args))
                {

                    Application.Run(form);
                }
            }
        }

        // Non GUI
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = e.ExceptionObject as Exception;
                if (ex != null)
                {
#if DEBUG
                    Notes.ShowError("Unexpected Error", ex.Message + "\n"+ ex.StackTrace);
#else
                    Notes.ShowError("Unexpected Error", ex.Message);
#endif
                }
            }
            finally
            {
                Application.Exit();
            }
            throw new NotImplementedException();
        }

        // GUI Exception
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            try
            {
#if DEBUG
                Notes.ShowError("Unexpected Error", e.Exception.Message + "\n" + e.Exception.StackTrace);
#else
                Notes.ShowError("Unexpected Error", e.Exception.Message);
#endif
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
