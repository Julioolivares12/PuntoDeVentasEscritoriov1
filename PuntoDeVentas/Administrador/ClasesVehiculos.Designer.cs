namespace PuntoDeVentas.Administrador
{
    partial class ClasesVehiculos
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
            this.txtBuscarClaseVehi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gridClaseVehi = new System.Windows.Forms.DataGridView();
            this.iDCLASESVEHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASESVEHICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repuestos3DataSet = new PuntoDeVentas.repuestos3DataSet();
            this.txtNombClaseVehi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarClaseVehi = new System.Windows.Forms.Button();
            this.btnBorrarClaseVehi = new System.Windows.Forms.Button();
            this.btnCrearClaseVehi = new System.Windows.Forms.Button();
            this.cLASESVEHICULOSTableAdapter = new PuntoDeVentas.repuestos3DataSetTableAdapters.CLASESVEHICULOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridClaseVehi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASESVEHICULOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarClaseVehi
            // 
            this.txtBuscarClaseVehi.Location = new System.Drawing.Point(165, 151);
            this.txtBuscarClaseVehi.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarClaseVehi.Name = "txtBuscarClaseVehi";
            this.txtBuscarClaseVehi.Size = new System.Drawing.Size(166, 20);
            this.txtBuscarClaseVehi.TabIndex = 228;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 227;
            this.label9.Text = "Buscar";
            // 
            // gridClaseVehi
            // 
            this.gridClaseVehi.AutoGenerateColumns = false;
            this.gridClaseVehi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClaseVehi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLASESVEHDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.gridClaseVehi.DataSource = this.cLASESVEHICULOSBindingSource;
            this.gridClaseVehi.Location = new System.Drawing.Point(383, 83);
            this.gridClaseVehi.Name = "gridClaseVehi";
            this.gridClaseVehi.Size = new System.Drawing.Size(260, 162);
            this.gridClaseVehi.TabIndex = 226;
            this.gridClaseVehi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridClaseVehi_CellMouseClick);
            this.gridClaseVehi.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gridClaseVehi_RowStateChanged);
            // 
            // iDCLASESVEHDataGridViewTextBoxColumn
            // 
            this.iDCLASESVEHDataGridViewTextBoxColumn.DataPropertyName = "ID_CLASESVEH";
            this.iDCLASESVEHDataGridViewTextBoxColumn.HeaderText = "ID_CLASESVEH";
            this.iDCLASESVEHDataGridViewTextBoxColumn.Name = "iDCLASESVEHDataGridViewTextBoxColumn";
            this.iDCLASESVEHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // cLASESVEHICULOSBindingSource
            // 
            this.cLASESVEHICULOSBindingSource.DataMember = "CLASESVEHICULOS";
            this.cLASESVEHICULOSBindingSource.DataSource = this.repuestos3DataSet;
            // 
            // repuestos3DataSet
            // 
            this.repuestos3DataSet.DataSetName = "repuestos3DataSet";
            this.repuestos3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombClaseVehi
            // 
            this.txtNombClaseVehi.Location = new System.Drawing.Point(174, 94);
            this.txtNombClaseVehi.Name = "txtNombClaseVehi";
            this.txtNombClaseVehi.Size = new System.Drawing.Size(157, 20);
            this.txtNombClaseVehi.TabIndex = 225;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 224;
            this.label2.Text = "Clase Vehiculo";
            // 
            // btnActualizarClaseVehi
            // 
            this.btnActualizarClaseVehi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarClaseVehi.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnActualizarClaseVehi.FlatAppearance.BorderSize = 2;
            this.btnActualizarClaseVehi.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarClaseVehi.Location = new System.Drawing.Point(313, 317);
            this.btnActualizarClaseVehi.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarClaseVehi.Name = "btnActualizarClaseVehi";
            this.btnActualizarClaseVehi.Size = new System.Drawing.Size(92, 33);
            this.btnActualizarClaseVehi.TabIndex = 223;
            this.btnActualizarClaseVehi.Text = "Actualizar";
            this.btnActualizarClaseVehi.UseVisualStyleBackColor = false;
            this.btnActualizarClaseVehi.Click += new System.EventHandler(this.btnActualizarClaseVehi_Click);
            // 
            // btnBorrarClaseVehi
            // 
            this.btnBorrarClaseVehi.BackColor = System.Drawing.Color.Red;
            this.btnBorrarClaseVehi.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarClaseVehi.FlatAppearance.BorderSize = 2;
            this.btnBorrarClaseVehi.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarClaseVehi.Location = new System.Drawing.Point(439, 317);
            this.btnBorrarClaseVehi.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarClaseVehi.Name = "btnBorrarClaseVehi";
            this.btnBorrarClaseVehi.Size = new System.Drawing.Size(95, 33);
            this.btnBorrarClaseVehi.TabIndex = 222;
            this.btnBorrarClaseVehi.Text = "Borrar";
            this.btnBorrarClaseVehi.UseVisualStyleBackColor = false;
            // 
            // btnCrearClaseVehi
            // 
            this.btnCrearClaseVehi.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCrearClaseVehi.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrearClaseVehi.FlatAppearance.BorderSize = 2;
            this.btnCrearClaseVehi.ForeColor = System.Drawing.Color.Black;
            this.btnCrearClaseVehi.Location = new System.Drawing.Point(174, 317);
            this.btnCrearClaseVehi.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearClaseVehi.Name = "btnCrearClaseVehi";
            this.btnCrearClaseVehi.Size = new System.Drawing.Size(96, 33);
            this.btnCrearClaseVehi.TabIndex = 220;
            this.btnCrearClaseVehi.Text = "Crear";
            this.btnCrearClaseVehi.UseVisualStyleBackColor = false;
            this.btnCrearClaseVehi.Click += new System.EventHandler(this.btnCrearClaseVehi_Click);
            // 
            // cLASESVEHICULOSTableAdapter
            // 
            this.cLASESVEHICULOSTableAdapter.ClearBeforeFill = true;
            // 
            // ClasesVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 405);
            this.Controls.Add(this.txtBuscarClaseVehi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridClaseVehi);
            this.Controls.Add(this.txtNombClaseVehi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizarClaseVehi);
            this.Controls.Add(this.btnBorrarClaseVehi);
            this.Controls.Add(this.btnCrearClaseVehi);
            this.Name = "ClasesVehiculos";
            this.Text = "ClasesVehiculos";
            this.Load += new System.EventHandler(this.ClasesVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClaseVehi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASESVEHICULOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarClaseVehi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridClaseVehi;
        private System.Windows.Forms.TextBox txtNombClaseVehi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizarClaseVehi;
        private System.Windows.Forms.Button btnBorrarClaseVehi;
        private System.Windows.Forms.Button btnCrearClaseVehi;
        private repuestos3DataSet repuestos3DataSet;
        private System.Windows.Forms.BindingSource cLASESVEHICULOSBindingSource;
        private repuestos3DataSetTableAdapters.CLASESVEHICULOSTableAdapter cLASESVEHICULOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLASESVEHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
    }
}