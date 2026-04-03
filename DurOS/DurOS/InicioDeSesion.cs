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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DurOS
{
    public partial class InicioDeSesion : Form
    {
        //Instancia de los manejadores
        ManejadorInicioSesion ms;

        public InicioDeSesion()
        {
            InitializeComponent();
            ms = new ManejadorInicioSesion();
        }
        //Al cargar el firmulario
        private void InicioDeSesion_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Usuario:"; // Establece el texto inicial
            txtUsuario.ForeColor = System.Drawing.Color.Gray; // Usa un color más claro
            txtUsuario.GotFocus += txtUsuario_Enter;
            txtUsuario.LostFocus += txtUsuario_Leave;

            txtContrasena.Text = "Contraseña:"; // Establece el texto inicial
            txtContrasena.ForeColor = System.Drawing.Color.Gray; // Usa un color más claro
            txtContrasena.GotFocus += txtContrasena_Enter;
            txtContrasena.LostFocus += txtContrasena_Leave;
        }

        

        
        
        //Funcionamiento hover
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario:";
                txtUsuario.ForeColor = System.Drawing.Color.Gray; // Vuelve al color del placeholder
            }
        }
        //Funcionamiento hover
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario:")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = System.Drawing.Color.Black; // Vuelve al color de texto normal
            }
        }
        //Funcionamiento hover
        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                txtContrasena.Text = "Contraseña:";
                txtContrasena.ForeColor = System.Drawing.Color.Gray; // Vuelve al color del placeholder
            }
        }
        //Funcionamiento hover
        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña:")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = System.Drawing.Color.Black; // Vuelve al color de texto normal
            }
        }








        //Inciar sesion
        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string rs = ms.Validar(txtUsuario, txtContrasena);

                if (rs == "C0rr3ct0")
                {
                    string atiende = txtUsuario.Text;
                    Inicio i = new Inicio(atiende);
                    i.Show();
                    this.Close();
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Usuario o Contraseña incorrecta";
                }
            }
            catch
            {
                lblError.Visible = true;
                lblError.Text = "Usuario o Contraseña incorrecta";
            }
        }
        //Salir del formulario
        private void button1_Click(object sender, EventArgs e)
        {
            PantallaCarga pantallaCarga = new PantallaCarga();
            pantallaCarga.Close();
            this.Close();
        }

        //Atajo de teclas
        private void InicioDeSesion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Atajo para iniciar sesion
                if (e.KeyCode == Keys.Enter)
                {
                    string rs = ms.Validar(txtUsuario, txtContrasena);

                    if (rs == "C0rr3ct0")
                    {
                        string atiende = txtUsuario.Text;
                        Inicio i = new Inicio(atiende);
                        i.Show();
                        this.Close();
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Usuario o Contraseña incorrecta";
                    }

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            catch {
                lblError.Visible = true;
                lblError.Text = "Usuario o Contraseña incorrecta";
            }
            
        }
    }
}
