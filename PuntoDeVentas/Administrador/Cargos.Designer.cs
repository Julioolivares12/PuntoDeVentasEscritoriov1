namespace PuntoDeVentas.Administrador
{
    partial class Cargos
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
            this.txtBuscarCargo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gridCargo = new System.Windows.Forms.DataGridView();
            this.txtDescripCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarCargo = new System.Windows.Forms.Button();
            this.btnBorrarCargo = new System.Windows.Forms.Button();
            this.btnCrearCargo = new System.Windows.Forms.Button();
            this.repuestos3DataSet = new PuntoDeVentas.repuestos3DataSet();
            this.cARGOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARGOSTableAdapter = new PuntoDeVentas.repuestos3DataSetTableAdapters.CARGOSTableAdapter();
            this.iDCARGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCargo
            // 
            this.txtBuscarCargo.Location = new System.Drawing.Point(474, 67);
            this.txtBuscarCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCargo.Name = "txtBuscarCargo";
            this.txtBuscarCargo.Size = new System.Drawing.Size(180, 20);
            this.txtBuscarCargo.TabIndex = 206;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 205;
            this.label9.Text = "Buscar";
            // 
            // gridCargo
            // 
            this.gridCargo.AutoGenerateColumns = false;
            this.gridCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCARGODataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.gridCargo.DataSource = this.cARGOSBindingSource;
            this.gridCargo.Location = new System.Drawing.Point(399, 122);
            this.gridCargo.Name = "gridCargo";
            this.gridCargo.Size = new System.Drawing.Size(348, 144);
            this.gridCargo.TabIndex = 204;
            this.gridCargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCargo_CellContentClick);
            // 
            // txtDescripCargo
            // 
            this.txtDescripCargo.Location = new System.Drawing.Point(183, 119);
            this.txtDescripCargo.Name = "txtDescripCargo";
            this.txtDescripCargo.Size = new System.Drawing.Size(150, 20);
            this.txtDescripCargo.TabIndex = 203;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 202;
            this.label3.Text = "Descripcion";
            // 
            // txtNombCargo
            // 
            this.txtNombCargo.Location = new System.Drawing.Point(183, 67);
            this.txtNombCargo.Name = "txtNombCargo";
            this.txtNombCargo.Size = new System.Drawing.Size(150, 20);
            this.txtNombCargo.TabIndex = 201;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 200;
            this.label2.Text = "Nombre Cargo";
            // 
            // btnActualizarCargo
            // 
            this.btnActualizarCargo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarCargo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnActualizarCargo.FlatAppearance.BorderSize = 2;
            this.btnActualizarCargo.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarCargo.Location = new System.Drawing.Point(332, 313);
            this.btnActualizarCargo.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarCargo.Name = "btnActualizarCargo";
            this.btnActualizarCargo.Size = new System.Drawing.Size(92, 33);
            this.btnActualizarCargo.TabIndex = 199;
            this.btnActualizarCargo.Text = "Actualizar";
            this.btnActualizarCargo.UseVisualStyleBackColor = false;
            this.btnActualizarCargo.Click += new System.EventHandler(this.btnActualizarCargo_Click);
            // 
            // btnBorrarCargo
            // 
            this.btnBorrarCargo.BackColor = System.Drawing.Color.Red;
            this.btnBorrarCargo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarCargo.FlatAppearance.BorderSize = 2;
            this.btnBorrarCargo.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarCargo.Location = new System.Drawing.Point(493, 313);
            this.btnBorrarCargo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarCargo.Name = "btnBorrarCargo";
            this.btnBorrarCargo.Size = new System.Drawing.Size(95, 33);
            this.btnBorrarCargo.TabIndex = 198;
            this.btnBorrarCargo.Text = "Borrar";
            this.btnBorrarCargo.UseVisualStyleBackColor = false;
            this.btnBorrarCargo.Click += new System.EventHandler(this.btnBorrarCargo_Click);
            // 
            // btnCrearCargo
            // 
            this.btnCrearCargo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCrearCargo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrearCargo.FlatAppearance.BorderSize = 2;
            this.btnCrearCargo.ForeColor = System.Drawing.Color.Black;
            this.btnCrearCargo.Location = new System.Drawing.Point(179, 313);
            this.btnCrearCargo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearCargo.Name = "btnCrearCargo";
            this.btnCrearCargo.Size = new System.Drawing.Size(96, 33);
            this.btnCrearCargo.TabIndex = 196;
            this.btnCrearCargo.Text = "Crear";
            this.btnCrearCargo.UseVisualStyleBackColor = false;
            this.btnCrearCargo.Click += new System.EventHandler(this.btnCrearCargo_Click);
            // 
            // repuestos3DataSet
            // 
            this.repuestos3DataSet.DataSetName = "repuestos3DataSet";
            this.repuestos3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cARGOSBindingSource
            // 
            this.cARGOSBindingSource.DataMember = "CARGOS";
            this.cARGOSBindingSource.DataSource = this.repuestos3DataSet;
            // 
            // cARGOSTableAdapter
            // 
            this.cARGOSTableAdapter.ClearBeforeFill = true;
            // 
            // iDCARGODataGridViewTextBoxColumn
            // 
            this.iDCARGODataGridViewTextBoxColumn.DataPropertyName = "ID_CARGO";
            this.iDCARGODataGridViewTextBoxColumn.HeaderText = "ID_CARGO";
            this.iDCARGODataGridViewTextBoxColumn.Name = "iDCARGODataGridViewTextBoxColumn";
            this.iDCARGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // Cargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 376);
            this.Controls.Add(this.txtBuscarCargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridCargo);
            this.Controls.Add(this.txtDescripCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizarCargo);
            this.Controls.Add(this.btnBorrarCargo);
            this.Controls.Add(this.btnCrearCargo);
            this.Name = "Cargos";
            this.Text = "Cargos";
            this.Load += new System.EventHandler(this.Cargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridCargo;
        private System.Windows.Forms.TextBox txtDescripCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizarCargo;
        private System.Windows.Forms.Button btnBorrarCargo;
        private System.Windows.Forms.Button btnCrearCargo;
        private repuestos3DataSet repuestos3DataSet;
        private System.Windows.Forms.BindingSource cARGOSBindingSource;
        private repuestos3DataSetTableAdapters.CARGOSTableAdapter cARGOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCARGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
    }
}