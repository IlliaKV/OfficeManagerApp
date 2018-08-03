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
    public partial class formEquipment : Form
    {
        public formEquipment()
        {
            InitializeComponent();
        }

        private void обладнанняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.обладнанняBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
        }

        private void formEquipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Обладнання' table. You can move, or remove it, as needed.
            this.обладнанняTableAdapter.Fill(this.myDataSet.Обладнання);

        }
    }
}
