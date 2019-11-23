namespace PuntoDeVentas.Administrador
{
    partial class ParteVehiculo
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
            this.txtBuscarModelo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gridModelo = new System.Windows.Forms.DataGridView();
            this.txtParte = new System.Windows.Forms.Label();
            this.btnActualizarModelo = new System.Windows.Forms.Button();
            this.btnBorrarModelo = new System.Windows.Forms.Button();
            this.btnCrearModelo = new System.Windows.Forms.Button();
            this.repuestos3DataSet = new PuntoDeVentas.repuestos3DataSet();
            this.pARTESVEHICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARTESVEHICULOSTableAdapter = new PuntoDeVentas.repuestos3DataSetTableAdapters.PARTESVEHICULOSTableAdapter();
            this.iDPARTEVEHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombParte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTESVEHICULOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarModelo
            // 
            this.txtBuscarModelo.Location = new System.Drawing.Point(126, 107);
            this.txtBuscarModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarModelo.Name = "txtBuscarModelo";
            this.txtBuscarModelo.Size = new System.Drawing.Size(168, 20);
            this.txtBuscarModelo.TabIndex = 224;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 223;
            this.label9.Text = "Buscar";
            // 
            // gridModelo
            // 
            this.gridModelo.AutoGenerateColumns = false;
            this.gridModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPARTEVEHDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.gridModelo.DataSource = this.pARTESVEHICULOSBindingSource;
            this.gridModelo.Location = new System.Drawing.Point(336, 46);
            this.gridModelo.Name = "gridModelo";
            this.gridModelo.Size = new System.Drawing.Size(245, 158);
            this.gridModelo.TabIndex = 222;
            this.gridModelo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridModelo_CellMouseClick);
            this.gridModelo.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gridModelo_RowStateChanged);
            // 
            // txtParte
            // 
            this.txtParte.AutoSize = true;
            this.txtParte.Location = new System.Drawing.Point(32, 63);
            this.txtParte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtParte.Name = "txtParte";
            this.txtParte.Size = new System.Drawing.Size(91, 13);
            this.txtParte.TabIndex = 220;
            this.txtParte.Text = "Parte de Vehiculo";
            this.txtParte.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnActualizarModelo
            // 
            this.btnActualizarModelo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarModelo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnActualizarModelo.FlatAppearance.BorderSize = 2;
            this.btnActualizarModelo.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarModelo.Location = new System.Drawing.Point(288, 261);
            this.btnActualizarModelo.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarModelo.Name = "btnActualizarModelo";
            this.btnActualizarModelo.Size = new System.Drawing.Size(92, 33);
            this.btnActualizarModelo.TabIndex = 219;
            this.btnActualizarModelo.Text = "Actualizar";
            this.btnActualizarModelo.UseVisualStyleBackColor = false;
            this.btnActualizarModelo.Click += new System.EventHandler(this.btnActualizarModelo_Click);
            // 
            // btnBorrarModelo
            // 
            this.btnBorrarModelo.BackColor = System.Drawing.Color.Red;
            this.btnBorrarModelo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarModelo.FlatAppearance.BorderSize = 2;
            this.btnBorrarModelo.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarModelo.Location = new System.Drawing.Point(411, 261);
            this.btnBorrarModelo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarModelo.Name = "btnBorrarModelo";
            this.btnBorrarModelo.Size = new System.Drawing.Size(95, 33);
            this.btnBorrarModelo.TabIndex = 218;
            this.btnBorrarModelo.Text = "Borrar";
            this.btnBorrarModelo.UseVisualStyleBackColor = false;
            // 
            // btnCrearModelo
            // 
            this.btnCrearModelo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCrearModelo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrearModelo.FlatAppearance.BorderSize = 2;
            this.btnCrearModelo.ForeColor = System.Drawing.Color.Black;
            this.btnCrearModelo.Location = new System.Drawing.Point(150, 261);
            this.btnCrearModelo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearModelo.Name = "btnCrearModelo";
            this.btnCrearModelo.Size = new System.Drawing.Size(96, 33);
            this.btnCrearModelo.TabIndex = 216;
            this.btnCrearModelo.Text = "Crear";
            this.btnCrearModelo.UseVisualStyleBackColor = false;
            this.btnCrearModelo.Click += new System.EventHandler(this.btnCrearModelo_Click);
            // 
            // repuestos3DataSet
            // 
            this.repuestos3DataSet.DataSetName = "repuestos3DataSet";
            this.repuestos3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARTESVEHICULOSBindingSource
            // 
            this.pARTESVEHICULOSBindingSource.DataMember = "PARTESVEHICULOS";
            this.pARTESVEHICULOSBindingSource.DataSource = this.repuestos3DataSet;
            // 
            // pARTESVEHICULOSTableAdapter
            // 
            this.pARTESVEHICULOSTableAdapter.ClearBeforeFill = true;
            // 
            // iDPARTEVEHDataGridViewTextBoxColumn
            // 
            this.iDPARTEVEHDataGridViewTextBoxColumn.DataPropertyName = "ID_PARTEVEH";
            this.iDPARTEVEHDataGridViewTextBoxColumn.HeaderText = "ID_PARTEVEH";
            this.iDPARTEVEHDataGridViewTextBoxColumn.Name = "iDPARTEVEHDataGridViewTextBoxColumn";
            this.iDPARTEVEHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // txtNombParte
            // 
            this.txtNombParte.Location = new System.Drawing.Point(128, 60);
            this.txtNombParte.Name = "txtNombParte";
            this.txtNombParte.Size = new System.Drawing.Size(166, 20);
            this.txtNombParte.TabIndex = 225;
            // 
            // ParteVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 333);
            this.Controls.Add(this.txtNombParte);
            this.Controls.Add(this.txtBuscarModelo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridModelo);
            this.Controls.Add(this.txtParte);
            this.Controls.Add(this.btnActualizarModelo);
            this.Controls.Add(this.btnBorrarModelo);
            this.Controls.Add(this.btnCrearModelo);
            this.Name = "ParteVehiculo";
            this.Text = "ParteVehiculo";
            this.Load += new System.EventHandler(this.ParteVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTESVEHICULOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarModelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridModelo;
        private System.Windows.Forms.Label txtParte;
        private System.Windows.Forms.Button btnActualizarModelo;
        private System.Windows.Forms.Button btnBorrarModelo;
        private System.Windows.Forms.Button btnCrearModelo;
        private repuestos3DataSet repuestos3DataSet;
        private System.Windows.Forms.BindingSource pARTESVEHICULOSBindingSource;
        private repuestos3DataSetTableAdapters.PARTESVEHICULOSTableAdapter pARTESVEHICULOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPARTEVEHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNombParte;
    }
}