namespace PuntoDeVentas.Vendedor
{
    partial class PuntoDeVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CB_Clientes = new System.Windows.Forms.ComboBox();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClienteNuevo = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.UPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMOVER = new System.Windows.Forms.DataGridViewButtonColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDar = new System.Windows.Forms.Button();
            this.txtDar = new System.Windows.Forms.TextBox();
            this.txtTomar = new System.Windows.Forms.TextBox();
            this.btnTomar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMetodo2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMetodo1 = new System.Windows.Forms.ComboBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.METODO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUITAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPagarImprimir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtConsolidado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(520, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto De Venta";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.CB_Clientes);
            this.panel2.Controls.Add(this.btnBuscarItem);
            this.panel2.Controls.Add(this.txtItem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnClienteNuevo);
            this.panel2.Controls.Add(this.btnBuscarCliente);
            this.panel2.Controls.Add(this.txtFecha);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTracking);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbDocumento);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1429, 185);
            this.panel2.TabIndex = 1;
            // 
            // CB_Clientes
            // 
            this.CB_Clientes.FormattingEnabled = true;
            this.CB_Clientes.Location = new System.Drawing.Point(205, 78);
            this.CB_Clientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_Clientes.Name = "CB_Clientes";
            this.CB_Clientes.Size = new System.Drawing.Size(259, 25);
            this.CB_Clientes.TabIndex = 61;
            this.CB_Clientes.SelectedIndexChanged += new System.EventHandler(this.CB_Clientes_SelectedIndexChanged);
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.BackgroundImage = global::PuntoDeVentas.Properties.Resources.lupa1;
            this.btnBuscarItem.Location = new System.Drawing.Point(591, 121);
            this.btnBuscarItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(48, 42);
            this.btnBuscarItem.TabIndex = 60;
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.BtnBuscarItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(183, 130);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(372, 23);
            this.txtItem.TabIndex = 59;
            this.txtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItem_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "BUSCAR REPUESTO";
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.BackgroundImage = global::PuntoDeVentas.Properties.Resources.plus;
            this.btnClienteNuevo.Location = new System.Drawing.Point(700, 71);
            this.btnClienteNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Size = new System.Drawing.Size(45, 38);
            this.btnClienteNuevo.TabIndex = 57;
            this.btnClienteNuevo.UseVisualStyleBackColor = true;
            this.btnClienteNuevo.Click += new System.EventHandler(this.BtnClienteNuevo_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImage = global::PuntoDeVentas.Properties.Resources.lupa1;
            this.btnBuscarCliente.Location = new System.Drawing.Point(647, 66);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(45, 43);
            this.btnBuscarCliente.TabIndex = 56;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(801, 30);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(160, 23);
            this.txtFecha.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(691, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "FECHA VENTA";
            // 
            // txtTracking
            // 
            this.txtTracking.Location = new System.Drawing.Point(477, 30);
            this.txtTracking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(160, 23);
            this.txtTracking.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(367, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "TRACKING N°";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(477, 78);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(160, 23);
            this.txtCliente.TabIndex = 51;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_keyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "CLIENTE";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DisplayMember = "DESCRIPCION";
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(135, 30);
            this.cmbDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(160, 25);
            this.cmbDocumento.TabIndex = 48;
            this.cmbDocumento.ValueMember = "ID_TIPODOC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "DOCUMENTO";
            // 
            // dgvItems
            // 
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UPC,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.DESCUENTO,
            this.PRECIO_UNITARIO,
            this.PRECIO_TOTAL,
            this.REMOVER});
            this.dgvItems.Location = new System.Drawing.Point(229, 286);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(929, 185);
            this.dgvItems.TabIndex = 54;
            // 
            // UPC
            // 
            this.UPC.Frozen = true;
            this.UPC.HeaderText = "UPC";
            this.UPC.MinimumWidth = 6;
            this.UPC.Name = "UPC";
            this.UPC.ReadOnly = true;
            this.UPC.Width = 125;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.Frozen = true;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MinimumWidth = 6;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 125;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.Frozen = true;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.MinimumWidth = 6;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 125;
            // 
            // DESCUENTO
            // 
            this.DESCUENTO.Frozen = true;
            this.DESCUENTO.HeaderText = "DESCUENTO";
            this.DESCUENTO.MinimumWidth = 6;
            this.DESCUENTO.Name = "DESCUENTO";
            this.DESCUENTO.Width = 125;
            // 
            // PRECIO_UNITARIO
            // 
            this.PRECIO_UNITARIO.Frozen = true;
            this.PRECIO_UNITARIO.HeaderText = "PRECIO UNITARIO";
            this.PRECIO_UNITARIO.MinimumWidth = 6;
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.ReadOnly = true;
            this.PRECIO_UNITARIO.Width = 125;
            // 
            // PRECIO_TOTAL
            // 
            this.PRECIO_TOTAL.HeaderText = "PRECIO TOTAL";
            this.PRECIO_TOTAL.MinimumWidth = 6;
            this.PRECIO_TOTAL.Name = "PRECIO_TOTAL";
            this.PRECIO_TOTAL.Width = 125;
            // 
            // REMOVER
            // 
            this.REMOVER.HeaderText = "REMOVER";
            this.REMOVER.MinimumWidth = 6;
            this.REMOVER.Name = "REMOVER";
            this.REMOVER.Width = 125;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 479);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(657, 117);
            this.richTextBox1.TabIndex = 55;
            this.richTextBox1.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDar);
            this.panel3.Controls.Add(this.txtDar);
            this.panel3.Controls.Add(this.txtTomar);
            this.panel3.Controls.Add(this.btnTomar);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cmbMetodo2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cmbMetodo1);
            this.panel3.Location = new System.Drawing.Point(13, 604);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 100);
            this.panel3.TabIndex = 79;
            // 
            // btnDar
            // 
            this.btnDar.Enabled = false;
            this.btnDar.Location = new System.Drawing.Point(467, 55);
            this.btnDar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDar.Name = "btnDar";
            this.btnDar.Size = new System.Drawing.Size(152, 28);
            this.btnDar.TabIndex = 76;
            this.btnDar.Text = "DAR VUELTO";
            this.btnDar.UseVisualStyleBackColor = true;
            this.btnDar.Click += new System.EventHandler(this.BtnDar_Click);
            // 
            // txtDar
            // 
            this.txtDar.Location = new System.Drawing.Point(104, 57);
            this.txtDar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDar.Name = "txtDar";
            this.txtDar.Size = new System.Drawing.Size(160, 22);
            this.txtDar.TabIndex = 75;
            // 
            // txtTomar
            // 
            this.txtTomar.Location = new System.Drawing.Point(104, 20);
            this.txtTomar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTomar.Name = "txtTomar";
            this.txtTomar.Size = new System.Drawing.Size(160, 22);
            this.txtTomar.TabIndex = 74;
            // 
            // btnTomar
            // 
            this.btnTomar.Enabled = false;
            this.btnTomar.Location = new System.Drawing.Point(467, 18);
            this.btnTomar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTomar.Name = "btnTomar";
            this.btnTomar.Size = new System.Drawing.Size(156, 28);
            this.btnTomar.TabIndex = 73;
            this.btnTomar.Text = "TOMAR PAGO";
            this.btnTomar.UseVisualStyleBackColor = true;
            this.btnTomar.Click += new System.EventHandler(this.BtnTomar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 72;
            this.label11.Text = "DAR";
            // 
            // cmbMetodo2
            // 
            this.cmbMetodo2.DisplayMember = "METODO";
            this.cmbMetodo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo2.FormattingEnabled = true;
            this.cmbMetodo2.Location = new System.Drawing.Point(293, 57);
            this.cmbMetodo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMetodo2.Name = "cmbMetodo2";
            this.cmbMetodo2.Size = new System.Drawing.Size(160, 24);
            this.cmbMetodo2.TabIndex = 71;
            this.cmbMetodo2.ValueMember = "ID_METODO";
            this.cmbMetodo2.SelectedIndexChanged += new System.EventHandler(this.CmbMetodo2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "TOMAR";
            // 
            // cmbMetodo1
            // 
            this.cmbMetodo1.DisplayMember = "METODO";
            this.cmbMetodo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo1.FormattingEnabled = true;
            this.cmbMetodo1.Location = new System.Drawing.Point(293, 20);
            this.cmbMetodo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMetodo1.Name = "cmbMetodo1";
            this.cmbMetodo1.Size = new System.Drawing.Size(160, 24);
            this.cmbMetodo1.TabIndex = 69;
            this.cmbMetodo1.ValueMember = "ID_METODO";
            this.cmbMetodo1.SelectedIndexChanged += new System.EventHandler(this.CmbMetodo1_SelectedIndexChanged);
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO,
            this.METODO,
            this.VALOR,
            this.QUITAR});
            this.dgvPagos.Location = new System.Drawing.Point(11, 716);
            this.dgvPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.RowHeadersWidth = 51;
            this.dgvPagos.Size = new System.Drawing.Size(659, 121);
            this.dgvPagos.TabIndex = 80;
            // 
            // TIPO
            // 
            this.TIPO.Frozen = true;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.MinimumWidth = 6;
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 125;
            // 
            // METODO
            // 
            this.METODO.Frozen = true;
            this.METODO.HeaderText = "METODO";
            this.METODO.MinimumWidth = 6;
            this.METODO.Name = "METODO";
            this.METODO.ReadOnly = true;
            this.METODO.Width = 125;
            // 
            // VALOR
            // 
            this.VALOR.Frozen = true;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.MinimumWidth = 6;
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 125;
            // 
            // QUITAR
            // 
            this.QUITAR.Frozen = true;
            this.QUITAR.HeaderText = "QUITAR";
            this.QUITAR.MinimumWidth = 6;
            this.QUITAR.Name = "QUITAR";
            this.QUITAR.ReadOnly = true;
            this.QUITAR.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnPagarImprimir);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(872, 676);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(555, 161);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagos";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPagar.Enabled = false;
            this.btnPagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPagar.Location = new System.Drawing.Point(312, 50);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(213, 44);
            this.btnPagar.TabIndex = 77;
            this.btnPagar.Text = "SOLO PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(215, 103);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 44);
            this.btnLimpiar.TabIndex = 76;
            this.btnLimpiar.Text = "LIMPIAR TODO";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnPagarImprimir
            // 
            this.btnPagarImprimir.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPagarImprimir.Enabled = false;
            this.btnPagarImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPagarImprimir.Location = new System.Drawing.Point(31, 50);
            this.btnPagarImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagarImprimir.Name = "btnPagarImprimir";
            this.btnPagarImprimir.Size = new System.Drawing.Size(256, 44);
            this.btnPagarImprimir.TabIndex = 75;
            this.btnPagarImprimir.Text = "PAGAR E IMPRIMIR";
            this.btnPagarImprimir.UseVisualStyleBackColor = false;
            this.btnPagarImprimir.Click += new System.EventHandler(this.BtnPagarImprimir_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txtConsolidado);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtSubtotal);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtMontoTotal);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtIva);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(872, 490);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 180);
            this.panel4.TabIndex = 82;
            // 
            // txtConsolidado
            // 
            this.txtConsolidado.Enabled = false;
            this.txtConsolidado.Location = new System.Drawing.Point(229, 143);
            this.txtConsolidado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConsolidado.Name = "txtConsolidado";
            this.txtConsolidado.Size = new System.Drawing.Size(160, 22);
            this.txtConsolidado.TabIndex = 86;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 153);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 17);
            this.label12.TabIndex = 85;
            this.label12.Text = "CONSOLIDADO";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(228, 64);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(160, 22);
            this.txtSubtotal.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 83;
            this.label9.Text = "SUBTOTAL: $";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(228, 96);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(160, 22);
            this.txtMontoTotal.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 81;
            this.label8.Text = "MONTO TOTAL: $";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(228, 32);
            this.txtIva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(160, 22);
            this.txtIva.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 79;
            this.label7.Text = "IVA: $";
            // 
            // PuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1439, 850);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PuntoDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuntoDeVenta";
            this.Load += new System.EventHandler(this.PuntoDeVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClienteNuevo;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_TOTAL;
        private System.Windows.Forms.DataGridViewButtonColumn REMOVER;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDar;
        private System.Windows.Forms.TextBox txtDar;
        private System.Windows.Forms.TextBox txtTomar;
        private System.Windows.Forms.Button btnTomar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbMetodo2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMetodo1;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn METODO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewButtonColumn QUITAR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPagarImprimir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtConsolidado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox CB_Clientes;
    }
}