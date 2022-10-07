using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviasales
{
    public partial class Line_Avia : Form
    {
        public Line_Avia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }

        private void Line_Avia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Line_Avia". При необходимости она может быть перемещена или удалена.
            this.line_AviaTableAdapter.Fill(this.aviasalesDataSet.Line_Avia);

        }

        private void line_AviaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.line_AviaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aviasalesDataSet);

        }

        private void air_CarrierLabel_Click(object sender, EventArgs e)
        {

        }

        private void air_CarrierTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void max_Count_of_peopleLabel_Click(object sender, EventArgs e)
        {

        }

        private void max_Count_of_peopleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
