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
                using (var context = new ProCitasContext())
                {
                    //Inicializando DataGridView en nulo
                    dgv_citizenInformation.DataSource = null;

                    var citizen = context.Citizens
                        .First(x => x.Dui.Equals(txt_DuiSearch.Text));

                    var newDS = context.Citizens
                        .Where(i => i.Id.Equals(citizen.Id))
                        .ToList();

                    var mappedDS = new List<CitizenVM>();

                    newDS.ForEach(c => mappedDS.Add(ProyectoPOOBDDMapped.MapCitizenToCitizenVM(c)));

                    //llenado el DataGridView
                    dgv_citizenInformation.DataSource = mappedDS;

                    //Modificar automaticamente el tamaño de las columnas del DataGridView
                    //para que se ajuste a la informacion que contiene el nombre del ciudadano y el lugar de vacunación
                    this.dgv_citizenInformation.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.dgv_citizenInformation.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_download_Click(object sender, EventArgs e)
        {
            if (dgv_citizenInformation.Rows.Count > 0)
            {
                bool errorMessage = false;
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf"; //tipo PDF
                save.FileName =
                    $"{dgv_citizenInformation.Rows[0].Cells[0].Value} Registro.pdf"; //Nombre por defecto dui de la persona
    
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        errorMessage = true;
                        MessageBox.Show(
                            "No se puede reemplazar el archivo, favor cambiar nombre del archivo o eliminar el ya existente");
                    }

                    if (!errorMessage)
                    {
                        try
                        {
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 32f, 32f, 32f, 32f); //margenes 
                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();
                                //Agregando informacion al documento
                                document.Add(new Paragraph("INFORMACIÓN CITA COVID-19\n"));
                                document.Add(new Paragraph("\nDui: " + dgv_citizenInformation.Rows[0].Cells[0].Value));
                                document.Add(new Paragraph("Nombre: " + dgv_citizenInformation.Rows[0].Cells[1].Value));
                                document.Add(new Paragraph("\nPrimera vacuna"));
                                document.Add(new Paragraph("Fecha: " + dgv_citizenInformation.Rows[0].Cells[2].Value));
                                document.Add(new Paragraph("Hora: " + dgv_citizenInformation.Rows[0].Cells[3].Value));
                                document.Add(new Paragraph("Lugar: " + dgv_citizenInformation.Rows[0].Cells[6].Value));

                                //si no se ha reservado la segunda cita (esta en null) surgira un error al intentar convertir un valor nulo a string
                                try
                                {
                                    document.Add(new Paragraph("\nSegunda vacuna"));
                                    document.Add(new Paragraph("Fecha: " + dgv_citizenInformation.Rows[0].Cells[4].Value.ToString()));
                                    document.Add(new Paragraph("Hora: " + dgv_citizenInformation.Rows[0].Cells[5].Value.ToString()));
                                    document.Add(new Paragraph("Lugar: " + dgv_citizenInformation.Rows[0].Cells[6].Value.ToString()));
                                }
                                catch (Exception exception)
                                {
                                    document.Add(new Paragraph("Aun no se ha registrado segunda cita"));
                                }

                                document.Close();
                                fileStream.Close();
                            }

                            MessageBox.Show("Archivo guardado", "Registro");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Se ha presentado un error al intentar guardar el archivo " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el registro a guardar", "Info");
                }
            }
        }
    }
}
