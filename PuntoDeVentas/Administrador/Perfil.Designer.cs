namespace PuntoDeVentas.Administrador
{
    partial class Perfil
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
            this.txtBuscarPerfil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gridPerfil = new System.Windows.Forms.DataGridView();
            this.btnActualizarPerfil = new System.Windows.Forms.Button();
            this.btnBorrarPerfil = new System.Windows.Forms.Button();
            this.btnCrearPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripPerfil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombPerfil = new System.Windows.Forms.TextBox();
            this.repuestos3DataSet = new PuntoDeVentas.repuestos3DataSet();
            this.pERFILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERFILTableAdapter = new PuntoDeVentas.repuestos3DataSetTableAdapters.PERFILTableAdapter();
            this.iDPERFILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarPerfil
            // 
            this.txtBuscarPerfil.Location = new System.Drawing.Point(479, 55);
            this.txtBuscarPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarPerfil.Name = "txtBuscarPerfil";
            this.txtBuscarPerfil.Size = new System.Drawing.Size(180, 20);
            this.txtBuscarPerfil.TabIndex = 238;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 237;
            this.label9.Text = "Buscar";
            // 
            // gridPerfil
            // 
            this.gridPerfil.AutoGenerateColumns = false;
            this.gridPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPERFILDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.gridPerfil.DataSource = this.pERFILBindingSource;
            this.gridPerfil.Location = new System.Drawing.Point(330, 97);
            this.gridPerfil.Name = "gridPerfil";
            this.gridPerfil.Size = new System.Drawing.Size(372, 150);
            this.gridPerfil.TabIndex = 236;
            this.gridPerfil.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPerfil_CellMouseClick);
            this.gridPerfil.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gridPerfil_RowStateChanged);
            // 
            // btnActualizarPerfil
            // 
            this.btnActualizarPerfil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarPerfil.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnActualizarPerfil.FlatAppearance.BorderSize = 2;
            this.btnActualizarPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarPerfil.Location = new System.Drawing.Point(286, 292);
            this.btnActualizarPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarPerfil.Name = "btnActualizarPerfil";
            this.btnActualizarPerfil.Size = new System.Drawing.Size(92, 33);
            this.btnActualizarPerfil.TabIndex = 232;
            this.btnActualizarPerfil.Text = "Actualizar";
            this.btnActualizarPerfil.UseVisualStyleBackColor = false;
            this.btnActualizarPerfil.Click += new System.EventHandler(this.btnActualizarPerfil_Click);
            // 
            // btnBorrarPerfil
            // 
            this.btnBorrarPerfil.BackColor = System.Drawing.Color.Red;
            this.btnBorrarPerfil.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarPerfil.FlatAppearance.BorderSize = 2;
            this.btnBorrarPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarPerfil.Location = new System.Drawing.Point(447, 292);
            this.btnBorrarPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarPerfil.Name = "btnBorrarPerfil";
            this.btnBorrarPerfil.Size = new System.Drawing.Size(95, 33);
            this.btnBorrarPerfil.TabIndex = 231;
            this.btnBorrarPerfil.Text = "Borrar";
            this.btnBorrarPerfil.UseVisualStyleBackColor = false;
            // 
            // btnCrearPerfil
            // 
            this.btnCrearPerfil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCrearPerfil.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrearPerfil.FlatAppearance.BorderSize = 2;
            this.btnCrearPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnCrearPerfil.Location = new System.Drawing.Point(133, 292);
            this.btnCrearPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearPerfil.Name = "btnCrearPerfil";
            this.btnCrearPerfil.Size = new System.Drawing.Size(96, 33);
            this.btnCrearPerfil.TabIndex = 229;
            this.btnCrearPerfil.Text = "Crear";
            this.btnCrearPerfil.UseVisualStyleBackColor = false;
            this.btnCrearPerfil.Click += new System.EventHandler(this.btnCrearPerfil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 243;
            this.label1.Text = "Nombre Perfil";
            // 
            // txtDescripPerfil
            // 
            this.txtDescripPerfil.Location = new System.Drawing.Point(116, 110);
            this.txtDescripPerfil.Name = "txtDescripPerfil";
            this.txtDescripPerfil.Size = new System.Drawing.Size(150, 20);
            this.txtDescripPerfil.TabIndex = 242;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 241;
            this.label3.Text = "Descripcion";
            // 
            // txtNombPerfil
            // 
            this.txtNombPerfil.Location = new System.Drawing.Point(116, 58);
            this.txtNombPerfil.Name = "txtNombPerfil";
            this.txtNombPerfil.Size = new System.Drawing.Size(150, 20);
            this.txtNombPerfil.TabIndex = 240;
            // 
            // repuestos3DataSet
            // 
            this.repuestos3DataSet.DataSetName = "repuestos3DataSet";
            this.repuestos3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERFILBindingSource
            // 
            this.pERFILBindingSource.DataMember = "PERFIL";
            this.pERFILBindingSource.DataSource = this.repuestos3DataSet;
            // 
            // pERFILTableAdapter
            // 
            this.pERFILTableAdapter.ClearBeforeFill = true;
            // 
            // iDPERFILDataGridViewTextBoxColumn
            // 
            this.iDPERFILDataGridViewTextBoxColumn.DataPropertyName = "ID_PERFIL";
            this.iDPERFILDataGridViewTextBoxColumn.HeaderText = "ID_PERFIL";
            this.iDPERFILDataGridViewTextBoxColumn.Name = "iDPERFILDataGridViewTextBoxColumn";
            this.iDPERFILDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripPerfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombPerfil);
            this.Controls.Add(this.txtBuscarPerfil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridPerfil);
            this.Controls.Add(this.btnActualizarPerfil);
            this.Controls.Add(this.btnBorrarPerfil);
            this.Controls.Add(this.btnCrearPerfil);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestos3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFILBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarPerfil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridPerfil;
        private System.Windows.Forms.Button btnActualizarPerfil;
        private System.Windows.Forms.Button btnBorrarPerfil;
        private System.Windows.Forms.Button btnCrearPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripPerfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombPerfil;
        private repuestos3DataSet repuestos3DataSet;
        private System.Windows.Forms.BindingSource pERFILBindingSource;
        private repuestos3DataSetTableAdapters.PERFILTableAdapter pERFILTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPERFILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
    }
}