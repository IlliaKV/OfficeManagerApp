namespace AdminGoITApp
{
    partial class formEquipment
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
            System.Windows.Forms.Label типLabel;
            System.Windows.Forms.Label операційна_системаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEquipment));
            this.myDataSet = new AdminGoITApp.myDataSet();
            this.обладнанняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.обладнанняTableAdapter = new AdminGoITApp.myDataSetTableAdapters.ОбладнанняTableAdapter();
            this.tableAdapterManager = new AdminGoITApp.myDataSetTableAdapters.TableAdapterManager();
            this.обладнанняBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.обладнанняBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.номерTextBox = new System.Windows.Forms.TextBox();
            this.типTextBox = new System.Windows.Forms.TextBox();
            this.операційна_системаTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            назваLabel = new System.Windows.Forms.Label();
            номерLabel = new System.Windows.Forms.Label();
            типLabel = new System.Windows.Forms.Label();
            операційна_системаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обладнанняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обладнанняBindingNavigator)).BeginInit();
            this.обладнанняBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // назваLabel
            // 
            назваLabel.AutoSize = true;
            назваLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            назваLabel.Location = new System.Drawing.Point(9, 47);
            назваLabel.Name = "назваLabel";
            назваLabel.Size = new System.Drawing.Size(42, 13);
            назваLabel.TabIndex = 3;
            назваLabel.Text = "Назва:";
            // 
            // номерLabel
            // 
            номерLabel.AutoSize = true;
            номерLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            номерLabel.Location = new System.Drawing.Point(9, 73);
            номерLabel.Name = "номерLabel";
            номерLabel.Size = new System.Drawing.Size(44, 13);
            номерLabel.TabIndex = 5;
            номерLabel.Text = "Номер:";
            // 
            // типLabel
            // 
            типLabel.AutoSize = true;
            типLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            типLabel.Location = new System.Drawing.Point(9, 99);
            типLabel.Name = "типLabel";
            типLabel.Size = new System.Drawing.Size(29, 13);
            типLabel.TabIndex = 7;
            типLabel.Text = "Тип:";
            // 
            // операційна_системаLabel
            // 
            операційна_системаLabel.AutoSize = true;
            операційна_системаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            операційна_системаLabel.Location = new System.Drawing.Point(9, 125);
            операційна_системаLabel.Name = "операційна_системаLabel";
            операційна_системаLabel.Size = new System.Drawing.Size(114, 13);
            операційна_системаLabel.TabIndex = 9;
            операційна_системаLabel.Text = "Операційна система:";
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // обладнанняBindingSource
            // 
            this.обладнанняBindingSource.DataMember = "Обладнання";
            this.обладнанняBindingSource.DataSource = this.myDataSet;
            // 
            // обладнанняTableAdapter
            // 
            this.обладнанняTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ОбладнанняTableAdapter = this.обладнанняTableAdapter;
            this.tableAdapterManager.ПідрядникTableAdapter = null;
            this.tableAdapterManager.ПриміщенняTableAdapter = null;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Фізична_особаTableAdapter = null;
            this.tableAdapterManager.Юридична_особаTableAdapter = null;
            // 
            // обладнанняBindingNavigator
            // 
            this.обладнанняBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.обладнанняBindingNavigator.BindingSource = this.обладнанняBindingSource;
            this.обладнанняBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.обладнанняBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.обладнанняBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.обладнанняBindingNavigatorSaveItem});
            this.обладнанняBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.обладнанняBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.обладнанняBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.обладнанняBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.обладнанняBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.обладнанняBindingNavigator.Name = "обладнанняBindingNavigator";
            this.обладнанняBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.обладнанняBindingNavigator.Size = new System.Drawing.Size(299, 25);
            this.обладнанняBindingNavigator.TabIndex = 0;
            this.обладнанняBindingNavigator.Text = "bindingNavigator1";
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
            // обладнанняBindingNavigatorSaveItem
            // 
            this.обладнанняBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.обладнанняBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("обладнанняBindingNavigatorSaveItem.Image")));
            this.обладнанняBindingNavigatorSaveItem.Name = "обладнанняBindingNavigatorSaveItem";
            this.обладнанняBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.обладнанняBindingNavigatorSaveItem.Text = "Save Data";
            this.обладнанняBindingNavigatorSaveItem.Click += new System.EventHandler(this.обладнанняBindingNavigatorSaveItem_Click);
            // 
            // назваTextBox
            // 
            this.назваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обладнанняBindingSource, "Назва", true));
            this.назваTextBox.Location = new System.Drawing.Point(129, 44);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.Size = new System.Drawing.Size(149, 20);
            this.назваTextBox.TabIndex = 4;
            // 
            // номерTextBox
            // 
            this.номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обладнанняBindingSource, "Номер", true));
            this.номерTextBox.Location = new System.Drawing.Point(129, 70);
            this.номерTextBox.Name = "номерTextBox";
            this.номерTextBox.Size = new System.Drawing.Size(149, 20);
            this.номерTextBox.TabIndex = 6;
            // 
            // типTextBox
            // 
            this.типTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обладнанняBindingSource, "Тип", true));
            this.типTextBox.Location = new System.Drawing.Point(129, 96);
            this.типTextBox.Name = "типTextBox";
            this.типTextBox.Size = new System.Drawing.Size(149, 20);
            this.типTextBox.TabIndex = 8;
            // 
            // операційна_системаTextBox
            // 
            this.операційна_системаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обладнанняBindingSource, "Операційна_система", true));
            this.операційна_системаTextBox.Location = new System.Drawing.Point(129, 122);
            this.операційна_системаTextBox.Name = "операційна_системаTextBox";
            this.операційна_системаTextBox.Size = new System.Drawing.Size(149, 20);
            this.операційна_системаTextBox.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminGoITApp.Properties.Resources.ga_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // formEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 159);
            this.Controls.Add(назваLabel);
            this.Controls.Add(this.назваTextBox);
            this.Controls.Add(номерLabel);
            this.Controls.Add(this.номерTextBox);
            this.Controls.Add(типLabel);
            this.Controls.Add(this.типTextBox);
            this.Controls.Add(операційна_системаLabel);
            this.Controls.Add(this.операційна_системаTextBox);
            this.Controls.Add(this.обладнанняBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formEquipment";
            this.Text = "Обладнання";
            this.Load += new System.EventHandler(this.formEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обладнанняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обладнанняBindingNavigator)).EndInit();
            this.обладнанняBindingNavigator.ResumeLayout(false);
            this.обладнанняBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource обладнанняBindingSource;
        private myDataSetTableAdapters.ОбладнанняTableAdapter обладнанняTableAdapter;
        private myDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator обладнанняBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton обладнанняBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.TextBox номерTextBox;
        private System.Windows.Forms.TextBox типTextBox;
        private System.Windows.Forms.TextBox операційна_системаTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}