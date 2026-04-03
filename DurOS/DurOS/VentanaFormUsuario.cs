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

namespace DurOS
{
    public partial class VentanaFormUsuario : Form
    {
        ManejadorUsuarios us;
        int accion; //0 = Agregar y 1 = Modificar
        int ids;

        public VentanaFormUsuario(int id, string nombre, string contrasena, string tipo)
        {
            InitializeComponent();
            us = new ManejadorUsuarios();

            ids = id;

            if (nombre != "")
            {
                accion = 1;
            }

            if (accion == 0)
            {
                lblForm.Text = "AGREGAR USUARIO";
            }
            else if (accion == 1)
            {
                lblForm.Text = "MODIFICAR USUARIO";
            }

            txtNombre.Text = nombre;
            txtContra.Text = contrasena;
            cmbTipo.Text = tipo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (accion == 0)
            {
                try
                {
                    us.AgregarUsuario(txtNombre.Text, cmbTipo.Text, txtContra.Text);
                    MessageBox.Show("Usuario agregado correctamente!!!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Algun dato es incorrecto!");
                }

            }
            else if (accion == 1)
            {
                try
                {
                    us.ModificarProducto(txtNombre.Text, cmbTipo.Text, txtContra.Text, ids);
                    MessageBox.Show("Usuario modificado correctamente!!!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Algun dato es incorrecto!");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaFormUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (accion == 0)
                {
                    try
                    {
                        us.AgregarUsuario(txtNombre.Text, cmbTipo.Text, txtContra.Text);
                        MessageBox.Show("Usuario agregado correctamente!!!");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Algun dato es incorrecto!");
                    }

                }
                else if (accion == 1)
                {
                    try
                    {
                        us.ModificarProducto(txtNombre.Text, cmbTipo.Text, txtContra.Text, ids);
                        MessageBox.Show("Usuario modificado correctamente!!!");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Algun dato es incorrecto!");
                    }
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
