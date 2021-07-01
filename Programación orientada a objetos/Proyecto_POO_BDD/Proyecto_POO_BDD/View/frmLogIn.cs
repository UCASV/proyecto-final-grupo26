using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_POO_BDD.SqlServerContext;

namespace Proyecto_POO_BDD.View
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new ProCitasContext();
                
                var listOfEmployees = db.Employees.OrderBy(c => c.Id);

            var result = listOfEmployees.Where(e =>
                e.UserG.Equals(txt_user.Text) && 
                e.Passwordd.Equals((txt_password.Text))).ToList();

            if (result.Count == 0)
                MessageBox.Show("Este usuario no existe", "Vaccination Program", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

            else
            {
                MessageBox.Show("Bienvenido Gestor!", "Vaccination Program", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                //Instanciando objeto del tipo record               
                var newRegister = new Record();
                
                //Añadiendo fecha y hora actual a la que se inicio sesion
                newRegister.DateR = DateTime.Today;
                newRegister.TimeR = DateTime.Now.TimeOfDay;
                
                Employeexcabin xref = db.Set<Employeexcabin>()
                    .SingleOrDefault(x => x.IdEmployee.Equals(result[0].Id));
                
                Cabin cbdd = db.Set<Cabin>()
                    .SingleOrDefault(c => c.Id == xref.IdCabin);
                
                newRegister.IdEmployee = result[0].Id;
                newRegister.IdCabin = cbdd.Id;

                db.Add(newRegister);
                db.SaveChanges();
                
                using (frmMainMenu window = new frmMainMenu(result[0]))
                {
                    this.Hide();
                    window.ShowDialog();
                }
                this.Show();
                txt_user.Clear(); 
                txt_password.Clear();
            }
        }
            catch (Exception exception)
            {
                MessageBox.Show($"No es posible conectar con la base de datos");
                throw;
            }
        }
    }
}
