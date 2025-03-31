namespace Расписание_занятий
{
    partial class ОтчетГруппы
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
            this.Отчет_группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.РасписаниеDataSet = new Расписание_занятий.РасписаниеDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Отчет_группыTableAdapter = new Расписание_занятий.РасписаниеDataSetTableAdapters.Отчет_группыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.РасписаниеDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Отчет_группыBindingSource
            // 
            this.Отчет_группыBindingSource.DataMember = "Отчет_группы";
            this.Отчет_группыBindingSource.DataSource = this.РасписаниеDataSet;
            // 
            // РасписаниеDataSet
            // 
            this.РасписаниеDataSet.DataSetName = "РасписаниеDataSet";
            this.РасписаниеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Отчет_группыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Расписание_занятий.Отчет Группы.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(328, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(645, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отчет_группыTableAdapter
            // 
            this.Отчет_группыTableAdapter.ClearBeforeFill = true;
            // 
            // ОтчетГруппы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ОтчетГруппы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группы - Расписание занятий";
            this.Load += new System.EventHandler(this.ОтчетГруппы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.РасписаниеDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отчет_группыBindingSource;
        private РасписаниеDataSet РасписаниеDataSet;
        private РасписаниеDataSetTableAdapters.Отчет_группыTableAdapter Отчет_группыTableAdapter;
    }
}