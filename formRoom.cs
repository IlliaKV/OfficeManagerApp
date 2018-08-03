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
    public partial class formRoom : Form
    {
        public formRoom()
        {
            InitializeComponent();
        }

        private void приміщенняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.приміщенняBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
        }

        private void formRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Приміщення' table. You can move, or remove it, as needed.
            this.приміщенняTableAdapter.Fill(this.myDataSet.Приміщення);

        }
    }
}
