using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGoITApp
{
    public partial class formSearchContractor : Form
    {
        public formSearchContractor()
        {
            InitializeComponent();
        }

        private void підрядникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.підрядникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDataSet);

        }

        private void formSearchContractor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Адміністратор' table. You can move, or remove it, as needed.
            this.адміністраторTableAdapter.Fill(this.myDataSet.Адміністратор);
            // TODO: This line of code loads data into the 'myDataSet.Рахунок_фактура' table. You can move, or remove it, as needed.
            this.рахунок_фактураTableAdapter.Fill(this.myDataSet.Рахунок_фактура);
            // TODO: This line of code loads data into the 'myDataSet.Юридична_особа' table. You can move, or remove it, as needed.
            this.юридична_особаTableAdapter.Fill(this.myDataSet.Юридична_особа);
            // TODO: This line of code loads data into the 'myDataSet.Фізична_особа' table. You can move, or remove it, as needed.
            this.фізична_особаTableAdapter.Fill(this.myDataSet.Фізична_особа);
            // TODO: This line of code loads data into the 'myDataSet.Підрядник' table. You can move, or remove it, as needed.
            this.підрядникTableAdapter.Fill(this.myDataSet.Підрядник);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemFound = this.підрядникBindingSource.Find("індифікаційний_код", textBox1.Text);

            this.підрядникBindingSource.Position = itemFound;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int itemFound = this.підрядникBindingSource.Find("Назва", код_підрядникаComboBox.Text);

            this.підрядникBindingSource.Position = itemFound;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
