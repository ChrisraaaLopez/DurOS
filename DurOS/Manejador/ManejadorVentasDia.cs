using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorVentasDia
    {
        Base b = new Base("localhost", "root", "", "duros");

        public void MostrarTicket(DataGridView tabla, DateTimePicker fecha)
        {
                string fechas = fecha.Text;
                tabla.Columns.Clear();
                tabla.DataSource = b.Consultar($"SELECT Folio AS FolioTicket, Fecha AS FechaTicket, Mesa AS MesaTicket, Total AS TotalTicket FROM Ticket WHERE DATE(Fecha) = '{fechas}';", "ticket").Tables[0];
                tabla.AutoResizeColumns();
                tabla.AutoResizeRows();
        }

        public void MostrarContenido(DataGridView tabla, string Folio)
        {
                tabla.Columns.Clear();
                tabla.DataSource = b.Consultar($"SELECT ct.fkFolio AS Folio, p.NombreProducto AS Producto, ct.Cantidad, ct.Preciounitario, ct.Subtotal FROM ContenidoTicket ct JOIN Productos p ON ct.Producto = p.ID WHERE ct.fkFolio = '{Folio}';", "ContenidoTicket").Tables[0];
                tabla.AutoResizeColumns();
                tabla.AutoResizeRows();
        }
    }
}
