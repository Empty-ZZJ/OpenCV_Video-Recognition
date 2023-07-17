using System;
using System.Windows.Forms;
namespace VideoSystem
{
    internal static class RunProgram
    {
        [STAThread]
        static void Main ()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());


        }
    }
}
