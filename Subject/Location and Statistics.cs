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
    public partial class Location_and_Statistics : Form
    {
        SqlConnection connection = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public Location_and_Statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashBoard s = new dashBoard();
            s.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Location_and_Statistics newForm = new Location_and_Statistics();
            newForm.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            StatisticsLec newForm = new StatisticsLec();
            newForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PreferredRoom newForm = new PreferredRoom ();
            newForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [Location] (lid, building, room, capacity) Values ('" + idtxt.Text + "','" + building.Text + "','" + room.Text + "','" + int.Parse(capacity.Text) + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            idtxt.Text = "";
            building.Text = "";
            room.Text = "";
            capacity.Text = "";
            display();
            MessageBox.Show("Location entered successfully");
        }

        public void display()
        {
            //to view the entered data
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Location]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
            dtadapter.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [Location] WHERE lid = '" + idtxt.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            idtxt.Text = "";
            building.Text = "";
            room.Text = "";
            capacity.Text = "";
            display();
            MessageBox.Show("Location Deleted successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [Location] SET building = '" + building.Text + "',room = '" + room.Text + "',capacity='" + capacity.Text + "' WHERE lid = '" + idtxt.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            idtxt.Text = "";
            building.Text = "";
            room.Text = "";
            capacity.Text = "";
            display();
            MessageBox.Show("Location Updated successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Location] WHERE (lid = '" + search.Text + "') OR (building = '" + search.Text + "') OR (room = '" + search.Text + "') OR (capacity = '" + search.Text + "')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
            idtxt.Text = "";
            building.Text = "";
            room.Text = "";
            capacity.Text = "";
        }
    }
}
