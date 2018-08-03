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
    public partial class FormSearchReservetion : Form
    {
        public FormSearchReservetion()
        {
            InitializeComponent();
        }

        private void бронювання_приміщенняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.бронювання_приміщенняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDataSet);

        }

        private void FormSearchReservetion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Захід' table. You can move, or remove it, as needed.
            this.західTableAdapter.Fill(this.myDataSet.Захід);
            // TODO: This line of code loads data into the 'myDataSet.Клієнт' table. You can move, or remove it, as needed.
            this.клієнтTableAdapter.Fill(this.myDataSet.Клієнт);
            // TODO: This line of code loads data into the 'myDataSet.Адміністратор' table. You can move, or remove it, as needed.
            this.адміністраторTableAdapter.Fill(this.myDataSet.Адміністратор);
            // TODO: This line of code loads data into the 'myDataSet.Приміщення' table. You can move, or remove it, as needed.
            this.приміщенняTableAdapter.Fill(this.myDataSet.Приміщення);
            // TODO: This line of code loads data into the 'myDataSet.Бронювання_приміщення' table. You can move, or remove it, as needed.
            this.бронювання_приміщенняTableAdapter.Fill(this.myDataSet.Бронювання_приміщення);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.бронювання_приміщенняBindingSource.RemoveFilter();

            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker1.Value.AddDays(1);
            TimeSpan ts = new TimeSpan(0, 0, 0);
            date1 = date1.Date + ts;
            date2 = date2.Date + ts;

            this.бронювання_приміщенняBindingSource.Filter = "Дата_запису_бронювання >=  '" + date1 + "' AND Дата_запису_бронювання <  '" + date2 + "'";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.бронювання_приміщенняBindingSource.RemoveFilter();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.бронювання_приміщенняBindingSource.RemoveFilter();

            DateTime date1 = dateTimePicker2.Value;
            DateTime date2 = dateTimePicker2.Value.AddDays(1);
            TimeSpan ts = new TimeSpan(0, 0, 0);
            date1 = date1.Date + ts;
            date2 = date2.Date + ts;

            this.бронювання_приміщенняBindingSource.Filter = "Дата_проведення_заходу >=  '" + date1 + "' AND Дата_проведення_заходу <  '" + date2 + "'";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.бронювання_приміщенняBindingSource.RemoveFilter();
        }
    }
}
