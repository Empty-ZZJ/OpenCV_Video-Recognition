using System;
using System.Windows.Forms;

namespace VideoSystem.Forms
{
    public partial class Form_About : Form
    {
        public Form_About ()
        {
            InitializeComponent();
        }

        private void Button_Ok_Click (object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
