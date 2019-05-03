namespace GestorOrquidario.App
{
    partial class frmRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.rptMaster = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelatorioFloresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioFloresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptMaster
            // 
            this.rptMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsRelatorioFlores";
            reportDataSource1.Value = this.RelatorioFloresBindingSource;
            this.rptMaster.LocalReport.DataSources.Add(reportDataSource1);
            this.rptMaster.LocalReport.ReportEmbeddedResource = "GestorOrquidario.App.Relatorios.rptFlores.rdlc";
            this.rptMaster.Location = new System.Drawing.Point(0, 0);
            this.rptMaster.Name = "rptMaster";
            this.rptMaster.Size = new System.Drawing.Size(643, 441);
            this.rptMaster.TabIndex = 0;
            // 
            // RelatorioFloresBindingSource
            // 
            this.RelatorioFloresBindingSource.DataSource = typeof(GestorOrquidario.Entities.RelatorioFlores);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 441);
            this.Controls.Add(this.rptMaster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioFloresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptMaster;
        private System.Windows.Forms.BindingSource RelatorioFloresBindingSource;

    }
}