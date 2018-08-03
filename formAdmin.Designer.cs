namespace AdminGoITApp
{
    partial class formAdmin
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
            System.Windows.Forms.Label прізвищеLabel;
            System.Windows.Forms.Label імяLabel;
            System.Windows.Forms.Label побатьковіLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label парольLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdmin));
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.адміністраторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.адміністраторTableAdapter = new AdminGoITApp.myDataSetTableAdapters.АдміністраторTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.адміністраторBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.адміністраторBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.прізвищеTextBox = new System.Windows.Forms.TextBox();
            this.імяTextBox = new System.Windows.Forms.TextBox();
            this.побатьковіTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            прізвищеLabel = new System.Windows.Forms.Label();
            імяLabel = new System.Windows.Forms.Label();
            побатьковіLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingNavigator)).BeginInit();
            this.адміністраторBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // прізвищеLabel
            // 
            прізвищеLabel.AutoSize = true;
            прізвищеLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            прізвищеLabel.Location = new System.Drawing.Point(12, 47);
            прізвищеLabel.Name = "прізвищеLabel";
            прізвищеLabel.Size = new System.Drawing.Size(59, 13);
            прізвищеLabel.TabIndex = 3;
            прізвищеLabel.Text = "Прізвище:";
            // 
            // імяLabel
            // 
            імяLabel.AutoSize = true;
            імяLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            імяLabel.Location = new System.Drawing.Point(12, 73);
            імяLabel.Name = "імяLabel";
            імяLabel.Size = new System.Drawing.Size(27, 13);
            імяLabel.TabIndex = 5;
            імяLabel.Text = "Імя:";
            // 
            // побатьковіLabel
            // 
            побатьковіLabel.AutoSize = true;
            побатьковіLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            побатьковіLabel.Location = new System.Drawing.Point(12, 99);
            побатьковіLabel.Name = "побатьковіLabel";
            побатьковіLabel.Size = new System.Drawing.Size(67, 13);
            побатьковіLabel.TabIndex = 7;
            побатьковіLabel.Text = "Побатькові:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            телефонLabel.Location = new System.Drawing.Point(12, 125);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 9;
            телефонLabel.Text = "Телефон:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            парольLabel.Location = new System.Drawing.Point(12, 151);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(48, 13);
            парольLabel.TabIndex = 11;
            парольLabel.Text = "Пароль:";
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AdminGoITApp.myDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдміністраторTableAdapter = this.адміністраторTableAdapter;
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
            // адміністраторBindingNavigator
            // 
            this.адміністраторBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.адміністраторBindingNavigator.BindingSource = this.адміністраторBindingSource;
            this.адміністраторBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.адміністраторBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.адміністраторBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.адміністраторBindingNavigatorSaveItem});
            this.адміністраторBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.адміністраторBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.адміністраторBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.адміністраторBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.адміністраторBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.адміністраторBindingNavigator.Name = "адміністраторBindingNavigator";
            this.адміністраторBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.адміністраторBindingNavigator.Size = new System.Drawing.Size(315, 25);
            this.адміністраторBindingNavigator.TabIndex = 0;
            this.адміністраторBindingNavigator.Text = "bindingNavigator1";
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
            // адміністраторBindingNavigatorSaveItem
            // 
            this.адміністраторBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.адміністраторBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("адміністраторBindingNavigatorSaveItem.Image")));
            this.адміністраторBindingNavigatorSaveItem.Name = "адміністраторBindingNavigatorSaveItem";
            this.адміністраторBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.адміністраторBindingNavigatorSaveItem.Text = "Save Data";
            this.адміністраторBindingNavigatorSaveItem.Click += new System.EventHandler(this.адміністраторBindingNavigatorSaveItem_Click);
            // 
            // прізвищеTextBox
            // 
            this.прізвищеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.адміністраторBindingSource, "Прізвище", true));
            this.прізвищеTextBox.Location = new System.Drawing.Point(126, 44);
            this.прізвищеTextBox.Name = "прізвищеTextBox";
            this.прізвищеTextBox.Size = new System.Drawing.Size(152, 20);
            this.прізвищеTextBox.TabIndex = 4;
            // 
            // імяTextBox
            // 
            this.імяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.адміністраторBindingSource, "Імя", true));
            this.імяTextBox.Location = new System.Drawing.Point(126, 70);
            this.імяTextBox.Name = "імяTextBox";
            this.імяTextBox.Size = new System.Drawing.Size(152, 20);
            this.імяTextBox.TabIndex = 6;
            // 
            // побатьковіTextBox
            // 
            this.побатьковіTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.адміністраторBindingSource, "Побатькові", true));
            this.побатьковіTextBox.Location = new System.Drawing.Point(126, 96);
            this.побатьковіTextBox.Name = "побатьковіTextBox";
            this.побатьковіTextBox.Size = new System.Drawing.Size(152, 20);
            this.побатьковіTextBox.TabIndex = 8;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.адміністраторBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(126, 122);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(152, 20);
            this.телефонTextBox.TabIndex = 10;
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.адміністраторBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(126, 148);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(152, 20);
            this.парольTextBox.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 197);
            this.Controls.Add(прізвищеLabel);
            this.Controls.Add(this.прізвищеTextBox);
            this.Controls.Add(імяLabel);
            this.Controls.Add(this.імяTextBox);
            this.Controls.Add(побатьковіLabel);
            this.Controls.Add(this.побатьковіTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(this.адміністраторBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formAdmin";
            this.Text = "Адміністратори";
            this.Load += new System.EventHandler(this.formAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адміністраторBindingNavigator)).EndInit();
            this.адміністраторBindingNavigator.ResumeLayout(false);
            this.адміністраторBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource адміністраторBindingSource;
        private myDataSetTableAdapters.АдміністраторTableAdapter адміністраторTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator адміністраторBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton адміністраторBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox прізвищеTextBox;
        private System.Windows.Forms.TextBox імяTextBox;
        private System.Windows.Forms.TextBox побатьковіTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}