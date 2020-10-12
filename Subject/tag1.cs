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
    public partial class tag1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public tag1()
        {
            InitializeComponent();
            display_tagData();
        }

        public void display_tagData()
        {

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from [tag] order by Id desc";
            cmd.ExecuteNonQuery();
            DataTable dtag = new DataTable();
            SqlDataAdapter dataTag = new SqlDataAdapter(cmd);
            dataTag.Fill(dtag);
            //dataGridView1.DataSource = dtag;
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dtag.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
            }
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashBoard d = new dashBoard();
            d.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into [tag] (tag) values ( '" + textBoxTag.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            textBoxTag.Text = " ";
            display_tagData();
            MessageBox.Show("Tag is added successfully");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*this.Hide();
           TagEditDelete f2 = new TagEditDelete();
           f2.Show();*/

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update [tag] set tag = '" + textBoxTag.Text + "' where id='" + textBoxId.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            textBoxTag.Text = " ";
            textBoxId.Text = " ";
            display_tagData();
            MessageBox.Show("Tag is updated successfully");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from [tag] where id ='" + textBoxId.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            textBoxTag.Text = " ";
            display_tagData();
            MessageBox.Show("Tag is deleted successfully");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from [tag] where id ='" + textBoxSearch.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //conn.Close();


            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
            }
            conn.Close();
            textBoxSearch.Text = " ";
            textBoxTag.Text = " ";
            textBoxId.Text = " ";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            display_tagData();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxTag.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
          addStudentDetails f2 = new addStudentDetails();
          f2.Show();

        }*/


    }
}
