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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, Малышев Никита Анатольевич, " +
                "группа 720 - 2, 2022", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, Малышев Никита Анатольевич, " +
                "группа 720 - 2, 2022", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void направлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var line_avia = new Line_Avia();
            line_avia.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, Малышев Никита Анатольевич, " +
                 "группа 720 - 2, 2022", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, Малышев Никита Анатольевич, " +
                 "группа 720 - 2, 2022", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void данныеОПассажирахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var passenger_data = new Passenger_data();
            passenger_data.Show();
        }

        private void сервисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var service = new Service();
            service.Show();
        }

        private void билетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ticket = new Ticket();
            ticket.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var users = new Users();
            users.Show();
        }
    }
}
