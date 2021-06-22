using System;
using System.Drawing;
using System.Windows.Forms;

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
    }
}