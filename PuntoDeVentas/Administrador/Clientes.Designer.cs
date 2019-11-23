namespace PuntoDeVentas.Administrador
{
    partial class Clientes
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
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIMERNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEGUNDONOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIMERAPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHANACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOCIVILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUGARTRABAJODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repuestos3DataSet = new PuntoDeVentas.repuestos3DataSet();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.cLIENTESTableAdapter = new PuntoDeVentas.repuestos3DataSetTableAdapters.CLIENTESTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDuiCliente = new System.Windows.Forms.TextBox();
            this.txtTelefTrabajoCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCelularCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTrabajoCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEstadoCivilCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSexoCliente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaNacCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefonoCasaCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccionCasaCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrimerApellidoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimerNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(797, 68);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(180, 20);
            this.txtBuscarCliente.TabIndex = 252;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 251;
            this.label2.Text = "Buscar";
            // 
            // gridCliente
            // 
            this.gridCliente.AutoGenerateColumns = false;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLIENTEDataGridViewTextBoxColumn,
            this.pRIMERNOMBREDataGridViewTextBoxColumn,
            this.sEGUNDONOMBREDataGridViewTextBoxColumn,
            this.pRIMERAPELLIDODataGridViewTextBoxColumn,
            this.sEGUNDOAPELLIDODataGridViewTextBoxColumn,
            this.fECHANACDataGridViewTextBoxColumn,
            this.sEXODataGridViewTextBoxColumn,
            this.eSTADOCIVILDataGridViewTextBoxColumn,
            this.lUGARTRABAJODataGridViewTextBoxColumn});
            this.gridCliente.DataSource = this.cLIENTESBindingSource;
            this.gridCliente.Location = new System.Drawing.Point(648, 116);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.Size = new System.Drawing.Size(449, 253);
            this.gridCliente.TabIndex = 250;
            this.gridCliente.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCliente_CellMouseClick);
            this.gridCliente.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gridCliente_RowStateChanged);
            // 
            // iDCLIENTEDataGridViewTextBoxColumn
            // 
            this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
            this.iDCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
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
            // lUGARTRABAJODataGridViewTextBoxColumn
            // 
            this.lUGARTRABAJODataGridViewTextBoxColumn.DataPropertyName = "LUGARTRABAJO";
            this.lUGARTRABAJODataGridViewTextBoxColumn.HeaderText = "LUGARTRABAJO";
            this.lUGARTRABAJODataGridViewTextBoxColumn.Name = "lUGARTRABAJODataGridViewTextBoxColumn";
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.repuestos3DataSet;
            // 
            // repuestos3DataSet
            // 
            this.repuestos3DataSet.DataSetName = "repuestos3DataSet";
            this.repuestos3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarCliente.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnActualizarCliente.FlatAppearance.BorderSize = 2;
            this.btnActualizarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarCliente.Location = new System.Drawing.Point(503, 429);
            this.btnActualizarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(92, 33);
            this.btnActualizarCliente.TabIndex = 249;
            this.btnActualizarCliente.Text = "Actualizar";
            this.btnActualizarCliente.UseVisualStyleBackColor = false;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.BackColor = System.Drawing.Color.Red;
            this.btnBorrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarCliente.FlatAppearance.BorderSize = 2;
            this.btnBorrarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarCliente.Location = new System.Drawing.Point(664, 429);
            this.btnBorrarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(95, 33);
            this.btnBorrarCliente.TabIndex = 248;
            this.btnBorrarCliente.Text = "Borrar";
            this.btnBorrarCliente.UseVisualStyleBackColor = false;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCrearCliente.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrearCliente.FlatAppearance.BorderSize = 2;
            this.btnCrearCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCrearCliente.Location = new System.Drawing.Point(350, 429);
            this.btnCrearCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(96, 33);
            this.btnCrearCliente.TabIndex = 226;
            this.btnCrearCliente.Text = "Crear";
            this.btnCrearCliente.UseVisualStyleBackColor = false;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 277;
            this.label4.Text = "DUI";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(139, 232);
            this.txtNit.Margin = new System.Windows.Forms.Padding(2);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(149, 20);
            this.txtNit.TabIndex = 276;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(35, 232);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 275;
            this.label21.Text = "NIT";
            // 
            // txtDuiCliente
            // 
            this.txtDuiCliente.Location = new System.Drawing.Point(139, 195);
            this.txtDuiCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuiCliente.Name = "txtDuiCliente";
            this.txtDuiCliente.Size = new System.Drawing.Size(149, 20);
            this.txtDuiCliente.TabIndex = 274;
            // 
            // txtTelefTrabajoCliente
            // 
            this.txtTelefTrabajoCliente.Location = new System.Drawing.Point(466, 198);
            this.txtTelefTrabajoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefTrabajoCliente.Name = "txtTelefTrabajoCliente";
            this.txtTelefTrabajoCliente.Size = new System.Drawing.Size(149, 20);
            this.txtTelefTrabajoCliente.TabIndex = 273;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 199);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 272;
            this.label13.Text = "Telefono Trabajo";
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Location = new System.Drawing.Point(467, 93);
            this.txtCelularCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.Size = new System.Drawing.Size(149, 20);
            this.txtCelularCliente.TabIndex = 271;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(324, 91);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 270;
            this.label14.Text = "Celular";
            // 
            // txtTrabajoCliente
            // 
            this.txtTrabajoCliente.Location = new System.Drawing.Point(466, 160);
            this.txtTrabajoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrabajoCliente.Name = "txtTrabajoCliente";
            this.txtTrabajoCliente.Size = new System.Drawing.Size(149, 20);
            this.txtTrabajoCliente.TabIndex = 269;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 268;
            this.label12.Text = "Lugar de trabajo";
            // 
            // cbEstadoCivilCliente
            // 
            this.cbEstadoCivilCliente.FormattingEnabled = true;
            this.cbEstadoCivilCliente.Items.AddRange(new object[] {
            "C",
            "S"});
            this.cbEstadoCivilCliente.Location = new System.Drawing.Point(139, 336);
            this.cbEstadoCivilCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstadoCivilCliente.Name = "cbEstadoCivilCliente";
            this.cbEstadoCivilCliente.Size = new System.Drawing.Size(56, 21);
            this.cbEstadoCivilCliente.TabIndex = 267;
            this.cbEstadoCivilCliente.SelectedIndexChanged += new System.EventHandler(this.cbEstadoCivilCliente_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 336);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 266;
            this.label10.Text = "Estado Civil";
            // 
            // cbSexoCliente
            // 
            this.cbSexoCliente.FormattingEnabled = true;
            this.cbSexoCliente.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexoCliente.Location = new System.Drawing.Point(139, 300);
            this.cbSexoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cbSexoCliente.Name = "cbSexoCliente";
            this.cbSexoCliente.Size = new System.Drawing.Size(56, 21);
            this.cbSexoCliente.TabIndex = 265;
            this.cbSexoCliente.SelectedIndexChanged += new System.EventHandler(this.cbSexoCliente_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 303);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 264;
            this.label9.Text = "Sexo";
            // 
            // txtFechaNacCliente
            // 
            this.txtFechaNacCliente.Location = new System.Drawing.Point(139, 163);
            this.txtFechaNacCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaNacCliente.Name = "txtFechaNacCliente";
            this.txtFechaNacCliente.Size = new System.Drawing.Size(151, 20);
            this.txtFechaNacCliente.TabIndex = 263;
            this.txtFechaNacCliente.Text = "         dd/mm/yyyy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 262;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // txtTelefonoCasaCliente
            // 
            this.txtTelefonoCasaCliente.Location = new System.Drawing.Point(141, 271);
            this.txtTelefonoCasaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoCasaCliente.Name = "txtTelefonoCasaCliente";
            this.txtTelefonoCasaCliente.Size = new System.Drawing.Size(147, 20);
            this.txtTelefonoCasaCliente.TabIndex = 261;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 260;
            this.label6.Text = "Telefono Casa";
            // 
            // txtDireccionCasaCliente
            // 
            this.txtDireccionCasaCliente.Location = new System.Drawing.Point(466, 130);
            this.txtDireccionCasaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionCasaCliente.Name = "txtDireccionCasaCliente";
            this.txtDireccionCasaCliente.Size = new System.Drawing.Size(149, 20);
            this.txtDireccionCasaCliente.TabIndex = 259;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 258;
            this.label5.Text = "Direccion Casa";
            // 
            // txtPrimerApellidoCliente
            // 
            this.txtPrimerApellidoCliente.Location = new System.Drawing.Point(139, 126);
            this.txtPrimerApellidoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimerApellidoCliente.Name = "txtPrimerApellidoCliente";
            this.txtPrimerApellidoCliente.Size = new System.Drawing.Size(149, 20);
            this.txtPrimerApellidoCliente.TabIndex = 257;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 256;
            this.label3.Text = "Primir Apellido";
            // 
            // txtPrimerNombreCliente
            // 
            this.txtPrimerNombreCliente.Location = new System.Drawing.Point(139, 90);
            this.txtPrimerNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimerNombreCliente.Name = "txtPrimerNombreCliente";
            this.txtPrimerNombreCliente.Size = new System.Drawing.Size(149, 20);
            this.txtPrimerNombreCliente.TabIndex = 255;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 254;
            this.label1.Text = "Primer Nombre";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 496);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtDuiCliente);
            this.Controls.Add(this.txtTelefTrabajoCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCelularCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTrabajoCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbEstadoCivilCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbSexoCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFechaNacCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefonoCasaCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccionCasaCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrimerApellidoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrimerNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.btnBorrarCliente);
            this.Controls.Add(this.btnCrearCliente);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Button btnActualizarCliente;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.Button btnCrearCliente;
        private repuestos3DataSet repuestos3DataSet;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private repuestos3DataSetTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIMERNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEGUNDONOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIMERAPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEGUNDOAPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHANACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOCIVILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUGARTRABAJODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDuiCliente;
        private System.Windows.Forms.TextBox txtTelefTrabajoCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCelularCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTrabajoCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbEstadoCivilCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSexoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFechaNacCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefonoCasaCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccionCasaCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrimerApellidoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimerNombreCliente;
        private System.Windows.Forms.Label label1;
    }
}