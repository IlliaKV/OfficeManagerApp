namespace AdminGoITApp
{
    partial class formKlient
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
            System.Windows.Forms.Label пІБLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label електронна_адресаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKlient));
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.клієнтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клієнтTableAdapter = new AdminGoITApp.myDataSetTableAdapters.КлієнтTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.клієнтBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.клієнтBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.пІБTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.електронна_адресаTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            пІБLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            електронна_адресаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingNavigator)).BeginInit();
            this.клієнтBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБLabel
            // 
            пІБLabel.AutoSize = true;
            пІБLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            пІБLabel.Location = new System.Drawing.Point(12, 42);
            пІБLabel.Name = "пІБLabel";
            пІБLabel.Size = new System.Drawing.Size(28, 13);
            пІБLabel.TabIndex = 3;
            пІБLabel.Text = "ПІБ:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            телефонLabel.Location = new System.Drawing.Point(12, 68);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 5;
            телефонLabel.Text = "Телефон:";
            // 
            // електронна_адресаLabel
            // 
            електронна_адресаLabel.AutoSize = true;
            електронна_адресаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            електронна_адресаLabel.Location = new System.Drawing.Point(12, 94);
            електронна_адресаLabel.Name = "електронна_адресаLabel";
            електронна_адресаLabel.Size = new System.Drawing.Size(109, 13);
            електронна_адресаLabel.TabIndex = 7;
            електронна_адресаLabel.Text = "Електронна адреса:";
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.КлієнтTableAdapter = this.клієнтTableAdapter;
            this.tableAdapterManager.ОбладнанняTableAdapter = null;
            this.tableAdapterManager.ПідрядникTableAdapter = null;
            this.tableAdapterManager.ПриміщенняTableAdapter = null;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Фізична_особаTableAdapter = null;
            this.tableAdapterManager.Юридична_особаTableAdapter = null;
            // 
            // клієнтBindingNavigator
            // 
            this.клієнтBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.клієнтBindingNavigator.BindingSource = this.клієнтBindingSource;
            this.клієнтBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.клієнтBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.клієнтBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.клієнтBindingNavigatorSaveItem});
            this.клієнтBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клієнтBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.клієнтBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.клієнтBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.клієнтBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.клієнтBindingNavigator.Name = "клієнтBindingNavigator";
            this.клієнтBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.клієнтBindingNavigator.Size = new System.Drawing.Size(475, 25);
            this.клієнтBindingNavigator.TabIndex = 0;
            this.клієнтBindingNavigator.Text = "bindingNavigator1";
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
            // клієнтBindingNavigatorSaveItem
            // 
            this.клієнтBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клієнтBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клієнтBindingNavigatorSaveItem.Image")));
            this.клієнтBindingNavigatorSaveItem.Name = "клієнтBindingNavigatorSaveItem";
            this.клієнтBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.клієнтBindingNavigatorSaveItem.Text = "Save Data";
            this.клієнтBindingNavigatorSaveItem.Click += new System.EventHandler(this.клієнтBindingNavigatorSaveItem_Click);
            // 
            // пІБTextBox
            // 
            this.пІБTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клієнтBindingSource, "ПІБ", true));
            this.пІБTextBox.Location = new System.Drawing.Point(127, 39);
            this.пІБTextBox.Name = "пІБTextBox";
            this.пІБTextBox.Size = new System.Drawing.Size(304, 20);
            this.пІБTextBox.TabIndex = 4;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клієнтBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(127, 65);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(304, 20);
            this.телефонTextBox.TabIndex = 6;
            // 
            // електронна_адресаTextBox
            // 
            this.електронна_адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клієнтBindingSource, "Електронна_адреса", true));
            this.електронна_адресаTextBox.Location = new System.Drawing.Point(127, 91);
            this.електронна_адресаTextBox.Name = "електронна_адресаTextBox";
            this.електронна_адресаTextBox.Size = new System.Drawing.Size(304, 20);
            this.електронна_адресаTextBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // formKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 143);
            this.Controls.Add(пІБLabel);
            this.Controls.Add(this.пІБTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(електронна_адресаLabel);
            this.Controls.Add(this.електронна_адресаTextBox);
            this.Controls.Add(this.клієнтBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formKlient";
            this.Text = "Клієнти";
            this.Load += new System.EventHandler(this.formKlient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingNavigator)).EndInit();
            this.клієнтBindingNavigator.ResumeLayout(false);
            this.клієнтBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource клієнтBindingSource;
        private myDataSetTableAdapters.КлієнтTableAdapter клієнтTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клієнтBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton клієнтBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox пІБTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox електронна_адресаTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}