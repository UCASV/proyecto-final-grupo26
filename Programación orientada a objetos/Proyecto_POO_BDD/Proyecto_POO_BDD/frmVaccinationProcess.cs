using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Proyecto_POO_BDD.SqlServerContext;

namespace Proyecto_POO_BDD
{
    public partial class frmVaccinationProcess : Form
    {
        private ProCitasContext db = new ProCitasContext();

        public frmVaccinationProcess()
        {
            InitializeComponent();
        }

        private void frmVaccinationProcess_Load(object sender, EventArgs e)
        {
            tabVaccinationProcess.ItemSize = new Size(0, 1);

            this.Height = 280;
        }

        private void btn_aceptDui_Click(object sender, EventArgs e)
        {
            var listOfCitizen = db.Citizens.OrderBy(c => c.Id).ToList();

            var result = listOfCitizen.Where(e =>
                e.Dui.Equals(txt_dui.Text)).ToList();

            if (result.Count == 0)
                MessageBox.Show("El usuario aun no esta registrado", "Vaccination Program", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation);
            //Agregar la opcion de registrarlo

            else
            {
                tabVaccinationProcess.SelectedIndex = 1;
                this.Height = 360;
                
            }
        }

        private void btnConsentAcepted_Click(object sender, EventArgs e)
        {
            tabVaccinationProcess.SelectedIndex = 2;
            this.Height = 315;

        }

        private void chkConsent_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConsent.Checked = true)
            {
                btnConsentAcepted.BackColor = ColorTranslator.FromHtml("#ed1b24");
                btnConsentAcepted.Enabled = true;
            }
        }

        private void btn_queueAcept_Click(object sender, EventArgs e)
        {
            Citizen c = db.Citizens.First(c => c.Dui.Equals(txt_dui.Text));

            c.DateWline = dtp_queueDate.Value.Date;
            c.TimeWline = dtp_queueDate.Value.TimeOfDay;

            db.SaveChanges();

            tabVaccinationProcess.SelectedIndex = 3;
        }
    }
}