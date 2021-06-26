using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Proyecto_POO_BDD.SqlServerContext;
using Proyecto_POO_BDD.Validations;

namespace Proyecto_POO_BDD
{
    public partial class frmRegisterCitizen : Form
    {
        private Employee employee { get; set; }
        private ProCitasContext db = new ProCitasContext();
        
        public frmRegisterCitizen(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegisterCitizen_Load(object sender, EventArgs e)
        {
            //Validar que el dia de la cita no sea un dia que ya haya transcurrido
            dtp_date.MinDate = DateTime.Now;
                    
            tabControl1.ItemSize = new Size(0, 1);
            
            //Poblando comboBox con las enfermedades
            cmb_Diseases.DataSource = db.Diseases.ToList();
            cmb_Diseases.DisplayMember = "diseases";
            cmb_Diseases.ValueMember = "id";

            //Unir los campos de Departamento, calle y municipio para mostrarla en comboBox
            var listdirection = db.Directions
                .Select( d => new{ Id = d.Id, Direction = d.Department+ " " + d.Street + " " + d.Municipality});
            
            //Poblando comboBox con las direcciones
            cmb_address.DataSource = listdirection.ToList();
            cmb_address.DisplayMember = "Direction";
            cmb_address.ValueMember = "Id";

            //Poblando comboBox con los lugares de vacunacion
            cmb_PlaceVaccination.DataSource = db.VaccinationPlaces.ToList();
            cmb_PlaceVaccination.DisplayMember = "Place";
            cmb_PlaceVaccination.ValueMember = "Id";
        }
        
        
        private void rb_deseasesYes_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            this.Height = 430;
        }

        private void btn_cancelDeseases_Click(object sender, EventArgs e)
        {
            this.Height = 680;
            tabControl1.SelectedIndex = 0;
            rb_diseasesNo.Checked = true;
            
        }

