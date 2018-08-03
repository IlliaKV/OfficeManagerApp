namespace AdminGoITApp
{
    partial class formSearchContractor
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
            System.Windows.Forms.Label паспортні_даніLabel;
            System.Windows.Forms.Label трудова_угодаLabel;
            System.Windows.Forms.Label фізична_адресаLabel;
            System.Windows.Forms.Label номер_договоруLabel;
            System.Windows.Forms.Label назваLabel;
            System.Windows.Forms.Label адресаLabel;
            System.Windows.Forms.Label тип_підрядникаLabel;
            System.Windows.Forms.Label індифікаційний_кодLabel;
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.підрядникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.підрядникTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ПідрядникTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.рахунок_фактураTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Рахунок_фактураTableAdapter();
            this.фізична_особаTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Фізична_особаTableAdapter();
            this.юридична_особаTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Юридична_особаTableAdapter();
            this.фізична_особаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.юридична_особаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рахунок_фактураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.рахунок_фактураDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.адміністраторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.паспортні_даніTextBox = new System.Windows.Forms.TextBox();
            this.трудова_угодаTextBox = new System.Windows.Forms.TextBox();
            this.фізична_адресаTextBox = new System.Windows.Forms.TextBox();
            this.номер_договоруTextBox = new System.Windows.Forms.TextBox();
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.адресаTextBox = new System.Windows.Forms.TextBox();
            this.тип_підрядникаTextBox = new System.Windows.Forms.TextBox();
            this.індифікаційний_кодTextBox = new System.Windows.Forms.TextBox();
            this.адміністраторTableAdapter = new AdminGoITApp.myDataSetTableAdapters.АдміністраторTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.код_підрядникаComboBox = new System.Windows.Forms.ComboBox();
            this.підрядникBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            паспортні_даніLabel = new System.Windows.Forms.Label();
            трудова_угодаLabel = new System.Windows.Forms.Label();
            фізична_адресаLabel = new System.Windows.Forms.Label();
            номер_договоруLabel = new System.Windows.Forms.Label();
            назваLabel = new System.Windows.Forms.Label();
            адресаLabel = new System.Windows.Forms.Label();
            тип_підрядникаLabel = new System.Windows.Forms.Label();
            індифікаційний_кодLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.підрядникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фізична_особаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.юридична_особаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рахунок_фактураBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рахунок_фактураDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.підрядникBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // паспортні_даніLabel
            // 
            паспортні_даніLabel.AutoSize = true;
            паспортні_даніLabel.Location = new System.Drawing.Point(410, 94);
            паспортні_даніLabel.Name = "паспортні_даніLabel";
            паспортні_даніLabel.Size = new System.Drawing.Size(84, 13);
            паспортні_даніLabel.TabIndex = 33;
            паспортні_даніLabel.Text = "Паспортні дані:";
            // 
            // трудова_угодаLabel
            // 
            трудова_угодаLabel.AutoSize = true;
            трудова_угодаLabel.Location = new System.Drawing.Point(410, 120);
            трудова_угодаLabel.Name = "трудова_угодаLabel";
            трудова_угодаLabel.Size = new System.Drawing.Size(83, 13);
            трудова_угодаLabel.TabIndex = 35;
            трудова_угодаLabel.Text = "Трудова угода:";
            // 
            // фізична_адресаLabel
            // 
            фізична_адресаLabel.AutoSize = true;
            фізична_адресаLabel.Location = new System.Drawing.Point(405, 39);
            фізична_адресаLabel.Name = "фізична_адресаLabel";
            фізична_адресаLabel.Size = new System.Drawing.Size(91, 13);
            фізична_адресаLabel.TabIndex = 29;
            фізична_адресаLabel.Text = "Фізична адреса:";
            // 
            // номер_договоруLabel
            // 
            номер_договоруLabel.AutoSize = true;
            номер_договоруLabel.Location = new System.Drawing.Point(405, 65);
            номер_договоруLabel.Name = "номер_договоруLabel";
            номер_договоруLabel.Size = new System.Drawing.Size(93, 13);
            номер_договоруLabel.TabIndex = 31;
            номер_договоруLabel.Text = "Номер договору:";
            // 
            // назваLabel
            // 
            назваLabel.AutoSize = true;
            назваLabel.Location = new System.Drawing.Point(117, 39);
            назваLabel.Name = "назваLabel";
            назваLabel.Size = new System.Drawing.Size(42, 13);
            назваLabel.TabIndex = 21;
            назваLabel.Text = "Назва:";
            // 
            // адресаLabel
            // 
            адресаLabel.AutoSize = true;
            адресаLabel.Location = new System.Drawing.Point(117, 65);
            адресаLabel.Name = "адресаLabel";
            адресаLabel.Size = new System.Drawing.Size(47, 13);
            адресаLabel.TabIndex = 23;
            адресаLabel.Text = "Адреса:";
            // 
            // тип_підрядникаLabel
            // 
            тип_підрядникаLabel.AutoSize = true;
            тип_підрядникаLabel.Location = new System.Drawing.Point(117, 91);
            тип_підрядникаLabel.Name = "тип_підрядникаLabel";
            тип_підрядникаLabel.Size = new System.Drawing.Size(88, 13);
            тип_підрядникаLabel.TabIndex = 25;
            тип_підрядникаLabel.Text = "Тип підрядника:";
            // 
            // індифікаційний_кодLabel
            // 
            індифікаційний_кодLabel.AutoSize = true;
            індифікаційний_кодLabel.Location = new System.Drawing.Point(113, 117);
            індифікаційний_кодLabel.Name = "індифікаційний_кодLabel";
            індифікаційний_кодLabel.Size = new System.Drawing.Size(117, 13);
            індифікаційний_кодLabel.TabIndex = 27;
            індифікаційний_кодLabel.Text = "Ідентифікаційний код:";
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // підрядникBindingSource
            // 
            this.підрядникBindingSource.DataMember = "Підрядник";
            this.підрядникBindingSource.DataSource = this.myDataSet;
            // 
            // підрядникTableAdapter
            // 
            this.підрядникTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            this.tableAdapterManager.ПідрядникTableAdapter = this.підрядникTableAdapter;
            this.tableAdapterManager.ПриміщенняTableAdapter = null;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = this.рахунок_фактураTableAdapter;
            this.tableAdapterManager.Рядок_рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Фізична_особаTableAdapter = this.фізична_особаTableAdapter;
            this.tableAdapterManager.Юридична_особаTableAdapter = this.юридична_особаTableAdapter;
            // 
            // рахунок_фактураTableAdapter
            // 
            this.рахунок_фактураTableAdapter.ClearBeforeFill = true;
            // 
            // фізична_особаTableAdapter
            // 
            this.фізична_особаTableAdapter.ClearBeforeFill = true;
            // 
            // юридична_особаTableAdapter
            // 
            this.юридична_особаTableAdapter.ClearBeforeFill = true;
            // 
            // фізична_особаBindingSource
            // 
            this.фізична_особаBindingSource.DataMember = "FK__Фізична_о__Код_п__1ED998B2";
            this.фізична_особаBindingSource.DataSource = this.підрядникBindingSource;
            // 
            // юридична_особаBindingSource
            // 
            this.юридична_особаBindingSource.DataMember = "FK__Юридична___Код_п__1FCDBCEB";
            this.юридична_особаBindingSource.DataSource = this.підрядникBindingSource;
            // 
            // рахунок_фактураBindingSource
            // 
            this.рахунок_фактураBindingSource.DataMember = "FK__Рахунок_ф__Код_п__1BFD2C07";
            this.рахунок_фактураBindingSource.DataSource = this.підрядникBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Пошук підрядника за ідентифікаційним кодом:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Знайти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.рахунок_фактураDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(10, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 256);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рахунки-фактури підрядника:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // рахунок_фактураDataGridView
            // 
            this.рахунок_фактураDataGridView.AutoGenerateColumns = false;
            this.рахунок_фактураDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.рахунок_фактураDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.рахунок_фактураDataGridView.DataSource = this.рахунок_фактураBindingSource;
            this.рахунок_фактураDataGridView.Location = new System.Drawing.Point(54, 23);
            this.рахунок_фактураDataGridView.Name = "рахунок_фактураDataGridView";
            this.рахунок_фактураDataGridView.Size = new System.Drawing.Size(647, 220);
            this.рахунок_фактураDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Коментар";
            this.dataGridViewTextBoxColumn3.HeaderText = "Коментар";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Замовник";
            this.dataGridViewTextBoxColumn4.HeaderText = "Замовник";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Загальна_сума";
            this.dataGridViewTextBoxColumn6.HeaderText = "Загальна сума";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Код_адміністратора";
            this.dataGridViewTextBoxColumn7.DataSource = this.адміністраторBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Прізвище";
            this.dataGridViewTextBoxColumn7.HeaderText = "Адміністратор";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "Код_адміністратора";
            // 
            // адміністраторBindingSource
            // 
            this.адміністраторBindingSource.DataMember = "Адміністратор";
            this.адміністраторBindingSource.DataSource = this.myDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(паспортні_даніLabel);
            this.groupBox2.Controls.Add(this.паспортні_даніTextBox);
            this.groupBox2.Controls.Add(трудова_угодаLabel);
            this.groupBox2.Controls.Add(this.трудова_угодаTextBox);
            this.groupBox2.Controls.Add(фізична_адресаLabel);
            this.groupBox2.Controls.Add(this.фізична_адресаTextBox);
            this.groupBox2.Controls.Add(номер_договоруLabel);
            this.groupBox2.Controls.Add(this.номер_договоруTextBox);
            this.groupBox2.Controls.Add(назваLabel);
            this.groupBox2.Controls.Add(this.назваTextBox);
            this.groupBox2.Controls.Add(адресаLabel);
            this.groupBox2.Controls.Add(this.адресаTextBox);
            this.groupBox2.Controls.Add(тип_підрядникаLabel);
            this.groupBox2.Controls.Add(this.тип_підрядникаTextBox);
            this.groupBox2.Controls.Add(індифікаційний_кодLabel);
            this.groupBox2.Controls.Add(this.індифікаційний_кодTextBox);
            this.groupBox2.Location = new System.Drawing.Point(10, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 155);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дані";
            // 
            // паспортні_даніTextBox
            // 
            this.паспортні_даніTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.юридична_особаBindingSource, "Паспортні_дані", true));
            this.паспортні_даніTextBox.Location = new System.Drawing.Point(504, 91);
            this.паспортні_даніTextBox.Name = "паспортні_даніTextBox";
            this.паспортні_даніTextBox.Size = new System.Drawing.Size(154, 20);
            this.паспортні_даніTextBox.TabIndex = 34;
            // 
            // трудова_угодаTextBox
            // 
            this.трудова_угодаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.юридична_особаBindingSource, "Трудова_угода", true));
            this.трудова_угодаTextBox.Location = new System.Drawing.Point(504, 117);
            this.трудова_угодаTextBox.Name = "трудова_угодаTextBox";
            this.трудова_угодаTextBox.Size = new System.Drawing.Size(154, 20);
            this.трудова_угодаTextBox.TabIndex = 36;
            // 
            // фізична_адресаTextBox
            // 
            this.фізична_адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фізична_особаBindingSource, "Фізична_адреса", true));
            this.фізична_адресаTextBox.Location = new System.Drawing.Point(504, 36);
            this.фізична_адресаTextBox.Name = "фізична_адресаTextBox";
            this.фізична_адресаTextBox.Size = new System.Drawing.Size(154, 20);
            this.фізична_адресаTextBox.TabIndex = 30;
            // 
            // номер_договоруTextBox
            // 
            this.номер_договоруTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фізична_особаBindingSource, "Номер_договору", true));
            this.номер_договоруTextBox.Location = new System.Drawing.Point(504, 62);
            this.номер_договоруTextBox.Name = "номер_договоруTextBox";
            this.номер_договоруTextBox.Size = new System.Drawing.Size(154, 20);
            this.номер_договоруTextBox.TabIndex = 32;
            // 
            // назваTextBox
            // 
            this.назваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.підрядникBindingSource, "Назва", true));
            this.назваTextBox.Location = new System.Drawing.Point(229, 36);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.Size = new System.Drawing.Size(149, 20);
            this.назваTextBox.TabIndex = 22;
            // 
            // адресаTextBox
            // 
            this.адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.підрядникBindingSource, "Адреса", true));
            this.адресаTextBox.Location = new System.Drawing.Point(229, 62);
            this.адресаTextBox.Name = "адресаTextBox";
            this.адресаTextBox.Size = new System.Drawing.Size(149, 20);
            this.адресаTextBox.TabIndex = 24;
            // 
            // тип_підрядникаTextBox
            // 
            this.тип_підрядникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.підрядникBindingSource, "Тип_підрядника", true));
            this.тип_підрядникаTextBox.Location = new System.Drawing.Point(229, 88);
            this.тип_підрядникаTextBox.Name = "тип_підрядникаTextBox";
            this.тип_підрядникаTextBox.Size = new System.Drawing.Size(149, 20);
            this.тип_підрядникаTextBox.TabIndex = 26;
            // 
            // індифікаційний_кодTextBox
            // 
            this.індифікаційний_кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.підрядникBindingSource, "Індифікаційний_код", true));
            this.індифікаційний_кодTextBox.Location = new System.Drawing.Point(229, 114);
            this.індифікаційний_кодTextBox.Name = "індифікаційний_кодTextBox";
            this.індифікаційний_кодTextBox.Size = new System.Drawing.Size(149, 20);
            this.індифікаційний_кодTextBox.TabIndex = 28;
            // 
            // адміністраторTableAdapter
            // 
            this.адміністраторTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(356, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Пошук підрядника за назвою:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Знайти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // код_підрядникаComboBox
            // 
            this.код_підрядникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.підрядникBindingSource, "Код_підрядника", true));
            this.код_підрядникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.підрядникBindingSource, "Назва", true));
            this.код_підрядникаComboBox.DataSource = this.підрядникBindingSource1;
            this.код_підрядникаComboBox.DisplayMember = "Назва";
            this.код_підрядникаComboBox.FormattingEnabled = true;
            this.код_підрядникаComboBox.Location = new System.Drawing.Point(356, 34);
            this.код_підрядникаComboBox.Name = "код_підрядникаComboBox";
            this.код_підрядникаComboBox.Size = new System.Drawing.Size(248, 21);
            this.код_підрядникаComboBox.TabIndex = 37;
            this.код_підрядникаComboBox.ValueMember = "Код_підрядника";
            // 
            // підрядникBindingSource1
            // 
            this.підрядникBindingSource1.DataMember = "Підрядник";
            this.підрядникBindingSource1.DataSource = this.myDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.підрядникBindingSource, "Назва", true));
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // formSearchContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 536);
            this.Controls.Add(this.код_підрядникаComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formSearchContractor";
            this.Text = "Пошук підрядника";
            this.Load += new System.EventHandler(this.formSearchContractor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.підрядникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фізична_особаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.юридична_особаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рахунок_фактураBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.рахунок_фактураDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.підрядникBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource підрядникBindingSource;
        private myDataSetTableAdapters.ПідрядникTableAdapter підрядникTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private myDataSetTableAdapters.Фізична_особаTableAdapter фізична_особаTableAdapter;
        private System.Windows.Forms.BindingSource фізична_особаBindingSource;
        private myDataSetTableAdapters.Юридична_особаTableAdapter юридична_особаTableAdapter;
        private System.Windows.Forms.BindingSource юридична_особаBindingSource;
        private myDataSetTableAdapters.Рахунок_фактураTableAdapter рахунок_фактураTableAdapter;
        private System.Windows.Forms.BindingSource рахунок_фактураBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView рахунок_фактураDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox паспортні_даніTextBox;
        private System.Windows.Forms.TextBox трудова_угодаTextBox;
        private System.Windows.Forms.TextBox фізична_адресаTextBox;
        private System.Windows.Forms.TextBox номер_договоруTextBox;
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.TextBox адресаTextBox;
        private System.Windows.Forms.TextBox тип_підрядникаTextBox;
        private System.Windows.Forms.TextBox індифікаційний_кодTextBox;
        private System.Windows.Forms.BindingSource адміністраторBindingSource;
        private myDataSetTableAdapters.АдміністраторTableAdapter адміністраторTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox код_підрядникаComboBox;
        private System.Windows.Forms.BindingSource підрядникBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}