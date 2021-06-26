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
            this.Height = 285;
            
            //Enlace comboBox que contiene los efecto secundarios
            cmbSideEffect.DataSource = db.SideEffects.ToList();
            cmbSideEffect.DisplayMember = "SideEffects";
            cmbSideEffect.ValueMember = "Id";
        }

        private void btn_aceptDui_Click(object sender, EventArgs e)
        {
            var listOfCitizen = db.Citizens.OrderBy(c => c.Id).ToList();

            var result = listOfCitizen.Where(e =>
                e.Dui.Equals(txt_dui.Text)).ToList();

            if (result.Count == 0)
                MessageBox.Show("El usuario aun no esta registrado", "Vaccination Program", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation);
            
            //TODO: AGREGAR la opcion de registrarlo

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
            tabVaccinationProcess.SelectedIndex = 3;
            this.Height = 440;
        }

        private void radYesSideEffects_Click(object sender, EventArgs e)
        {
            tabVaccinationProcess.SelectedIndex = 4;
        }

        private void btn_CancelSideEffect_Click(object sender, EventArgs e)
        {
            this.Height = 440;
            tabVaccinationProcess.SelectedIndex = 3;
            radNoSideEffects.Checked = true;
        }

        private void btn_aceptTimeEffects_Click(object sender, EventArgs e)
        {
            this.Height = 440;
            tabVaccinationProcess.SelectedIndex = 3;
            radYesSideEffects.Checked = true;
        }

        private void btn_aceptVaccineRecieved_Click(object sender, EventArgs e)
        {
            Citizen c = db.Citizens.First(c => c.Dui.Equals(txt_dui.Text));

            c.DateWline = dtp_queueDate.Value.Date;
            c.TimeWline = dtp_queueDate.Value.TimeOfDay;

            if (radYesSideEffects.Checked)
            {
                //Se resta la hora en que se dan los efectos secundarios con la hora en que se coloco la vacuna 
                var Time = dtpTimeSideEffect.Value.TimeOfDay.Subtract(dtp_dateVaccineRecieved.Value.TimeOfDay);
                int minutes = Convert.ToInt32(Time.Minutes); // Se convierten los minutos a entero

                c.TimeEffect = minutes; //se ingresan los minutos
                c.DateEffect = dtp_dateVaccineRecieved.Value.Date;
                
                int idSideEffects = cmbSideEffect.SelectedIndex + 1; 
                // el indice empieza de 0 por lo que se le suma 1 para obtener su id

                SideEffect sbdd = db.Set<SideEffect>()
                    .SingleOrDefault(s => s.Id == idSideEffects);
                
                c.IdSideEffects = sbdd.Id;
            }
            else
            {
                c.TimeEffect = null;
                c.DateEffect = null;
            }
            InfoVaccination updateInfo = db.InfoVaccinations.First(i => i.Id.Equals(c.IdInfoVaccination));



            if (updateInfo.DateAppointment2 == null && updateInfo.TimeAppointment2 == null)
            {
                tabVaccinationProcess.SelectedIndex = 5;
                
                updateInfo.DateAppointment2 = dtp_date2vaccine.Value.Date;
                updateInfo.TimeAppointment2 = dtp_date2vaccine.Value.TimeOfDay;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Ambas dosis recibidas", "Vacuna Covid-19", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    db.SaveChanges();
                    
                    this.Close();
            }

            tabVaccinationProcess.SelectedIndex = 5;
            this.Height = 280;
        }

        private void btn_Acept2vaccine_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Segunda cita registrada", "Segunda cita de vacunación", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            this.Close();
        }
    }
}