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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void бронюванняПриміщенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formReservetionRoom1 = new formReservetionRoom();
            formReservetionRoom1.ShowDialog();
        }

        private void пошукБронюванняПриміщенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSearchReservetion().ShowDialog();
        }

        private void рахунокфактуруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormInvoice().ShowDialog();
        }

        private void пошукПідрядникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formSearchContractor().ShowDialog();
        }

        private void поРонюваннямПриміщеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormReportReserv().ShowDialog();
        }

        private void підрядникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormContractor().ShowDialog();
        }

        private void адміністратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formAdmin().ShowDialog();
        }

        private void клієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formKlient().ShowDialog();
        }

        private void обладнанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formEquipment().ShowDialog();
        }

        private void гарнітурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formFurniture().ShowDialog();
        }

        private void створитиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void розкладВикористанняОбладнанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formSearchPlanUseEquipOnDate().ShowDialog();
        }

        private void роToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formSearchPlanUseRooms().ShowDialog();
        }

        private void плануванняРоботиПерсоналуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formPlaningForState().ShowDialog();
        }

        private void графікПерсоналуНаТижденьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formPlaningStateForWeek().ShowDialog();
        }

        private void поРахункамфактурамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formReportInvoice().ShowDialog();
        }

        private void поОбраномуОбладнанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formReportUseEquip().ShowDialog();
        }

        private void поОбранихГарнітурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formReportUseFurniture().ShowDialog();
        }

        private void пошукТаФільтраціяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void створитиЗвітToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
