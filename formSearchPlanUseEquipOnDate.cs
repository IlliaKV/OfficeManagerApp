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
    public partial class formSearchPlanUseEquipOnDate : Form
    {
        public formSearchPlanUseEquipOnDate()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        { 

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker1.Value.AddDays(1);
            TimeSpan ts = new TimeSpan(0, 0, 0);
            date1 = date1.Date + ts;
            date2 = date2.Date + ts;
            this.розклад_викор_облTableAdapter.Fill(this.myDataSet.розклад_викор_обл, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(date1, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(date2, typeof(System.DateTime))))));
            this.розклад_викор_гарнTableAdapter.Fill(this.myDataSet.розклад_викор_гарн, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(date1, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(date2, typeof(System.DateTime))))));

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }
    }
}
