namespace PodrozeSluzbowe
{
    partial class FormRaport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaport));
            this.ViewerRaportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PodrozeDataSet = new PodrozeSluzbowe.PodrozeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDO = new System.Windows.Forms.TextBox();
            this.textBoxOD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BusinessTripsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BusinessTripsTableAdapter = new PodrozeSluzbowe.PodrozeDataSetTableAdapters.BusinessTripsTableAdapter();
            this.ViewerRaportTableAdapter = new PodrozeSluzbowe.PodrozeDataSetTableAdapters.ViewerRaportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewerRaportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PodrozeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessTripsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewerRaportBindingSource
            // 
            this.ViewerRaportBindingSource.DataMember = "ViewerRaport";
            this.ViewerRaportBindingSource.DataSource = this.PodrozeDataSet;
            // 
            // PodrozeDataSet
            // 
            this.PodrozeDataSet.DataSetName = "PodrozeDataSet";
            this.PodrozeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.ViewerRaportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PodrozeSluzbowe.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(833, 324);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDO);
            this.groupBox1.Controls.Add(this.textBoxOD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje filtrowania";
            // 
            // textBoxDO
            // 
            this.textBoxDO.Location = new System.Drawing.Point(292, 23);
            this.textBoxDO.Name = "textBoxDO";
            this.textBoxDO.Size = new System.Drawing.Size(100, 20);
            this.textBoxDO.TabIndex = 4;
            this.textBoxDO.Click += new System.EventHandler(this.textBoxDO_Click_1);
            // 
            // textBoxOD
            // 
            this.textBoxOD.Location = new System.Drawing.Point(103, 23);
            this.textBoxOD.Name = "textBoxOD";
            this.textBoxOD.Size = new System.Drawing.Size(100, 20);
            this.textBoxOD.TabIndex = 3;
            this.textBoxOD.Click += new System.EventHandler(this.textBoxOD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "data do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data od";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(714, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Filtruj";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BusinessTripsBindingSource
            // 
            this.BusinessTripsBindingSource.DataMember = "BusinessTrips";
            this.BusinessTripsBindingSource.DataSource = this.PodrozeDataSet;
            // 
            // BusinessTripsTableAdapter
            // 
            this.BusinessTripsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewerRaportTableAdapter
            // 
            this.ViewerRaportTableAdapter.ClearBeforeFill = true;
            // 
            // FormRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRaport";
            this.Text = "Raport";
            this.Load += new System.EventHandler(this.FormRaport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewerRaportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PodrozeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessTripsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource BusinessTripsBindingSource;
        private PodrozeDataSet PodrozeDataSet;
        private PodrozeDataSetTableAdapters.BusinessTripsTableAdapter BusinessTripsTableAdapter;
        private System.Windows.Forms.TextBox textBoxDO;
        private System.Windows.Forms.TextBox textBoxOD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ViewerRaportBindingSource;
        private PodrozeDataSetTableAdapters.ViewerRaportTableAdapter ViewerRaportTableAdapter;
    }
}