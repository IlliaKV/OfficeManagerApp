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
    public partial class formPlaningStateForWeek : Form
    {
        public formPlaningStateForWeek()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.графік_роботи_персоналу_на_тижденьTableAdapter.Fill(this.myDataSet.Графік_роботи_персоналу_на_тиждень, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1.Text, typeof(int))))), comboBox2.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox3.Text, typeof(int))))));

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка пошуку!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
