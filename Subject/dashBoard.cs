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
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecturer l = new Lecturer();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            subject s = new subject();
            s.Show();
        }

        private void dashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session s = new Session();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStudentDetails s = new addStudentDetails();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            tag1 s = new tag1();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location_and_Statistics s = new Location_and_Statistics();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s = new Form1();
            s.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSec5 s = new FormSec5();
            s.Show();
        }
    }
}