        private void rb_institutionYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_institutionYes.Checked)
            {
                tabControl1.SelectedIndex = 2;
                this.Height = 420;
            }
        }

        private void btn_cancelTab3_Click(object sender, EventArgs e)
        {
             tabControl1.SelectedIndex = 0;
             rb_institutionNo.Checked = true;
             this.Height = 680;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            var listCitizen = db.Citizens.ToList();

            //Se evalua si el dui que se ingreso ya esta en la base de datos
            var result = listCitizen.Where(e => e.Dui.Equals(txt_dui.Text)).ToList();

            if (txt_name.Text.Length > 0 && txt_dui.Text.Length > 0 && txt_age.Text.Length > 0 &&
                txt_celphone.Text.Length > 0)

                if (result.Count == 0) // Si no se encontro ningun dui igual en la base de datos se puede registrar
                {
                    int age = Int32.Parse(txt_age.Text);
                    if (ValidationDui.VerificationDui(txt_dui.Text) && ValidationAge.VerificationAge(age) && ValidationPhoneNumber.VerificationNumer(txt_celphone.Text))
                    {
                        tabControl1.SelectedIndex = 3;
                        this.Height = 380;
                    }
                }
                else 
                    // Si se ha encontrado un dui igual en la base no se puede volver a registrar
                    MessageBox.Show("Este numero de dui ya ha sido registrado para una cita", "Cita duplicada",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
                MessageBox.Show("Asegurese de llenar todos los campo", "Registro ciudadano", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }

        private void btn_aceptDeseases_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            rb_diseasesYes.Checked = true;
            this.Height = 680;
        }

        private void btn_aceptInstitution_Click(object sender, EventArgs e)
        {
            if (txt_numInstitution.Text.Length == 0)
                MessageBox.Show("Asegurese de ingresar todo los valores", "Identificador de institucion",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else
            {
                var listOfInstitution = db.Institutions.
                    OrderBy(c => c.Id).ToList();

                var result = listOfInstitution.Where(i =>
                    i.IdentifierNumber.Equals(txt_numInstitution.Text)).ToList();
                
                if (result.Count == 0)
                    MessageBox.Show("No se encontro Institucion", "Identificar de insitucion",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    tabControl1.SelectedIndex = 0;
                    rb_institutionYes.Checked = true;
                    this.Height = 680;
                }
            }
        }

        private void btn_aceptRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Citizen newCitizen = new Citizen();

                newCitizen.Dui = txt_dui.Text;
                newCitizen.NameCitizen = txt_name.Text;
                newCitizen.Phone = txt_celphone.Text;
                newCitizen.Mail = txt_email.Text;
                newCitizen.IdEmployee = employee.Id;

                //EMFERMEDADES---------------------------------------------------
                if (rb_diseasesNo.Checked)
                    newCitizen.IdDiseases = null;
                else
                {
                    Disease dref = (Disease) cmb_Diseases.SelectedItem;
                    Disease dbdd = db.Set<Disease>()
                        .SingleOrDefault(m => m.Id == dref.Id);

                    newCitizen.IdDiseases = dbdd.Id;
                }
                //------------------------------------------------------------------
                
                //INSTITUCION-------------------------------------------------------
                Institution ibdd = db.Set<Institution>()
                    .SingleOrDefault(i => i.IdentifierNumber == txt_numInstitution.Text);

                if (rb_institutionNo.Checked)
                    newCitizen.IdInstitution = null;
                else
                    newCitizen.IdInstitution = ibdd.Id;
                //--------------------------------------------------------------------

                
                //CABINA--------------------------------------------------------------
                Employeexcabin xref = db.Set<Employeexcabin>()
                    .SingleOrDefault(x => x.IdEmployee.Equals(employee.Id));

                Cabin cbdd = db.Set<Cabin>()
                    .SingleOrDefault(c => c.Id == xref.IdCabin);
    
                newCitizen.IdCabin = cbdd.Id;
                //---------------------------------------------------------------------


                //DIRECCION------------------------------------------------------------//
                int idAddress = cmb_address.SelectedIndex + 1; 
                // el indice empieza de 0 por lo que se le suma 1 para obtener su id

                
                Direction rbdd = db.Set<Direction>()
                    .SingleOrDefault(r => r.Id == idAddress);
                
                newCitizen.IdDirection = rbdd.Id;
                //------------------------------------------------------------------------
                
                
                //Detalles de la cita------------------------------------------------------
                        
                    //obtener valor del comboBox del lugar de la cita
                    VaccinationPlace vref = (VaccinationPlace) cmb_PlaceVaccination.SelectedItem;
                    VaccinationPlace vbdd = db.Set<VaccinationPlace>()
                        .SingleOrDefault(v => v.Id == vref.Id);

                    //asignando valores a la tabla INFOVACCINATION
                    InfoVaccination newInfo = new InfoVaccination();
                    newInfo.DateAppointment1 = dtp_date.Value.Date;
                    newInfo.TimeAppointment1 = dtp_date.Value.TimeOfDay;
                    newInfo.IdVaccinationPlace = vbdd.Id;
                    newInfo.DateAppointment2 = null;
                    newInfo.TimeAppointment2 = null;

                    db.Add(newInfo);
                    db.SaveChanges();
                    
                    newCitizen.IdInfoVaccination = newInfo.Id; //asignar la fk de INFO_VACCINATION
                //----------------------------------------------------------------------

                //----------------------------------------------------------------------//

                //valores temporalmente nulos ya que se llenan mas adelante--------------//
                newCitizen.TimeEffect = null;
                newCitizen.DateEffect = null;
                newCitizen.TimeWline = null;
                newCitizen.DateWline = null;
                newCitizen.IdSideEffects = null;
                //-----------------------------------------------------------------------//
                
                db.Add(newCitizen);
                db.SaveChanges();

                MessageBox.Show("Ciudadano Registrado","Vacunacion Covid-19", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                
                this.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            } 

            
        }

        private void btn_cancelRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}