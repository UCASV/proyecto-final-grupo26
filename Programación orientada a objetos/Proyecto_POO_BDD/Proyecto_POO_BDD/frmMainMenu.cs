using System;
using System.Windows.Forms;

namespace Proyecto_POO_BDD
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }


        private void btn_citizenRegister_Click(object sender, EventArgs e)
        {
            using (frmRegisterCitizen window = new frmRegisterCitizen())
            {
                this.Hide();
                window.ShowDialog();
            }
            this.Show();
        }
    }
}