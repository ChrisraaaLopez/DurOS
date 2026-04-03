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
    public partial class VentanaEntrada : Form
    {
        //Instancia de los manejadores

        double monto;
        string fechaActual;

        public VentanaEntrada()
        {
            InitializeComponent();
            fechaActual = DateTime.Now.ToString("yyyy-MM-dd");

        }

        //Agregar entrada
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            monto = double.Parse(txtMonto.Text);
            this.Close(); 
        }

        //Salir del formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Mostrar Entradas al cargar
        private void VentanaEntrada_Load(object sender, EventArgs e)
        {
        }

        private void VentanaEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            //Agregar Entrada
            if (e.KeyCode == Keys.Enter)
            {
                monto = double.Parse(txtMonto.Text);
                this.Close();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            //Cerrar form
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un dígito ni una tecla de control, cancelar el evento para que no se escriba
                e.Handled = true;
            }
        }
    }
}
