namespace AdminGoITApp
{
    partial class FormSearchReservetion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.бронювання_приміщенняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бронювання_приміщенняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Бронювання_приміщенняTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.бронювання_приміщенняDataGridView = new System.Windows.Forms.DataGridView();
            this.приміщенняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приміщенняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ПриміщенняTableAdapter();
            this.адміністраторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.адміністраторTableAdapter = new AdminGoITApp.myDataSetTableAdapters.АдміністраторTableAdapter();
            this.клієнтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клієнтTableAdapter = new AdminGoITApp.myDataSetTableAdapters.КлієнтTableAdapter();
            this.західBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.західTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ЗахідTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронювання_приміщенняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронювання_приміщенняDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приміщенняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.західBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук за датою запису бронювання";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(144, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Відмінити фільтрування";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Виконати фільтрування";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(291, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пошук бронювання за датою проведення заходу";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 70);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(144, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Відмінити фільтрування";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 47);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(144, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Виконати фільтрування";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бронювання_приміщенняBindingSource
            // 
            this.бронювання_приміщенняBindingSource.DataMember = "Бронювання_приміщення";
            this.бронювання_приміщенняBindingSource.DataSource = this.myDataSet;
            // 
            // бронювання_приміщенняTableAdapter
            // 
            this.бронювання_приміщенняTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AdminGoITApp.myDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдміністраторTableAdapter = null;
            this.tableAdapterManager.Бронювання_приміщенняTableAdapter = this.бронювання_приміщенняTableAdapter;
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
            // бронювання_приміщенняDataGridView
            // 
            this.бронювання_приміщенняDataGridView.AutoGenerateColumns = false;
            this.бронювання_приміщенняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.бронювання_приміщенняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.бронювання_приміщенняDataGridView.DataSource = this.бронювання_приміщенняBindingSource;
            this.бронювання_приміщенняDataGridView.Location = new System.Drawing.Point(0, 142);
            this.бронювання_приміщенняDataGridView.Name = "бронювання_приміщенняDataGridView";
            this.бронювання_приміщенняDataGridView.Size = new System.Drawing.Size(1043, 220);
            this.бронювання_приміщенняDataGridView.TabIndex = 3;
            // 
            // приміщенняBindingSource
            // 
            this.приміщенняBindingSource.DataMember = "Приміщення";
            this.приміщенняBindingSource.DataSource = this.myDataSet;
            // 
            // приміщенняTableAdapter
            // 
            this.приміщенняTableAdapter.ClearBeforeFill = true;
            // 
            // адміністраторBindingSource
            // 
            this.адміністраторBindingSource.DataMember = "Адміністратор";
            this.адміністраторBindingSource.DataSource = this.myDataSet;
            // 
            // адміністраторTableAdapter
            // 
            this.адміністраторTableAdapter.ClearBeforeFill = true;
            // 
            // клієнтBindingSource
            // 
            this.клієнтBindingSource.DataMember = "Клієнт";
            this.клієнтBindingSource.DataSource = this.myDataSet;
            // 
            // клієнтTableAdapter
            // 
            this.клієнтTableAdapter.ClearBeforeFill = true;
            // 
            // західBindingSource
            // 
            this.західBindingSource.DataMember = "Захід";
            this.західBindingSource.DataSource = this.myDataSet;
            // 
            // західTableAdapter
            // 
            this.західTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата_запису_бронювання";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата запису бронювання";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Кількість_людей";
            this.dataGridViewTextBoxColumn3.HeaderText = "Кількість людей";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_проведення_заходу";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата проведення заходу";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Час_початку";
            this.dataGridViewTextBoxColumn5.HeaderText = "Час початку";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Тривалість_годин";
            this.dataGridViewTextBoxColumn6.HeaderText = "Тривалість годин";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Коментар";
            this.dataGridViewTextBoxColumn7.HeaderText = "Коментар";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Код_приміщення";
            this.dataGridViewTextBoxColumn8.DataSource = this.приміщенняBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Номер";
            this.dataGridViewTextBoxColumn8.HeaderText = "Приміщення";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "Код_приміщення";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Код_адміністратора";
            this.dataGridViewTextBoxColumn9.DataSource = this.адміністраторBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "Прізвище";
            this.dataGridViewTextBoxColumn9.HeaderText = "Адміністратор";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "Код_адміністратора";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Код_клієнт";
            this.dataGridViewTextBoxColumn10.DataSource = this.клієнтBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "ПІБ";
            this.dataGridViewTextBoxColumn10.HeaderText = "Клієнт";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "Код_клієнт";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Код_заходу";
            this.dataGridViewTextBoxColumn11.DataSource = this.західBindingSource;
            this.dataGridViewTextBoxColumn11.DisplayMember = "Назва";
            this.dataGridViewTextBoxColumn11.HeaderText = "Захід";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn11.ValueMember = "Код_заходу";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1042, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FormSearchReservetion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1043, 364);
            this.Controls.Add(this.бронювання_приміщенняDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSearchReservetion";
            this.Text = "Пошук бронювання";
            this.Load += new System.EventHandler(this.FormSearchReservetion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронювання_приміщенняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронювання_приміщенняDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приміщенняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.західBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource бронювання_приміщенняBindingSource;
        private myDataSetTableAdapters.Бронювання_приміщенняTableAdapter бронювання_приміщенняTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView бронювання_приміщенняDataGridView;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource приміщенняBindingSource;
        private myDataSetTableAdapters.ПриміщенняTableAdapter приміщенняTableAdapter;
        private System.Windows.Forms.BindingSource адміністраторBindingSource;
        private myDataSetTableAdapters.АдміністраторTableAdapter адміністраторTableAdapter;
        private System.Windows.Forms.BindingSource клієнтBindingSource;
        private myDataSetTableAdapters.КлієнтTableAdapter клієнтTableAdapter;
        private System.Windows.Forms.BindingSource західBindingSource;
        private myDataSetTableAdapters.ЗахідTableAdapter західTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}