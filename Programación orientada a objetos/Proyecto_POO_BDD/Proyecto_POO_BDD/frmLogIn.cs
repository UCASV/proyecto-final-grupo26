using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_POO_BDD.SqlServerContext;

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
            var db = new ProCitasContext();
            var listOfEmployees = db.Employees.
                OrderBy(c => c.Id).ToList();

            var result = listOfEmployees.Where(e =>
                e.NameEmployee.Equals(txt_user.Text) &&
                e.Passwordd.Equals((txt_password.Text))).ToList();

            if (result.Count == 0)
                MessageBox.Show("Este usuario no existe", "Vaccination Program", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            
            else
            {
                MessageBox.Show("Bienvenido Gestor!", "Vaccination Program", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                frmMainMenu window = new frmMainMenu();
                window.Show();
                this.Hide();
            }
        }
    }
}