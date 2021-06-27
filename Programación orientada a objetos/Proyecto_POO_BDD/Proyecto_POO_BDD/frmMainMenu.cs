using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_POO_BDD.SqlServerContext;

namespace Proyecto_POO_BDD
{
    public partial class frmMainMenu : Form
    {
        private Employee employee { get; set; }

        public frmMainMenu(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }


        private void btn_citizenRegister_Click(object sender, EventArgs e)
        {
            using (frmRegisterCitizen window = new frmRegisterCitizen(employee))
            {
                this.Hide();
                window.ShowDialog();
            }
            this.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            lbl_user.Text = $"Usuario: {employee.NameEmployee}";
        }

        private void btn_vaccinationProcess_Click(object sender, EventArgs e)
        {
            using (frmVaccinationProcess window = new frmVaccinationProcess())
            {
                this.Hide();
                window.ShowDialog();
            }
            this.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (frmSearch window = new frmSearch())
            {
                this.Hide();
                window.ShowDialog();
            }
            this.Show();
        }
    }
}