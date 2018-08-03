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
    public partial class formSearchPlanUseRooms : Form
    {
        public formSearchPlanUseRooms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker1.Value.AddDays(1);
            TimeSpan ts = new TimeSpan(0, 0, 0);
            date1 = date1.Date + ts;
            date2 = date2.Date + ts;
            this.графік_бронювань_приміщень_за_датоюTableAdapter.Fill(this.myDataSet.Графік_бронювань_приміщень_за_датою, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(date1, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(date2, typeof(System.DateTime))))));

            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 24;
            chart1.Series["s"].XValueMember = "Номер";
            chart1.Series["s"].YValueMembers = "Час_початку";
            chart1.Series["s2"].XValueMember = "Номер"; 
            chart1.Series["s2"].YValueMembers = "Тривалість_годин";

            chart1.DataBind();

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form formReservetionRoom1 = new formReservetionRoom();
            formReservetionRoom1.ShowDialog();
        }
    }
}
