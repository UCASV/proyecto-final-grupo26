using System;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
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
            var listOfEmployees = db.Employees.OrderBy(c => c.Id).ToList();

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
                frmMainMenu window = new frmMainMenu(result[0]);
                window.Show();

                DateTime date = DateTime.Today;
                string formatDate = "yyyy MM d";

                string fullTime = $"{date.ToString(formatDate)}";
<<<<<<< HEAD

               //DateTime time = DateTime.Now;
                DateTime time = DateTime.Now;

=======
                DateTime time = DateTime.Now;
>>>>>>> 9515f614d87ebf2f3d096797a1073b9366fc3b24
                string formatTime = "hh mm";


                var newRegister = new Record();
                newRegister.DateR = DateTime.Today;
<<<<<<< HEAD

                //newRegister.TimeR = DateTime.Now.TimeOfDay;

                newRegister.TimeR = DateTime.Now.TimeOfDay;

=======
                newRegister.TimeR = DateTime.Now.TimeOfDay;
>>>>>>> 9515f614d87ebf2f3d096797a1073b9366fc3b24

                db.Add(newRegister);
                db.SaveChanges();

                this.Hide();
            }
        }
    }
}
