using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Windows.Forms;
using System.Data;

namespace Manejador
{
    public class ManejadorVenta
    {

        Base b = new Base("localhost", "root", "", "duros");

        public string InsertarTicket(decimal total, int mesa)
        {
            DataSet ds = b.Consultar($"call p_Ticket({mesa}, {total});", "Ticket");
            DataTable dt = ds.Tables[0];

            return dt.Rows[0]["folio"].ToString();
        }

        public void AgregarContenidoTicket(string folio, string nombre, int cantidad, decimal subtotal)
        {
            b.Comando($"call p_contenidoTicket('{folio}', '{nombre}', {cantidad}, '{subtotal}');");
        }

        public string Tipo(string nombre)
        {
            DataSet tipoU = b.Consultar($"SELECT tipoUsuario FROM usuarios WHERE nombre = '{nombre}';", "Usuarios");
            DataTable dt = tipoU.Tables[0];
            return dt.Rows[0]["tipoUsuario"].ToString();
        }
    }
}
