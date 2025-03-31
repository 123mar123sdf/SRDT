namespace Расписание_занятий
{
    partial class ОтчетПредметы
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
            this.Отчет_предметыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.РасписаниеDataSet = new Расписание_занятий.РасписаниеDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Отчет_предметыTableAdapter = new Расписание_занятий.РасписаниеDataSetTableAdapters.Отчет_предметыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_предметыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.РасписаниеDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Отчет_предметыBindingSource
            // 
            this.Отчет_предметыBindingSource.DataMember = "Отчет_предметы";
            this.Отчет_предметыBindingSource.DataSource = this.РасписаниеDataSet;
            // 
            // РасписаниеDataSet
            // 
            this.РасписаниеDataSet.DataSetName = "РасписаниеDataSet";
            this.РасписаниеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Отчет_предметыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Расписание_занятий.Отчет Объединения.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(198, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 505);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отчет_предметыTableAdapter
            // 
            this.Отчет_предметыTableAdapter.ClearBeforeFill = true;
            // 
            // ОтчетПредметы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ОтчетПредметы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объединения - Расписание занятий";
            this.Load += new System.EventHandler(this.ОтчетПредметы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_предметыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.РасписаниеDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отчет_предметыBindingSource;
        private РасписаниеDataSet РасписаниеDataSet;
        private РасписаниеDataSetTableAdapters.Отчет_предметыTableAdapter Отчет_предметыTableAdapter;
    }
}