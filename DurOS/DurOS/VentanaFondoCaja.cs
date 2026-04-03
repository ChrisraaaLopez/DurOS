using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace DurOS
{
    public partial class VentanaFondoCaja : Form
    {
        public string atiende;

        //Instancia de manejadores


        public VentanaFondoCaja(string ati)
        {
            InitializeComponent();
            atiende = ati;

        }

        private void VentanaFondoCaja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fondo = txtFondoCaja.Text;
                Inicio i = new Inicio(atiende);
                i.Show();
                this.Close();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string fondo = txtFondoCaja.Text;
            Inicio i = new Inicio(atiende);
            i.Show();
            this.Close();
        }



        //Permitir que el textbox solo ponga numeros
        private void txtFondoCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un dígito ni una tecla de control, cancelar el evento para que no se escriba
                e.Handled = true;
            }
        }
    }
}
