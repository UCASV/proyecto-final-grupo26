using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Proyecto_POO_BDD.SqlServerContext;

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
            tabControl1.ItemSize = new Size(0, 1);

            cmb_Diseases.DataSource = db.Diseases.ToList();
            cmb_Diseases.DisplayMember = "diseases";
            cmb_Diseases.ValueMember = "id";

            var listdirection = db.Directions
                .Select( d => new{ Id = d.Id, Direction = d.Department+ " " + d.Street + " " + d.Municipality});

            cmb_address.DataSource = listdirection.ToList();
            cmb_address.DisplayMember = "Direction";
            cmb_address.ValueMember = "Id";
        }
        
        
        private void rb_deseasesYes_Click(object sender, EventArgs e)
        {
            if (rb_diseasesYes.Checked)
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
            }
        
            this.Height = 420;
        }

        private void btn_cancelTab3_Click(object sender, EventArgs e)
        {
             tabControl1.SelectedIndex = 0;
             rb_institutionNo.Checked = true;
             this.Height = 680;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length > 0 && txt_dui.Text.Length > 0 && txt_age.Text.Length > 0 &&
                txt_celphone.Text.Length > 0)

                tabControl1.SelectedIndex = 3;
            else
                MessageBox.Show("Asegurese de llenar todos los campo", "Registro ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_aceptDeseases_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            rb_diseasesYes.Checked = true;
            this.Height = 680;
        }

        private void btn_aceptInstitution_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            rb_institutionYes.Checked = true;
            this.Height = 680;
        }

        private void btn_aceptRegister_Click(object sender, EventArgs e)
        {

            var listCitizen = db.Citizens
                .Include(c => c.IdDirection)
                .Include(c => c.IdCabin)
                .Include(c => c.IdDiseases)
                .Include(c => c.IdEmployee)
                .Include(c => c.IdInstitution)
                .Include(c => c.IdInfoVaccination)
                .ToList();

            Citizen newCitizen = new Citizen();

            newCitizen.Dui = txt_dui.Text;
            newCitizen.NameCitizen = txt_name.Text;
            newCitizen.Phone = txt_celphone.Text;
            newCitizen.Mail = txt_email.Text;
            newCitizen.IdEmployee = employee.Id;
            newCitizen.IdEmployeeNavigation = employee;

            //EMFERMEDADES---------------------------------------------------//
            if (rb_diseasesNo.Checked)
            {
                newCitizen.IdDiseases = null;
                newCitizen.IdDiseases = null;
            }
            else
            {
                // Curso cref = (Curso) cmbCursos.SelectedItem;

                Disease dref = (Disease) cmb_Diseases.SelectedItem;
                Disease dbdd = db.Set<Disease>()
                    .SingleOrDefault(m => m.Id == dref.Id);

                newCitizen.IdDiseases = dbdd.Id;
                newCitizen.IdDiseasesNavigation = dbdd;
            }
            //------------------------------------------------------------------//

            //INSTITUCION-------------------------------------------------------//
            Institution ibdd = db.Set<Institution>()
                .SingleOrDefault(i => i.IdentifierNumber == txt_numInstitution.Text);

            if (rb_institutionNo.Checked)
            {
                newCitizen.IdInstitution = null;
                newCitizen.IdInstitutionNavigation = null;
            }
            else
            {
                newCitizen.IdInstitution = ibdd.Id;
                newCitizen.IdInstitutionNavigation = ibdd;
            }
            //--------------------------------------------------------------------//

            //CABINA--------------------------------------------------------------//
            Employeexcabin xref = db.Set<Employeexcabin>()
                .SingleOrDefault(x => x.IdEmployee.Equals(employee.Id));

            Cabin cbdd = db.Set<Cabin>()
                .SingleOrDefault(c => c.Id == xref.IdCabin);

            newCitizen.IdCabin = cbdd.Id;
            newCitizen.IdCabinNavigation = cbdd;
            //---------------------------------------------------------------------//

            //DIRECCION------------------------------------------------------------//
            Direction rref = (Direction) cmb_address.SelectedItem;
            Direction rbdd = db.Set<Direction>()
                .SingleOrDefault(r => r.Id == rref.Id);

            newCitizen.IdDirection = rbdd.Id;
            newCitizen.IdDirectionNavigation = rbdd;
            //---------------------------------------------------------------------//

            // asignar detalles de la cita de la vacuna
            InfoVaccination newInfo = new InfoVaccination();
            newInfo.DateAppointment1 = dtp_date.Value.Date;
            newInfo.TimeAppointment1 = dtp_date.Value.TimeOfDay;
            newInfo.VaccinationPlace = "prueba";

            newCitizen.IdInfoVaccinationNavigation = newInfo;
            newCitizen.IdInfoVaccination = newInfo.Id;
            //----------------------------------------------------------------------//

            
            
            db.Add(newCitizen);
            db.SaveChanges();

            MessageBox.Show("Ciudadano Registrado","Vacunacion Covid-19", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }
    }
}