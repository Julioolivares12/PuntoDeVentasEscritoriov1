namespace PuntoDeVentas.Administrador
{
    partial class Empleado
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridEmpleado = new System.Windows.Forms.DataGridView();
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
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnBorrarEmpleado = new System.Windows.Forms.Button();
            this.txtTelEmpleado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.txtEmailEmpleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaNacEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidosEmpleados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uSUARIOSTableAdapter = new PuntoDeVentas.repuestos3DataSetTableAdapters.USUARIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 272;
            this.label4.Text = "Perfil";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(158, 224);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(149, 20);
            this.txtClave.TabIndex = 271;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 227);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 270;
            this.label8.Text = "Clave";
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(158, 336);
            this.cbPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(120, 21);
            this.cbPerfil.TabIndex = 269;
            this.cbPerfil.SelectedIndexChanged += new System.EventHandler(this.cbPerfil_SelectedIndexChanged);
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(158, 303);
            this.cbCargo.Margin = new System.Windows.Forms.Padding(2);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(120, 21);
            this.cbCargo.TabIndex = 268;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 267;
            this.label6.Text = "Cargo";
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(513, 46);
            this.txtBuscarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(180, 20);
            this.txtBuscarEmpleado.TabIndex = 266;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 265;
            this.label2.Text = "Buscar";
            // 
            // gridEmpleado
            // 
            this.gridEmpleado.AutoGenerateColumns = false;
            this.gridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.gridEmpleado.DataSource = this.uSUARIOSBindingSource;
            this.gridEmpleado.Location = new System.Drawing.Point(363, 97);
            this.gridEmpleado.Name = "gridEmpleado";
            this.gridEmpleado.RowHeadersWidth = 45;
            this.gridEmpleado.Size = new System.Drawing.Size(486, 323);
            this.gridEmpleado.TabIndex = 264;
            this.gridEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmpleado_CellContentClick);
            this.gridEmpleado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridEmpleado_CellMouseClick);
            this.gridEmpleado.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gridEmpleado_RowStateChanged);
            // 
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            this.iDUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUSUARIODataGridViewTextBoxColumn.Width = 110;
            // 
            // iDCARGODataGridViewTextBoxColumn
            // 
            this.iDCARGODataGridViewTextBoxColumn.DataPropertyName = "ID_CARGO";
            this.iDCARGODataGridViewTextBoxColumn.HeaderText = "ID_CARGO";
            this.iDCARGODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCARGODataGridViewTextBoxColumn.Name = "iDCARGODataGridViewTextBoxColumn";
            this.iDCARGODataGridViewTextBoxColumn.Width = 110;
            // 
            // iDPERFILDataGridViewTextBoxColumn
            // 
            this.iDPERFILDataGridViewTextBoxColumn.DataPropertyName = "ID_PERFIL";
            this.iDPERFILDataGridViewTextBoxColumn.HeaderText = "ID_PERFIL";
            this.iDPERFILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPERFILDataGridViewTextBoxColumn.Name = "iDPERFILDataGridViewTextBoxColumn";
            this.iDPERFILDataGridViewTextBoxColumn.Width = 110;
            // 
            // pRIMERNOMBREDataGridViewTextBoxColumn
            // 
            this.pRIMERNOMBREDataGridViewTextBoxColumn.DataPropertyName = "PRIMERNOMBRE";
            this.pRIMERNOMBREDataGridViewTextBoxColumn.HeaderText = "PRIMERNOMBRE";
            this.pRIMERNOMBREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRIMERNOMBREDataGridViewTextBoxColumn.Name = "pRIMERNOMBREDataGridViewTextBoxColumn";
            this.pRIMERNOMBREDataGridViewTextBoxColumn.Width = 110;
            // 
            // sEGUNDONOMBREDataGridViewTextBoxColumn
            // 
            this.sEGUNDONOMBREDataGridViewTextBoxColumn.DataPropertyName = "SEGUNDONOMBRE";
            this.sEGUNDONOMBREDataGridViewTextBoxColumn.HeaderText = "SEGUNDONOMBRE";
            this.sEGUNDONOMBREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEGUNDONOMBREDataGridViewTextBoxColumn.Name = "sEGUNDONOMBREDataGridViewTextBoxColumn";
            this.sEGUNDONOMBREDataGridViewTextBoxColumn.Width = 110;
            // 
            // pRIMERAPELLIDODataGridViewTextBoxColumn
            // 
            this.pRIMERAPELLIDODataGridViewTextBoxColumn.DataPropertyName = "PRIMERAPELLIDO";
            this.pRIMERAPELLIDODataGridViewTextBoxColumn.HeaderText = "PRIMERAPELLIDO";
            this.pRIMERAPELLIDODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRIMERAPELLIDODataGridViewTextBoxColumn.Name = "pRIMERAPELLIDODataGridViewTextBoxColumn";
            this.pRIMERAPELLIDODataGridViewTextBoxColumn.Width = 110;
            // 
            // sEGUNDOAPELLIDODataGridViewTextBoxColumn
            // 
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn.DataPropertyName = "SEGUNDOAPELLIDO";
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn.HeaderText = "SEGUNDOAPELLIDO";
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn.Name = "sEGUNDOAPELLIDODataGridViewTextBoxColumn";
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn.Width = 110;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.Width = 110;
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            this.tELEFONODataGridViewTextBoxColumn.Width = 110;
            // 
            // fECHANACDataGridViewTextBoxColumn
            // 
            this.fECHANACDataGridViewTextBoxColumn.DataPropertyName = "FECHANAC";
            this.fECHANACDataGridViewTextBoxColumn.HeaderText = "FECHANAC";
            this.fECHANACDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHANACDataGridViewTextBoxColumn.Name = "fECHANACDataGridViewTextBoxColumn";
            this.fECHANACDataGridViewTextBoxColumn.Width = 110;
            // 
            // sEXODataGridViewTextBoxColumn
            // 
            this.sEXODataGridViewTextBoxColumn.DataPropertyName = "SEXO";
            this.sEXODataGridViewTextBoxColumn.HeaderText = "SEXO";
            this.sEXODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEXODataGridViewTextBoxColumn.Name = "sEXODataGridViewTextBoxColumn";
            this.sEXODataGridViewTextBoxColumn.Width = 110;
            // 
            // eSTADOCIVILDataGridViewTextBoxColumn
            // 
            this.eSTADOCIVILDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_CIVIL";
            this.eSTADOCIVILDataGridViewTextBoxColumn.HeaderText = "ESTADO_CIVIL";
            this.eSTADOCIVILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eSTADOCIVILDataGridViewTextBoxColumn.Name = "eSTADOCIVILDataGridViewTextBoxColumn";
            this.eSTADOCIVILDataGridViewTextBoxColumn.Width = 110;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 110;
            // 
            // pASSDataGridViewTextBoxColumn
            // 
            this.pASSDataGridViewTextBoxColumn.DataPropertyName = "PASS";
            this.pASSDataGridViewTextBoxColumn.HeaderText = "PASS";
            this.pASSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pASSDataGridViewTextBoxColumn.Name = "pASSDataGridViewTextBoxColumn";
            this.pASSDataGridViewTextBoxColumn.Width = 110;
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
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnActualizarEmpleado.FlatAppearance.BorderSize = 2;
            this.btnActualizarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(382, 479);
            this.btnActualizarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(92, 33);
            this.btnActualizarEmpleado.TabIndex = 263;
            this.btnActualizarEmpleado.Text = "Actualizar";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click_1);
            // 
            // btnBorrarEmpleado
            // 
            this.btnBorrarEmpleado.BackColor = System.Drawing.Color.Red;
            this.btnBorrarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarEmpleado.FlatAppearance.BorderSize = 2;
            this.btnBorrarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarEmpleado.Location = new System.Drawing.Point(524, 479);
            this.btnBorrarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarEmpleado.Name = "btnBorrarEmpleado";
            this.btnBorrarEmpleado.Size = new System.Drawing.Size(95, 33);
            this.btnBorrarEmpleado.TabIndex = 262;
            this.btnBorrarEmpleado.Text = "Borrar";
            this.btnBorrarEmpleado.UseVisualStyleBackColor = false;
            // 
            // txtTelEmpleado
            // 
            this.txtTelEmpleado.Location = new System.Drawing.Point(158, 153);
            this.txtTelEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelEmpleado.Name = "txtTelEmpleado";
            this.txtTelEmpleado.Size = new System.Drawing.Size(149, 20);
            this.txtTelEmpleado.TabIndex = 260;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 149);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 259;
            this.label14.Text = "Telefono";
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCrearEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrearEmpleado.FlatAppearance.BorderSize = 2;
            this.btnCrearEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnCrearEmpleado.Location = new System.Drawing.Point(249, 479);
            this.btnCrearEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(96, 33);
            this.btnCrearEmpleado.TabIndex = 258;
            this.btnCrearEmpleado.Text = "Crear";
            this.btnCrearEmpleado.UseVisualStyleBackColor = false;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.Location = new System.Drawing.Point(158, 190);
            this.txtEmailEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.Size = new System.Drawing.Size(149, 20);
            this.txtEmailEmpleado.TabIndex = 257;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 190);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 256;
            this.label11.Text = "Correo";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "C",
            "S"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(158, 407);
            this.cbEstadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(56, 21);
            this.cbEstadoCivil.TabIndex = 255;
            this.cbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.cbEstadoCivil_SelectedIndexChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 407);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 254;
            this.label10.Text = "Estado Civil";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(158, 371);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(56, 21);
            this.cbSexo.TabIndex = 253;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 374);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 252;
            this.label9.Text = "Sexo";
            // 
            // txtFechaNacEmpleado
            // 
            this.txtFechaNacEmpleado.Location = new System.Drawing.Point(158, 117);
            this.txtFechaNacEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaNacEmpleado.Name = "txtFechaNacEmpleado";
            this.txtFechaNacEmpleado.Size = new System.Drawing.Size(151, 20);
            this.txtFechaNacEmpleado.TabIndex = 251;
            this.txtFechaNacEmpleado.Text = "         dd/mm/yyyy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 250;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(158, 264);
            this.txtDireccionEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(149, 20);
            this.txtDireccionEmpleado.TabIndex = 249;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 248;
            this.label5.Text = "Direccion ";
            // 
            // txtApellidosEmpleados
            // 
            this.txtApellidosEmpleados.Location = new System.Drawing.Point(158, 80);
            this.txtApellidosEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidosEmpleados.Name = "txtApellidosEmpleados";
            this.txtApellidosEmpleados.Size = new System.Drawing.Size(149, 20);
            this.txtApellidosEmpleados.TabIndex = 247;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 246;
            this.label3.Text = "Apellidos";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(158, 44);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(149, 20);
            this.txtNombreEmpleado.TabIndex = 245;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 244;
            this.label1.Text = "Nombres";
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 542);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridEmpleado);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.btnBorrarEmpleado);
            this.Controls.Add(this.txtTelEmpleado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.txtEmailEmpleado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFechaNacEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccionEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidosEmpleados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.label1);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridEmpleado;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnBorrarEmpleado;
        private System.Windows.Forms.TextBox txtTelEmpleado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.TextBox txtEmailEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFechaNacEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidosEmpleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label1;
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
    }
}