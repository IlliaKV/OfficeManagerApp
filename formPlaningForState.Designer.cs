namespace AdminGoITApp
{
    partial class formPlaningForState
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
            System.Windows.Forms.Label деньLabel;
            System.Windows.Forms.Label тижденьLabel;
            System.Windows.Forms.Label місяцьLabel;
            System.Windows.Forms.Label рікLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label код_адміністратораLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPlaningForState));
            this.графік_роботи_персоналуBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.графік_роботи_персоналуBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.графік_роботи_персоналуBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.графік_роботи_персоналуTableAdapter = new AdminGoITApp.myDataSetTableAdapters.Графік_роботи_персоналуTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.деньComboBox = new System.Windows.Forms.ComboBox();
            this.тижденьComboBox = new System.Windows.Forms.ComboBox();
            this.місяцьComboBox = new System.Windows.Forms.ComboBox();
            this.рікComboBox = new System.Windows.Forms.ComboBox();
            this.статусComboBox = new System.Windows.Forms.ComboBox();
            this.код_адміністратораComboBox = new System.Windows.Forms.ComboBox();
            this.адміністраторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.адміністраторTableAdapter = new AdminGoITApp.myDataSetTableAdapters.АдміністраторTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            деньLabel = new System.Windows.Forms.Label();
            тижденьLabel = new System.Windows.Forms.Label();
            місяцьLabel = new System.Windows.Forms.Label();
            рікLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            код_адміністратораLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.графік_роботи_персоналуBindingNavigator)).BeginInit();
            this.графік_роботи_персоналуBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.графік_роботи_персоналуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // деньLabel
            // 
            деньLabel.AutoSize = true;
            деньLabel.Location = new System.Drawing.Point(39, 65);
            деньLabel.Name = "деньLabel";
            деньLabel.Size = new System.Drawing.Size(37, 13);
            деньLabel.TabIndex = 1;
            деньLabel.Text = "День:";
            // 
            // тижденьLabel
            // 
            тижденьLabel.AutoSize = true;
            тижденьLabel.Location = new System.Drawing.Point(39, 92);
            тижденьLabel.Name = "тижденьLabel";
            тижденьLabel.Size = new System.Drawing.Size(55, 13);
            тижденьLabel.TabIndex = 3;
            тижденьLabel.Text = "Тиждень:";
            // 
            // місяцьLabel
            // 
            місяцьLabel.AutoSize = true;
            місяцьLabel.Location = new System.Drawing.Point(39, 119);
            місяцьLabel.Name = "місяцьLabel";
            місяцьLabel.Size = new System.Drawing.Size(45, 13);
            місяцьLabel.TabIndex = 5;
            місяцьLabel.Text = "Місяць:";
            // 
            // рікLabel
            // 
            рікLabel.AutoSize = true;
            рікLabel.Location = new System.Drawing.Point(39, 146);
            рікLabel.Name = "рікLabel";
            рікLabel.Size = new System.Drawing.Size(25, 13);
            рікLabel.TabIndex = 7;
            рікLabel.Text = "Рік:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(39, 173);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 9;
            статусLabel.Text = "Статус:";
            // 
            // код_адміністратораLabel
            // 
            код_адміністратораLabel.AutoSize = true;
            код_адміністратораLabel.Location = new System.Drawing.Point(39, 38);
            код_адміністратораLabel.Name = "код_адміністратораLabel";
            код_адміністратораLabel.Size = new System.Drawing.Size(81, 13);
            код_адміністратораLabel.TabIndex = 11;
            код_адміністратораLabel.Text = "Адміністратор:";
            // 
            // графік_роботи_персоналуBindingNavigator
            // 
            this.графік_роботи_персоналуBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.графік_роботи_персоналуBindingNavigator.BindingSource = this.графік_роботи_персоналуBindingSource;
            this.графік_роботи_персоналуBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.графік_роботи_персоналуBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.графік_роботи_персоналуBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.графік_роботи_персоналуBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.графік_роботи_персоналуBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.графік_роботи_персоналуBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.графік_роботи_персоналуBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.графік_роботи_персоналуBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.графік_роботи_персоналуBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.графік_роботи_персоналуBindingNavigator.Name = "графік_роботи_персоналуBindingNavigator";
            this.графік_роботи_персоналуBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.графік_роботи_персоналуBindingNavigator.Size = new System.Drawing.Size(473, 25);
            this.графік_роботи_персоналуBindingNavigator.TabIndex = 0;
            this.графік_роботи_персоналуBindingNavigator.Text = "bindingNavigator1";
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
            // графік_роботи_персоналуBindingSource
            // 
            this.графік_роботи_персоналуBindingSource.DataMember = "Графік_роботи_персоналу";
            this.графік_роботи_персоналуBindingSource.DataSource = this.myDataSet;
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
            // графік_роботи_персоналуBindingNavigatorSaveItem
            // 
            this.графік_роботи_персоналуBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.графік_роботи_персоналуBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("графік_роботи_персоналуBindingNavigatorSaveItem.Image")));
            this.графік_роботи_персоналуBindingNavigatorSaveItem.Name = "графік_роботи_персоналуBindingNavigatorSaveItem";
            this.графік_роботи_персоналуBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.графік_роботи_персоналуBindingNavigatorSaveItem.Text = "Save Data";
            this.графік_роботи_персоналуBindingNavigatorSaveItem.Click += new System.EventHandler(this.графік_роботи_персоналуBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(175, 22);
            this.toolStripButton1.Text = "Графік персоналу на тиждень";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // графік_роботи_персоналуTableAdapter
            // 
            this.графік_роботи_персоналуTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Графік_роботи_персоналуTableAdapter = this.графік_роботи_персоналуTableAdapter;
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
            // деньComboBox
            // 
            this.деньComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.графік_роботи_персоналуBindingSource, "День", true));
            this.деньComboBox.FormattingEnabled = true;
            this.деньComboBox.Items.AddRange(new object[] {
            "Понеділок",
            "Вівторок",
            "Середа",
            "Четвер",
            "Пятниця",
            "Субота",
            "Неділя"});
            this.деньComboBox.Location = new System.Drawing.Point(126, 62);
            this.деньComboBox.Name = "деньComboBox";
            this.деньComboBox.Size = new System.Drawing.Size(121, 21);
            this.деньComboBox.TabIndex = 2;
            // 
            // тижденьComboBox
            // 
            this.тижденьComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.графік_роботи_персоналуBindingSource, "Тиждень", true));
            this.тижденьComboBox.FormattingEnabled = true;
            this.тижденьComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.тижденьComboBox.Location = new System.Drawing.Point(126, 89);
            this.тижденьComboBox.Name = "тижденьComboBox";
            this.тижденьComboBox.Size = new System.Drawing.Size(121, 21);
            this.тижденьComboBox.TabIndex = 4;
            // 
            // місяцьComboBox
            // 
            this.місяцьComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.графік_роботи_персоналуBindingSource, "Місяць", true));
            this.місяцьComboBox.FormattingEnabled = true;
            this.місяцьComboBox.Items.AddRange(new object[] {
            "Січень",
            "Лютий",
            "Березень",
            "Квітень",
            "Травень",
            "Червень",
            "Липень",
            "Серпень",
            "Вересень",
            "Жовтень",
            "Листопад",
            "Грудень"});
            this.місяцьComboBox.Location = new System.Drawing.Point(126, 116);
            this.місяцьComboBox.Name = "місяцьComboBox";
            this.місяцьComboBox.Size = new System.Drawing.Size(121, 21);
            this.місяцьComboBox.TabIndex = 6;
            // 
            // рікComboBox
            // 
            this.рікComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.графік_роботи_персоналуBindingSource, "Рік", true));
            this.рікComboBox.FormattingEnabled = true;
            this.рікComboBox.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038"});
            this.рікComboBox.Location = new System.Drawing.Point(126, 143);
            this.рікComboBox.Name = "рікComboBox";
            this.рікComboBox.Size = new System.Drawing.Size(121, 21);
            this.рікComboBox.TabIndex = 8;
            // 
            // статусComboBox
            // 
            this.статусComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.графік_роботи_персоналуBindingSource, "Статус", true));
            this.статусComboBox.FormattingEnabled = true;
            this.статусComboBox.Items.AddRange(new object[] {
            "1",
            "0"});
            this.статусComboBox.Location = new System.Drawing.Point(126, 170);
            this.статусComboBox.Name = "статусComboBox";
            this.статусComboBox.Size = new System.Drawing.Size(121, 21);
            this.статусComboBox.TabIndex = 10;
            // 
            // код_адміністратораComboBox
            // 
            this.код_адміністратораComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.графік_роботи_персоналуBindingSource, "Код_адміністратора", true));
            this.код_адміністратораComboBox.DataSource = this.адміністраторBindingSource;
            this.код_адміністратораComboBox.DisplayMember = "Прізвище";
            this.код_адміністратораComboBox.FormattingEnabled = true;
            this.код_адміністратораComboBox.Location = new System.Drawing.Point(126, 35);
            this.код_адміністратораComboBox.Name = "код_адміністратораComboBox";
            this.код_адміністратораComboBox.Size = new System.Drawing.Size(121, 21);
            this.код_адміністратораComboBox.TabIndex = 12;
            this.код_адміністратораComboBox.ValueMember = "Код_адміністратора";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // formPlaningForState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(473, 313);
            this.Controls.Add(код_адміністратораLabel);
            this.Controls.Add(this.код_адміністратораComboBox);
            this.Controls.Add(статусLabel);
            this.Controls.Add(this.статусComboBox);
            this.Controls.Add(рікLabel);
            this.Controls.Add(this.рікComboBox);
            this.Controls.Add(місяцьLabel);
            this.Controls.Add(this.місяцьComboBox);
            this.Controls.Add(тижденьLabel);
            this.Controls.Add(this.тижденьComboBox);
            this.Controls.Add(деньLabel);
            this.Controls.Add(this.деньComboBox);
            this.Controls.Add(this.графік_роботи_персоналуBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formPlaningForState";
            this.Text = "Графік роботи персоналу";
            this.Load += new System.EventHandler(this.formPlaningForState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.графік_роботи_персоналуBindingNavigator)).EndInit();
            this.графік_роботи_персоналуBindingNavigator.ResumeLayout(false);
            this.графік_роботи_персоналуBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.графік_роботи_персоналуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource графік_роботи_персоналуBindingSource;
        private myDataSetTableAdapters.Графік_роботи_персоналуTableAdapter графік_роботи_персоналуTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator графік_роботи_персоналуBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton графік_роботи_персоналуBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox деньComboBox;
        private System.Windows.Forms.ComboBox тижденьComboBox;
        private System.Windows.Forms.ComboBox місяцьComboBox;
        private System.Windows.Forms.ComboBox рікComboBox;
        private System.Windows.Forms.ComboBox статусComboBox;
        private System.Windows.Forms.ComboBox код_адміністратораComboBox;
        private System.Windows.Forms.BindingSource адміністраторBindingSource;
        private myDataSetTableAdapters.АдміністраторTableAdapter адміністраторTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}