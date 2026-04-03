using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Manejador;

namespace DurOS
{
    public partial class VentanaInventario : Form
    {
        //Instancia de los Manejadores
        ManejadorInventario mi;

        int columns, fila;
        string codigo, nombre;
        int invMin, invAc;
        double precPub, precUi;

        public VentanaInventario()
        {
            InitializeComponent();
            mi = new ManejadorInventario(); 
        }

        //Actualizar Data Grid
        private void VentanaInventario_Load(object sender, EventArgs e)
        {
            mi.MostrarInventario(dtgvInventario, txtFiltro.Text);
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            mi.MostrarInventario(dtgvInventario, txtFiltro.Text);
        }

        //Exportar Inventario a Excel
        private void btnExportar_Click(object sender, EventArgs e)
        {
            mi.MostrarInventario(dtgvInventario, "");
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            try
            {
                for (int i = 1; i <= dtgvInventario.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dtgvInventario.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dtgvInventario.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgvInventario.Columns.Count; j++)
                    {
                        if (dtgvInventario.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dtgvInventario.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                worksheet.Columns.AutoFit();

                // Obtener la fecha actual para el nombre del archivo
                string fechaActual = DateTime.Now.ToString("dd-MM-yyyy");
                string nombreArchivo = $"Inventario_{fechaActual}.xlsx";
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

        //Cerrar Form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaInventario_KeyDown(object sender, KeyEventArgs e)
        {
            //Cerrar form
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Asignar valor seleccionado
        private void dtgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columns = e.ColumnIndex;
            codigo = dtgvInventario.Rows[fila].Cells[0].Value.ToString();
            nombre = dtgvInventario.Rows[fila].Cells[1].Value.ToString();
            precPub = double.Parse(dtgvInventario.Rows[fila].Cells[2].Value.ToString());
            precUi = double.Parse(dtgvInventario.Rows[fila].Cells[3].Value.ToString());
            invAc = int.Parse(dtgvInventario.Rows[fila].Cells[4].Value.ToString());
            invMin = int.Parse(dtgvInventario.Rows[fila].Cells[5].Value.ToString());
        }

        //Eliminar Producto
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    mi.BorrarProducto(codigo);
                    mi.MostrarInventario(dtgvInventario, txtFiltro.Text);
                    MessageBox.Show("Producto Borrado con exito!!!");
                }
                catch
                {
                    MessageBox.Show("No se logro borrar el producto!");
                }
            }
        }

        //Agregar Producto
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VentanaFormProducto fp = new VentanaFormProducto(0, "", "", 0, 0, 0.00, 0.00);
            fp.ShowDialog();
            mi.MostrarInventario(dtgvInventario, txtFiltro.Text);
        }

        //Modificar Producto
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigo != "")
                {
                    int id = mi.id(codigo);
                    VentanaFormProducto fp = new VentanaFormProducto(id, codigo, nombre, invMin, invAc, precPub, precUi);
                    fp.ShowDialog();
                    mi.MostrarInventario(dtgvInventario, txtFiltro.Text);
                }
                else
                {
                    MessageBox.Show("Seleccione un producto!");
                }
            }
            catch
            {
                MessageBox.Show("Seleccione un producto!");
            }
            
        }

        //Agregar Inventario
        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
