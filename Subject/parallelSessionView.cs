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
    public partial class parallelSessionView : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public parallelSessionView()
        {
            InitializeComponent();
            display_parallelSessions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            parallelSessions f2 = new parallelSessions();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (bool.Parse(dr.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Selected Rows : " + dr.Cells[0].RowIndex.ToString());

                    //String time = textBox2.Text;

                    conn.Open();

                    String id = dr.Cells[1].Value.ToString();


                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " delete from[parllelSessions] where id ='" + id + "'";
                    cmd.ExecuteNonQuery();



                    conn.Close();



                }



            }

            display_parallelSessions();

        }

        public void display_parallelSessions()
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id,lec,subj,subCode,tag,grp,Day,Time from [parllelSessions]  ";
            cmd.ExecuteNonQuery();
            //represent one table in memeory data
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "false";
                dataGridView1.Rows[n].Cells[1].Value = dr["id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr["lec"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr["subj"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr["subcode"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr["tag"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr["grp"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = dr["Day"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = dr["Time"].ToString();
            }
            conn.Close();


        }

        // search
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id,lec,subj,subCode,tag,grp,Day,Time from [parllelSessions] where grp like'" + textBox1.Text + "%'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "false";
                dataGridView1.Rows[n].Cells[1].Value = dr["id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr["lec"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr["subj"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr["subcode"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr["tag"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr["grp"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = dr["Day"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = dr["Time"].ToString();
            }

            conn.Close();

        }
    }
}
