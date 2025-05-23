namespace Projeto_Agenda_2025_1Sem.Formulários
{
    partial class frmVisualizaRelatorioPessoas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Agenda = new Projeto_Agenda_2025_1Sem.Dados.DataSet_Agenda();
            this.dataSetAgendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblPessoaTableAdapter = new Projeto_Agenda_2025_1Sem.Dados.DataSet_AgendaTableAdapters.tblPessoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAgendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tblPessoaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Agenda_2025_1Sem.Relatórios.Relaatorio_Pessoas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(934, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // dataSet_Agenda
            // 
            this.dataSet_Agenda.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetAgendaBindingSource
            // 
            this.dataSetAgendaBindingSource.DataSource = this.dataSet_Agenda;
            this.dataSetAgendaBindingSource.Position = 0;
            // 
            // tblPessoaBindingSource
            // 
            this.tblPessoaBindingSource.DataMember = "tblPessoa";
            this.tblPessoaBindingSource.DataSource = this.dataSet_Agenda;
            // 
            // tblPessoaBindingSource1
            // 
            this.tblPessoaBindingSource1.DataMember = "tblPessoa";
            this.tblPessoaBindingSource1.DataSource = this.dataSetAgendaBindingSource;
            // 
            // tblPessoaTableAdapter
            // 
            this.tblPessoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisualizaRelatorioPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVisualizaRelatorioPessoas";
            this.Text = "frmVisualizaRelatorioPessoas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVisualizaRelatorioPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAgendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetAgendaBindingSource;
        private Dados.DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource tblPessoaBindingSource;
        private System.Windows.Forms.BindingSource tblPessoaBindingSource1;
        private Dados.DataSet_AgendaTableAdapters.tblPessoaTableAdapter tblPessoaTableAdapter;
    }
}