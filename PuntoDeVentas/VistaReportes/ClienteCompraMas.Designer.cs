namespace PuntoDeVentas.VistaReportes
{
    partial class ClienteCompraMas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_reporte_cliente_que_compra_masTableAdapter1 = new PuntoDeVentas.DataSets.ReportesDataSetTableAdapters.sp_reporte_cliente_que_compra_masTableAdapter();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PuntoDeVentas.reportes.ClienteCompraMas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(983, 676);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_reporte_cliente_que_compra_masTableAdapter1
            // 
            this.sp_reporte_cliente_que_compra_masTableAdapter1.ClearBeforeFill = true;
            // 
            // ClienteCompraMas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 676);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ClienteCompraMas";
            this.Text = "ClienteCompraMas";
            this.Load += new System.EventHandler(this.ClienteCompraMas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.ReportesDataSetTableAdapters.sp_reporte_cliente_que_compra_masTableAdapter sp_reporte_cliente_que_compra_masTableAdapter1;
    }
}