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
    public partial class formReportUseFurniture : Form
    {
        public formReportUseFurniture()
        {
            InitializeComponent();
        }

        private void formReportUseFurniture_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Звіт_обраних_гарнітур_за_датоюTableAdapter.Fill(this.myDataSet.Звіт_обраних_гарнітур_за_датою, dateTimePicker1.Value, dateTimePicker2.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
