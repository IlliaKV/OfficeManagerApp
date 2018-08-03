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
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }

        private void рахунок_фактураBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.рахунок_фактураBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }

        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Адміністратор' table. You can move, or remove it, as needed.
            this.адміністраторTableAdapter.Fill(this.myDataSet.Адміністратор);
            // TODO: This line of code loads data into the 'myDataSet.Підрядник' table. You can move, or remove it, as needed.
            this.підрядникTableAdapter.Fill(this.myDataSet.Підрядник);
            // TODO: This line of code loads data into the 'myDataSet.Рядок_рахунок_фактура' table. You can move, or remove it, as needed.
            this.рядок_рахунок_фактураTableAdapter.Fill(this.myDataSet.Рядок_рахунок_фактура);
            // TODO: This line of code loads data into the 'myDataSet.Рахунок_фактура' table. You can move, or remove it, as needed.
            this.рахунок_фактураTableAdapter.Fill(this.myDataSet.Рахунок_фактура);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormContractor().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new formAdmin().ShowDialog();
        }

        private void рядок_рахунок_фактураBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.рядок_рахунок_фактураBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
        }

        private void датаDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Адміністратор' table. You can move, or remove it, as needed.
            this.адміністраторTableAdapter.Fill(this.myDataSet.Адміністратор);
            // TODO: This line of code loads data into the 'myDataSet.Підрядник' table. You can move, or remove it, as needed.
            this.підрядникTableAdapter.Fill(this.myDataSet.Підрядник);
            // TODO: This line of code loads data into the 'myDataSet.Рядок_рахунок_фактура' table. You can move, or remove it, as needed.
            this.рядок_рахунок_фактураTableAdapter.Fill(this.myDataSet.Рядок_рахунок_фактура);
            // TODO: This line of code loads data into the 'myDataSet.Рахунок_фактура' table. You can move, or remove it, as needed.
            this.рахунок_фактураTableAdapter.Fill(this.myDataSet.Рахунок_фактура);
        }

        private void рядок_рахунок_фактураBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.рядок_рахунок_фактураBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
