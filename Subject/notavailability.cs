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
    public partial class notavailability : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public notavailability()
        {
            InitializeComponent();
            InitializeTimePicker();
        }

        private DateTimePicker timePicker;

        private void InitializeTimePicker()
        {


            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            //timePicker.Location = new Point(25, 10);
            timePicker.Location = new Point(447, 579);

            // timePicker.Location = new Point(label2.Right,dataGridView1.Bottom);

            timePicker.Width = 100;
            Controls.Add(timePicker);

        }

        public void display_NotAvailabilityData()
        {

            if (comboBox1.SelectedItem.ToString() == "Lecturer")
            {
                label3.Visible = true;
                label3.Text = "Search by Lecturer Name";
                label4.Visible = true;
                label4.Text = "Name";
                textBox2.Visible = true;
               
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select empID,Name from [Lecturers]";
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
                label4.Visible = true;
                label4.Text = "Session";
                textBox2.Visible = true;
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,session from [Session]";
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
                label4.Visible = true;
                label4.Text = "Group";
                label3.Visible = true;
                label3.Text = "Search by Group Id";
                textBox2.Visible = true;
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id,GroupId from [student]";
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
                label4.Visible = true;
                label4.Text = "Subgroup";
                textBox2.Visible = true;
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id,SubGroupId from [student]";
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Lecturer")
            {

                textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            }

            else if (comboBox1.SelectedItem.ToString() == "Session")
            {

                textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            }
            else if (comboBox1.SelectedItem.ToString() == "Group")
            {

                textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            }

            else
            {

                textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Lecturer")
            {
                conn.Open();
                //notAvailabilityLecturers

                String x = "not available";

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " insert into  [notAvailabilityLecturers] (empID,Name,Time,Status) values ((select empID from [Lecturers] where empID = " + textBox4.Text + "),'" + textBox2.Text + "','" + timePicker.Value.ToString() + "','" + x + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                textBox4.Text = " ";
                textBox2.Text = " ";

                display_NotAvailabilityData();
                MessageBox.Show(" data added successfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Session")
            {
                conn.Open();
                // notAvailabilitySessions


                String x = "not available";

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " insert into [notAvailabilitySessions] (SessionId,Session,Time,Status) values ( (select id from [Session] where id = " + textBox4.Text + "),'" + textBox2.Text + "','" + timePicker.Value.ToString() + "','" + x + "')";
                cmd.ExecuteNonQuery();


                conn.Close();

                textBox4.Text = " ";
                textBox2.Text = " ";

                display_NotAvailabilityData();
                MessageBox.Show(" data added successfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Group")
            {
                conn.Open();
                //notAvailabilityGroup


                String x = "not available";

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " insert into [notAvailabilityGroup] (stId,GroupId,Time,Status) values ((select Id from [student] where Id = " + textBox4.Text + "),'" + textBox2.Text + "','" + timePicker.Value.ToString() + "','" + x + "')";
                cmd.ExecuteNonQuery();


                conn.Close();

                textBox4.Text = " ";
                textBox2.Text = " ";

                display_NotAvailabilityData();
                MessageBox.Show(" data added successfully");
            }

            else
            {
                conn.Open();
                //notAvailabilitySubGroup


                String x = "not available";

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " insert into [notAvailabilitySubGroup] (stId,SubGroupId,Time,Status) values ( (select Id from [student] where Id = " + textBox4.Text + "),'" + textBox2.Text + "','" + timePicker.Value.ToString() + "','" + x + "')";
                cmd.ExecuteNonQuery();


                conn.Close();
                textBox4.Text = " ";
                textBox2.Text = " ";

                display_NotAvailabilityData();
                MessageBox.Show(" data added successfully");

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Lecturer")
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select empID,Name from [Lecturers] where Name like'" + textBox1.Text + "%'";
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

                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,session from [Session]  where session like'" + textBox1.Text + "%'";
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
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id,GroupId from [student]  where GroupId like'" + textBox1.Text + "%'";
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
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id,SubGroupId from [student]  where SubGroupId like'" + textBox1.Text + "%'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            notAvailabilitySessionsView f1 = new notAvailabilitySessionsView();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session f1 = new Session();
            f1.Show();
        }
    }
}
