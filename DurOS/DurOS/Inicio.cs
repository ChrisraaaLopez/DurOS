using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;
using System.Runtime.InteropServices;

namespace DurOS
{


    public partial class Inicio : Form
    {
        ManejadorBuscador mb;
        ManejadorVenta mv;
        int columns, fila;
        string ticketTexto;
        string tipo;

        //Constructor
        public Inicio(string atiende)
        {
            InitializeComponent();
            lblAtiende.Text = atiende;
            mb = new ManejadorBuscador();
            mv = new ManejadorVenta();

            //Venta y Tickets
            for (int i = 1; i <= 9; i++)
                tickets[$"Mesa {i}"] = new BindingList<VentaProducto>();

            dtgvTicket.DataSource = tickets[ticketActual]; // dgvVentas es el de la izquierda

            //Extraer tipo
            tipo = mv.Tipo(lblAtiende.Text);
            MessageBox.Show(tipo);
            MessageBox.Show(lblAtiende.Text);
        }
        //Al cargar formulartio
        private void Inicio_Load(object sender, EventArgs e)
        {
            mb.MostrarProductos(dtgvProductos, txtFiltro.Text);
        }

        //Atajos por teclas
        private void Inicio_KeyDown(object sender, KeyEventArgs e)
        {
            //Buscar Producto
            if (e.KeyCode == Keys.F10)
            {
                VentanaBusqueda vb = new VentanaBusqueda();
                vb.ShowDialog();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            //Inventario
            if (e.KeyCode == Keys.F4)
            {
                VentanaInventario vi = new VentanaInventario();
                vi.ShowDialog();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            //Ventana Pago
            if (e.KeyCode == Keys.F12)
            {
                string textoOriginal = lblTotal.Text;
                string textoLimpio = textoOriginal.Replace("$", "").Replace(",", "");

                string texto = lblMesa.Text;
                string numeroSolo = Regex.Match(texto, @"\d+").Value;

                string folio = mv.InsertarTicket(Convert.ToDecimal(textoLimpio), int.Parse(numeroSolo));
                decimal precio = 0;
                string nombre = "";
                int cantidad = 0;
                decimal subtotal = 0;

                foreach (DataGridViewRow fila in dtgvTicket.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        nombre = fila.Cells[0].Value?.ToString();
                        precio = Convert.ToDecimal(fila.Cells[1].Value?.ToString());
                        cantidad = int.Parse(fila.Cells[2].Value?.ToString());
                        subtotal = Convert.ToDecimal(fila.Cells[4].Value?.ToString());
                    }

                    mv.AgregarContenidoTicket(folio, nombre, cantidad, subtotal);
                }

                GenerarTicket();



                tickets[ticketActual].Clear();
                dtgvTicket.Refresh();
                CalcularTotal();
                status = false;

                //Imprimir Ticket
                if (string.IsNullOrEmpty(ticketTexto))
                {
                    MessageBox.Show("No hay ticket para imprimir. Complete una orden primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    ImprimirTicket();
                    MessageBox.Show("Ticket impreso correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al imprimir ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }



            //Logica Ventas y Tickets

            //Agregar cantidad de producto
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                if (dtgvTicket.CurrentRow != null)
                {
                    var producto = dtgvTicket.CurrentRow.DataBoundItem as VentaProducto;
                    if (producto != null)
                    {
                        if (producto.Cantidad < producto.Stock)
                        {
                            producto.Cantidad++;
                        }
                        else
                        {
                            MessageBox.Show("No puedes agregar más. Stock insuficiente.", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        dtgvTicket.Refresh();
                        CalcularTotal();
                    }
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            //Agregar cantidad de producto
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                if (dtgvTicket.CurrentRow != null)
                {
                    var producto = dtgvTicket.CurrentRow.DataBoundItem as VentaProducto;
                    if (producto != null)
                    {
                        producto.Cantidad--;

                        if (producto.Cantidad <= 0)
                        {
                            tickets[ticketActual].Remove(producto);
                        }

                        dtgvTicket.Refresh();
                        CalcularTotal();
                    }
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        //Mostrar Ventana de Inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (tipo == "Encargado" || tipo == "Administrador")
            {
                VentanaInventario vi = new VentanaInventario();
                vi.ShowDialog();
            }
            else 
            {
                MessageBox.Show("No tienes acceso!");
            }

        }
        //Mostrar Ventas del dia
        private void btnVentasDia_Click(object sender, EventArgs e)
        {
                VnetanaRegistroVentas vrv = new VnetanaRegistroVentas();
                vrv.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioDeSesion inicioDeSesion = new InicioDeSesion();
            inicioDeSesion.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tipo == "Encargado" || tipo == "Administrador")
            {
                VentanaUsuarios ventanaUsuarios = new VentanaUsuarios();
                ventanaUsuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tienes acceso!");
            }
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mb.MostrarProductos(dtgvProductos, txtFiltro.Text);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            mb.MostrarProductos(dtgvProductos, txtFiltro.Text);
        }











        //Logica de Venta y Tickets


        //Metodo de apoyo
        public class VentaProducto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; } = 1;
            public int Stock { get; set; }
            public decimal Subtotal => Precio * Cantidad;
        }

        //Diccionario para los tickets
        private Dictionary<string, BindingList<VentaProducto>> tickets = new Dictionary<string, BindingList<VentaProducto>>();
        private string ticketActual = "Mesa 1";


        //Agregar producto con doble click
        private void dtgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombre = dtgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                decimal precio = Convert.ToDecimal(dtgvProductos.Rows[e.RowIndex].Cells["Precio"].Value);
                int stock = Convert.ToInt32(dtgvProductos.Rows[e.RowIndex].Cells["Inventario"].Value); // 👈 Stock del producto

                var lista = tickets[ticketActual];
                var existente = lista.FirstOrDefault(p => p.Nombre == nombre);

                if (existente != null)
                {
                    if (existente.Cantidad < stock)
                    {
                        existente.Cantidad++;
                    }
                    else
                    {
                        MessageBox.Show("No puedes agregar más. Stock insuficiente.", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (stock > 0)
                    {
                        lista.Add(new VentaProducto { Nombre = nombre, Precio = precio, Stock = stock });
                    }
                    else
                    {
                        MessageBox.Show("Este producto no tiene stock disponible.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                dtgvTicket.Refresh();
                CalcularTotal();
            }
        }

        string mesaN = "Mesa 1";
        //Cambiar Mesa
        private void CambiarMesa(string mesa)
        {
            lblMesa.Text = mesa;
            ticketActual = mesa;
            mesaN = mesa; 
            dtgvTicket.DataSource = tickets[ticketActual];
            dtgvTicket.Refresh();
            CalcularTotal();
        }


        //Botones de Mesa
        private void button5_Click(object sender, EventArgs e) => CambiarMesa("Mesa 1");
        private void mesa2_Click(object sender, EventArgs e) => CambiarMesa("Mesa 2");
        private void mesa3_Click(object sender, EventArgs e) => CambiarMesa("Mesa 3");
        private void mesa4_Click(object sender, EventArgs e) => CambiarMesa("Mesa 4");
        private void mesa5_Click(object sender, EventArgs e) => CambiarMesa("Mesa 5");
        private void mesa6_Click(object sender, EventArgs e) => CambiarMesa("Mesa 6");
        private void mesa7_Click(object sender, EventArgs e) => CambiarMesa("Mesa 7");
        private void mesa8_Click(object sender, EventArgs e) => CambiarMesa("Mesa 8");
        private void mesa9_Click(object sender, EventArgs e) => CambiarMesa("Mesa 9");

        

        private void CalcularTotal()
        {
            decimal total = tickets[ticketActual].Sum(p => p.Subtotal);
            lblTotal.Text = total.ToString("C"); // ejemplo: "$ 50.00"
        }

        //Variable status pago
        public static bool status = false;
        string folio;
        //Boton de cobrar
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            string textoOriginal = lblTotal.Text;
            string textoLimpio = textoOriginal.Replace("$", "").Replace(",", "");

                string texto = lblMesa.Text;
                string numeroSolo = Regex.Match(texto, @"\d+").Value;

                folio = mv.InsertarTicket(Convert.ToDecimal(textoLimpio), int.Parse(numeroSolo));
                decimal precio = 0;
                string nombre = "";
                int cantidad = 0;
                decimal subtotal = 0;

                foreach (DataGridViewRow fila in dtgvTicket.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        nombre = fila.Cells[0].Value?.ToString();
                        precio = Convert.ToDecimal(fila.Cells[1].Value?.ToString());
                        cantidad = int.Parse(fila.Cells[2].Value?.ToString());
                        subtotal = Convert.ToDecimal(fila.Cells[4].Value?.ToString());
                    }

                    mv.AgregarContenidoTicket(folio, nombre, cantidad, subtotal);
                }

                GenerarTicket();


            
                tickets[ticketActual].Clear();
                dtgvTicket.Refresh();
                CalcularTotal();
                status = false;

            //Imprimir Ticket
            if (string.IsNullOrEmpty(ticketTexto))
            {
                MessageBox.Show("No hay ticket para imprimir. Complete una orden primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                ImprimirTicket();
                MessageBox.Show("Ticket impreso correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void ImprimirTicket()
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = "La chida"; // Asegúrate de que coincida exactamente
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("58mm Receipt", 220, 700);
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);

            try
            {
                printDoc.Print(); // Imprimir directamente sin mostrar PrintDialog}
                WindowHelper.SetForegroundWindow(this.Handle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message);
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Ajustar tamaño de fuente para impresora térmica
            Font fuente = new Font("Consolas", 8);

            // Ancho reducido para impresora de 58mm (aproximadamente 203 dots)
            float anchoPapel = 203;

            // Configurar márgenes mínimos para impresora térmica
            float margenIzquierdo = 1;
            float margenSuperior = 1;

            // Dibujar el texto en el área disponible
            e.Graphics.DrawString(
                ticketTexto,
                fuente,
                Brushes.Black,
                new RectangleF(margenIzquierdo, margenSuperior, anchoPapel, 9999)
            );
        }

        private void GenerarTicket()
        {
            StringBuilder sb = new StringBuilder();

            // Cabecera centrada y más corta
            
            sb.AppendLine("* Duros y Tostadas el Padre *");
            sb.AppendLine("   Sistema DurOS");
            sb.AppendLine("-----------------------------");
            sb.AppendLine($"Fecha: {DateTime.Now.ToShortDateString()}");
            sb.AppendLine($"Hora: {DateTime.Now.ToShortTimeString()}");
            sb.AppendLine(" ");
            sb.AppendLine($"Cajero: {lblAtiende.Text}");
            sb.AppendLine($"{mesaN}");
            sb.AppendLine(" ");
            sb.AppendLine($"Folio: {folio}");
            sb.AppendLine("-----------------------------"); 
            sb.AppendLine(" ");
            sb.AppendLine("Prod.    Cant  Precio");

            foreach (DataGridViewRow row in dtgvTicket.Rows)
            {
                if (row.Cells["Nombre"].Value == null) continue;

                string producto = row.Cells["Nombre"].Value.ToString();

                // Verificar si es una fila de producto válida
                if (row.Cells["Cantidad"].Value == null) continue;

                string cantidad = row.Cells["Cantidad"].Value.ToString();
                string precio = row.Cells["Precio"].Value.ToString();

                // Acortar nombre de producto para impresora de 58mm
                if (producto.Length > 8)
                    producto = producto.Substring(0, 8);

                sb.AppendLine($"{producto.PadRight(8)}  {cantidad.PadLeft(2)}  ${precio.PadLeft(6)}");
            }
            sb.AppendLine(" ");
            sb.AppendLine("-----------------------------");
            sb.AppendLine($"TOTAL: {lblTotal.Text}");
            sb.AppendLine($"Pago: Efectivo");
            sb.AppendLine("-----------------------------");
            sb.AppendLine(" ");
            sb.AppendLine("  ¡GRACIAS POR SU COMPRA!");
            sb.AppendLine(" ");
            sb.AppendLine(" ");
            sb.AppendLine("-----------------------------");

            ticketTexto = sb.ToString();
        }

    }

    public static class WindowHelper
    {
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }

}


