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
    public partial class consecutiveSessions : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public consecutiveSessions()
        {
            InitializeComponent();
            display_studentData();
        }
        public void display_studentData()
        {

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select lec,subj,subcode,tag,grp from [Session]";
            cmd.ExecuteNonQuery();
            //represent one table in memeory data
            DataTable dtag = new DataTable();
            //retrieve data from a data source 
            SqlDataAdapter dataTag = new SqlDataAdapter(cmd);
            dataTag.Fill(dtag);
            //dataGridView1.DataSource = dtag;
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dtag.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();

            }
            //conn.Close();

            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tag from tag";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                // checkedListBox1.Items.Add(dr["tag"].ToString());
                comboBox1.Items.Add(dr["tag"].ToString());

            }


            conn.Close();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session s = new Session();
            s.Show();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //List<String> myInts = new List<String>();


            //int x =   myInts.Count;

            String lecturer = textBox1.Text;
            String subject = textBox2.Text;
            String subCode = textBox3.Text;
            String tag = textBox5.Text;
            String grpId = textBox4.Text;
            String combobx = comboBox1.SelectedItem.ToString();
            String tg = tag + "," + combobx;

            conn.Open();
            String qry = "insert into consecutiveSession (lecturer,suject,subCode,groupId,tag) values ('" + lecturer + "','" + subject + "','" + subCode + "','" + grpId + "', '" + tg + "')";
            SqlCommand cmd = new SqlCommand(qry, conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Consecutive session added successfully");

            // foreach (String s in checkedListBox1.CheckedItems)

            //{
            // conn.Open();

            //String qry = "insert into consecutiveSession (groupId,tag) values ('" + grpId + "', '" + s + "')";
            // SqlCommand cmd = new SqlCommand(qry, conn);

            // cmd.ExecuteNonQuery();
            // conn.Close();
            // myInts.Add(s);

            // }




            // for (int i=0; i<x; i++)
            // {
            //conn.Open();

            //String qry = "insert into consecutiveSession (groupId,tag) values ('" + grpId + "','" +  myInts[i] +  "')";
            //object allows to query and send commands to db
            //SqlCommand cmd = new SqlCommand(qry, conn);
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = " insert into [student] (YearSem,Programme,GroupNo,SubGroup,GroupId,SubGroupId) values ( '" +comboBoxYearSem.SelectedItem.ToString() + "', '" + textBoxProgramme.Text+"','"+textBoxGroupNo+"' ,'"+ textBoxSubGroup.Text+"')";

            //execute commands such as transact-sql insert, delete, update and set statements

            // cmd.ExecuteNonQuery();
            //conn.Close();


            // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsecutiveSessionView f1 = new ConsecutiveSessionView();
            f1.Show();
        }

    }
}
