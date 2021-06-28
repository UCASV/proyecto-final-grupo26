using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Proyecto_POO_BDD.SqlServerContext;
using Proyecto_POO_BDD.ViewModels;

namespace Proyecto_POO_BDD
{
    public partial class frmSearch : Form
    {
        private bool _showFormDB = false;
        ProCitasContext db = new ProCitasContext();
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var listOfCitizen = db.Citizens.OrderBy(c => c.Id).ToList();

            var result = listOfCitizen.Where(e =>
                e.Dui.Equals(txt_DuiSearch.Text)).ToList();

            if (result.Count == 0 || txt_DuiSearch.Text.Length == 0)
                MessageBox.Show("Ciudadano no registrado", "Vaccination Program", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation);
            else
            { 
                using(var context = new ProCitasContext())
               {
                   dgv_citizenInformation.DataSource = null;
                   
                    var citizen = context.Citizens
                        .First(x => x.Dui.Equals(txt_DuiSearch.Text));
                    
                    var newDS = context.InfoVaccinations
                        .Where(i => i.Id.Equals(citizen.IdInfoVaccination))
                        .ToList();

                    var mappedDS = new List<InfoVaccinationVM>();
                    
                    newDS.ForEach(i => mappedDS.Add(ProyectoPOOBDDMapped.MapInfoVaccinationToInfoVaccinationVm(i)));
                    
                    dgv_citizenInformation.DataSource = mappedDS;
               }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_download_Click(object sender, EventArgs e)
        {
            if (dgv_citizenInformation.Rows.Count>0)
            { 
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
                            document.Add(new Paragraph("Fecha: " + dgv_citizenInformation.Rows[0].Cells[0].Value.ToString()));
                            document.Add(new Paragraph("Hora: " + dgv_citizenInformation.Rows[0].Cells[1].Value.ToString()));
                            
                            document.Add(new Paragraph("Lugar: " + dgv_citizenInformation.Rows[0].Cells[4].Value.ToString()));
                            
                            //si no se ha reservado la segunda cita (esta en null) se omite en el PDF

                            try
                            {
                                document.Add(new Paragraph("\nSegunda vacuna"));
                                document.Add(new Paragraph("Fecha: " + dgv_citizenInformation.Rows[0].Cells[2].Value.ToString()));
                                document.Add(new Paragraph("Hora: " + dgv_citizenInformation.Rows[0].Cells[3].Value.ToString()));
                                document.Add(new Paragraph("Lugar: " + dgv_citizenInformation.Rows[0].Cells[4].Value.ToString()));
                            }
                            catch (Exception exception)
                            {
                                document.Add(new Paragraph("Aun no se ha registrado segunda cita"));
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
            }
            else
            { 
                MessageBox.Show("No se ha encontrado el registro a guardar","Info");
            }
        }
    }
}
