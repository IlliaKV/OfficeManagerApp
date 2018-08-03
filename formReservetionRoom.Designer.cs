namespace AdminGoITApp
{
    partial class formReservetionRoom
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
            System.Windows.Forms.Label дата_запису_бронюванняLabel;
            System.Windows.Forms.Label кількість_людейLabel;
            System.Windows.Forms.Label дата_проведення_заходуLabel;
            System.Windows.Forms.Label час_початкуLabel;
            System.Windows.Forms.Label тривалість_годинLabel;
            System.Windows.Forms.Label коментарLabel;
            System.Windows.Forms.Label код_приміщенняLabel;
            System.Windows.Forms.Label код_адміністратораLabel;
            System.Windows.Forms.Label код_клієнтLabel;
            System.Windows.Forms.Label код_заходуLabel;
            System.Windows.Forms.Label код_обладнанняLabel;
            System.Windows.Forms.Label код_гарнітурLabel;
            System.Windows.Forms.Label кількість_обладнанняLabel;
            System.Windows.Forms.Label кількість_гарнітурLabel;
            System.Windows.Forms.Label коментарLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReservetionRoom));
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.бронювання_приміщенняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бронювання_приміщенняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Бронювання_приміщенняTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.адміністраторTableAdapter = new AdminGoITApp.myDataSetTableAdapters.АдміністраторTableAdapter();
            this.використання_обладнання_ГарнітурTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Використання_обладнання_ГарнітурTableAdapter();
            this.використання_обладнання_ОбладнанняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Використання_обладнання_ОбладнанняTableAdapter();
            this.використання_обладнанняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Використання_обладнанняTableAdapter();
            this.гарнітурTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ГарнітурTableAdapter();
            this.західTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ЗахідTableAdapter();
            this.клієнтTableAdapter = new AdminGoITApp.myDataSetTableAdapters.КлієнтTableAdapter();
            this.обладнанняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ОбладнанняTableAdapter();
            this.використання_обладнання_ГарнітурBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.використання_обладнанняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дата_запису_бронюванняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.кількість_людейTextBox = new System.Windows.Forms.TextBox();
            this.дата_проведення_заходуDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.час_початкуTextBox = new System.Windows.Forms.TextBox();
            this.тривалість_годинTextBox = new System.Windows.Forms.TextBox();
            this.коментарTextBox = new System.Windows.Forms.TextBox();
            this.код_приміщенняComboBox = new System.Windows.Forms.ComboBox();
            this.приміщенняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_адміністратораComboBox = new System.Windows.Forms.ComboBox();
            this.адміністраторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_клієнтComboBox = new System.Windows.Forms.ComboBox();
            this.клієнтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_заходуComboBox = new System.Windows.Forms.ComboBox();
            this.західBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.приміщенняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ПриміщенняTableAdapter();
            this.гарнітурBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.використання_обладнання_ОбладнанняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.обладнанняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.перегляд_обраного_гарнітурBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.перегляд_обраного_гарнітурTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Перегляд_обраного_гарнітурTableAdapter();
            this.перегляд_обраного_обладнанняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.перегляд_обраного_обладнанняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Перегляд_обраного_обладнанняTableAdapter();
            this.bindingNavigator6 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton27 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton28 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton29 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.перегляд_обраного_обладнанняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Операційна_система = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.перегляд_обраного_гарнітурDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.код_обладнанняComboBox = new System.Windows.Forms.ComboBox();
            this.код_гарнітурComboBox = new System.Windows.Forms.ComboBox();
            this.кількість_обладнанняTextBox = new System.Windows.Forms.TextBox();
            this.кількість_гарнітурTextBox = new System.Windows.Forms.TextBox();
            this.коментарTextBox1 = new System.Windows.Forms.TextBox();
            this.код_бронювання_приміщенняTextBox = new System.Windows.Forms.TextBox();
            this.підрахунок_кількість_гарнітурBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.підрахунок_кількість_гарнітурTableAdapter = new AdminGoITApp.myDataSetTableAdapters.підрахунок_кількість_гарнітурTableAdapter();
            this.підрахунок_кількість_обладнанняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.підрахунок_кількість_обладнанняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.підрахунок_кількість_обладнанняTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            дата_запису_бронюванняLabel = new System.Windows.Forms.Label();
            кількість_людейLabel = new System.Windows.Forms.Label();
            дата_проведення_заходуLabel = new System.Windows.Forms.Label();
            час_початкуLabel = new System.Windows.Forms.Label();
            тривалість_годинLabel = new System.Windows.Forms.Label();
            коментарLabel = new System.Windows.Forms.Label();
            код_приміщенняLabel = new System.Windows.Forms.Label();
            код_адміністратораLabel = new System.Windows.Forms.Label();
            код_клієнтLabel = new System.Windows.Forms.Label();
            код_заходуLabel = new System.Windows.Forms.Label();
            код_обладнанняLabel = new System.Windows.Forms.Label();
            код_гарнітурLabel = new System.Windows.Forms.Label();
            кількість_обладнанняLabel = new System.Windows.Forms.Label();
            кількість_гарнітурLabel = new System.Windows.Forms.Label();
            коментарLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронювання_приміщенняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.використання_обладнання_ГарнітурBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.використання_обладнанняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приміщенняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.західBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гарнітурBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.використання_обладнання_ОбладнанняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обладнанняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перегляд_обраного_гарнітурBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перегляд_обраного_обладнанняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).BeginInit();
            this.bindingNavigator6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.перегляд_обраного_обладнанняDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перегляд_обраного_гарнітурDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.підрахунок_кількість_гарнітурBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.підрахунок_кількість_обладнанняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // дата_запису_бронюванняLabel
            // 
            дата_запису_бронюванняLabel.AutoSize = true;
            дата_запису_бронюванняLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            дата_запису_бронюванняLabel.Location = new System.Drawing.Point(9, 45);
            дата_запису_бронюванняLabel.Name = "дата_запису_бронюванняLabel";
            дата_запису_бронюванняLabel.Size = new System.Drawing.Size(139, 13);
            дата_запису_бронюванняLabel.TabIndex = 3;
            дата_запису_бронюванняLabel.Text = "Дата запису бронювання:";
            // 
            // кількість_людейLabel
            // 
            кількість_людейLabel.AutoSize = true;
            кількість_людейLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            кількість_людейLabel.Location = new System.Drawing.Point(9, 70);
            кількість_людейLabel.Name = "кількість_людейLabel";
            кількість_людейLabel.Size = new System.Drawing.Size(91, 13);
            кількість_людейLabel.TabIndex = 5;
            кількість_людейLabel.Text = "Кількість людей:";
            // 
            // дата_проведення_заходуLabel
            // 
            дата_проведення_заходуLabel.AutoSize = true;
            дата_проведення_заходуLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            дата_проведення_заходуLabel.Location = new System.Drawing.Point(9, 97);
            дата_проведення_заходуLabel.Name = "дата_проведення_заходуLabel";
            дата_проведення_заходуLabel.Size = new System.Drawing.Size(136, 13);
            дата_проведення_заходуLabel.TabIndex = 7;
            дата_проведення_заходуLabel.Text = "Дата проведення заходу:";
            // 
            // час_початкуLabel
            // 
            час_початкуLabel.AutoSize = true;
            час_початкуLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            час_початкуLabel.Location = new System.Drawing.Point(9, 122);
            час_початкуLabel.Name = "час_початкуLabel";
            час_початкуLabel.Size = new System.Drawing.Size(72, 13);
            час_початкуLabel.TabIndex = 9;
            час_початкуLabel.Text = "Час початку:";
            // 
            // тривалість_годинLabel
            // 
            тривалість_годинLabel.AutoSize = true;
            тривалість_годинLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            тривалість_годинLabel.Location = new System.Drawing.Point(9, 148);
            тривалість_годинLabel.Name = "тривалість_годинLabel";
            тривалість_годинLabel.Size = new System.Drawing.Size(98, 13);
            тривалість_годинLabel.TabIndex = 11;
            тривалість_годинLabel.Text = "Тривалість годин:";
            // 
            // коментарLabel
            // 
            коментарLabel.AutoSize = true;
            коментарLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            коментарLabel.Location = new System.Drawing.Point(9, 199);
            коментарLabel.Name = "коментарLabel";
            коментарLabel.Size = new System.Drawing.Size(60, 13);
            коментарLabel.TabIndex = 13;
            коментарLabel.Text = "Коментар:";
            // 
            // код_приміщенняLabel
            // 
            код_приміщенняLabel.AutoSize = true;
            код_приміщенняLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            код_приміщенняLabel.Location = new System.Drawing.Point(9, 225);
            код_приміщенняLabel.Name = "код_приміщенняLabel";
            код_приміщенняLabel.Size = new System.Drawing.Size(73, 13);
            код_приміщенняLabel.TabIndex = 15;
            код_приміщенняLabel.Text = "Приміщення:";
            // 
            // код_адміністратораLabel
            // 
            код_адміністратораLabel.AutoSize = true;
            код_адміністратораLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            код_адміністратораLabel.Location = new System.Drawing.Point(9, 280);
            код_адміністратораLabel.Name = "код_адміністратораLabel";
            код_адміністратораLabel.Size = new System.Drawing.Size(81, 13);
            код_адміністратораLabel.TabIndex = 17;
            код_адміністратораLabel.Text = "Адміністратор:";
            // 
            // код_клієнтLabel
            // 
            код_клієнтLabel.AutoSize = true;
            код_клієнтLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            код_клієнтLabel.Location = new System.Drawing.Point(9, 334);
            код_клієнтLabel.Name = "код_клієнтLabel";
            код_клієнтLabel.Size = new System.Drawing.Size(42, 13);
            код_клієнтLabel.TabIndex = 19;
            код_клієнтLabel.Text = "Клієнт:";
            // 
            // код_заходуLabel
            // 
            код_заходуLabel.AutoSize = true;
            код_заходуLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            код_заходуLabel.Location = new System.Drawing.Point(9, 390);
            код_заходуLabel.Name = "код_заходуLabel";
            код_заходуLabel.Size = new System.Drawing.Size(36, 13);
            код_заходуLabel.TabIndex = 21;
            код_заходуLabel.Text = "Захід:";
            // 
            // код_обладнанняLabel
            // 
            код_обладнанняLabel.AutoSize = true;
            код_обладнанняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_обладнанняLabel.Location = new System.Drawing.Point(358, 211);
            код_обладнанняLabel.Name = "код_обладнанняLabel";
            код_обладнанняLabel.Size = new System.Drawing.Size(72, 13);
            код_обладнанняLabel.TabIndex = 60;
            код_обладнанняLabel.Text = "Обладнання:";
            // 
            // код_гарнітурLabel
            // 
            код_гарнітурLabel.AutoSize = true;
            код_гарнітурLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_гарнітурLabel.Location = new System.Drawing.Point(9, 211);
            код_гарнітурLabel.Name = "код_гарнітурLabel";
            код_гарнітурLabel.Size = new System.Drawing.Size(52, 13);
            код_гарнітурLabel.TabIndex = 58;
            код_гарнітурLabel.Text = "Гарнітур:";
            // 
            // кількість_обладнанняLabel
            // 
            кількість_обладнанняLabel.AutoSize = true;
            кількість_обладнанняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кількість_обладнанняLabel.Location = new System.Drawing.Point(14, 49);
            кількість_обладнанняLabel.Name = "кількість_обладнанняLabel";
            кількість_обладнанняLabel.Size = new System.Drawing.Size(119, 13);
            кількість_обладнанняLabel.TabIndex = 52;
            кількість_обладнанняLabel.Text = "Кількість обладнання:";
            // 
            // кількість_гарнітурLabel
            // 
            кількість_гарнітурLabel.AutoSize = true;
            кількість_гарнітурLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кількість_гарнітурLabel.Location = new System.Drawing.Point(14, 75);
            кількість_гарнітурLabel.Name = "кількість_гарнітурLabel";
            кількість_гарнітурLabel.Size = new System.Drawing.Size(100, 13);
            кількість_гарнітурLabel.TabIndex = 54;
            кількість_гарнітурLabel.Text = "Кількість гарнітур:";
            // 
            // коментарLabel1
            // 
            коментарLabel1.AutoSize = true;
            коментарLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            коментарLabel1.Location = new System.Drawing.Point(14, 101);
            коментарLabel1.Name = "коментарLabel1";
            коментарLabel1.Size = new System.Drawing.Size(60, 13);
            коментарLabel1.TabIndex = 56;
            коментарLabel1.Text = "Коментар:";
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
            this.tableAdapterManager.АдміністраторTableAdapter = this.адміністраторTableAdapter;
            this.tableAdapterManager.Бронювання_приміщенняTableAdapter = this.бронювання_приміщенняTableAdapter;
            this.tableAdapterManager.Використання_обладнання_ГарнітурTableAdapter = this.використання_обладнання_ГарнітурTableAdapter;
            this.tableAdapterManager.Використання_обладнання_ОбладнанняTableAdapter = this.використання_обладнання_ОбладнанняTableAdapter;
            this.tableAdapterManager.Використання_обладнанняTableAdapter = this.використання_обладнанняTableAdapter;
            this.tableAdapterManager.ГарнітурTableAdapter = this.гарнітурTableAdapter;
            this.tableAdapterManager.Графік_використання_аудиторійTableAdapter = null;
            this.tableAdapterManager.Графік_роботи_персоналуTableAdapter = null;
            this.tableAdapterManager.ЗахідTableAdapter = this.західTableAdapter;
            this.tableAdapterManager.КлієнтTableAdapter = this.клієнтTableAdapter;
            this.tableAdapterManager.ОбладнанняTableAdapter = this.обладнанняTableAdapter;
            this.tableAdapterManager.ПідрядникTableAdapter = null;
            this.tableAdapterManager.ПриміщенняTableAdapter = null;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Фізична_особаTableAdapter = null;
            this.tableAdapterManager.Юридична_особаTableAdapter = null;
            // 
            // адміністраторTableAdapter
            // 
            this.адміністраторTableAdapter.ClearBeforeFill = true;
            // 
            // використання_обладнання_ГарнітурTableAdapter
            // 
            this.використання_обладнання_ГарнітурTableAdapter.ClearBeforeFill = true;
            // 
            // використання_обладнання_ОбладнанняTableAdapter
            // 
            this.використання_обладнання_ОбладнанняTableAdapter.ClearBeforeFill = true;
            // 
            // використання_обладнанняTableAdapter
            // 
            this.використання_обладнанняTableAdapter.ClearBeforeFill = true;
            // 
            // гарнітурTableAdapter
            // 
            this.гарнітурTableAdapter.ClearBeforeFill = true;
            // 
            // західTableAdapter
            // 
            this.західTableAdapter.ClearBeforeFill = true;
            // 
            // клієнтTableAdapter
            // 
            this.клієнтTableAdapter.ClearBeforeFill = true;
            // 
            // обладнанняTableAdapter
            // 
            this.обладнанняTableAdapter.ClearBeforeFill = true;
            // 
            // використання_обладнання_ГарнітурBindingSource
            // 
            this.використання_обладнання_ГарнітурBindingSource.DataMember = "FK__Використа__Код_б__15502E78";
            this.використання_обладнання_ГарнітурBindingSource.DataSource = this.використання_обладнанняBindingSource;
            // 
            // використання_обладнанняBindingSource
            // 
            this.використання_обладнанняBindingSource.DataMember = "FK__Використа__Код_б__145C0A3F";
            this.використання_обладнанняBindingSource.DataSource = this.бронювання_приміщенняBindingSource;
            // 
            // дата_запису_бронюванняDateTimePicker
            // 
            this.дата_запису_бронюванняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.бронювання_приміщенняBindingSource, "Дата_запису_бронювання", true));
            this.дата_запису_бронюванняDateTimePicker.Location = new System.Drawing.Point(150, 41);
            this.дата_запису_бронюванняDateTimePicker.Name = "дата_запису_бронюванняDateTimePicker";
            this.дата_запису_бронюванняDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_запису_бронюванняDateTimePicker.TabIndex = 4;
            // 
            // кількість_людейTextBox
            // 
            this.кількість_людейTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.бронювання_приміщенняBindingSource, "Кількість_людей", true));
            this.кількість_людейTextBox.Location = new System.Drawing.Point(150, 67);
            this.кількість_людейTextBox.Name = "кількість_людейTextBox";
            this.кількість_людейTextBox.Size = new System.Drawing.Size(200, 20);
            this.кількість_людейTextBox.TabIndex = 6;
            // 
            // дата_проведення_заходуDateTimePicker
            // 
            this.дата_проведення_заходуDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.бронювання_приміщенняBindingSource, "Дата_проведення_заходу", true));
            this.дата_проведення_заходуDateTimePicker.Location = new System.Drawing.Point(150, 93);
            this.дата_проведення_заходуDateTimePicker.Name = "дата_проведення_заходуDateTimePicker";
            this.дата_проведення_заходуDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_проведення_заходуDateTimePicker.TabIndex = 8;
            // 
            // час_початкуTextBox
            // 
            this.час_початкуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.бронювання_приміщенняBindingSource, "Час_початку", true));
            this.час_початкуTextBox.Location = new System.Drawing.Point(150, 119);
            this.час_початкуTextBox.Name = "час_початкуTextBox";
            this.час_початкуTextBox.Size = new System.Drawing.Size(200, 20);
            this.час_початкуTextBox.TabIndex = 10;
            // 
            // тривалість_годинTextBox
            // 
            this.тривалість_годинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.бронювання_приміщенняBindingSource, "Тривалість_годин", true));
            this.тривалість_годинTextBox.Location = new System.Drawing.Point(150, 145);
            this.тривалість_годинTextBox.Name = "тривалість_годинTextBox";
            this.тривалість_годинTextBox.Size = new System.Drawing.Size(200, 20);
            this.тривалість_годинTextBox.TabIndex = 12;
            // 
            // коментарTextBox
            // 
            this.коментарTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.бронювання_приміщенняBindingSource, "Коментар", true));
            this.коментарTextBox.Location = new System.Drawing.Point(150, 196);
            this.коментарTextBox.Name = "коментарTextBox";
            this.коментарTextBox.Size = new System.Drawing.Size(200, 20);
            this.коментарTextBox.TabIndex = 14;
            // 
            // код_приміщенняComboBox
            // 
            this.код_приміщенняComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.бронювання_приміщенняBindingSource, "Код_приміщення", true));
            this.код_приміщенняComboBox.DataSource = this.приміщенняBindingSource;
            this.код_приміщенняComboBox.DisplayMember = "Номер";
            this.код_приміщенняComboBox.FormattingEnabled = true;
            this.код_приміщенняComboBox.Location = new System.Drawing.Point(150, 222);
            this.код_приміщенняComboBox.Name = "код_приміщенняComboBox";
            this.код_приміщенняComboBox.Size = new System.Drawing.Size(200, 21);
            this.код_приміщенняComboBox.TabIndex = 16;
            this.код_приміщенняComboBox.ValueMember = "Код_приміщення";
            // 
            // приміщенняBindingSource
            // 
            this.приміщенняBindingSource.DataMember = "Приміщення";
            this.приміщенняBindingSource.DataSource = this.myDataSet;
            // 
            // код_адміністратораComboBox
            // 
            this.код_адміністратораComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.бронювання_приміщенняBindingSource, "Код_адміністратора", true));
            this.код_адміністратораComboBox.DataSource = this.адміністраторBindingSource;
            this.код_адміністратораComboBox.DisplayMember = "Прізвище";
            this.код_адміністратораComboBox.FormattingEnabled = true;
            this.код_адміністратораComboBox.Location = new System.Drawing.Point(150, 277);
            this.код_адміністратораComboBox.Name = "код_адміністратораComboBox";
            this.код_адміністратораComboBox.Size = new System.Drawing.Size(200, 21);
            this.код_адміністратораComboBox.TabIndex = 18;
            this.код_адміністратораComboBox.ValueMember = "Код_адміністратора";
            // 
            // адміністраторBindingSource
            // 
            this.адміністраторBindingSource.DataMember = "Адміністратор";
            this.адміністраторBindingSource.DataSource = this.myDataSet;
            // 
            // код_клієнтComboBox
            // 
            this.код_клієнтComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.бронювання_приміщенняBindingSource, "Код_клієнт", true));
            this.код_клієнтComboBox.DataSource = this.клієнтBindingSource;
            this.код_клієнтComboBox.DisplayMember = "ПІБ";
            this.код_клієнтComboBox.FormattingEnabled = true;
            this.код_клієнтComboBox.Location = new System.Drawing.Point(150, 331);
            this.код_клієнтComboBox.Name = "код_клієнтComboBox";
            this.код_клієнтComboBox.Size = new System.Drawing.Size(200, 21);
            this.код_клієнтComboBox.TabIndex = 20;
            this.код_клієнтComboBox.ValueMember = "Код_клієнт";
            // 
            // клієнтBindingSource
            // 
            this.клієнтBindingSource.DataMember = "Клієнт";
            this.клієнтBindingSource.DataSource = this.myDataSet;
            // 
            // код_заходуComboBox
            // 
            this.код_заходуComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.бронювання_приміщенняBindingSource, "Код_заходу", true));
            this.код_заходуComboBox.DataSource = this.західBindingSource;
            this.код_заходуComboBox.DisplayMember = "Назва";
            this.код_заходуComboBox.FormattingEnabled = true;
            this.код_заходуComboBox.Location = new System.Drawing.Point(150, 387);
            this.код_заходуComboBox.Name = "код_заходуComboBox";
            this.код_заходуComboBox.Size = new System.Drawing.Size(200, 21);
            this.код_заходуComboBox.TabIndex = 22;
            this.код_заходуComboBox.ValueMember = "Код_заходу";
            // 
            // західBindingSource
            // 
            this.західBindingSource.DataMember = "Захід";
            this.західBindingSource.DataSource = this.myDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "+ приміщення";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "+ адміністратора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "+ захід";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(150, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "+ клієнта";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // приміщенняTableAdapter
            // 
            this.приміщенняTableAdapter.ClearBeforeFill = true;
            // 
            // гарнітурBindingSource
            // 
            this.гарнітурBindingSource.DataMember = "Гарнітур";
            this.гарнітурBindingSource.DataSource = this.myDataSet;
            // 
            // використання_обладнання_ОбладнанняBindingSource
            // 
            this.використання_обладнання_ОбладнанняBindingSource.DataMember = "FK__Використа__Код_б__173876EA";
            this.використання_обладнання_ОбладнанняBindingSource.DataSource = this.використання_обладнанняBindingSource;
            // 
            // обладнанняBindingSource
            // 
            this.обладнанняBindingSource.DataMember = "Обладнання";
            this.обладнанняBindingSource.DataSource = this.myDataSet;
            // 
            // перегляд_обраного_гарнітурBindingSource
            // 
            this.перегляд_обраного_гарнітурBindingSource.DataMember = "Перегляд_обраного_гарнітур";
            this.перегляд_обраного_гарнітурBindingSource.DataSource = this.myDataSet;
            // 
            // перегляд_обраного_гарнітурTableAdapter
            // 
            this.перегляд_обраного_гарнітурTableAdapter.ClearBeforeFill = true;
            // 
            // перегляд_обраного_обладнанняBindingSource
            // 
            this.перегляд_обраного_обладнанняBindingSource.DataMember = "Перегляд_обраного_обладнання";
            this.перегляд_обраного_обладнанняBindingSource.DataSource = this.myDataSet;
            // 
            // перегляд_обраного_обладнанняTableAdapter
            // 
            this.перегляд_обраного_обладнанняTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator6
            // 
            this.bindingNavigator6.AddNewItem = this.toolStripButton15;
            this.bindingNavigator6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator6.BindingSource = this.бронювання_приміщенняBindingSource;
            this.bindingNavigator6.CountItem = this.toolStripLabel4;
            this.bindingNavigator6.DeleteItem = this.toolStripButton16;
            this.bindingNavigator6.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton24,
            this.toolStripButton25,
            this.toolStripSeparator10,
            this.toolStripTextBox4,
            this.toolStripLabel4,
            this.toolStripSeparator11,
            this.toolStripButton26,
            this.toolStripButton27,
            this.toolStripSeparator12,
            this.toolStripButton15,
            this.toolStripButton16,
            this.toolStripButton28,
            this.toolStripButton29});
            this.bindingNavigator6.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator6.MoveFirstItem = this.toolStripButton24;
            this.bindingNavigator6.MoveLastItem = this.toolStripButton27;
            this.bindingNavigator6.MoveNextItem = this.toolStripButton26;
            this.bindingNavigator6.MovePreviousItem = this.toolStripButton25;
            this.bindingNavigator6.Name = "bindingNavigator6";
            this.bindingNavigator6.PositionItem = this.toolStripTextBox4;
            this.bindingNavigator6.Size = new System.Drawing.Size(337, 25);
            this.bindingNavigator6.TabIndex = 52;
            this.bindingNavigator6.Text = "bindingNavigator1";
            this.bindingNavigator6.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bindingNavigator6_ItemClicked);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "Add new";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "of {0}";
            this.toolStripLabel4.ToolTipText = "Total number of items";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "Delete";
            // 
            // toolStripButton24
            // 
            this.toolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton24.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton24.Image")));
            this.toolStripButton24.Name = "toolStripButton24";
            this.toolStripButton24.RightToLeftAutoMirrorImage = true;
            this.toolStripButton24.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton24.Text = "Move first";
            this.toolStripButton24.Click += new System.EventHandler(this.toolStripButton24_Click);
            // 
            // toolStripButton25
            // 
            this.toolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton25.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton25.Image")));
            this.toolStripButton25.Name = "toolStripButton25";
            this.toolStripButton25.RightToLeftAutoMirrorImage = true;
            this.toolStripButton25.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton25.Text = "Move previous";
            this.toolStripButton25.Click += new System.EventHandler(this.toolStripButton25_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.AccessibleName = "Position";
            this.toolStripTextBox4.AutoSize = false;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox4.Text = "0";
            this.toolStripTextBox4.ToolTipText = "Current position";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton26
            // 
            this.toolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton26.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton26.Image")));
            this.toolStripButton26.Name = "toolStripButton26";
            this.toolStripButton26.RightToLeftAutoMirrorImage = true;
            this.toolStripButton26.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton26.Text = "Move next";
            this.toolStripButton26.Click += new System.EventHandler(this.toolStripButton26_Click);
            // 
            // toolStripButton27
            // 
            this.toolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton27.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton27.Image")));
            this.toolStripButton27.Name = "toolStripButton27";
            this.toolStripButton27.RightToLeftAutoMirrorImage = true;
            this.toolStripButton27.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton27.Text = "Move last";
            this.toolStripButton27.Click += new System.EventHandler(this.toolStripButton27_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton28
            // 
            this.toolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton28.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton28.Image")));
            this.toolStripButton28.Name = "toolStripButton28";
            this.toolStripButton28.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton28.Text = "Save Data";
            this.toolStripButton28.Click += new System.EventHandler(this.toolStripButton28_Click);
            // 
            // toolStripButton29
            // 
            this.toolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton29.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton29.Image")));
            this.toolStripButton29.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton29.Name = "toolStripButton29";
            this.toolStripButton29.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton29.Text = "Оновити";
            this.toolStripButton29.Click += new System.EventHandler(this.toolStripButton29_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.bindingNavigator5);
            this.groupBox1.Controls.Add(this.bindingNavigator4);
            this.groupBox1.Controls.Add(this.bindingNavigator3);
            this.groupBox1.Controls.Add(this.перегляд_обраного_обладнанняDataGridView);
            this.groupBox1.Controls.Add(this.перегляд_обраного_гарнітурDataGridView);
            this.groupBox1.Controls.Add(код_обладнанняLabel);
            this.groupBox1.Controls.Add(this.код_обладнанняComboBox);
            this.groupBox1.Controls.Add(код_гарнітурLabel);
            this.groupBox1.Controls.Add(this.код_гарнітурComboBox);
            this.groupBox1.Controls.Add(кількість_обладнанняLabel);
            this.groupBox1.Controls.Add(this.кількість_обладнанняTextBox);
            this.groupBox1.Controls.Add(кількість_гарнітурLabel);
            this.groupBox1.Controls.Add(this.кількість_гарнітурTextBox);
            this.groupBox1.Controls.Add(коментарLabel1);
            this.groupBox1.Controls.Add(this.коментарTextBox1);
            this.groupBox1.Controls.Add(this.код_бронювання_приміщенняTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(356, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 475);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати обладнання";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(291, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 48);
            this.button5.TabIndex = 67;
            this.button5.Text = "Підрахувати\r\nкількості";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = this.toolStripButton8;
            this.bindingNavigator5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bindingNavigator5.BindingSource = this.використання_обладнанняBindingSource;
            this.bindingNavigator5.CountItem = null;
            this.bindingNavigator5.DeleteItem = null;
            this.bindingNavigator5.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripButton14});
            this.bindingNavigator5.Location = new System.Drawing.Point(13, 20);
            this.bindingNavigator5.MoveFirstItem = null;
            this.bindingNavigator5.MoveLastItem = null;
            this.bindingNavigator5.MoveNextItem = null;
            this.bindingNavigator5.MovePreviousItem = null;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = null;
            this.bindingNavigator5.Size = new System.Drawing.Size(58, 25);
            this.bindingNavigator5.TabIndex = 66;
            this.bindingNavigator5.Text = "bindingNavigator1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Add new";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Save Data";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click_1);
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.toolStripButton1;
            this.bindingNavigator4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bindingNavigator4.BindingSource = this.використання_обладнання_ГарнітурBindingSource;
            this.bindingNavigator4.CountItem = this.toolStripLabel1;
            this.bindingNavigator4.DeleteItem = this.toolStripButton2;
            this.bindingNavigator4.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator4.Location = new System.Drawing.Point(7, 180);
            this.bindingNavigator4.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator4.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator4.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator4.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator4.Size = new System.Drawing.Size(278, 25);
            this.bindingNavigator4.TabIndex = 65;
            this.bindingNavigator4.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Save Data";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click_1);
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.toolStripButton17;
            this.bindingNavigator3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bindingNavigator3.BindingSource = this.використання_обладнання_ОбладнанняBindingSource;
            this.bindingNavigator3.CountItem = this.toolStripLabel3;
            this.bindingNavigator3.DeleteItem = this.toolStripButton18;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton21,
            this.toolStripButton22,
            this.toolStripSeparator9,
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripButton23});
            this.bindingNavigator3.Location = new System.Drawing.Point(359, 180);
            this.bindingNavigator3.MoveFirstItem = this.toolStripButton19;
            this.bindingNavigator3.MoveLastItem = this.toolStripButton22;
            this.bindingNavigator3.MoveNextItem = this.toolStripButton21;
            this.bindingNavigator3.MovePreviousItem = this.toolStripButton20;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.toolStripTextBox3;
            this.bindingNavigator3.Size = new System.Drawing.Size(278, 25);
            this.bindingNavigator3.TabIndex = 64;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "Add new";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "of {0}";
            this.toolStripLabel3.ToolTipText = "Total number of items";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton18.Text = "Delete";
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.RightToLeftAutoMirrorImage = true;
            this.toolStripButton19.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton19.Text = "Move first";
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.RightToLeftAutoMirrorImage = true;
            this.toolStripButton20.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton20.Text = "Move previous";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "Position";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Current position";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton21
            // 
            this.toolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton21.Image")));
            this.toolStripButton21.Name = "toolStripButton21";
            this.toolStripButton21.RightToLeftAutoMirrorImage = true;
            this.toolStripButton21.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton21.Text = "Move next";
            // 
            // toolStripButton22
            // 
            this.toolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton22.Image")));
            this.toolStripButton22.Name = "toolStripButton22";
            this.toolStripButton22.RightToLeftAutoMirrorImage = true;
            this.toolStripButton22.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton22.Text = "Move last";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton23
            // 
            this.toolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton23.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            this.toolStripButton23.Name = "toolStripButton23";
            this.toolStripButton23.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton23.Text = "Save Data";
            this.toolStripButton23.Click += new System.EventHandler(this.toolStripButton23_Click_1);
            // 
            // перегляд_обраного_обладнанняDataGridView
            // 
            this.перегляд_обраного_обладнанняDataGridView.AutoGenerateColumns = false;
            this.перегляд_обраного_обладнанняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.перегляд_обраного_обладнанняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Операційна_система});
            this.перегляд_обраного_обладнанняDataGridView.DataSource = this.перегляд_обраного_обладнанняBindingSource;
            this.перегляд_обраного_обладнанняDataGridView.Location = new System.Drawing.Point(359, 235);
            this.перегляд_обраного_обладнанняDataGridView.Name = "перегляд_обраного_обладнанняDataGridView";
            this.перегляд_обраного_обладнанняDataGridView.Size = new System.Drawing.Size(466, 220);
            this.перегляд_обраного_обладнанняDataGridView.TabIndex = 63;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn4.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Тип";
            this.dataGridViewTextBoxColumn6.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Операційна_система
            // 
            this.Операційна_система.DataPropertyName = "Операційна_система";
            this.Операційна_система.HeaderText = "Операційна система";
            this.Операційна_система.Name = "Операційна_система";
            this.Операційна_система.Width = 120;
            // 
            // перегляд_обраного_гарнітурDataGridView
            // 
            this.перегляд_обраного_гарнітурDataGridView.AutoGenerateColumns = false;
            this.перегляд_обраного_гарнітурDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.перегляд_обраного_гарнітурDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.перегляд_обраного_гарнітурDataGridView.DataSource = this.перегляд_обраного_гарнітурBindingSource;
            this.перегляд_обраного_гарнітурDataGridView.Location = new System.Drawing.Point(7, 235);
            this.перегляд_обраного_гарнітурDataGridView.Name = "перегляд_обраного_гарнітурDataGridView";
            this.перегляд_обраного_гарнітурDataGridView.Size = new System.Drawing.Size(346, 220);
            this.перегляд_обраного_гарнітурDataGridView.TabIndex = 62;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn1.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Колір";
            this.dataGridViewTextBoxColumn3.HeaderText = "Колір";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // код_обладнанняComboBox
            // 
            this.код_обладнанняComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.використання_обладнання_ОбладнанняBindingSource, "Код_обладнання", true));
            this.код_обладнанняComboBox.DataSource = this.обладнанняBindingSource;
            this.код_обладнанняComboBox.DisplayMember = "Назва";
            this.код_обладнанняComboBox.FormattingEnabled = true;
            this.код_обладнанняComboBox.Location = new System.Drawing.Point(436, 208);
            this.код_обладнанняComboBox.Name = "код_обладнанняComboBox";
            this.код_обладнанняComboBox.Size = new System.Drawing.Size(203, 21);
            this.код_обладнанняComboBox.TabIndex = 61;
            this.код_обладнанняComboBox.ValueMember = "Код_обладнання";
            // 
            // код_гарнітурComboBox
            // 
            this.код_гарнітурComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.використання_обладнання_ГарнітурBindingSource, "Код_гарнітур", true));
            this.код_гарнітурComboBox.DataSource = this.гарнітурBindingSource;
            this.код_гарнітурComboBox.DisplayMember = "Назва";
            this.код_гарнітурComboBox.FormattingEnabled = true;
            this.код_гарнітурComboBox.Location = new System.Drawing.Point(67, 208);
            this.код_гарнітурComboBox.Name = "код_гарнітурComboBox";
            this.код_гарнітурComboBox.Size = new System.Drawing.Size(218, 21);
            this.код_гарнітурComboBox.TabIndex = 59;
            this.код_гарнітурComboBox.ValueMember = "Код_гарнітур";
            // 
            // кількість_обладнанняTextBox
            // 
            this.кількість_обладнанняTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.використання_обладнанняBindingSource, "Кількість_обладнання", true));
            this.кількість_обладнанняTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кількість_обладнанняTextBox.Location = new System.Drawing.Point(160, 46);
            this.кількість_обладнанняTextBox.Name = "кількість_обладнанняTextBox";
            this.кількість_обладнанняTextBox.Size = new System.Drawing.Size(125, 20);
            this.кількість_обладнанняTextBox.TabIndex = 53;
            // 
            // кількість_гарнітурTextBox
            // 
            this.кількість_гарнітурTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.використання_обладнанняBindingSource, "Кількість_гарнітур", true));
            this.кількість_гарнітурTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кількість_гарнітурTextBox.Location = new System.Drawing.Point(160, 72);
            this.кількість_гарнітурTextBox.Name = "кількість_гарнітурTextBox";
            this.кількість_гарнітурTextBox.Size = new System.Drawing.Size(125, 20);
            this.кількість_гарнітурTextBox.TabIndex = 55;
            // 
            // коментарTextBox1
            // 
            this.коментарTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.використання_обладнанняBindingSource, "Коментар", true));
            this.коментарTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.коментарTextBox1.Location = new System.Drawing.Point(89, 98);
            this.коментарTextBox1.Multiline = true;
            this.коментарTextBox1.Name = "коментарTextBox1";
            this.коментарTextBox1.Size = new System.Drawing.Size(196, 67);
            this.коментарTextBox1.TabIndex = 57;
            // 
            // код_бронювання_приміщенняTextBox
            // 
            this.код_бронювання_приміщенняTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.бронювання_приміщенняBindingSource, "Код_бронювання_приміщення", true));
            this.код_бронювання_приміщенняTextBox.Location = new System.Drawing.Point(17, 294);
            this.код_бронювання_приміщенняTextBox.Name = "код_бронювання_приміщенняTextBox";
            this.код_бронювання_приміщенняTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_бронювання_приміщенняTextBox.TabIndex = 54;
            // 
            // підрахунок_кількість_гарнітурBindingSource
            // 
            this.підрахунок_кількість_гарнітурBindingSource.DataMember = "підрахунок_кількість_гарнітур";
            this.підрахунок_кількість_гарнітурBindingSource.DataSource = this.myDataSet;
            // 
            // підрахунок_кількість_гарнітурTableAdapter
            // 
            this.підрахунок_кількість_гарнітурTableAdapter.ClearBeforeFill = true;
            // 
            // підрахунок_кількість_обладнанняBindingSource
            // 
            this.підрахунок_кількість_обладнанняBindingSource.DataMember = "підрахунок_кількість_обладнання";
            this.підрахунок_кількість_обладнанняBindingSource.DataSource = this.myDataSet;
            // 
            // підрахунок_кількість_обладнанняTableAdapter
            // 
            this.підрахунок_кількість_обладнанняTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1201, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(150, 169);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 23);
            this.button6.TabIndex = 55;
            this.button6.Text = "Перевірити пронювання";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // formReservetionRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 521);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(дата_запису_бронюванняLabel);
            this.Controls.Add(this.дата_запису_бронюванняDateTimePicker);
            this.Controls.Add(кількість_людейLabel);
            this.Controls.Add(this.кількість_людейTextBox);
            this.Controls.Add(дата_проведення_заходуLabel);
            this.Controls.Add(this.дата_проведення_заходуDateTimePicker);
            this.Controls.Add(час_початкуLabel);
            this.Controls.Add(this.час_початкуTextBox);
            this.Controls.Add(тривалість_годинLabel);
            this.Controls.Add(this.тривалість_годинTextBox);
            this.Controls.Add(коментарLabel);
            this.Controls.Add(this.коментарTextBox);
            this.Controls.Add(код_приміщенняLabel);
            this.Controls.Add(this.код_приміщенняComboBox);
            this.Controls.Add(код_адміністратораLabel);
            this.Controls.Add(this.код_адміністратораComboBox);
            this.Controls.Add(код_клієнтLabel);
            this.Controls.Add(this.код_клієнтComboBox);
            this.Controls.Add(код_заходуLabel);
            this.Controls.Add(this.код_заходуComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formReservetionRoom";
            this.Text = "Розподілення приміщень";
            this.Load += new System.EventHandler(this.formReservetionRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронювання_приміщенняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.використання_обладнання_ГарнітурBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.використання_обладнанняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приміщенняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.західBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гарнітурBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.використання_обладнання_ОбладнанняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обладнанняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перегляд_обраного_гарнітурBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перегляд_обраного_обладнанняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).EndInit();
            this.bindingNavigator6.ResumeLayout(false);
            this.bindingNavigator6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.перегляд_обраного_обладнанняDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перегляд_обраного_гарнітурDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.підрахунок_кількість_гарнітурBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.підрахунок_кількість_обладнанняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource бронювання_приміщенняBindingSource;
        private myDataSetTableAdapters.Бронювання_приміщенняTableAdapter бронювання_приміщенняTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private myDataSetTableAdapters.АдміністраторTableAdapter адміністраторTableAdapter;
        private System.Windows.Forms.DateTimePicker дата_запису_бронюванняDateTimePicker;
        private System.Windows.Forms.TextBox кількість_людейTextBox;
        private System.Windows.Forms.DateTimePicker дата_проведення_заходуDateTimePicker;
        private System.Windows.Forms.TextBox час_початкуTextBox;
        private System.Windows.Forms.TextBox тривалість_годинTextBox;
        private System.Windows.Forms.TextBox коментарTextBox;
        private System.Windows.Forms.ComboBox код_приміщенняComboBox;
        private System.Windows.Forms.ComboBox код_адміністратораComboBox;
        private System.Windows.Forms.ComboBox код_клієнтComboBox;
        private System.Windows.Forms.ComboBox код_заходуComboBox;
        private System.Windows.Forms.BindingSource адміністраторBindingSource;
        private myDataSetTableAdapters.КлієнтTableAdapter клієнтTableAdapter;
        private System.Windows.Forms.BindingSource клієнтBindingSource;
        private myDataSetTableAdapters.ЗахідTableAdapter західTableAdapter;
        private System.Windows.Forms.BindingSource західBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource приміщенняBindingSource;
        private myDataSetTableAdapters.ПриміщенняTableAdapter приміщенняTableAdapter;
        private System.Windows.Forms.BindingSource використання_обладнанняBindingSource;
        private myDataSetTableAdapters.Використання_обладнанняTableAdapter використання_обладнанняTableAdapter;
        private System.Windows.Forms.BindingSource використання_обладнання_ГарнітурBindingSource;
        private myDataSetTableAdapters.Використання_обладнання_ГарнітурTableAdapter використання_обладнання_ГарнітурTableAdapter;
        private System.Windows.Forms.BindingSource використання_обладнання_ОбладнанняBindingSource;
        private myDataSetTableAdapters.Використання_обладнання_ОбладнанняTableAdapter використання_обладнання_ОбладнанняTableAdapter;
        private System.Windows.Forms.BindingSource перегляд_обраного_гарнітурBindingSource;
        private myDataSetTableAdapters.Перегляд_обраного_гарнітурTableAdapter перегляд_обраного_гарнітурTableAdapter;
        private System.Windows.Forms.BindingSource перегляд_обраного_обладнанняBindingSource;
        private myDataSetTableAdapters.Перегляд_обраного_обладнанняTableAdapter перегляд_обраного_обладнанняTableAdapter;
        private System.Windows.Forms.BindingSource гарнітурBindingSource;
        private myDataSetTableAdapters.ГарнітурTableAdapter гарнітурTableAdapter;
        private System.Windows.Forms.BindingSource обладнанняBindingSource;
        private myDataSetTableAdapters.ОбладнанняTableAdapter обладнанняTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator6;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton24;
        private System.Windows.Forms.ToolStripButton toolStripButton25;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton26;
        private System.Windows.Forms.ToolStripButton toolStripButton27;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton toolStripButton28;
        private System.Windows.Forms.ToolStripButton toolStripButton29;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton21;
        private System.Windows.Forms.ToolStripButton toolStripButton22;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton23;
        private System.Windows.Forms.DataGridView перегляд_обраного_обладнанняDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Операційна_система;
        private System.Windows.Forms.DataGridView перегляд_обраного_гарнітурDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox код_обладнанняComboBox;
        private System.Windows.Forms.ComboBox код_гарнітурComboBox;
        private System.Windows.Forms.TextBox кількість_обладнанняTextBox;
        private System.Windows.Forms.TextBox кількість_гарнітурTextBox;
        private System.Windows.Forms.TextBox коментарTextBox1;
        private System.Windows.Forms.TextBox код_бронювання_приміщенняTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource підрахунок_кількість_гарнітурBindingSource;
        private myDataSetTableAdapters.підрахунок_кількість_гарнітурTableAdapter підрахунок_кількість_гарнітурTableAdapter;
        private System.Windows.Forms.BindingSource підрахунок_кількість_обладнанняBindingSource;
        private myDataSetTableAdapters.підрахунок_кількість_обладнанняTableAdapter підрахунок_кількість_обладнанняTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
    }
}