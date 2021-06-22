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

        private void btn_vaccinationProcess_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            using (frmRegisterCitizen window = new frmRegisterCitizen())
            {
                window.ShowDialog();
            }
        }
    }
}