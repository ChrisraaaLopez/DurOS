using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Manejador;

namespace DurOS
{
    public partial class VentanaUsuarios : Form
    {
        string nombre, tipoUsuario, status;
        int columns, fila;

        ManejadorUsuarios mu;
        public VentanaUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
        }
        private void VentanaUsuarios_Load(object sender, EventArgs e)
        {
            mu.MostrarUsuarios(dtgvUsuarios, txtFiltro.Text);
        }





















        private void VentanaUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }




        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VentanaFormUsuario fu = new VentanaFormUsuario(0, "", "", "");
            fu.ShowDialog();
            mu.MostrarUsuarios(dtgvUsuarios, txtFiltro.Text);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            mu.MostrarUsuarios(dtgvUsuarios, txtFiltro.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombre != "")
                {
                    int id = mu.id(nombre);

                    VentanaFormUsuario fu = new VentanaFormUsuario(id, nombre, "", tipoUsuario);
                    
                    fu.ShowDialog();
                    mu.MostrarUsuarios(dtgvUsuarios, txtFiltro.Text);
                }
                else
                {
                    MessageBox.Show("Seleccione un producto!");
                }
            }
            catch
            {
                MessageBox.Show("Error, Seleccione un producto!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    mu.BorrarUsuario(nombre);
                    mu.MostrarUsuarios(dtgvUsuarios, txtFiltro.Text);
                    MessageBox.Show("Usuario Borrado con exito!!!");
                }
                catch
                {
                    MessageBox.Show("No se logro borrar el producto!");
                }
            }
        }

        private void dtgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columns = e.ColumnIndex;
            nombre = dtgvUsuarios.Rows[fila].Cells[0].Value.ToString();
            tipoUsuario = dtgvUsuarios.Rows[fila].Cells[1].Value.ToString();
        }
    }
}
