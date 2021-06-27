using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cms;
using Proyecto_POO_BDD.SqlServerContext;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
            
            //TODO: Asignar la fehca minima para la segunda cita dentro de 6 semanas 
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
            if (chkConsent.Checked)
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
            if(Int32.Parse(txt_minutesEffects.Text) <= 0)
                MessageBox.Show("Minutos invalidos", "Vacuna Covid-19", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else if(Int32.Parse(txt_minutesEffects.Text) > 30)
                MessageBox.Show("El tiempo de observacion maximo es de 30 minutos", "Vacuna Covid-19", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            
            this.Height = 440;
            tabVaccinationProcess.SelectedIndex = 3;
            radYesSideEffects.Checked = true;
        }

        private void btn_aceptVaccineRecieved_Click(object sender, EventArgs e)
        {
            Citizen c = db.Citizens.First(c => c.Dui.Equals(txt_dui.Text));

            if (radYesSideEffects.Checked)
            {
                c.TimeEffect = Int32.Parse(txt_minutesEffects.Text); //se ingresan los minutos
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
                this.Height = 280;
                
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
        }

        private void btn_Acept2vaccine_Click(object sender, EventArgs e)
        {
            /* System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 20);
            gfx.DrawString("Tryouts", font, XBrushes.Blue,
                
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.Center);
*/
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save your Vaccination Card";
            saveFileDialog1.ShowDialog();

            //document.Save();

            MessageBox.Show("Segunda cita registrada", "Segunda cita de vacunación", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            this.Close();
        }

        private void btn_dateTimeNowQueue_Click(object sender, EventArgs e)
        {
            Citizen c = db.Citizens.First(c => c.Dui.Equals(txt_dui.Text));
            
            c.DateWline = DateTime.Today;
            c.TimeWline = DateTime.Now.TimeOfDay;
            db.SaveChanges();
        }
    }
}