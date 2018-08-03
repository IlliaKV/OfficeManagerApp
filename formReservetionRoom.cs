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
    public partial class formReservetionRoom : Form
    {
        public int key = 0;
        public formReservetionRoom()
        {
            InitializeComponent();
        }

        private void бронювання_приміщенняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void formReservetionRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Обладнання' table. You can move, or remove it, as needed.
            this.обладнанняTableAdapter.Fill(this.myDataSet.Обладнання);
            // TODO: This line of code loads data into the 'myDataSet.Гарнітур' table. You can move, or remove it, as needed.
            this.гарнітурTableAdapter.Fill(this.myDataSet.Гарнітур);
            // TODO: This line of code loads data into the 'myDataSet.Використання_обладнання_Обладнання' table. You can move, or remove it, as needed.
            this.використання_обладнання_ОбладнанняTableAdapter.Fill(this.myDataSet.Використання_обладнання_Обладнання);
            // TODO: This line of code loads data into the 'myDataSet.Використання_обладнання_Гарнітур' table. You can move, or remove it, as needed.
            this.використання_обладнання_ГарнітурTableAdapter.Fill(this.myDataSet.Використання_обладнання_Гарнітур);
            // TODO: This line of code loads data into the 'myDataSet.Використання_обладнання' table. You can move, or remove it, as needed.
            this.використання_обладнанняTableAdapter.Fill(this.myDataSet.Використання_обладнання);
            // TODO: This line of code loads data into the 'myDataSet.Приміщення' table. You can move, or remove it, as needed.
            this.приміщенняTableAdapter.Fill(this.myDataSet.Приміщення);
            // TODO: This line of code loads data into the 'myDataSet.Захід' table. You can move, or remove it, as needed.
            this.західTableAdapter.Fill(this.myDataSet.Захід);
            // TODO: This line of code loads data into the 'myDataSet.Клієнт' table. You can move, or remove it, as needed.
            this.клієнтTableAdapter.Fill(this.myDataSet.Клієнт);
            // TODO: This line of code loads data into the 'myDataSet.Приміщення' table. You can move, or remove it, as needed.
            this.приміщенняTableAdapter.Fill(this.myDataSet.Приміщення);
            // TODO: This line of code loads data into the 'myDataSet.Адміністратор' table. You can move, or remove it, as needed.
            this.адміністраторTableAdapter.Fill(this.myDataSet.Адміністратор);
            // TODO: This line of code loads data into the 'myDataSet.Бронювання_приміщення' table. You can move, or remove it, as needed.
            this.бронювання_приміщенняTableAdapter.Fill(this.myDataSet.Бронювання_приміщення);

            this.перегляд_обраного_гарнітурTableAdapter.Fill(this.myDataSet.Перегляд_обраного_гарнітур, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
            this.перегляд_обраного_обладнанняTableAdapter.Fill(this.myDataSet.Перегляд_обраного_обладнання, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formRoom().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new formAdmin().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new formKlient().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new formEvent().ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {


        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton23_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.бронювання_приміщенняBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
        }

        private void toolStripButton29_Click(object sender, EventArgs e)
        {
            

            // TODO: This line of code loads data into the 'myDataSet.Обладнання' table. You can move, or remove it, as needed.
            this.обладнанняTableAdapter.Fill(this.myDataSet.Обладнання);
            // TODO: This line of code loads data into the 'myDataSet.Гарнітур' table. You can move, or remove it, as needed.
            this.гарнітурTableAdapter.Fill(this.myDataSet.Гарнітур);
            // TODO: This line of code loads data into the 'myDataSet.Використання_обладнання_Обладнання' table. You can move, or remove it, as needed.
            this.використання_обладнання_ОбладнанняTableAdapter.Fill(this.myDataSet.Використання_обладнання_Обладнання);
            // TODO: This line of code loads data into the 'myDataSet.Використання_обладнання_Гарнітур' table. You can move, or remove it, as needed.
            this.використання_обладнання_ГарнітурTableAdapter.Fill(this.myDataSet.Використання_обладнання_Гарнітур);
            // TODO: This line of code loads data into the 'myDataSet.Використання_обладнання' table. You can move, or remove it, as needed.
            this.використання_обладнанняTableAdapter.Fill(this.myDataSet.Використання_обладнання);
            // TODO: This line of code loads data into the 'myDataSet.Приміщення' table. You can move, or remove it, as needed.
            this.приміщенняTableAdapter.Fill(this.myDataSet.Приміщення);
            // TODO: This line of code loads data into the 'myDataSet.Захід' table. You can move, or remove it, as needed.
            this.західTableAdapter.Fill(this.myDataSet.Захід);
            // TODO: This line of code loads data into the 'myDataSet.Клієнт' table. You can move, or remove it, as needed.
            this.клієнтTableAdapter.Fill(this.myDataSet.Клієнт);
            // TODO: This line of code loads data into the 'myDataSet.Приміщення' table. You can move, or remove it, as needed.
            this.приміщенняTableAdapter.Fill(this.myDataSet.Приміщення);
            // TODO: This line of code loads data into the 'myDataSet.Адміністратор' table. You can move, or remove it, as needed.
            this.адміністраторTableAdapter.Fill(this.myDataSet.Адміністратор);
            // TODO: This line of code loads data into the 'myDataSet.Бронювання_приміщення' table. You can move, or remove it, as needed.
            this.бронювання_приміщенняTableAdapter.Fill(this.myDataSet.Бронювання_приміщення);

            this.перегляд_обраного_гарнітурTableAdapter.Fill(this.myDataSet.Перегляд_обраного_гарнітур, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
            this.перегляд_обраного_обладнанняTableAdapter.Fill(this.myDataSet.Перегляд_обраного_обладнання, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));

        }

        private void bindingNavigator6_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void toolStripButton24_Click(object sender, EventArgs e)
        {
            this.перегляд_обраного_гарнітурTableAdapter.Fill(this.myDataSet.Перегляд_обраного_гарнітур, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
            this.перегляд_обраного_обладнанняTableAdapter.Fill(this.myDataSet.Перегляд_обраного_обладнання, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));

        }

        private void toolStripButton25_Click(object sender, EventArgs e)
        {
            this.перегляд_обраного_гарнітурTableAdapter.Fill(this.myDataSet.Перегляд_обраного_гарнітур, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
            this.перегляд_обраного_обладнанняTableAdapter.Fill(this.myDataSet.Перегляд_обраного_обладнання, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));

        }

        private void toolStripButton26_Click(object sender, EventArgs e)
        {
            this.перегляд_обраного_гарнітурTableAdapter.Fill(this.myDataSet.Перегляд_обраного_гарнітур, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
            this.перегляд_обраного_обладнанняTableAdapter.Fill(this.myDataSet.Перегляд_обраного_обладнання, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));

        }

        private void toolStripButton27_Click(object sender, EventArgs e)
        {
            this.перегляд_обраного_гарнітурTableAdapter.Fill(this.myDataSet.Перегляд_обраного_гарнітур, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
            this.перегляд_обраного_обладнанняTableAdapter.Fill(this.myDataSet.Перегляд_обраного_обладнання, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));

        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.використання_обладнання_ГарнітурBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
            this.перегляд_обраного_гарнітурTableAdapter.Fill(this.myDataSet.Перегляд_обраного_гарнітур, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
            this.перегляд_обраного_обладнанняTableAdapter.Fill(this.myDataSet.Перегляд_обраного_обладнання, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
        }

        private void toolStripButton14_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.використання_обладнанняBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
        }

        private void toolStripButton23_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.використання_обладнання_ОбладнанняBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                MessageBox.Show("Збережено!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка збереження!");
            }
            this.перегляд_обраного_гарнітурTableAdapter.Fill(this.myDataSet.Перегляд_обраного_гарнітур, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
            this.перегляд_обраного_обладнанняTableAdapter.Fill(this.myDataSet.Перегляд_обраного_обладнання, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
         

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.підрахунок_кількість_гарнітурTableAdapter.Fill(this.myDataSet.підрахунок_кількість_гарнітур, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));
                this.підрахунок_кількість_обладнанняTableAdapter.Fill(this.myDataSet.підрахунок_кількість_обладнання, ((int)(System.Convert.ChangeType(код_бронювання_приміщенняTextBox.Text, typeof(int)))));

                MessageBox.Show("Підраховано, обновіть вікно.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка підрахунку!");
            }
        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {
 

        }

        private void fillToolStripButton1_Click_1(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Бронювання можливе.", "Перевірка існування бронювання",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                key++;
            }
            else
            {
                MessageBox.Show("Бронювання неможливе!", "Перевірка існування бронювання",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                key--;
            }
            
        }
    }
}
