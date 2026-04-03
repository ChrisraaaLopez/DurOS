namespace DurOS
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.mesa2 = new System.Windows.Forms.Button();
            this.mesa4 = new System.Windows.Forms.Button();
            this.mesa3 = new System.Windows.Forms.Button();
            this.mesa6 = new System.Windows.Forms.Button();
            this.mesa5 = new System.Windows.Forms.Button();
            this.mesa8 = new System.Windows.Forms.Button();
            this.mesa7 = new System.Windows.Forms.Button();
            this.mesa9 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAtiende = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnVentasDia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMesa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(1188, 154);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(546, 26);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnVentas
            // 
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Location = new System.Drawing.Point(36, 92);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(207, 33);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Text = "F1 | Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.ForeColor = System.Drawing.Color.Black;
            this.btnInventario.Location = new System.Drawing.Point(249, 92);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(207, 33);
            this.btnInventario.TabIndex = 7;
            this.btnInventario.Text = "F4 | Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1418, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 90);
            this.label1.TabIndex = 8;
            this.label1.Text = "                                                                             \r\n\r\n" +
    "\r\n\r\n\r\n";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(1418, 735);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(316, 40);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$ 00, 000. 00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(36, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 33);
            this.button5.TabIndex = 11;
            this.button5.Text = "Mesa 1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // mesa2
            // 
            this.mesa2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mesa2.Location = new System.Drawing.Point(131, 147);
            this.mesa2.Name = "mesa2";
            this.mesa2.Size = new System.Drawing.Size(89, 33);
            this.mesa2.TabIndex = 12;
            this.mesa2.Text = "Mesa 2";
            this.mesa2.UseVisualStyleBackColor = true;
            this.mesa2.Click += new System.EventHandler(this.mesa2_Click);
            // 
            // mesa4
            // 
            this.mesa4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mesa4.Location = new System.Drawing.Point(321, 147);
            this.mesa4.Name = "mesa4";
            this.mesa4.Size = new System.Drawing.Size(89, 33);
            this.mesa4.TabIndex = 14;
            this.mesa4.Text = "Mesa 4";
            this.mesa4.UseVisualStyleBackColor = true;
            this.mesa4.Click += new System.EventHandler(this.mesa4_Click);
            // 
            // mesa3
            // 
            this.mesa3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mesa3.Location = new System.Drawing.Point(226, 147);
            this.mesa3.Name = "mesa3";
            this.mesa3.Size = new System.Drawing.Size(89, 33);
            this.mesa3.TabIndex = 13;
            this.mesa3.Text = "Mesa 3";
            this.mesa3.UseVisualStyleBackColor = true;
            this.mesa3.Click += new System.EventHandler(this.mesa3_Click);
            // 
            // mesa6
            // 
            this.mesa6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mesa6.Location = new System.Drawing.Point(511, 147);
            this.mesa6.Name = "mesa6";
            this.mesa6.Size = new System.Drawing.Size(89, 33);
            this.mesa6.TabIndex = 16;
            this.mesa6.Text = "Mesa 6";
            this.mesa6.UseVisualStyleBackColor = true;
            this.mesa6.Click += new System.EventHandler(this.mesa6_Click);
            // 
            // mesa5
            // 
            this.mesa5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mesa5.Location = new System.Drawing.Point(416, 147);
            this.mesa5.Name = "mesa5";
            this.mesa5.Size = new System.Drawing.Size(89, 33);
            this.mesa5.TabIndex = 15;
            this.mesa5.Text = "Mesa 5";
            this.mesa5.UseVisualStyleBackColor = true;
            this.mesa5.Click += new System.EventHandler(this.mesa5_Click);
            // 
            // mesa8
            // 
            this.mesa8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mesa8.Location = new System.Drawing.Point(701, 147);
            this.mesa8.Name = "mesa8";
            this.mesa8.Size = new System.Drawing.Size(89, 33);
            this.mesa8.TabIndex = 18;
            this.mesa8.Text = "Mesa 8";
            this.mesa8.UseVisualStyleBackColor = true;
            this.mesa8.Click += new System.EventHandler(this.mesa8_Click);
            // 
            // mesa7
            // 
            this.mesa7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mesa7.Location = new System.Drawing.Point(606, 147);
            this.mesa7.Name = "mesa7";
            this.mesa7.Size = new System.Drawing.Size(89, 33);
            this.mesa7.TabIndex = 17;
            this.mesa7.Text = "Mesa 7";
            this.mesa7.UseVisualStyleBackColor = true;
            this.mesa7.Click += new System.EventHandler(this.mesa7_Click);
            // 
            // mesa9
            // 
            this.mesa9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mesa9.Location = new System.Drawing.Point(793, 147);
            this.mesa9.Name = "mesa9";
            this.mesa9.Size = new System.Drawing.Size(89, 33);
            this.mesa9.TabIndex = 19;
            this.mesa9.Text = "Mesa 9";
            this.mesa9.UseVisualStyleBackColor = true;
            this.mesa9.Click += new System.EventHandler(this.mesa9_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1773, 75);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1495, 711);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total del tiket:";
            // 
            // lblAtiende
            // 
            this.lblAtiende.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtiende.BackColor = System.Drawing.Color.Black;
            this.lblAtiende.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtiende.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAtiende.Location = new System.Drawing.Point(1421, 39);
            this.lblAtiende.Name = "lblAtiende";
            this.lblAtiende.Size = new System.Drawing.Size(313, 24);
            this.lblAtiende.TabIndex = 23;
            this.lblAtiende.Text = "(Nombre)";
            this.lblAtiende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(1421, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Le atiende:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1167, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nombre del producto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(675, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 33);
            this.button3.TabIndex = 27;
            this.button3.Text = "Usuarios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(1527, 92);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(207, 33);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.ForeColor = System.Drawing.Color.Black;
            this.btnCobrar.Location = new System.Drawing.Point(1188, 711);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(207, 55);
            this.btnCobrar.TabIndex = 30;
            this.btnCobrar.Text = "F12 | Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnVentasDia
            // 
            this.btnVentasDia.ForeColor = System.Drawing.Color.Black;
            this.btnVentasDia.Location = new System.Drawing.Point(462, 92);
            this.btnVentasDia.Name = "btnVentasDia";
            this.btnVentasDia.Size = new System.Drawing.Size(207, 33);
            this.btnVentasDia.TabIndex = 31;
            this.btnVentasDia.Text = "Ventas del dia";
            this.btnVentasDia.UseVisualStyleBackColor = true;
            this.btnVentasDia.Click += new System.EventHandler(this.btnVentasDia_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1535, 846);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 40);
            this.button1.TabIndex = 35;
            this.button1.Text = "ESC | Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1353, 846);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(166, 40);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "ENTER | Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dtgvTicket
            // 
            this.dtgvTicket.AllowUserToAddRows = false;
            this.dtgvTicket.AllowUserToDeleteRows = false;
            this.dtgvTicket.AllowUserToResizeColumns = false;
            this.dtgvTicket.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvTicket.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.Location = new System.Drawing.Point(36, 197);
            this.dtgvTicket.MultiSelect = false;
            this.dtgvTicket.Name = "dtgvTicket";
            this.dtgvTicket.ReadOnly = true;
            this.dtgvTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTicket.Size = new System.Drawing.Size(1128, 486);
            this.dtgvTicket.TabIndex = 37;
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.AllowUserToAddRows = false;
            this.dtgvProductos.AllowUserToDeleteRows = false;
            this.dtgvProductos.AllowUserToResizeColumns = false;
            this.dtgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn9});
            this.dtgvProductos.Location = new System.Drawing.Point(1188, 197);
            this.dtgvProductos.MultiSelect = false;
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.ReadOnly = true;
            this.dtgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProductos.Size = new System.Drawing.Size(546, 486);
            this.dtgvProductos.TabIndex = 38;
            this.dtgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProductos_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre del Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventario Minimo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Inventario Actual";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // lblMesa
            // 
            this.lblMesa.BackColor = System.Drawing.Color.White;
            this.lblMesa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMesa.Location = new System.Drawing.Point(1041, 148);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(123, 33);
            this.lblMesa.TabIndex = 39;
            this.lblMesa.Text = "Mesa 1";
            this.lblMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1773, 829);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.dtgvProductos);
            this.Controls.Add(this.dtgvTicket);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnVentasDia);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAtiende);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.mesa9);
            this.Controls.Add(this.mesa8);
            this.Controls.Add(this.mesa7);
            this.Controls.Add(this.mesa6);
            this.Controls.Add(this.mesa5);
            this.Controls.Add(this.mesa4);
            this.Controls.Add(this.mesa3);
            this.Controls.Add(this.mesa2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.txtFiltro);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "durOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inicio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button mesa2;
        private System.Windows.Forms.Button mesa4;
        private System.Windows.Forms.Button mesa3;
        private System.Windows.Forms.Button mesa6;
        private System.Windows.Forms.Button mesa5;
        private System.Windows.Forms.Button mesa8;
        private System.Windows.Forms.Button mesa7;
        private System.Windows.Forms.Button mesa9;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAtiende;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnVentasDia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dtgvTicket;
        private System.Windows.Forms.DataGridView dtgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label lblMesa;
    }
}

