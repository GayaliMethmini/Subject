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
    public partial class subject : Form
    {
        //SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Gayali\Desktop\Subject\Subject\Database.mdf;Integrated Security = True");
        SqlConnection connection = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public subject()
        {
            InitializeComponent();
            display_details();

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Subject (code,name,year,semester,lechrs,tutehrs,labhrs,evaluationhrs) values('" + textBoxcode.Text + "','" + textBoxname.Text + "','" + textBoxyear.Text + "','" + textBoxsem.Text + "','" + textBoxlechrs.Text + "','" + textBoxtutehrs.Text + "','" + textBoxlabhrs.Text + "','" + textBoxevalhrs.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBoxcode.Text = "";
            textBoxname.Text = "";
            textBoxyear.Text = "";
            textBoxsem.Text = "";
            textBoxlechrs.Text = "";
            textBoxtutehrs.Text = "";
            textBoxlabhrs.Text = "";
            textBoxevalhrs.Text = "";
            display_details();

            MessageBox.Show("Successfully Added");
        }

        //display details
        public void display_details()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Subject";
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter dataadap = new SqlDataAdapter(cmd);
            dataadap.Fill(data);
            dataGridView1.DataSource = data;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Subject where code = '" + textBoxcode.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBoxcode.Text = "";
            textBoxname.Text = "";
            textBoxyear.Text = "";
            textBoxsem.Text = "";
            textBoxlechrs.Text = "";
            textBoxtutehrs.Text = "";
            textBoxlabhrs.Text = "";
            textBoxevalhrs.Text = "";
            display_details();

            MessageBox.Show("Successfully Deleted");
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Subject set code = '" + textBoxcode.Text+"', name = '"+textBoxname.Text+"', year = '"+textBoxyear.Text+ "', semester = '"+textBoxsem.Text+"', lechrs = '"+textBoxlechrs.Text+"', tutehrs = '"+textBoxtutehrs.Text+"', labhrs = '"+textBoxlabhrs.Text+"', evaluationhrs = '"+textBoxevalhrs.Text+"' where code = '"+textBoxcode.Text+"'";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBoxcode.Text = "";
            textBoxname.Text = "";
            textBoxyear.Text = "";
            textBoxsem.Text = "";
            textBoxlechrs.Text = "";
            textBoxtutehrs.Text = "";
            textBoxlabhrs.Text = "";
            textBoxevalhrs.Text = "";
            display_details();

            MessageBox.Show("Successfully Updated");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxyear.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxsem.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxlechrs.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxtutehrs.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxlabhrs.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxevalhrs.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashBoard d = new dashBoard();
            d.Show();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Subject where code like '" + textBoxsearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            d.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
