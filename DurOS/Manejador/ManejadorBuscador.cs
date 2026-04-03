using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorBuscador
    {
        Base b = new Base("localhost", "root", "", "duros");

        public void MostrarProductos(DataGridView tabla, string filtro)                                                                                                                                                            
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar($"SELECT nombreProducto AS Nombre, precioPublico AS Precio, inventarioActual AS Inventario FROM productos WHERE nombreProducto LIKE '%{filtro}%' AND inventarioActual > 0", "productos").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
