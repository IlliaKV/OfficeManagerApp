namespace AdminGoITApp
{
    partial class formFurniture
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
            System.Windows.Forms.Label номерLabel;
            System.Windows.Forms.Label колірLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFurniture));
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.гарнітурBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гарнітурTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ГарнітурTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.гарнітурBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.гарнітурBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.номерTextBox = new System.Windows.Forms.TextBox();
            this.колірTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            назваLabel = new System.Windows.Forms.Label();
            номерLabel = new System.Windows.Forms.Label();
            колірLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гарнітурBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гарнітурBindingNavigator)).BeginInit();
            this.гарнітурBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // назваLabel
            // 
            назваLabel.AutoSize = true;
            назваLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            назваLabel.Location = new System.Drawing.Point(12, 37);
            назваLabel.Name = "назваLabel";
            назваLabel.Size = new System.Drawing.Size(42, 13);
            назваLabel.TabIndex = 3;
            назваLabel.Text = "Назва:";
            // 
            // номерLabel
            // 
            номерLabel.AutoSize = true;
            номерLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            номерLabel.Location = new System.Drawing.Point(12, 63);
            номерLabel.Name = "номерLabel";
            номерLabel.Size = new System.Drawing.Size(44, 13);
            номерLabel.TabIndex = 5;
            номерLabel.Text = "Номер:";
            // 
            // колірLabel
            // 
            колірLabel.AutoSize = true;
            колірLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            колірLabel.Location = new System.Drawing.Point(12, 89);
            колірLabel.Name = "колірLabel";
            колірLabel.Size = new System.Drawing.Size(37, 13);
            колірLabel.TabIndex = 7;
            колірLabel.Text = "Колір:";
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // гарнітурBindingSource
            // 
            this.гарнітурBindingSource.DataMember = "Гарнітур";
            this.гарнітурBindingSource.DataSource = this.myDataSet;
            // 
            // гарнітурTableAdapter
            // 
            this.гарнітурTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ГарнітурTableAdapter = this.гарнітурTableAdapter;
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
            // гарнітурBindingNavigator
            // 
            this.гарнітурBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.гарнітурBindingNavigator.BindingSource = this.гарнітурBindingSource;
            this.гарнітурBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.гарнітурBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.гарнітурBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.гарнітурBindingNavigatorSaveItem});
            this.гарнітурBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.гарнітурBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.гарнітурBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.гарнітурBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.гарнітурBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.гарнітурBindingNavigator.Name = "гарнітурBindingNavigator";
            this.гарнітурBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.гарнітурBindingNavigator.Size = new System.Drawing.Size(302, 25);
            this.гарнітурBindingNavigator.TabIndex = 0;
            this.гарнітурBindingNavigator.Text = "bindingNavigator1";
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
            // гарнітурBindingNavigatorSaveItem
            // 
            this.гарнітурBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.гарнітурBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("гарнітурBindingNavigatorSaveItem.Image")));
            this.гарнітурBindingNavigatorSaveItem.Name = "гарнітурBindingNavigatorSaveItem";
            this.гарнітурBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.гарнітурBindingNavigatorSaveItem.Text = "Save Data";
            this.гарнітурBindingNavigatorSaveItem.Click += new System.EventHandler(this.гарнітурBindingNavigatorSaveItem_Click);
            // 
            // назваTextBox
            // 
            this.назваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гарнітурBindingSource, "Назва", true));
            this.назваTextBox.Location = new System.Drawing.Point(91, 34);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.Size = new System.Drawing.Size(100, 20);
            this.назваTextBox.TabIndex = 4;
            // 
            // номерTextBox
            // 
            this.номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гарнітурBindingSource, "Номер", true));
            this.номерTextBox.Location = new System.Drawing.Point(91, 60);
            this.номерTextBox.Name = "номерTextBox";
            this.номерTextBox.Size = new System.Drawing.Size(100, 20);
            this.номерTextBox.TabIndex = 6;
            // 
            // колірTextBox
            // 
            this.колірTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гарнітурBindingSource, "Колір", true));
            this.колірTextBox.Location = new System.Drawing.Point(91, 86);
            this.колірTextBox.Name = "колірTextBox";
            this.колірTextBox.Size = new System.Drawing.Size(100, 20);
            this.колірTextBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // formFurniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 126);
            this.Controls.Add(назваLabel);
            this.Controls.Add(this.назваTextBox);
            this.Controls.Add(номерLabel);
            this.Controls.Add(this.номерTextBox);
            this.Controls.Add(колірLabel);
            this.Controls.Add(this.колірTextBox);
            this.Controls.Add(this.гарнітурBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formFurniture";
            this.Text = "Гарнітур";
            this.Load += new System.EventHandler(this.formFurniture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гарнітурBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гарнітурBindingNavigator)).EndInit();
            this.гарнітурBindingNavigator.ResumeLayout(false);
            this.гарнітурBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource гарнітурBindingSource;
        private myDataSetTableAdapters.ГарнітурTableAdapter гарнітурTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator гарнітурBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton гарнітурBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.TextBox номерTextBox;
        private System.Windows.Forms.TextBox колірTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}