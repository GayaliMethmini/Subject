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
    public partial class notAvailabilitySessionsView : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public notAvailabilitySessionsView()
        {
            InitializeComponent();
        }

        public void display_NotAvailabilityData()
        {

            if (comboBox1.SelectedItem.ToString() == "Lecturer")
            {
                label3.Visible = true;
               

                label3.Text = "Search by Lecturer Name";
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,empID,Name,Time,Status from [notAvailabilityLecturers]";
                cmd.ExecuteNonQuery();
                //represent one table in memeory data
                DataTable dtag = new DataTable();

                //retrieve data from a data source 
                SqlDataAdapter dataTag = new SqlDataAdapter(cmd);
                dataTag.Fill(dtag);
                //dataGridView1.DataSource = dtag;
                dataGridView1.DataSource = dtag;

                conn.Close();



            }


            else if (comboBox1.SelectedItem.ToString() == "Session")
            {
                label3.Visible = true;
                label3.Text = "Search by Session";
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,SessionId,Session,Time,Status from [notAvailabilitySessions]";
                cmd.ExecuteNonQuery();
                //represent one table in memeory data
                DataTable dtag = new DataTable();

                //retrieve data from a data source 
                SqlDataAdapter dataTag = new SqlDataAdapter(cmd);
                dataTag.Fill(dtag);
                //dataGridView1.DataSource = dtag;
                dataGridView1.DataSource = dtag;

                conn.Close();
            }

            else if (comboBox1.SelectedItem.ToString() == "Group")
            {
                label3.Visible = true;
                label3.Text = "Search by Group Id";
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,stId,GroupId,Time,Status from [notAvailabilityGroup]";
                cmd.ExecuteNonQuery();
                //represent one table in memeory data
                DataTable dtag = new DataTable();

                //retrieve data from a data source 
                SqlDataAdapter dataTag = new SqlDataAdapter(cmd);
                dataTag.Fill(dtag);
                //dataGridView1.DataSource = dtag;
                dataGridView1.DataSource = dtag;
                conn.Close();
            }

            else
            {
                label3.Visible = true;
                label3.Text = "Search by SubGroup Id";
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,stId,SubGroupId,Time,Status from [notAvailabilitySubGroup]";
                cmd.ExecuteNonQuery();
                //represent one table in memeory data
                DataTable dtag = new DataTable();

                //retrieve data from a data source 
                SqlDataAdapter dataTag = new SqlDataAdapter(cmd);
                dataTag.Fill(dtag);
                //dataGridView1.DataSource = dtag;
                dataGridView1.DataSource = dtag;
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_NotAvailabilityData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Lecturer")
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " delete from [notAvailabilityLecturers] where id ='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                textBox2.Text = " ";
                display_NotAvailabilityData();
                MessageBox.Show("lecturer is deleted successfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Session")
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " delete from [notAvailabilitySessions] where id ='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                textBox1.Text = " ";
                display_NotAvailabilityData();
                MessageBox.Show("Session is deleted successfully");
            }


            else if (comboBox1.SelectedItem.ToString() == "Group")
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " delete from [notAvailabilityGroup] where id ='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                textBox2.Text = " ";
                display_NotAvailabilityData();
                MessageBox.Show("Group is deleted successfully");
            }

            else
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " delete from [notAvailabilitySubGroup] where id ='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                textBox2.Text = " ";
                display_NotAvailabilityData();
                MessageBox.Show("Subgroup is deleted successfully");

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Lecturer")
            {

                //label1.Text = "Search by Lecturer Name";
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,empID,Name,Time,Status from [notAvailabilityLecturers] where Name like '" + textBox1.Text + "%'";
                cmd.ExecuteNonQuery();
                //represent one table in memeory data
                DataTable dtag = new DataTable();

                //retrieve data from a data source 
                SqlDataAdapter dataTag = new SqlDataAdapter(cmd);
                dataTag.Fill(dtag);
                //dataGridView1.DataSource = dtag;
                dataGridView1.DataSource = dtag;

                conn.Close();



            }


            else if (comboBox1.SelectedItem.ToString() == "Session")
            {

                // label1.Text = "Search by Session";
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,SessionId,Session,Time,Status from [notAvailabilitySessions] where Session like'" + textBox1.Text + "%'";
                cmd.ExecuteNonQuery();
                //represent one table in memeory data
                DataTable dtag = new DataTable();

                //retrieve data from a data source 
                SqlDataAdapter dataTag = new SqlDataAdapter(cmd);
                dataTag.Fill(dtag);
                //dataGridView1.DataSource = dtag;
                dataGridView1.DataSource = dtag;

                conn.Close();
            }

            else if (comboBox1.SelectedItem.ToString() == "Group")
            {

                //label1.Text = "Search by Group Id";
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,stId,GroupId,Time,Status from [notAvailabilityGroup] where GroupId like '" + textBox1.Text + "%'";
                cmd.ExecuteNonQuery();
                //represent one table in memeory data
                DataTable dtag = new DataTable();

                //retrieve data from a data source 
                SqlDataAdapter dataTag = new SqlDataAdapter(cmd);
                dataTag.Fill(dtag);
                //dataGridView1.DataSource = dtag;
                dataGridView1.DataSource = dtag;
                conn.Close();
            }

            else
            {

                //label1.Text = "Search by SubGroup Id";
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,stId,SubGroupId,Time,Status from [notAvailabilitySubGroup] where SubGroupId like '" + textBox1.Text + "%'";
                cmd.ExecuteNonQuery();
                //represent one table in memeory data
                DataTable dtag = new DataTable();

                //retrieve data from a data source 
                SqlDataAdapter dataTag = new SqlDataAdapter(cmd);
                dataTag.Fill(dtag);
                //dataGridView1.DataSource = dtag;
                dataGridView1.DataSource = dtag;
                conn.Close();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            notavailability f2 = new notavailability();
            f2.Show();
        }
    }
}
