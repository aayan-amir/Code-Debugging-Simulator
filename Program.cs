using System;
using System.Windows.Forms;

namespace Code_Debugging
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 1️⃣  Standard WinForms start‑up plumbing
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 2️⃣  Launch whatever form you want first:
            new Menu();
            //     • new Form1();      – if Form1 should open first
            //     • new Form3(); etc.
            Application.Run(new Menu());
        }
    }
}
