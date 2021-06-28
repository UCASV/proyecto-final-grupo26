using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
<<<<<<< HEAD
using iTextSharp.text;
using iTextSharp.text.pdf;
=======
>>>>>>> 05dd5268232156d4b201335a29290d6af0c82b61
using Org.BouncyCastle.Asn1.Cms;
using Proyecto_POO_BDD.SqlServerContext;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
namespace Proyecto_POO_BDD
{
    public partial class frmVaccinationProcess : Form
    {
        private Employee employee { get; set; } // enviar el empleado que esta registrando si se desea registrar a un ciudadano
        private ProCitasContext db = new ProCitasContext(); //tener acceso a la base de datos
       
        public frmVaccinationProcess(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }
        
        
        private void frmVaccinationProcess_Load(object sender, EventArgs e)
        {
            tabVaccinationProcess.ItemSize = new Size(0, 1);
            this.Height = 285;
            
            //Enlace comboBox que contiene los efecto secundarios
            cmbSideEffect.DataSource = db.SideEffects.ToList();
            cmbSideEffect.DisplayMember = "SideEffects";
            cmbSideEffect.ValueMember = "Id";
            
            //La segunda vacuna se coloca minimo dentro de 6 semanas
            //Se suman 42 dias apartir de la primera dosis (dia actual) que equivale a 6 semanas
            dtp_date2vaccine.MinDate = DateTime.Now.AddDays(42);
            //La segunda vacuna se coloca maximo dentro de 8 semanas
            //Se suman 56 dias apartir de la primera dosis (dia actual) que equivale a 8 semanas
            dtp_date2vaccine.MaxDate = DateTime.Now.AddDays(56);
        }

        private void btn_aceptDui_Click(object sender, EventArgs e)
        {
            var listOfCitizen = db.Citizens.OrderBy(c => c.Id).ToList();

            var result = listOfCitizen.Where(e =>
                e.Dui.Equals(txt_dui.Text)).ToList();

            if (result.Count == 0)
            {
                DialogResult answer = MessageBox.Show("El usuario aun no esta registrado\n ¿Desea regsitrarlo?", "Vaccination Program", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    using (frmRegisterCitizen window = new frmRegisterCitizen(employee))
                    { 
                        this.Hide(); 
                        window.ShowDialog();
                    }
                }
            }
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
<<<<<<< HEAD
           /* SaveFileDialog saveFileDialog1 = new SaveFileDialog();
=======

            
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
>>>>>>> 05dd5268232156d4b201335a29290d6af0c82b61
            saveFileDialog1.Title = "Save your Vaccination Card";
            saveFileDialog1.ShowDialog();
            MessageBox.Show("Segunda cita registrada", "Segunda cita de vacunación", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
            */
           
                SaveFileDialog save = new SaveFileDialog(); 
                save.Filter = "PDF (*.pdf)|*.pdf"; //tipo PDF
                save.FileName = "Result.pdf"; //Nombre por defecto
        
                bool ErrorMessage = false;
        
                if (save.ShowDialog()==DialogResult.OK)
                    if (File.Exists(save.FileName)) 
                    {    
                        ErrorMessage = true; 
                        MessageBox.Show("No se puede reemplazar el archivo, favor cambiar nombre del archivo o eliminar el ya existente");
                    }
                if (!ErrorMessage)
                {
                    try
                    {
                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);//margenes 
                            PdfWriter.GetInstance(document, fileStream);
                            document.Open();
                            //Agregando informacion al documento
                            document.Add(new Paragraph("INFORMACIÓN CITA COVID-19\n")); 
                            document.Add(new Paragraph("Primera vacuna")); 
                            document.Add(new Paragraph("Fecha: " + dtp_dateVaccineRecieved.Value));
                            //frmRegisterCitizen reference = new frmRegisterCitizen();
                            
                                
                            
                            //document.Add(new Paragraph("Hora: " + dtp_dateVaccineRecieved.Value));
                            if (radNoSideEffects.Checked)
                            {
                                document.Add((new Paragraph("No presento efectos adversos")));
                            }
                            else if (radYesSideEffects.Checked)
                            {
                                document.Add(new Paragraph("Presentó efectos adversos"));
                                document.Add(new Paragraph("Efecto secundario:" + cmbSideEffect.SelectedItem));
                            }
                            
                            
                                //si no se ha reservado la segunda cita (esta en null) se omite en el PDF
                            try
                            {
                                document.Add(new Paragraph("\nSegunda vacuna"));
                                document.Add(new Paragraph("Fecha: " + dtp_date2vaccine.Value));
                                //document.Add(new Paragraph("Hora: " + dtp_date2vaccine.Value));
                            }
                            catch (Exception exception)
                            {
                               // document.Add(new Paragraph("Lugar: " + dgv_citizenInformation.Rows[0].Cells[4].Value.ToString()));
                            }
                            
                            document.Close();

                            fileStream.Close();
                        } 
                        MessageBox.Show("Archivo guardado","info");
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show("Se ha presentado un error al intentar guardar el archivo " + ex.Message); 
                    }
                }
                else
            { 
                MessageBox.Show("No se ha encontrado el registro a guardar","Info");
            }
        
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