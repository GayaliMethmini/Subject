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
    public partial class Session : Form
    {

        SqlConnection connection = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;

        public Session()
        {
            InitializeComponent();
            display_details();
            display_sessions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashBoard d = new dashBoard();
            d.Show();
        }

        //display sessions
        public void display_sessions()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select session from Session";
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter dataadap = new SqlDataAdapter(cmd);
            dataadap.Fill(data);
            dataGridView1.DataSource = data;
            connection.Close();
        }
        
        //display session details
        public void display_details ()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id,lec,subj,subcode,tag,grp,count,duration from Session";
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter dataadap = new SqlDataAdapter(cmd);
            dataadap.Fill(data);
            dataGridView2.DataSource = data;
            connection.Close();
        }
        
        private void Session_Load(object sender, EventArgs e)
        {
            //lecturers
            comboBoxlec.Items.Clear();
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from Lecturers";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter d1 = new SqlDataAdapter(cmd);
            d1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboBoxlec.Items.Add(dr1["Name"].ToString());
            }
            connection.Close();

            /*
            //subjects
            comboBoxsubj.Items.Clear();
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select subject from Lecturers";
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter d2 = new SqlDataAdapter(cmd);
            d2.Fill(dt2);
            foreach(DataRow dr2 in dt2.Rows)
            {
                comboBoxsubj.Items.Add(dr2["subject"].ToString());
            }
            connection.Close();
            */


            //tags
            comboBoxtag.Items.Clear();
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tag from tag";
            cmd.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter d3 = new SqlDataAdapter(cmd);
            d3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                comboBoxtag.Items.Add(dr3["tag"].ToString());
            }
            connection.Close();

            //group
            /*
            string tag = comboBoxtag.SelectedItem.ToString();

            if (tag == "Lecture" || tag=="Tutorial")
            {
                comboBoxgroup.Items.Clear();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select GroupId from student";
                cmd.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                SqlDataAdapter d4 = new SqlDataAdapter(cmd);
                d4.Fill(dt4);
                foreach (DataRow dr4 in dt4.Rows)
                {
                    comboBoxgroup.Items.Add(dr4["GroupId"].ToString());
                }
                connection.Close();
            }
            else
            {
                comboBoxgroup.Items.Clear();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select SubGroupId from student";
                cmd.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                SqlDataAdapter d4 = new SqlDataAdapter(cmd);
                d4.Fill(dt4);
                foreach (DataRow dr4 in dt4.Rows)
                {
                    comboBoxgroup.Items.Add(dr4["SubGroupId"].ToString());
                }
                connection.Close();
            }*/

            /*
            comboBoxgroup.Items.Clear();
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select GroupId from student";
            cmd.ExecuteNonQuery();
            DataTable dt4 = new DataTable();
            SqlDataAdapter d4 = new SqlDataAdapter(cmd);
            d4.Fill(dt4);
            foreach (DataRow dr4 in dt4.Rows)
            {
                comboBoxgroup.Items.Add(dr4["GroupId"].ToString());
            }
            connection.Close();
            */
        }

        /*
        private void comboBoxsubj_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sc;
            SqlDataReader dr;

            string s = "select code from Subject where name = '" + comboBoxsubj.SelectedItem.ToString() + "'";
            connection.Open();
            sc = new SqlCommand(s, connection);
            dr = sc.ExecuteReader();
            while (dr.Read())
            {
                textBoxSubcode.Text = dr.GetValue(0).ToString();
            }
            sc.Dispose();
            connection.Close();

        }
        */
        private void comboBoxgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string tag = comboBoxtag.SelectedItem.ToString();

            if (tag == "Lecture" || tag == "Tutorial")
            {
                comboBoxgroup.Items.Clear();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select GroupId from student";
                cmd.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                SqlDataAdapter d4 = new SqlDataAdapter(cmd);
                d4.Fill(dt4);
                foreach (DataRow dr4 in dt4.Rows)
                {
                    comboBoxgroup.Items.Add(dr4["GroupId"].ToString());
                }
                connection.Close();
            }
            else
            {
                comboBoxgroup.Items.Clear();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select SubGroupId from student";
                cmd.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                SqlDataAdapter d4 = new SqlDataAdapter(cmd);
                d4.Fill(dt4);
                foreach (DataRow dr4 in dt4.Rows)
                {
                    comboBoxgroup.Items.Add(dr4["SubGroupId"].ToString());
                }
                connection.Close();*/
        }

        private void comboBoxtag_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tag = comboBoxtag.SelectedItem.ToString();

            if (tag == "Lecture" || tag == "Tutorial")
            {
                comboBoxgroup.Items.Clear();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select GroupId from student";
                cmd.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                SqlDataAdapter d4 = new SqlDataAdapter(cmd);
                d4.Fill(dt4);
                foreach (DataRow dr4 in dt4.Rows)
                {
                    comboBoxgroup.Items.Add(dr4["GroupId"].ToString());
                }
                connection.Close();
            }
            /*
            else if(tag == "Tutorial")
            {
                comboBoxgroup.Items.Clear();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select GroupId from student";
                cmd.ExecuteNonQuery();
                DataTable dt5 = new DataTable();
                SqlDataAdapter d5 = new SqlDataAdapter(cmd);
                d5.Fill(dt5);
                foreach (DataRow dr5 in dt5.Rows)
                {
                    comboBoxgroup.Items.Add(dr5["GroupId"].ToString());
                }
                connection.Close();
            }*/
            else
            {
                comboBoxgroup.Items.Clear();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select SubGroupId from student";
                cmd.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                SqlDataAdapter d4 = new SqlDataAdapter(cmd);
                d4.Fill(dt4);
                foreach (DataRow dr4 in dt4.Rows)
                {
                    comboBoxgroup.Items.Add(dr4["SubGroupId"].ToString());
                }
                connection.Close();
            }
        }

        private void buttonaddsess_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Session (lec,subj,subcode,tag,grp,count,duration,session) values('" + comboBoxlec.SelectedItem.ToString() + "','" + textBoxsubj.Text + "','" + textBoxSubcode.Text + "','" + comboBoxtag.SelectedItem.ToString() + "','" + comboBoxgroup.SelectedItem.ToString() + "','" + textBoxcount.Text + "','" + textBoxduration.Text + "','" + comboBoxlec.SelectedItem.ToString() + "," + textBoxsubj.Text + "," + textBoxSubcode.Text + "," + comboBoxtag.SelectedItem.ToString() + "," + comboBoxgroup.SelectedItem.ToString() + "," + textBoxcount.Text + "," + textBoxduration.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            comboBoxlec.SelectedItem = "";
            textBoxsubj.Text = "";
            textBoxSubcode.Text = "";
            comboBoxtag.SelectedItem = "";
            comboBoxgroup.SelectedItem = "";
            textBoxcount.Text = "";
            textBoxduration.Text = "";
            display_details();
            display_sessions();

            MessageBox.Show("Successfully Added");
        }
        /*
        private void textBoxsubj_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sc;
            SqlDataReader dr;

            string s = "select code from Subject where name = '" + textBoxsubj.Text + "'";
            connection.Open();
            sc = new SqlCommand(s, connection);
            dr = sc.ExecuteReader();
            while (dr.Read())
            {
                textBoxSubcode.Text = dr.GetValue(0).ToString();
            }
            sc.Dispose();
            connection.Close();
        }
        */
        private void comboBoxlec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sc;
            SqlDataReader dr;

            string l = "select subject from Lecturers where Name = '" + comboBoxlec.SelectedItem.ToString() + "'";
            connection.Open();
            sc = new SqlCommand(l, connection);
            dr = sc.ExecuteReader();
            while (dr.Read())
            {
                textBoxsubj.Text = dr.GetValue(0).ToString();
            }
            sc.Dispose();
            connection.Close();


            SqlCommand sc1;
            SqlDataReader dr1;

            string s = "select code from Subject where name = '" + textBoxsubj.Text + "'";
            connection.Open();
            sc1 = new SqlCommand(s, connection);
            dr1 = sc1.ExecuteReader();
            while (dr1.Read())
            {
                textBoxSubcode.Text = dr1.GetValue(0).ToString();
            }
            sc1.Dispose();
            connection.Close();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            comboBoxlec.SelectedItem = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBoxsubj.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBoxSubcode.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            comboBoxtag.SelectedItem = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            comboBoxgroup.SelectedItem = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBoxcount.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBoxduration.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Session set tag = '" + comboBoxtag.SelectedItem.ToString() + "', grp = '" + comboBoxgroup.SelectedItem.ToString() + "', count = '" + textBoxcount.Text + "', duration = '" + textBoxduration.Text + "',session = '" + comboBoxlec.SelectedItem.ToString() + "," + textBoxsubj.Text + "," + textBoxSubcode.Text + "," + comboBoxtag.SelectedItem.ToString() + "," + comboBoxgroup.SelectedItem.ToString() + "," + textBoxcount.Text + "," + textBoxduration.Text + "' where id = '" + textBoxid.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            comboBoxlec.SelectedItem = "";
            textBoxsubj.Text = "";
            textBoxSubcode.Text = "";
            comboBoxtag.SelectedItem = "";
            comboBoxgroup.SelectedItem = "";
            textBoxcount.Text = "";
            textBoxduration.Text = "";
            display_details();
            display_sessions();

            MessageBox.Show("Successfully Updated");
            
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Session where id = '" + textBoxid.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            comboBoxlec.SelectedItem = "";
            textBoxsubj.Text = "";
            textBoxSubcode.Text = "";
            comboBoxtag.SelectedItem = "";
            comboBoxgroup.SelectedItem = "";
            textBoxcount.Text = "";
            textBoxduration.Text = "";
            display_details();
            display_sessions();

            MessageBox.Show("Successfully Deleted");
        }
        
        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  id,lec,subj,subcode,tag,grp,count,duration from Session where lec like '" + textBoxsearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            d.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();

          
            connection.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  session from Session where lec like '" + textBoxsearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter d1 = new SqlDataAdapter(cmd);
            d1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            connection.Close();
            
        }
        
        private void textBoxs1_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  id,lec,subj,subcode,tag,grp,count,duration from Session where subj like '" + textBoxsch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            d.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();

            connection.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  session from Session where subj like '" + textBoxsch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter d1 = new SqlDataAdapter(cmd);
            d1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            connection.Close();
        }

        private void textBoxs2_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  id,lec,subj,subcode,tag,grp,count,duration from Session where grp like '" + textBoxsrch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            d.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();

            connection.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  session from Session where grp like '" + textBoxsrch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter d1 = new SqlDataAdapter(cmd);
            d1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            consecutiveSessions f2 = new consecutiveSessions();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            notoverlapSessions f2 = new notoverlapSessions();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            notavailability f2 = new notavailability();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            parallelSessions f2 = new parallelSessions();
            f2.Show();
        }
    }
}
