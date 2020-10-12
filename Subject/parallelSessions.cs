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
    public partial class parallelSessions : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public parallelSessions()
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
            timePicker.Location = new Point(403, 493);

            // timePicker.Location = new Point(label2.Right,dataGridView1.Bottom);

            timePicker.Width = 100;
            Controls.Add(timePicker);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session f2 = new Session();
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

                    String lec = dr.Cells[1].Value.ToString();
                    String subj = dr.Cells[2].Value.ToString();
                    String subCode = dr.Cells[3].Value.ToString();
                    String tag = dr.Cells[4].Value.ToString();
                    String grp = dr.Cells[5].Value.ToString();
                    String duration = dr.Cells[6].Value.ToString();
                    String day = comboBox1.SelectedItem.ToString();
                    String time = timePicker.Value.ToString();


                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " insert into [parllelSessions] (lec,subj,subCode,tag,grp,duration,Day,Time) values ( '" + lec + "','" + subj + "','" + subCode + "','" + tag + "','" + grp + "','" + duration + "','" + day + "','" + time + "')";
                    cmd.ExecuteNonQuery();
                    //String qry = "insert into parllelSessions(lec,subj,subCode,tag,grp,duration) values ('" + dr.Cells[1].Value.ToString()+ "', '" + dr.Cells[2].Value.ToString() + "','" + dr.Cells[3].Value.ToString() + "' ,'" + dr.Cells[4].Value.ToString() + "','" + dr.Cells[5].Value.ToString() + "','" + dr.Cells[6].Value.ToString() + "')";
                    //object allows to query and send commands to db
                    //SqlCommand cmd = new SqlCommand(qry, conn);
                    //SqlCommand cmd = conn.CreateCommand();
                    //cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = " insert into [student] (YearSem,Programme,GroupNo,SubGroup,GroupId,SubGroupId) values ( '" +comboBoxYearSem.SelectedItem.ToString() + "', '" + textBoxProgramme.Text+"','"+textBoxGroupNo+"' ,'"+ textBoxSubGroup.Text+"')";

                    //execute commands such as transact-sql insert, delete, update and set statements


                    conn.Close();



                }



            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            String id = textBox1.Text;

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select lec,subj,subcode,tag,grp,duration,session from [Session] where grp like'" + id + "%' ";
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
                dataGridView1.Rows[n].Cells[1].Value = dr["lec"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr["subj"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr["subcode"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr["tag"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr["grp"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr["duration"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = dr["session"].ToString();
            }
            conn.Close();
            //textBox1.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            parallelSessionView f2 = new parallelSessionView();
            f2.Show();
        }
    }
}
