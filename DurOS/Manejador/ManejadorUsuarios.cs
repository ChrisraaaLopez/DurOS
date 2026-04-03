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
    public class ManejadorUsuarios
    {
        Base b = new Base("localhost", "root", "", "duros");


        public void MostrarUsuarios(DataGridView tabla, string filtro)
        {
            try
            {
                tabla.Columns.Clear();
                tabla.DataSource = b.Consultar($"SELECT nombre AS Nombre, tipoUsuario AS Tipo FROM usuarios WHERE nombre LIKE '%{filtro}%' AND status = 'Activo';", "usuarios").Tables[0];
                tabla.AutoResizeColumns();
                tabla.AutoResizeRows();
            }
            catch
            {
                MessageBox.Show("No se permiten valores invalidos!");
            }
        }

        public void BorrarUsuario(string nombre)
        {
            b.Comando($"UPDATE usuarios SET STATUS = 'Inactivo' WHERE nombre = '{nombre}';");
        }

        public void AgregarUsuario(string nombre, string tipo, string contrasena)
        {

            b.Comando($"INSERT INTO usuarios (idU, nombre, contrasena, tipoUsuario, status) VALUES (NULL, '{nombre}', '{Sha1(contrasena)}', '{tipo}', 'Activo');");
        }

        public void ModificarProducto(string nombre, string tipo, string contrasena, int id)
        {
            b.Comando($"UPDATE usuarios SET nombre = '{nombre}', tipoUsuario = '{tipo}' WHERE idU = {id};");

            if (contrasena != "")
            {
                b.Comando($"UPDATE usuarios SET contrasena = '{Sha1(contrasena)}' WHERE idU = {id};");
            }
        }

        public int id(string nom)
        {

            DataSet ds = b.Consultar($"SELECT idU FROM usuarios WHERE nombre = '{nom}';", "usuarios");
            DataTable dt = ds.Tables[0];

            return int.Parse(dt.Rows[0]["idU"].ToString());
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
