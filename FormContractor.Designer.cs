namespace AdminGoITApp
{
    partial class FormContractor
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
            System.Windows.Forms.Label назваLabel;
            System.Windows.Forms.Label адресаLabel;
            System.Windows.Forms.Label тип_підрядникаLabel;
            System.Windows.Forms.Label індифікаційний_кодLabel;
            System.Windows.Forms.Label фізична_адресаLabel;
            System.Windows.Forms.Label номер_договоруLabel;
            System.Windows.Forms.Label паспортні_даніLabel;
            System.Windows.Forms.Label трудова_угодаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContractor));
            this.підрядникBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.підрядникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.підрядникBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.адресаTextBox = new System.Windows.Forms.TextBox();
            this.тип_підрядникаTextBox = new System.Windows.Forms.TextBox();
            this.індифікаційний_кодTextBox = new System.Windows.Forms.TextBox();
            this.фізична_особаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.юридична_особаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.фізична_адресаTextBox = new System.Windows.Forms.TextBox();
            this.номер_договоруTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.паспортні_даніTextBox = new System.Windows.Forms.TextBox();
            this.трудова_угодаTextBox = new System.Windows.Forms.TextBox();
            this.підрядникTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ПідрядникTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.фізична_особаTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Фізична_особаTableAdapter();
            this.юридична_особаTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Юридична_особаTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            назваLabel = new System.Windows.Forms.Label();
            адресаLabel = new System.Windows.Forms.Label();
            тип_підрядникаLabel = new System.Windows.Forms.Label();
            індифікаційний_кодLabel = new System.Windows.Forms.Label();
            фізична_адресаLabel = new System.Windows.Forms.Label();
            номер_договоруLabel = new System.Windows.Forms.Label();
            паспортні_даніLabel = new System.Windows.Forms.Label();
            трудова_угодаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.підрядникBindingNavigator)).BeginInit();
            this.підрядникBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.підрядникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фізична_особаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.юридична_особаBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // назваLabel
            // 
            назваLabel.AutoSize = true;
            назваLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            назваLabel.Location = new System.Drawing.Point(12, 44);
            назваLabel.Name = "назваLabel";
            назваLabel.Size = new System.Drawing.Size(42, 13);
            назваLabel.TabIndex = 3;
            назваLabel.Text = "Назва:";
            // 
            // адресаLabel
            // 
            адресаLabel.AutoSize = true;
            адресаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            адресаLabel.Location = new System.Drawing.Point(12, 70);
            адресаLabel.Name = "адресаLabel";
            адресаLabel.Size = new System.Drawing.Size(47, 13);
            адресаLabel.TabIndex = 5;
            адресаLabel.Text = "Адреса:";
            // 
            // тип_підрядникаLabel
            // 
            тип_підрядникаLabel.AutoSize = true;
            тип_підрядникаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            тип_підрядникаLabel.Location = new System.Drawing.Point(12, 96);
            тип_підрядникаLabel.Name = "тип_підрядникаLabel";
            тип_підрядникаLabel.Size = new System.Drawing.Size(88, 13);
            тип_підрядникаLabel.TabIndex = 7;
            тип_підрядникаLabel.Text = "Тип підрядника:";
            // 
            // індифікаційний_кодLabel
            // 
            індифікаційний_кодLabel.AutoSize = true;
            індифікаційний_кодLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            індифікаційний_кодLabel.Location = new System.Drawing.Point(12, 122);
            індифікаційний_кодLabel.Name = "індифікаційний_кодLabel";
            індифікаційний_кодLabel.Size = new System.Drawing.Size(106, 13);
            індифікаційний_кодLabel.TabIndex = 9;
            індифікаційний_кодLabel.Text = "Індифікаційний код:";
            // 
            // фізична_адресаLabel
            // 
            фізична_адресаLabel.AutoSize = true;
            фізична_адресаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фізична_адресаLabel.Location = new System.Drawing.Point(11, 52);
            фізична_адресаLabel.Name = "фізична_адресаLabel";
            фізична_адресаLabel.Size = new System.Drawing.Size(91, 13);
            фізична_адресаLabel.TabIndex = 22;
            фізична_адресаLabel.Text = "Фізична адреса:";
            // 
            // номер_договоруLabel
            // 
            номер_договоруLabel.AutoSize = true;
            номер_договоруLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_договоруLabel.Location = new System.Drawing.Point(11, 78);
            номер_договоруLabel.Name = "номер_договоруLabel";
            номер_договоруLabel.Size = new System.Drawing.Size(93, 13);
            номер_договоруLabel.TabIndex = 24;
            номер_договоруLabel.Text = "Номер договору:";
            // 
            // паспортні_даніLabel
            // 
            паспортні_даніLabel.AutoSize = true;
            паспортні_даніLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            паспортні_даніLabel.Location = new System.Drawing.Point(18, 52);
            паспортні_даніLabel.Name = "паспортні_даніLabel";
            паспортні_даніLabel.Size = new System.Drawing.Size(84, 13);
            паспортні_даніLabel.TabIndex = 23;
            паспортні_даніLabel.Text = "Паспортні дані:";
            // 
            // трудова_угодаLabel
            // 
            трудова_угодаLabel.AutoSize = true;
            трудова_угодаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            трудова_угодаLabel.Location = new System.Drawing.Point(18, 78);
            трудова_угодаLabel.Name = "трудова_угодаLabel";
            трудова_угодаLabel.Size = new System.Drawing.Size(83, 13);
            трудова_угодаLabel.TabIndex = 25;
            трудова_угодаLabel.Text = "Трудова угода:";
            // 
            // підрядникBindingNavigator
            // 
            this.підрядникBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.підрядникBindingNavigator.BindingSource = this.підрядникBindingSource;
            this.підрядникBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.підрядникBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.підрядникBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.підрядникBindingNavigatorSaveItem,
            this.toolStripButton4});
            this.підрядникBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.підрядникBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.підрядникBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.підрядникBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.підрядникBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.підрядникBindingNavigator.Name = "підрядникBindingNavigator";
            this.підрядникBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.підрядникBindingNavigator.Size = new System.Drawing.Size(525, 25);
            this.підрядникBindingNavigator.TabIndex = 0;
            this.підрядникBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // підрядникBindingSource
            // 
            this.підрядникBindingSource.DataMember = "Підрядник";
            this.підрядникBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // підрядникBindingNavigatorSaveItem
            // 
            this.підрядникBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.підрядникBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("підрядникBindingNavigatorSaveItem.Image")));
            this.підрядникBindingNavigatorSaveItem.Name = "підрядникBindingNavigatorSaveItem";
            this.підрядникBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.підрядникBindingNavigatorSaveItem.Text = "Save Data";
            this.підрядникBindingNavigatorSaveItem.Click += new System.EventHandler(this.підрядникBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton4.Text = "Оновити";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // назваTextBox
            // 
            this.назваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.підрядникBindingSource, "Назва", true));
            this.назваTextBox.Location = new System.Drawing.Point(124, 41);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.Size = new System.Drawing.Size(138, 20);
            this.назваTextBox.TabIndex = 4;
            // 
            // адресаTextBox
            // 
            this.адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.підрядникBindingSource, "Адреса", true));
            this.адресаTextBox.Location = new System.Drawing.Point(124, 67);
            this.адресаTextBox.Name = "адресаTextBox";
            this.адресаTextBox.Size = new System.Drawing.Size(138, 20);
            this.адресаTextBox.TabIndex = 6;
            // 
            // тип_підрядникаTextBox
            // 
            this.тип_підрядникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.підрядникBindingSource, "Тип_підрядника", true));
            this.тип_підрядникаTextBox.Location = new System.Drawing.Point(124, 93);
            this.тип_підрядникаTextBox.Name = "тип_підрядникаTextBox";
            this.тип_підрядникаTextBox.Size = new System.Drawing.Size(138, 20);
            this.тип_підрядникаTextBox.TabIndex = 8;
            // 
            // індифікаційний_кодTextBox
            // 
            this.індифікаційний_кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.підрядникBindingSource, "Індифікаційний_код", true));
            this.індифікаційний_кодTextBox.Location = new System.Drawing.Point(124, 119);
            this.індифікаційний_кодTextBox.Name = "індифікаційний_кодTextBox";
            this.індифікаційний_кодTextBox.Size = new System.Drawing.Size(138, 20);
            this.індифікаційний_кодTextBox.TabIndex = 10;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(фізична_адресаLabel);
            this.groupBox1.Controls.Add(this.фізична_адресаTextBox);
            this.groupBox1.Controls.Add(номер_договоруLabel);
            this.groupBox1.Controls.Add(this.номер_договоруTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 113);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати як фізичну особу";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bindingNavigator1.BindingSource = this.фізична_особаBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(10, 18);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(58, 25);
            this.bindingNavigator1.TabIndex = 26;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Save Data";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // фізична_адресаTextBox
            // 
            this.фізична_адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фізична_особаBindingSource, "Фізична_адреса", true));
            this.фізична_адресаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фізична_адресаTextBox.Location = new System.Drawing.Point(110, 49);
            this.фізична_адресаTextBox.Name = "фізична_адресаTextBox";
            this.фізична_адресаTextBox.Size = new System.Drawing.Size(130, 20);
            this.фізична_адресаTextBox.TabIndex = 23;
            // 
            // номер_договоруTextBox
            // 
            this.номер_договоруTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фізична_особаBindingSource, "Номер_договору", true));
            this.номер_договоруTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_договоруTextBox.Location = new System.Drawing.Point(110, 75);
            this.номер_договоруTextBox.Name = "номер_договоруTextBox";
            this.номер_договоруTextBox.Size = new System.Drawing.Size(130, 20);
            this.номер_договоруTextBox.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bindingNavigator2);
            this.groupBox2.Controls.Add(паспортні_даніLabel);
            this.groupBox2.Controls.Add(this.паспортні_даніTextBox);
            this.groupBox2.Controls.Add(трудова_угодаLabel);
            this.groupBox2.Controls.Add(this.трудова_угодаTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(267, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 113);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додати як юридичну особу";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton2;
            this.bindingNavigator2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bindingNavigator2.BindingSource = this.юридична_особаBindingSource;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3});
            this.bindingNavigator2.Location = new System.Drawing.Point(21, 18);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(58, 25);
            this.bindingNavigator2.TabIndex = 27;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Add new";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Save Data";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // паспортні_даніTextBox
            // 
            this.паспортні_даніTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.юридична_особаBindingSource, "Паспортні_дані", true));
            this.паспортні_даніTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.паспортні_даніTextBox.Location = new System.Drawing.Point(112, 49);
            this.паспортні_даніTextBox.Name = "паспортні_даніTextBox";
            this.паспортні_даніTextBox.Size = new System.Drawing.Size(130, 20);
            this.паспортні_даніTextBox.TabIndex = 24;
            // 
            // трудова_угодаTextBox
            // 
            this.трудова_угодаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.юридична_особаBindingSource, "Трудова_угода", true));
            this.трудова_угодаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.трудова_угодаTextBox.Location = new System.Drawing.Point(112, 75);
            this.трудова_угодаTextBox.Name = "трудова_угодаTextBox";
            this.трудова_угодаTextBox.Size = new System.Drawing.Size(130, 20);
            this.трудова_угодаTextBox.TabIndex = 26;
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
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Фізична_особаTableAdapter = this.фізична_особаTableAdapter;
            this.tableAdapterManager.Юридична_особаTableAdapter = this.юридична_особаTableAdapter;
            // 
            // фізична_особаTableAdapter
            // 
            this.фізична_особаTableAdapter.ClearBeforeFill = true;
            // 
            // юридична_особаTableAdapter
            // 
            this.юридична_особаTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FormContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(назваLabel);
            this.Controls.Add(this.назваTextBox);
            this.Controls.Add(адресаLabel);
            this.Controls.Add(this.адресаTextBox);
            this.Controls.Add(тип_підрядникаLabel);
            this.Controls.Add(this.тип_підрядникаTextBox);
            this.Controls.Add(індифікаційний_кодLabel);
            this.Controls.Add(this.індифікаційний_кодTextBox);
            this.Controls.Add(this.підрядникBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormContractor";
            this.Text = "Підрядники";
            this.Load += new System.EventHandler(this.FormContractor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.підрядникBindingNavigator)).EndInit();
            this.підрядникBindingNavigator.ResumeLayout(false);
            this.підрядникBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.підрядникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фізична_особаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.юридична_особаBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource підрядникBindingSource;
        private myDataSetTableAdapters.ПідрядникTableAdapter підрядникTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator підрядникBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton підрядникBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.TextBox адресаTextBox;
        private System.Windows.Forms.TextBox тип_підрядникаTextBox;
        private System.Windows.Forms.TextBox індифікаційний_кодTextBox;
        private myDataSetTableAdapters.Фізична_особаTableAdapter фізична_особаTableAdapter;
        private System.Windows.Forms.BindingSource фізична_особаBindingSource;
        private myDataSetTableAdapters.Юридична_особаTableAdapter юридична_особаTableAdapter;
        private System.Windows.Forms.BindingSource юридична_особаBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.TextBox фізична_адресаTextBox;
        private System.Windows.Forms.TextBox номер_договоруTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox паспортні_даніTextBox;
        private System.Windows.Forms.TextBox трудова_угодаTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}