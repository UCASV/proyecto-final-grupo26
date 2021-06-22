using System;
using System.Windows.Forms;
<<<<<<< HEAD
using Microsoft.VisualBasic;
using Microsoft.VisualBasic;
=======
>>>>>>> 3d6e4200b4cb12faa46601a07a3136d7337e9dda


namespace Proyecto_POO_BDD
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        



        private void brn_register_Click(object sender, EventArgs e)
        {
            frmLogIn window = new frmLogIn();
            window.ShowDialog();

        }
=======

    
>>>>>>> 3d6e4200b4cb12faa46601a07a3136d7337e9dda

        private void btn_register_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            

=======
            using (frmRegisterCitizen window = new frmRegisterCitizen())
            {
                window.ShowDialog();
            }
>>>>>>> 3d6e4200b4cb12faa46601a07a3136d7337e9dda
        }
        
    }
}