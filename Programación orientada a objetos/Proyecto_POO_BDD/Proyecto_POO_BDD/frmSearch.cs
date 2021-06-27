using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Proyecto_POO_BDD.SqlServerContext;
using Proyecto_POO_BDD.ViewModels;

namespace Proyecto_POO_BDD
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            using(var context = new ProCitasContext())
            {
                var newDS = context.Citizens.ToList();
                var mappedDS = new List<CitizenVM>();
                
                newDS.ForEach(c => mappedDS.Add(ProyectoPOOBDDMapped.MapCitizenToCitizenVm(c)));

                dgv_citizenInformation.DataSource = mappedDS;
            }
        }
    }
}