using System;
using System.Windows.Forms;

namespace Proyecto_POO_BDD
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "Bienvenido", "Vaccination", MessageBoxButtons.OK,MessageBoxIcon.Hand);


        }
    }
}