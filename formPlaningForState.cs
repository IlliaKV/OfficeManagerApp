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
    public partial class formPlaningForState : Form
    {
        public formPlaningForState()
        {
            InitializeComponent();
        }

        private void графік_роботи_персоналуBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.графік_роботи_персоналуBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!", "Повідомлення:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formPlaningForState_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Адміністратор' table. You can move, or remove it, as needed.
            this.адміністраторTableAdapter.Fill(this.myDataSet.Адміністратор);
            // TODO: This line of code loads data into the 'myDataSet.Графік_роботи_персоналу' table. You can move, or remove it, as needed.
            this.графік_роботи_персоналуTableAdapter.Fill(this.myDataSet.Графік_роботи_персоналу);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new formPlaningStateForWeek().ShowDialog();
        }
    }
}
