namespace AdminGoITApp
{
    partial class formSearchPlanUseEquipOnDate
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
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.розклад_викор_облBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.розклад_викор_облTableAdapter = new AdminGoITApp.myDataSetTableAdapters.розклад_викор_облTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.розклад_викор_облDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.розклад_викор_гарнBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.розклад_викор_гарнTableAdapter = new AdminGoITApp.myDataSetTableAdapters.розклад_викор_гарнTableAdapter();
            this.розклад_викор_гарнDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_викор_облBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_викор_облDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_викор_гарнBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_викор_гарнDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // розклад_викор_облBindingSource
            // 
            this.розклад_викор_облBindingSource.DataMember = "розклад_викор_обл";
            this.розклад_викор_облBindingSource.DataSource = this.myDataSet;
            // 
            // розклад_викор_облTableAdapter
            // 
            this.розклад_викор_облTableAdapter.ClearBeforeFill = true;
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
            // розклад_викор_облDataGridView
            // 
            this.розклад_викор_облDataGridView.AutoGenerateColumns = false;
            this.розклад_викор_облDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.розклад_викор_облDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.розклад_викор_облDataGridView.DataSource = this.розклад_викор_облBindingSource;
            this.розклад_викор_облDataGridView.Location = new System.Drawing.Point(9, 66);
            this.розклад_викор_облDataGridView.Name = "розклад_викор_облDataGridView";
            this.розклад_викор_облDataGridView.Size = new System.Drawing.Size(665, 280);
            this.розклад_викор_облDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Час_початку";
            this.dataGridViewTextBoxColumn1.HeaderText = "Години, на коли зарезервовано";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тривалість_годин";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тривалість годин";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn3.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Тип";
            this.dataGridViewTextBoxColumn5.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Операційна_система";
            this.dataGridViewTextBoxColumn6.HeaderText = "Операційна система";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 52);
            this.groupBox1.TabIndex = 3;
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
            // розклад_викор_гарнBindingSource
            // 
            this.розклад_викор_гарнBindingSource.DataMember = "розклад_викор_гарн";
            this.розклад_викор_гарнBindingSource.DataSource = this.myDataSet;
            // 
            // розклад_викор_гарнTableAdapter
            // 
            this.розклад_викор_гарнTableAdapter.ClearBeforeFill = true;
            // 
            // розклад_викор_гарнDataGridView
            // 
            this.розклад_викор_гарнDataGridView.AutoGenerateColumns = false;
            this.розклад_викор_гарнDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.розклад_викор_гарнDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.розклад_викор_гарнDataGridView.DataSource = this.розклад_викор_гарнBindingSource;
            this.розклад_викор_гарнDataGridView.Location = new System.Drawing.Point(9, 352);
            this.розклад_викор_гарнDataGridView.Name = "розклад_викор_гарнDataGridView";
            this.розклад_викор_гарнDataGridView.Size = new System.Drawing.Size(547, 280);
            this.розклад_викор_гарнDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Час_початку";
            this.dataGridViewTextBoxColumn7.HeaderText = "Години, на коли зарезервовано";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Тривалість_годин";
            this.dataGridViewTextBoxColumn8.HeaderText = "Тривалість годин";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn9.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn10.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Колір";
            this.dataGridViewTextBoxColumn11.HeaderText = "Колір";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 643);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // formSearchPlanUseEquipOnDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(681, 638);
            this.Controls.Add(this.розклад_викор_гарнDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.розклад_викор_облDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formSearchPlanUseEquipOnDate";
            this.Text = "Розклад використання обладнання та гарнітур";
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_викор_облBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_викор_облDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.розклад_викор_гарнBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_викор_гарнDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource розклад_викор_облBindingSource;
        private myDataSetTableAdapters.розклад_викор_облTableAdapter розклад_викор_облTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView розклад_викор_облDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource розклад_викор_гарнBindingSource;
        private myDataSetTableAdapters.розклад_викор_гарнTableAdapter розклад_викор_гарнTableAdapter;
        private System.Windows.Forms.DataGridView розклад_викор_гарнDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}