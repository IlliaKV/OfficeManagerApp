namespace AdminGoITApp
{
    partial class formRoom
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
            System.Windows.Forms.Label номерLabel;
            System.Windows.Forms.Label назваLabel;
            System.Windows.Forms.Label площаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRoom));
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.приміщенняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приміщенняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ПриміщенняTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.приміщенняBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.приміщенняBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номерTextBox = new System.Windows.Forms.TextBox();
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.площаTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            номерLabel = new System.Windows.Forms.Label();
            назваLabel = new System.Windows.Forms.Label();
            площаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приміщенняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приміщенняBindingNavigator)).BeginInit();
            this.приміщенняBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // номерLabel
            // 
            номерLabel.AutoSize = true;
            номерLabel.Location = new System.Drawing.Point(12, 42);
            номерLabel.Name = "номерLabel";
            номерLabel.Size = new System.Drawing.Size(44, 13);
            номерLabel.TabIndex = 3;
            номерLabel.Text = "Номер:";
            // 
            // назваLabel
            // 
            назваLabel.AutoSize = true;
            назваLabel.Location = new System.Drawing.Point(12, 68);
            назваLabel.Name = "назваLabel";
            назваLabel.Size = new System.Drawing.Size(42, 13);
            назваLabel.TabIndex = 5;
            назваLabel.Text = "Назва:";
            // 
            // площаLabel
            // 
            площаLabel.AutoSize = true;
            площаLabel.Location = new System.Drawing.Point(12, 94);
            площаLabel.Name = "площаLabel";
            площаLabel.Size = new System.Drawing.Size(45, 13);
            площаLabel.TabIndex = 7;
            площаLabel.Text = "Площа:";
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.ПідрядникTableAdapter = null;
            this.tableAdapterManager.ПриміщенняTableAdapter = this.приміщенняTableAdapter;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Фізична_особаTableAdapter = null;
            this.tableAdapterManager.Юридична_особаTableAdapter = null;
            // 
            // приміщенняBindingNavigator
            // 
            this.приміщенняBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.приміщенняBindingNavigator.BindingSource = this.приміщенняBindingSource;
            this.приміщенняBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.приміщенняBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.приміщенняBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.приміщенняBindingNavigatorSaveItem});
            this.приміщенняBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.приміщенняBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.приміщенняBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.приміщенняBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.приміщенняBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.приміщенняBindingNavigator.Name = "приміщенняBindingNavigator";
            this.приміщенняBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.приміщенняBindingNavigator.Size = new System.Drawing.Size(299, 25);
            this.приміщенняBindingNavigator.TabIndex = 0;
            this.приміщенняBindingNavigator.Text = "bindingNavigator1";
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
            // приміщенняBindingNavigatorSaveItem
            // 
            this.приміщенняBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.приміщенняBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("приміщенняBindingNavigatorSaveItem.Image")));
            this.приміщенняBindingNavigatorSaveItem.Name = "приміщенняBindingNavigatorSaveItem";
            this.приміщенняBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.приміщенняBindingNavigatorSaveItem.Text = "Save Data";
            this.приміщенняBindingNavigatorSaveItem.Click += new System.EventHandler(this.приміщенняBindingNavigatorSaveItem_Click);
            // 
            // номерTextBox
            // 
            this.номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приміщенняBindingSource, "Номер", true));
            this.номерTextBox.Location = new System.Drawing.Point(111, 39);
            this.номерTextBox.Name = "номерTextBox";
            this.номерTextBox.Size = new System.Drawing.Size(161, 20);
            this.номерTextBox.TabIndex = 4;
            // 
            // назваTextBox
            // 
            this.назваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приміщенняBindingSource, "Назва", true));
            this.назваTextBox.Location = new System.Drawing.Point(111, 65);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.Size = new System.Drawing.Size(161, 20);
            this.назваTextBox.TabIndex = 6;
            // 
            // площаTextBox
            // 
            this.площаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приміщенняBindingSource, "Площа", true));
            this.площаTextBox.Location = new System.Drawing.Point(111, 91);
            this.площаTextBox.Name = "площаTextBox";
            this.площаTextBox.Size = new System.Drawing.Size(161, 20);
            this.площаTextBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // formRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(299, 132);
            this.Controls.Add(номерLabel);
            this.Controls.Add(this.номерTextBox);
            this.Controls.Add(назваLabel);
            this.Controls.Add(this.назваTextBox);
            this.Controls.Add(площаLabel);
            this.Controls.Add(this.площаTextBox);
            this.Controls.Add(this.приміщенняBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formRoom";
            this.Text = "Приміщення";
            this.Load += new System.EventHandler(this.formRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приміщенняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приміщенняBindingNavigator)).EndInit();
            this.приміщенняBindingNavigator.ResumeLayout(false);
            this.приміщенняBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource приміщенняBindingSource;
        private myDataSetTableAdapters.ПриміщенняTableAdapter приміщенняTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator приміщенняBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton приміщенняBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номерTextBox;
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.TextBox площаTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}