using System;
using System.Windows.Forms;

namespace VideoSystem.Forms
{
    public partial class Full : Form
    {
        public Full ()
        {
            InitializeComponent();
        }

        private void Full_Load (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.BackgroundImage=
        }
    }
}
