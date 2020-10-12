using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subject
{
    public partial class StatisticsSubj : Form
    {
        public StatisticsSubj()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StatisticsLec newForm = new StatisticsLec();
            newForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            StatisticsStud newForm = new StatisticsStud();
            newForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            StatisticsSubj newForm = new StatisticsSubj();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Location_and_Statistics newForm = new Location_and_Statistics();
            newForm.Show();
            this.Hide();
        }
    }
}
