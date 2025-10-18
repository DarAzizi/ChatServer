using System;
using System.Windows.Forms;

namespace ChatServer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show("Erreur non gérée : " + e.Exception.Message);
            };

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}