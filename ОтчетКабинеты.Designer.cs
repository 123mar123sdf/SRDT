namespace Расписание_занятий
{
    partial class ОтчетКабинеты
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
            this.Отчет_кабинетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.РасписаниеDataSet = new Расписание_занятий.РасписаниеDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Отчет_кабинетыTableAdapter = new Расписание_занятий.РасписаниеDataSetTableAdapters.Отчет_кабинетыTableAdapter();
            this.Отчет_группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Отчет_группыTableAdapter = new Расписание_занятий.РасписаниеDataSetTableAdapters.Отчет_группыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_кабинетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.РасписаниеDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_группыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Отчет_кабинетыBindingSource
            // 
            this.Отчет_кабинетыBindingSource.DataMember = "Отчет_кабинеты";
            this.Отчет_кабинетыBindingSource.DataSource = this.РасписаниеDataSet;
            // 
            // РасписаниеDataSet
            // 
            this.РасписаниеDataSet.DataSetName = "РасписаниеDataSet";
            this.РасписаниеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Отчет_кабинетыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Расписание_занятий.Отчет Кабинеты.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(354, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(666, 553);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отчет_кабинетыTableAdapter
            // 
            this.Отчет_кабинетыTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет_группыBindingSource
            // 
            this.Отчет_группыBindingSource.DataMember = "Отчет_группы";
            this.Отчет_группыBindingSource.DataSource = this.РасписаниеDataSet;
            // 
            // Отчет_группыTableAdapter
            // 
            this.Отчет_группыTableAdapter.ClearBeforeFill = true;
            // 
            // ОтчетКабинеты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ОтчетКабинеты";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кабинеты - Расписание занятий";
            this.Load += new System.EventHandler(this.ОтчетКабинеты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_кабинетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.РасписаниеDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_группыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отчет_кабинетыBindingSource;
        private РасписаниеDataSet РасписаниеDataSet;
        private РасписаниеDataSetTableAdapters.Отчет_кабинетыTableAdapter Отчет_кабинетыTableAdapter;
        private System.Windows.Forms.BindingSource Отчет_группыBindingSource;
        private РасписаниеDataSetTableAdapters.Отчет_группыTableAdapter Отчет_группыTableAdapter;
    }
}