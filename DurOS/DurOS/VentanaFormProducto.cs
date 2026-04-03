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
    public partial class VentanaFormProducto : Form
    {
        ManejadorInventario i;
        int accion; //0 = Agregar y 1 = Modificar
        int ids;

        public VentanaFormProducto(int id, string codigo, string nombre, int invMin, int invAct, double precPub, double precUi)
        {
            InitializeComponent();
            i = new ManejadorInventario();
            ids = id;
            if (codigo != "")
            {
                accion = 1; 
            }

            if (accion == 0)
            {
                lblForm.Text = "AGREGAR PRODUCTO";
            }
            else if (accion == 1)
            {
                lblForm.Text = "MODIFICAR PRODUCTO";
            }

            txtCodigo.Text = codigo;
            txtNombre.Text = nombre;
            txtINMin.Text = invMin.ToString();
            txtINAct.Text = invAct.ToString();
            txtPPub.Text = precPub.ToString();
            txtPUni.Text = precUi.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (accion == 0)
            {
                try
                {
                    i.AgregarProducto(txtCodigo.Text, txtNombre.Text, int.Parse(txtINMin.Text), int.Parse(txtINAct.Text), double.Parse(txtPPub.Text), double.Parse(txtPUni.Text));
                    MessageBox.Show("Producto agregado correctamente!!!");
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
                    i.ModificarProducto(ids, txtCodigo.Text, txtNombre.Text, int.Parse(txtINMin.Text), int.Parse(txtINAct.Text), double.Parse(txtPPub.Text), double.Parse(txtPUni.Text));
                    MessageBox.Show("Producto modificado correctamente!!!");
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

        private void VentanaFormProducto_KeyDown(object sender, KeyEventArgs e)
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
                        i.AgregarProducto(txtCodigo.Text, txtNombre.Text, int.Parse(txtINMin.Text), int.Parse(txtINAct.Text), double.Parse(txtPPub.Text), double.Parse(txtPUni.Text));
                        MessageBox.Show("Producto agregado correctamente!!!");
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
                        i.ModificarProducto(ids, txtCodigo.Text, txtNombre.Text, int.Parse(txtINMin.Text), int.Parse(txtINAct.Text), double.Parse(txtPPub.Text), double.Parse(txtPUni.Text));
                        MessageBox.Show("Producto modificado correctamente!!!");
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
