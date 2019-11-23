namespace PuntoDeVentas.Administrador
{
    partial class Repuestos
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
            this.components = new System.ComponentModel.Container();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuscarRepuesto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gridRepuesto = new System.Windows.Forms.DataGridView();
            this.iDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCARGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPERFILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIMERNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEGUNDONOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIMERAPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHANACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOCIVILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repuestos3DataSet = new PuntoDeVentas.repuestos3DataSet();
            this.btnActualizarRepues = new System.Windows.Forms.Button();
            this.btnBorrarRepues = new System.Windows.Forms.Button();
            this.btnCrearRepues = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uSUARIOSTableAdapter = new PuntoDeVentas.repuestos3DataSetTableAdapters.USUARIOSTableAdapter();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescripRep = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumVin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumChasis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumMotor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaResp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioCompraResp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombRepuest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbParteVehi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModeloVehi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-56, 316);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 237;
            this.label12.Text = "Cantidad";
            // 
            // txtBuscarRepuesto
            // 
            this.txtBuscarRepuesto.Location = new System.Drawing.Point(700, 47);
            this.txtBuscarRepuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarRepuesto.Name = "txtBuscarRepuesto";
            this.txtBuscarRepuesto.Size = new System.Drawing.Size(180, 20);
            this.txtBuscarRepuesto.TabIndex = 234;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(622, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 233;
            this.label9.Text = "Buscar";
            // 
            // gridRepuesto
            // 
            this.gridRepuesto.AutoGenerateColumns = false;
            this.gridRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRepuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUSUARIODataGridViewTextBoxColumn,
            this.iDCARGODataGridViewTextBoxColumn,
            this.iDPERFILDataGridViewTextBoxColumn,
            this.pRIMERNOMBREDataGridViewTextBoxColumn,
            this.sEGUNDONOMBREDataGridViewTextBoxColumn,
            this.pRIMERAPELLIDODataGridViewTextBoxColumn,
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.fECHANACDataGridViewTextBoxColumn,
            this.sEXODataGridViewTextBoxColumn,
            this.eSTADOCIVILDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pASSDataGridViewTextBoxColumn});
            this.gridRepuesto.DataSource = this.uSUARIOSBindingSource;
            this.gridRepuesto.Location = new System.Drawing.Point(615, 84);
            this.gridRepuesto.Name = "gridRepuesto";
            this.gridRepuesto.Size = new System.Drawing.Size(345, 227);
            this.gridRepuesto.TabIndex = 232;
            this.gridRepuesto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridRepuesto_CellMouseClick);
            this.gridRepuesto.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gridRepuesto_RowStateChanged);
            // 
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            this.iDUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCARGODataGridViewTextBoxColumn
            // 
            this.iDCARGODataGridViewTextBoxColumn.DataPropertyName = "ID_CARGO";
            this.iDCARGODataGridViewTextBoxColumn.HeaderText = "ID_CARGO";
            this.iDCARGODataGridViewTextBoxColumn.Name = "iDCARGODataGridViewTextBoxColumn";
            // 
            // iDPERFILDataGridViewTextBoxColumn
            // 
            this.iDPERFILDataGridViewTextBoxColumn.DataPropertyName = "ID_PERFIL";
            this.iDPERFILDataGridViewTextBoxColumn.HeaderText = "ID_PERFIL";
            this.iDPERFILDataGridViewTextBoxColumn.Name = "iDPERFILDataGridViewTextBoxColumn";
            // 
            // pRIMERNOMBREDataGridViewTextBoxColumn
            // 
            this.pRIMERNOMBREDataGridViewTextBoxColumn.DataPropertyName = "PRIMERNOMBRE";
            this.pRIMERNOMBREDataGridViewTextBoxColumn.HeaderText = "PRIMERNOMBRE";
            this.pRIMERNOMBREDataGridViewTextBoxColumn.Name = "pRIMERNOMBREDataGridViewTextBoxColumn";
            // 
            // sEGUNDONOMBREDataGridViewTextBoxColumn
            // 
            this.sEGUNDONOMBREDataGridViewTextBoxColumn.DataPropertyName = "SEGUNDONOMBRE";
            this.sEGUNDONOMBREDataGridViewTextBoxColumn.HeaderText = "SEGUNDONOMBRE";
            this.sEGUNDONOMBREDataGridViewTextBoxColumn.Name = "sEGUNDONOMBREDataGridViewTextBoxColumn";
            // 
            // pRIMERAPELLIDODataGridViewTextBoxColumn
            // 
            this.pRIMERAPELLIDODataGridViewTextBoxColumn.DataPropertyName = "PRIMERAPELLIDO";
            this.pRIMERAPELLIDODataGridViewTextBoxColumn.HeaderText = "PRIMERAPELLIDO";
            this.pRIMERAPELLIDODataGridViewTextBoxColumn.Name = "pRIMERAPELLIDODataGridViewTextBoxColumn";
            // 
            // sEGUNDOAPELLIDODataGridViewTextBoxColumn
            // 
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn.DataPropertyName = "SEGUNDOAPELLIDO";
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn.HeaderText = "SEGUNDOAPELLIDO";
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn.Name = "sEGUNDOAPELLIDODataGridViewTextBoxColumn";
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            // 
            // fECHANACDataGridViewTextBoxColumn
            // 
            this.fECHANACDataGridViewTextBoxColumn.DataPropertyName = "FECHANAC";
            this.fECHANACDataGridViewTextBoxColumn.HeaderText = "FECHANAC";
            this.fECHANACDataGridViewTextBoxColumn.Name = "fECHANACDataGridViewTextBoxColumn";
            // 
            // sEXODataGridViewTextBoxColumn
            // 
            this.sEXODataGridViewTextBoxColumn.DataPropertyName = "SEXO";
            this.sEXODataGridViewTextBoxColumn.HeaderText = "SEXO";
            this.sEXODataGridViewTextBoxColumn.Name = "sEXODataGridViewTextBoxColumn";
            // 
            // eSTADOCIVILDataGridViewTextBoxColumn
            // 
            this.eSTADOCIVILDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_CIVIL";
            this.eSTADOCIVILDataGridViewTextBoxColumn.HeaderText = "ESTADO_CIVIL";
            this.eSTADOCIVILDataGridViewTextBoxColumn.Name = "eSTADOCIVILDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // pASSDataGridViewTextBoxColumn
            // 
            this.pASSDataGridViewTextBoxColumn.DataPropertyName = "PASS";
            this.pASSDataGridViewTextBoxColumn.HeaderText = "PASS";
            this.pASSDataGridViewTextBoxColumn.Name = "pASSDataGridViewTextBoxColumn";
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.repuestos3DataSet;
            // 
            // repuestos3DataSet
            // 
            this.repuestos3DataSet.DataSetName = "repuestos3DataSet";
            this.repuestos3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnActualizarRepues
            // 
            this.btnActualizarRepues.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarRepues.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnActualizarRepues.FlatAppearance.BorderSize = 2;
            this.btnActualizarRepues.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarRepues.Location = new System.Drawing.Point(445, 379);
            this.btnActualizarRepues.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarRepues.Name = "btnActualizarRepues";
            this.btnActualizarRepues.Size = new System.Drawing.Size(92, 33);
            this.btnActualizarRepues.TabIndex = 231;
            this.btnActualizarRepues.Text = "Actualizar";
            this.btnActualizarRepues.UseVisualStyleBackColor = false;
            this.btnActualizarRepues.Click += new System.EventHandler(this.btnActualizarRepues_Click);
            // 
            // btnBorrarRepues
            // 
            this.btnBorrarRepues.BackColor = System.Drawing.Color.Red;
            this.btnBorrarRepues.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarRepues.FlatAppearance.BorderSize = 2;
            this.btnBorrarRepues.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarRepues.Location = new System.Drawing.Point(606, 379);
            this.btnBorrarRepues.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarRepues.Name = "btnBorrarRepues";
            this.btnBorrarRepues.Size = new System.Drawing.Size(95, 33);
            this.btnBorrarRepues.TabIndex = 230;
            this.btnBorrarRepues.Text = "Borrar";
            this.btnBorrarRepues.UseVisualStyleBackColor = false;
            // 
            // btnCrearRepues
            // 
            this.btnCrearRepues.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCrearRepues.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrearRepues.FlatAppearance.BorderSize = 2;
            this.btnCrearRepues.ForeColor = System.Drawing.Color.Black;
            this.btnCrearRepues.Location = new System.Drawing.Point(292, 379);
            this.btnCrearRepues.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearRepues.Name = "btnCrearRepues";
            this.btnCrearRepues.Size = new System.Drawing.Size(96, 33);
            this.btnCrearRepues.TabIndex = 228;
            this.btnCrearRepues.Text = "Crear";
            this.btnCrearRepues.UseVisualStyleBackColor = false;
            this.btnCrearRepues.Click += new System.EventHandler(this.btnCrearRepues_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-60, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 220;
            this.label7.Text = "Descuento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-60, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 215;
            this.label3.Text = "Descripcion";
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 308);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 266;
            this.label16.Text = "Cantidad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 272);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 265;
            this.label15.Text = "Descuento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 92);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 264;
            this.label14.Text = "Descripcion";
            // 
            // txtDescripRep
            // 
            this.txtDescripRep.Location = new System.Drawing.Point(131, 92);
            this.txtDescripRep.Name = "txtDescripRep";
            this.txtDescripRep.Size = new System.Drawing.Size(150, 20);
            this.txtDescripRep.TabIndex = 263;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(131, 308);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 20);
            this.txtCantidad.TabIndex = 262;
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(406, 256);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(150, 20);
            this.txtUPC.TabIndex = 261;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 263);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 260;
            this.label13.Text = "UPC";
            // 
            // txtNumVin
            // 
            this.txtNumVin.Location = new System.Drawing.Point(407, 215);
            this.txtNumVin.Name = "txtNumVin";
            this.txtNumVin.Size = new System.Drawing.Size(150, 20);
            this.txtNumVin.TabIndex = 259;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 258;
            this.label8.Text = "Numero Vin";
            // 
            // txtNumChasis
            // 
            this.txtNumChasis.Location = new System.Drawing.Point(407, 171);
            this.txtNumChasis.Name = "txtNumChasis";
            this.txtNumChasis.Size = new System.Drawing.Size(150, 20);
            this.txtNumChasis.TabIndex = 257;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 256;
            this.label11.Text = "Numero Chasis";
            // 
            // txtNumMotor
            // 
            this.txtNumMotor.Location = new System.Drawing.Point(407, 127);
            this.txtNumMotor.Name = "txtNumMotor";
            this.txtNumMotor.Size = new System.Drawing.Size(150, 20);
            this.txtNumMotor.TabIndex = 255;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 254;
            this.label6.Text = "Numero Motor";
            // 
            // txtDescVenta
            // 
            this.txtDescVenta.Location = new System.Drawing.Point(131, 269);
            this.txtDescVenta.Name = "txtDescVenta";
            this.txtDescVenta.Size = new System.Drawing.Size(150, 20);
            this.txtDescVenta.TabIndex = 253;
            // 
            // txtPrecioVentaResp
            // 
            this.txtPrecioVentaResp.Location = new System.Drawing.Point(132, 227);
            this.txtPrecioVentaResp.Name = "txtPrecioVentaResp";
            this.txtPrecioVentaResp.Size = new System.Drawing.Size(150, 20);
            this.txtPrecioVentaResp.TabIndex = 252;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 251;
            this.label4.Text = "Precio Venta";
            // 
            // txtPrecioCompraResp
            // 
            this.txtPrecioCompraResp.Location = new System.Drawing.Point(132, 185);
            this.txtPrecioCompraResp.Name = "txtPrecioCompraResp";
            this.txtPrecioCompraResp.Size = new System.Drawing.Size(150, 20);
            this.txtPrecioCompraResp.TabIndex = 250;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 249;
            this.label5.Text = "Precio Compra";
            // 
            // txtNombRepuest
            // 
            this.txtNombRepuest.Location = new System.Drawing.Point(132, 50);
            this.txtNombRepuest.Name = "txtNombRepuest";
            this.txtNombRepuest.Size = new System.Drawing.Size(150, 20);
            this.txtNombRepuest.TabIndex = 248;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 247;
            this.label2.Text = "Nombre Repuesto";
            // 
            // cbParteVehi
            // 
            this.cbParteVehi.FormattingEnabled = true;
            this.cbParteVehi.Items.AddRange(new object[] {
            "C",
            "S"});
            this.cbParteVehi.Location = new System.Drawing.Point(406, 45);
            this.cbParteVehi.Margin = new System.Windows.Forms.Padding(2);
            this.cbParteVehi.Name = "cbParteVehi";
            this.cbParteVehi.Size = new System.Drawing.Size(150, 21);
            this.cbParteVehi.TabIndex = 246;
            this.cbParteVehi.SelectedIndexChanged += new System.EventHandler(this.cbParteVehi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 245;
            this.label1.Text = "Parte Vehiculo";
            // 
            // cbModeloVehi
            // 
            this.cbModeloVehi.FormattingEnabled = true;
            this.cbModeloVehi.Items.AddRange(new object[] {
            "C",
            "S"});
            this.cbModeloVehi.Location = new System.Drawing.Point(406, 89);
            this.cbModeloVehi.Margin = new System.Windows.Forms.Padding(2);
            this.cbModeloVehi.Name = "cbModeloVehi";
            this.cbModeloVehi.Size = new System.Drawing.Size(156, 21);
            this.cbModeloVehi.TabIndex = 244;
            this.cbModeloVehi.SelectedIndexChanged += new System.EventHandler(this.cbModeloVehi_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 243;
            this.label10.Text = "Modelo Vehiculo";
            // 
            // Repuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 444);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDescripRep);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtUPC);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNumVin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumChasis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNumMotor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescVenta);
            this.Controls.Add(this.txtPrecioVentaResp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioCompraResp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombRepuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbParteVehi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbModeloVehi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBuscarRepuesto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridRepuesto);
            this.Controls.Add(this.btnActualizarRepues);
            this.Controls.Add(this.btnBorrarRepues);
            this.Controls.Add(this.btnCrearRepues);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Name = "Repuestos";
            this.Text = "Repuestos";
            this.Load += new System.EventHandler(this.Repuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRepuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBuscarRepuesto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridRepuesto;
        private System.Windows.Forms.Button btnActualizarRepues;
        private System.Windows.Forms.Button btnBorrarRepues;
        private System.Windows.Forms.Button btnCrearRepues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private repuestos3DataSet repuestos3DataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private repuestos3DataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCARGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPERFILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIMERNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEGUNDONOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIMERAPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEGUNDOAPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHANACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOCIVILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescripRep;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumVin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumChasis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumMotor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescVenta;
        private System.Windows.Forms.TextBox txtPrecioVentaResp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioCompraResp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombRepuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbParteVehi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModeloVehi;
        private System.Windows.Forms.Label label10;
    }
}