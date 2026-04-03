using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;
using Excel = Microsoft.Office.Interop.Excel;

namespace DurOS
{
    public partial class VnetanaRegistroVentas : Form
    {
        //Instancia de los manejadores
        ManejadorVentasDia mvd;

        string folio;
        int fila, columns;

        public VnetanaRegistroVentas()
        {
            InitializeComponent();
            mvd = new ManejadorVentasDia();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            mvd.MostrarTicket(dtgvTicket, dtpFecha);
            mvd.MostrarContenido(dtgvContenidoTicket, folio);
        }

        private void dtgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columns = e.ColumnIndex;
            folio = dtgvTicket.Rows[fila].Cells[0].Value.ToString();

            mvd.MostrarTicket(dtgvTicket, dtpFecha);
            mvd.MostrarContenido(dtgvContenidoTicket, folio);
        }

        //Atajo de tecla
        private void VnetanaRegistroVentas_KeyDown(object sender, KeyEventArgs e)
        {
            //Cerrar form
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Exportar a excel
        private void btnExportar_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            try
            {
                for (int i = 1; i <= dtgvTicket.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dtgvTicket.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dtgvTicket.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgvTicket.Columns.Count; j++)
                    {
                        if (dtgvTicket.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dtgvTicket.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                worksheet.Columns.AutoFit();

                string nombreArchivo = $"Registro de Ventas_{dtpFecha.Text}.xlsx";
                // Especificar la ruta donde se guardará el archivo
                string rutaGuardado = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nombreArchivo);
                // Guardar el libro de trabajo
                workbook.SaveAs(rutaGuardado);
                // Cerrar la aplicación de Excel
                excelApp.Quit();

                MessageBox.Show($"¡Los datos se han exportado y guardado como '{nombreArchivo}' en Mis Documentos!", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al exportar a Excel: {ex.Message}", "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (workbook != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                if (excelApp != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            finally
            {
                if (worksheet != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            }
        }





        //Cerrar form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
