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
    public partial class formFurniture : Form
    {
        public formFurniture()
        {
            InitializeComponent();
        }

        private void гарнітурBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.гарнітурBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
        }

        private void formFurniture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Гарнітур' table. You can move, or remove it, as needed.
            this.гарнітурTableAdapter.Fill(this.myDataSet.Гарнітур);

        }
    }
}
