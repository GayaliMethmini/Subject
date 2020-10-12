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
    public partial class Lecturer : Form
    {
        //SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Gayali\Desktop\Subject\Subject\Database.mdf;Integrated Security = True");
        SqlConnection connection = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public Lecturer()
        {
            InitializeComponent();
            display_details();
        }

        private void buttonaddlec_Click(object sender, EventArgs e)
        {
            //emp id should be a 6 digit number
            if (textBoxempId.Text.Length == 6)
            {

            String level = comboBoxlevel.SelectedItem.ToString();
            if (level == "Professor")
            {
                level = "1";
            }
            else if(level == "Assistant Professor")
            {
                level = "2";
            }
            else if (level == "Senior Lecturer(HG)")
            {
                level = "3";     
            }
            else if (level == "Senior Lecturer")
            {
                level = "4"; 
            }
            else if (level == "Lecturer")
            {
                level = "5";
            }
            else if (level == "Assistant Lecturer")
            {
                level = "6";
            }
            else
            {
                level = "7";
            }

           String rank = level + "." + textBoxempId.Text.ToString();

                /*connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Lecturers(empID,Name,faculty,department,center,building,level,Rank) values('"+textBoxempId.Text+"','"+textBoxname.Text+"','"+textBoxfac.Text+"','"+textBoxdep.Text+"','"+textBoxcenter.Text+"','"+textBoxbuild.Text+"','" +comboBoxlevel.SelectedItem.ToString()+ "','" + rank + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                textBoxempId.Text = "";
                textBoxname.Text = "";
                textBoxfac.Text = "";
                textBoxdep.Text = "";
                textBoxcenter.Text = "";
                textBoxbuild.Text = "";
                comboBoxlevel.SelectedItem = "";
                rank = "";
                display_details();
                */

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Lecturers(empID,Name,faculty,department,center,building,level,Rank,subject) values('"+textBoxempId.Text+"','"+textBoxname.Text+"','"+textBoxfac.Text+"','"+textBoxdep.Text+"','"+textBoxcenter.Text+"','"+textBoxbuild.Text+"','" +comboBoxlevel.SelectedItem.ToString()+ "','" + rank + "','" + comboBoxsubj.SelectedItem.ToString() + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBoxempId.Text = "";
            textBoxname.Text = "";
            textBoxfac.Text = "";
            textBoxdep.Text = "";
            textBoxcenter.Text = "";
            textBoxbuild.Text = "";
            comboBoxlevel.SelectedItem = "";
            rank = "";
            comboBoxsubj.SelectedItem = "";

            display_details();


            MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Please enter a 6 digit number for Employee ID");
            }
        }

        //display details
        public void display_details()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Lecturers";
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter dataadap = new SqlDataAdapter(cmd);
            dataadap.Fill(data);
            dataGridView1.DataSource = data;
            connection.Close();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            String level = comboBoxlevel.SelectedItem.ToString();
            if (level == "Professor")
            {
                level = "1";
            }
            else if (level == "Assistant Professor")
            {
                level = "2";
            }
            else if (level == "Senior Lecturer(HG)")
            {
                level = "3";
            }
            else if (level == "Senior Lecturer")
            {
                level = "4";
            }
            else if (level == "Lecturer")
            {
                level = "5";
            }
            else if (level == "Assistant Lecturer")
            {
                level = "6";
            }
            else
            {
                level = "7";
            }

            String rank = level + "." + textBoxempId.Text.ToString();

            /*
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Lecturers set empID = '" + textBoxempId.Text + "', Name = '" + textBoxname.Text + "', faculty = '" + textBoxfac.Text + "', department = '" + textBoxdep.Text + "', center = '" + textBoxcenter.Text + "', building = '" + textBoxbuild.Text + "', level = '" + comboBoxlevel.SelectedItem.ToString()+ "', Rank = '"+rank+ "' where empID = '" + textBoxempId.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBoxempId.Text = "";
            textBoxname.Text = "";
            textBoxfac.Text = "";
            textBoxdep.Text = "";
            textBoxcenter.Text = "";
            textBoxbuild.Text = "";
            comboBoxlevel.SelectedItem = "";
            display_details();
            */

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Lecturers set empID = '" + textBoxempId.Text + "', Name = '" + textBoxname.Text + "', faculty = '" + textBoxfac.Text + "', department = '" + textBoxdep.Text + "', center = '" + textBoxcenter.Text + "', building = '" + textBoxbuild.Text + "', level = '" + comboBoxlevel.SelectedItem.ToString() + "', Rank = '" + rank + "',subject = '" + comboBoxsubj.SelectedItem.ToString() + "' where empID = '" + textBoxempId.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBoxempId.Text = "";
            textBoxname.Text = "";
            textBoxfac.Text = "";
            textBoxdep.Text = "";
            textBoxcenter.Text = "";
            textBoxbuild.Text = "";
            comboBoxlevel.SelectedItem = "";
            
            display_details();

            MessageBox.Show("Successfully Updated");
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Lecturers where empID = '" + textBoxempId.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBoxempId.Text = "";
            textBoxname.Text = "";
            textBoxfac.Text = "";
            textBoxdep.Text = "";
            textBoxcenter.Text = "";
            textBoxbuild.Text = "";
            comboBoxlevel.SelectedItem = "";
            comboBoxsubj.SelectedItem = "";
            display_details();

            MessageBox.Show("Successfully Deleted");
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxempId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxfac.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxdep.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxcenter.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxbuild.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBoxlevel.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBoxsubj.SelectedItem = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashBoard d = new dashBoard();
            d.Show();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            //lecturers
            comboBoxsubj.Items.Clear();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from Subject";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter d1 = new SqlDataAdapter(cmd);
            d1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboBoxsubj.Items.Add(dr1["name"].ToString());
            }
            connection.Close();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Lecturers where empID like '" + textBoxsearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            d.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}