using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Subject
{
    public partial class PreferredRoom : Form
    {
        SqlConnection connection = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public PreferredRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Location_and_Statistics newForm = new Location_and_Statistics();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [preferred2] (tag,subject,lecturer,grp,session,room,time) Values ('" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + comboBox3.SelectedItem.ToString() + "','" + comboBox6.SelectedItem.ToString() + "','" + comboBox4.SelectedItem.ToString() + "','" + comboBox5.SelectedItem.ToString() + "','" + txt.Text + "' )";
            cmd.ExecuteNonQuery();
            connection.Close();
            comboBox1.SelectedItem = "-1";
            comboBox2.SelectedItem = "-1";
            comboBox3.SelectedItem = "-1";
            comboBox6.SelectedItem = "-1";
            comboBox4.SelectedItem = "-1";
            comboBox5.SelectedValue = "";
            txt.Text = "";
            display();
            MessageBox.Show("Room selected successfully");
        }
        public void display()
        {
            //to view the entered data
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [preferred2]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
            dtadapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [preferred2] SET  tag = '" + comboBox1.SelectedItem.ToString() + "', subject = '" + comboBox2.SelectedItem.ToString() + "',lecturer ='" + comboBox3.SelectedItem.ToString() + "',grp ='" + comboBox6.SelectedItem.ToString() + "',session ='" + comboBox4.SelectedItem.ToString() + "',room ='" + comboBox5.SelectedItem.ToString() + "',time = '" + txt.Text + "' WHERE id = '" + tex2.Text + "' ";
            cmd.ExecuteNonQuery();
            connection.Close();
            comboBox1.SelectedItem = "-1";
            comboBox2.SelectedItem = "-1";
            comboBox3.SelectedItem = "-1";
            comboBox6.SelectedItem = "-1";
            comboBox4.SelectedItem = "-1";
            comboBox5.SelectedValue = "";
            txt.Text = "";

            display();
            MessageBox.Show("preferred room Updated successfully");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tex2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.SelectedItem = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox3.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox6.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox4.SelectedItem = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBox5.SelectedItem = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txt.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [preferred2] WHERE id = '" + tex2.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            comboBox1.SelectedItem = "-1";
            comboBox2.SelectedItem = "-1";
            comboBox3.SelectedItem = "-1";
            comboBox6.SelectedItem = "-1";
            comboBox4.SelectedItem = "-1";
            comboBox5.SelectedValue = "";
            txt.Text = "";
            display();
            MessageBox.Show("preferred room Deleted successfully");
        }
    }
}
