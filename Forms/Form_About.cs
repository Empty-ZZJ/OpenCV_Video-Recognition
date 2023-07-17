using SkinSharp;
using System;
using System.Windows.Forms;

namespace VideoSystem.Forms
{

    public partial class Form_About : Form
    {
        public SkinH_Net WindowsCoreSkin;
        public Form_About ()
        {
            InitializeComponent();
        }

        private void Button_Ok_Click (object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form_About_Load (object sender, EventArgs e)
        {
            Skin_class:
            {
                WindowsCoreSkin = new SkinH_Net();
                WindowsCoreSkin.AttachEx(System.Windows.Forms.Application.StartupPath + "\\Public\\windows-core-ui.she", "");
                int mycolor;
                System.Drawing.Color c = System.Drawing.Color.DarkGray;
                mycolor = c.A * 256 * 256 * 256 + c.R * 256 * 256 + c.G * 256 + c.B;
                IntPtr hWnd = DllImport_Pro.DllImport_Pro.FindWindow(null, "关于本程序");
                DllImport_Pro.DllImport_Pro.windows_shadow(hWnd.ToInt32(), mycolor, 5);

            }
        }
    }
}
