using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGoITApp
{
    public partial class FormContractor : Form
    {
        public FormContractor()
        {
            InitializeComponent();
        }

        private void підрядникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.підрядникBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }

        }

        private void FormContractor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Юридична_особа' table. You can move, or remove it, as needed.
            this.юридична_особаTableAdapter.Fill(this.myDataSet.Юридична_особа);
            // TODO: This line of code loads data into the 'myDataSet.Фізична_особа' table. You can move, or remove it, as needed.
            this.фізична_особаTableAdapter.Fill(this.myDataSet.Фізична_особа);
            // TODO: This line of code loads data into the 'myDataSet.Підрядник' table. You can move, or remove it, as needed.
            this.підрядникTableAdapter.Fill(this.myDataSet.Підрядник);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.фізична_особаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.юридична_особаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Юридична_особа' table. You can move, or remove it, as needed.
            this.юридична_особаTableAdapter.Fill(this.myDataSet.Юридична_особа);
            // TODO: This line of code loads data into the 'myDataSet.Фізична_особа' table. You can move, or remove it, as needed.
            this.фізична_особаTableAdapter.Fill(this.myDataSet.Фізична_особа);
            // TODO: This line of code loads data into the 'myDataSet.Підрядник' table. You can move, or remove it, as needed.
            this.підрядникTableAdapter.Fill(this.myDataSet.Підрядник);
        }
    }
}
