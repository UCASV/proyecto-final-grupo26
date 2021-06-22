using System;
using System.Windows.Forms;

using Microsoft.VisualBasic;


namespace Proyecto_POO_BDD
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        
        private void brn_register_Click(object sender, EventArgs e)
        {
            frmLogIn window = new frmLogIn();
            window.ShowDialog();
        }
        
    }
}