using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Proyecto_POO_BDD.SqlServerContext;

namespace Proyecto_POO_BDD
{
    public partial class frmRegisterCitizen : Form
    {
        public frmRegisterCitizen()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegisterCitizen_Load(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(0, 1);
        }

        private void rb_deseasesYes_Click(object sender, EventArgs e)
        {
            if (rb_deseasesYes.Checked)
            {
                tabControl1.SelectedIndex = 1;
            }

            this.Height = 350;
        }

        private void btn_cancelDeseases_Click(object sender, EventArgs e)
        {
            this.Height = 680;
            tabControl1.SelectedIndex = 0;
            rb_deseasesNo.Checked = true;
            
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

        private void btn_register_Click(object sender, EventArgs e)
        {
            /*var db = new ProCitasContext();

            var listCitizen = db.Citizens
                .Include(c => c.IdDirection)
                .Include(c => c.IdCabin)
                .Include(c => c.IdDiseases)
                .Include(c => c.IdEmployee)
                .Include(c => c.IdInstitution)
                .Include(c => c.IdInfoVaccination);

            Citizen newCitizen = new Citizen();
                newCitizen.Dui = txt_dui.Text;
                newCitizen.NameCitizen = txt_name.Text;
                newCitizen.Phone = txt_celphone.Text;
                newCitizen.Mail = txt_email.Text;
                if (rb_deseasesNo.Checked)
                    newCitizen.IdDiseases = null;
                else
                {
                    
                }

                if (rb_institutionNo.Checked)
                    newCitizen.IdDiseases = null;
                else
                {
                    
                }
            
            //ver como agregar el empleado y la cabina

            db.Add(newCitizen);
            db.SaveChanges();
            
            MessageBox.Show("Ciudadano Registrado","Vacunacion Covid-19", MessageBoxButtons.OK,
                MessageBoxIcon.Information);*/
        }
    }
}