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
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void адміністраторBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.адміністраторBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }

        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Адміністратор' table. You can move, or remove it, as needed.
            this.адміністраторTableAdapter.Fill(this.myDataSet.Адміністратор);

        }
    }
}
