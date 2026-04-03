using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorInventario
    {
        Base b = new Base("localhost", "root", "", "duros");

        public void MostrarInventario(DataGridView tabla, string filtro)
        {
            try
            {
                tabla.Columns.Clear();
                tabla.DataSource = b.Consultar($"SELECT CodigoProducto AS Código, nombreProducto AS Nombre, precioPublico AS Precio, precioUnitario AS 'Precio Unitario', inventarioActual AS Inventario, inventarioMinimo AS 'Inventario Minimo' FROM productos WHERE nombreProducto LIKE '%{filtro}%' AND status = 'Activo';", "productos").Tables[0];
                tabla.AutoResizeColumns();
                tabla.AutoResizeRows();
            }
            catch
            {
                MessageBox.Show("No se permiten valores invalidos!");
            }
        }

        public void BorrarProducto(string codigo)
        {
            b.Comando($"UPDATE productos SET STATUS = 'Inactivo' WHERE codigoProducto = '{codigo}';");
        }

        public void AgregarProducto(string codigo, string nombre, int invMin, int invAct, double precPub, double precUi)
        {
            b.Comando($"INSERT INTO Productos (ID, CodigoProducto, NombreProducto, InventarioMinimo, InventarioActual, PrecioPublico, PrecioUnitario, status) VALUES (NULL, '{codigo}', '{nombre}', {invMin}, {invAct}, {precPub}, {precUi}, 'Activo');");
        }

        public int id (string codigo)
        {

                DataSet ds = b.Consultar($"SELECT ID FROM Productos WHERE codigoProducto = '{codigo}';", "usuarios");
                DataTable dt = ds.Tables[0];

                return int.Parse(dt.Rows[0]["ID"].ToString());
        }

        public void ModificarProducto(int id, string codigo, string nombre, int invMin, int invAct, double precPub, double precUi)
        {
            b.Comando($"UPDATE ProductoS SET codigoProducto = '{codigo}', nombreProducto = '{nombre}', inventarioMinimo = {invMin}, inventarioActual = {invAct}, precioPublico = {precPub}, precioUnitario = {precUi} WHERE id = {id};");
        }
    }
}
