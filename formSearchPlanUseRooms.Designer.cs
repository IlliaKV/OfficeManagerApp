namespace AdminGoITApp
{
    partial class formSearchPlanUseRooms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.графік_бронювань_приміщень_за_датоюDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.графік_бронювань_приміщень_за_датоюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.графік_бронювань_приміщень_за_датоюTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Графік_бронювань_приміщень_за_датоюTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.графік_бронювань_приміщень_за_датоюDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.графік_бронювань_приміщень_за_датоюBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Розклад використання обладнання та гарнітур за обраною датою";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // графік_бронювань_приміщень_за_датоюDataGridView
            // 
            this.графік_бронювань_приміщень_за_датоюDataGridView.AutoGenerateColumns = false;
            this.графік_бронювань_приміщень_за_датоюDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.графік_бронювань_приміщень_за_датоюDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.графік_бронювань_приміщень_за_датоюDataGridView.DataSource = this.графік_бронювань_приміщень_за_датоюBindingSource;
            this.графік_бронювань_приміщень_за_датоюDataGridView.Location = new System.Drawing.Point(12, 70);
            this.графік_бронювань_приміщень_за_датоюDataGridView.Name = "графік_бронювань_приміщень_за_датоюDataGridView";
            this.графік_бронювань_приміщень_за_датоюDataGridView.Size = new System.Drawing.Size(457, 193);
            this.графік_бронювань_приміщень_за_датоюDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn1.HeaderText = "Назва заходу";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер приміщення";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Час_початку";
            this.dataGridViewTextBoxColumn3.HeaderText = "Час початку заходу";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Тривалість_годин";
            this.dataGridViewTextBoxColumn4.HeaderText = "Тривалість годин";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // графік_бронювань_приміщень_за_датоюBindingSource
            // 
            this.графік_бронювань_приміщень_за_датоюBindingSource.DataMember = "Графік_бронювань_приміщень_за_датою";
            this.графік_бронювань_приміщень_за_датоюBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.графік_бронювань_приміщень_за_датоюBindingSource;
            this.chart1.Location = new System.Drawing.Point(12, 270);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Color = System.Drawing.Color.Transparent;
            series1.MarkerSize = 1;
            series1.Name = "s";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.MarkerSize = 1;
            series2.Name = "s2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(735, 344);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            title1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Графік приміщень";
            this.chart1.Titles.Add(title1);
            // 
            // графік_бронювань_приміщень_за_датоюTableAdapter
            // 
            this.графік_бронювань_приміщень_за_датоюTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = AdminGoITApp.myDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдміністраторTableAdapter = null;
            this.tableAdapterManager.Бронювання_приміщенняTableAdapter = null;
            this.tableAdapterManager.Використання_обладнання_ГарнітурTableAdapter = null;
            this.tableAdapterManager.Використання_обладнання_ОбладнанняTableAdapter = null;
            this.tableAdapterManager.Використання_обладнанняTableAdapter = null;
            this.tableAdapterManager.ГарнітурTableAdapter = null;
            this.tableAdapterManager.Графік_використання_аудиторійTableAdapter = null;
            this.tableAdapterManager.Графік_роботи_персоналуTableAdapter = null;
            this.tableAdapterManager.ЗахідTableAdapter = null;
            this.tableAdapterManager.КлієнтTableAdapter = null;
            this.tableAdapterManager.ОбладнанняTableAdapter = null;
            this.tableAdapterManager.ПідрядникTableAdapter = null;
            this.tableAdapterManager.ПриміщенняTableAdapter = null;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Фізична_особаTableAdapter = null;
            this.tableAdapterManager.Юридична_особаTableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 628);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 36);
            this.button2.TabIndex = 28;
            this.button2.Text = "Додати бронювання приміщення";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // formSearchPlanUseRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 626);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.графік_бронювань_приміщень_за_датоюDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formSearchPlanUseRooms";
            this.Text = "Розклад використання обладнання та гарнітур";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.графік_бронювань_приміщень_за_датоюDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.графік_бронювань_приміщень_за_датоюBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource графік_бронювань_приміщень_за_датоюBindingSource;
        private myDataSetTableAdapters.Графік_бронювань_приміщень_за_датоюTableAdapter графік_бронювань_приміщень_за_датоюTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView графік_бронювань_приміщень_за_датоюDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}