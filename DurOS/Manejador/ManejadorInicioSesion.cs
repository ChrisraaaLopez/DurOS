using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorInicioSesion
    {
        Base b = new Base("localhost", "root", "", "duros");
        public string Validar(TextBox nombre, TextBox contrasena)
        {
            DataSet ds = b.Consultar($"call p_Validar('{nombre.Text}', '{Sha1(contrasena.Text)}')", "usuarios");
            DataTable dt = ds.Tables[0];

            if (dt.Rows[0]["rs"].ToString().Equals("C0rr3ct0"))
                return "C0rr3ct0";
            else
                return "Error";
        }

        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.ASCII.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
