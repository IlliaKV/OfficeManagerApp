namespace AdminGoITApp
{
    partial class formReportUseFurniture
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
            this.Звіт_обраних_гарнітур_за_датоюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Звіт_обраних_гарнітур_за_датоюTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Звіт_обраних_гарнітур_за_датоюTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Звіт_обраних_гарнітур_за_датоюBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Звіт_обраних_гарнітур_за_датоюBindingSource
            // 
            this.Звіт_обраних_гарнітур_за_датоюBindingSource.DataMember = "Звіт_обраних_гарнітур_за_датою";
            this.Звіт_обраних_гарнітур_за_датоюBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Звіт_обраних_гарнітур_за_датоюBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AdminGoITApp.ReportUseFurniture.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(776, 477);
            this.reportViewer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(2, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оберіть від якої дати по яку";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(229, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Звіт_обраних_гарнітур_за_датоюTableAdapter
            // 
            this.Звіт_обраних_гарнітур_за_датоюTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // formReportUseFurniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 545);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formReportUseFurniture";
            this.Text = "Створення звіту по обраних гарнітур";
            this.Load += new System.EventHandler(this.formReportUseFurniture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Звіт_обраних_гарнітур_за_датоюBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource Звіт_обраних_гарнітур_за_датоюBindingSource;
        private myDataSet myDataSet;
        private myDataSetTableAdapters.Звіт_обраних_гарнітур_за_датоюTableAdapter Звіт_обраних_гарнітур_за_датоюTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}