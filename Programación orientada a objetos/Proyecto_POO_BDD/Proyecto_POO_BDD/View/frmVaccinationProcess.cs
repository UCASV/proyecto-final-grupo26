using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Proyecto_POO_BDD.SqlServerContext;

namespace Proyecto_POO_BDD.View
{
    public partial class frmVaccinationProcess : Form
    {
        private Employee employee { get; set; }
        // enviar el empleado que esta registrando si se desea registrar a un ciudadano

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
            
            //Estableciendo formato del canlendario y la hora para escojer la segunda cita
            dtp_date2vaccine.Format = DateTimePickerFormat.Custom;
            dtp_date2vaccine.CustomFormat = "yyyy/MM/dd    HH:mm";
            
            //La segunda vacuna se coloca minimo dentro de 6 semanas
            //Se suman 42 dias apartir de la primera dosis (dia actual) que equivale a 6 semanas
            dtp_date2vaccine.MinDate = DateTime.Now.AddDays(42);
            
            //La segunda vacuna se coloca maximo dentro de 8 semanas
            //Se suman 56 dias apartir de la primera dosis (dia actual) que equivale a 8 semanas
            dtp_date2vaccine.MaxDate = DateTime.Now.AddDays(56);
            
            //Que no se permita ver el calendario en el dateTimePicker porque solo se necesita la hora
            dtp_dateVaccineRecieved.ShowUpDown = true;
        }
        
        private void btn_aceptDui_Click(object sender, EventArgs e)
        {
            var listOfCitizen = db.Citizens.OrderBy(c => c.Id).ToList();

            var result = listOfCitizen.Where(e =>
                e.Dui.Equals(txt_dui.Text)).ToList();
            
            if (result.Count == 0)
            {
                DialogResult answer = MessageBox.Show("El usuario aun no esta registrado\n ¿Desea regsitrarlo?",
                    "Vaccination Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            chkConsent.Checked = true;

            if (chkConsent.Checked)
            {
                btnConsentAcepted.BackColor = ColorTranslator.FromHtml("#ed1b24");
                btnConsentAcepted.Enabled = true;
            }
        }
        
        private void btn_queueAcept_Click(object sender, EventArgs e)
        {
            tabVaccinationProcess.SelectedIndex = 3;// avanzar a la siguiente ventana
            this.Height = 440;
        }
        
        private void radYesSideEffects_Click(object sender, EventArgs e)
        {
            tabVaccinationProcess.SelectedIndex = 4;//Mostrar la ventana con los efectos secundarios 
            this.Height = 350;
        }
        
        private void btn_CancelSideEffect_Click(object sender, EventArgs e)
        {
            this.Height = 440;
            radNoSideEffects.Checked = true; //Y volver a marca no
            tabVaccinationProcess.SelectedIndex = 3;//Regresar a la ventana anterior
            
        }
        
        private void btn_aceptTimeEffects_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txt_minutesEffects.Text) <= 0)
                MessageBox.Show("Minutos invalidos", "Vacuna Covid-19", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            else if (Int32.Parse(txt_minutesEffects.Text) > 30)
                MessageBox.Show("El tiempo de observacion maximo es de 30 minutos", "Vacuna Covid-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                this.Height = 440;
                tabVaccinationProcess.SelectedIndex = 3; // avanzar a la siguiente venta    
            }
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
                tabVaccinationProcess.SelectedIndex = 5;// avanzar a la siguiente ventana
                this.Height = 300;

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
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf"; //tipo PDF
            save.FileName = $"{txt_dui.Text} Vacunacion.pdf"; //Nombre por defecto
            
            bool ErrorMessage = false;

            if (save.ShowDialog() == DialogResult.OK)
                if (File.Exists(save.FileName))
                {
                    ErrorMessage = true;
                    MessageBox.Show(
                        "No se puede reemplazar el archivo, favor cambiar nombre del archivo o eliminar el ya existente");
                }

            if (!ErrorMessage)
            {
                try
                {
                    using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 32f, 32f, 32f, 32f); //margenes 
                        PdfWriter.GetInstance(document, fileStream);

                        document.Open();

                        var yearRecieved = dtp_dateVaccineRecieved.Value.Year;
                        var monthRecieved = dtp_dateVaccineRecieved.Value.Month;
                        var dayRecieved = dtp_dateVaccineRecieved.Value.Day;
                        
                        //Agregando informacion al documento
                        document.Add(new Paragraph("INFORMACIÓN CITA COVID-19\n\n"));
                        document.Add(new Paragraph("vacuna realizada"));
                        document.Add(new Paragraph("Fecha: " + yearRecieved + "/" + monthRecieved + "/" + dayRecieved));
                        document.Add(new Paragraph("Hora: " + dtp_dateVaccineRecieved.Value.TimeOfDay));

                        //Agregar informacion de los efecto secundarios si se presentaron
                        if (radNoSideEffects.Checked)
                        {
                            document.Add((new Paragraph("No presento efectos secundarios")));
                        }
                        else if (radYesSideEffects.Checked)
                        {
                            int idSideEffects = cmbSideEffect.SelectedIndex + 1;
                            // el indice empieza de 0 por lo que se le suma 1 para obtener su id

                            SideEffect sbdd = db.Set<SideEffect>()
                                .SingleOrDefault(s => s.Id == idSideEffects);
                            
                            document.Add(new Paragraph("Presentó efectos adversos"));
                            document.Add(new Paragraph("Efecto secundario:" + sbdd.SideEffects));
                        }
                        
                        document.Add(new Paragraph("\nCita para segunda vacuna"));
                        
                        var year = dtp_date2vaccine.Value.Year;
                        var month = dtp_date2vaccine.Value.Month;
                        var day = dtp_date2vaccine.Value.Day;

                        document.Add(new Paragraph("Fecha: " + year + "/" + month + "/" + day));
                        document.Add(new Paragraph("Hora: " + dtp_date2vaccine.Value.TimeOfDay));

                        document.Close();

                        fileStream.Close();
                    }
                    
                    MessageBox.Show("Archivo guardado", "info");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha presentado un error al intentar guardar el archivo " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado el registro a guardar", "Info");
            }
            this.Close();
        }
        
        private void btn_dateTimeNowQueue_Click(object sender, EventArgs e)
        {
            Citizen c = db.Citizens.First(c => c.Dui.Equals(txt_dui.Text));

            c.DateWline = DateTime.Today;
            c.TimeWline = DateTime.Now.TimeOfDay;

            db.SaveChanges();
            
            btn_queueAcept.Enabled = true;
            //Habilitar el boton aceptar para avanzar a la siguiente parte
            btn_queueAcept.BackColor = ColorTranslator.FromHtml("#ed1b24");
            //cambiar el color del boton a rojo para indicar que esta habilitado
        }
        
        private void btn_cancelDui_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConsentCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}