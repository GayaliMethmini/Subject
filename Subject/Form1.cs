using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
//using MongoDB.Bson;
//using DocumentFormat.OpenXml.Drawing;

namespace Subject
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public Form1()
        {
            InitializeComponent();
            getInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashBoard newForm = new dashBoard();
            newForm.Show();
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //string s = "";
            //foreach (Control connection in this.Controls)
            //{
            //    if (connection is CheckBox)
            //    {
            //        CheckBox b = (CheckBox)connection;
            //        if (b.Checked)
            //        {
            //            s = b.Text + "" + s;
            //        }
            //    }
            //}

            //connection.Open();
            //SqlCommand cmd = connection.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "insert into [dbo].[WorkingDaysAndTime] (NumOfWorkingHoursPerDay,StartTime,EndTime,TimeSlot,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Friday) values('" + numOfWoringHoursPerDay.Value + "', '"+ startTime.Text + "', '"+endTime.Text +"', '"+ timeSlot.Text + "', )";
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //numOfWoringHoursPerDay.Value = 0;
            //startTime.Text = "";
            //endTime.Text = "";
            //timeSlot.Text = "";
            //getInfo();
            //MessageBox.Show("successfully insert");

            SqlCommand xp = new SqlCommand("insert into [dbo].[WorkingDaysAndTime] (NumOfWorkingHoursPerDay,StartTime,EndTime,TimeSlot,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday) values(@NumOfWorkingHoursPerDay, @startTime, @endTime, @timeSlot, @Monday,@Tuesday, @Wednesday,@Thursday,@Friday, @Saturday, @Sunday )", connection);

            xp.Parameters.AddWithValue("@NumOfWorkingHoursPerDay", numOfWoringHoursPerDay.Value);
            xp.Parameters.AddWithValue("@StartTime", startTime.Text);
            xp.Parameters.AddWithValue("@EndTime", endTime.Text);
            xp.Parameters.AddWithValue("@TimeSlot", timeSlot.Text);

            if (checkBox1.Checked == true)
            {

                xp.Parameters.AddWithValue("@Monday", checkBox1.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Monday", "");
            }
            if (checkBox2.Checked == true)
            {

                xp.Parameters.AddWithValue("@Tuesday", checkBox2.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Tuesday", "");
            }
            if (checkBox3.Checked == true)
            {

                xp.Parameters.AddWithValue("@Wednesday", checkBox3.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Wednesday", "");
            }
            if (checkBox4.Checked == true)
            {

                xp.Parameters.AddWithValue("@Thursday", checkBox4.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Thursday", "");
            }
            if (checkBox5.Checked == true)
            {

                xp.Parameters.AddWithValue("@Friday", checkBox5.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Friday", "");
            }
            if (checkBox6.Checked == true)
            {

                xp.Parameters.AddWithValue("@Saturday", checkBox6.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Saturday", "");
            }
            if (checkBox7.Checked == true)
            {

                xp.Parameters.AddWithValue("@Sunday", checkBox7.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Sunday", "");
            }
            connection.Open();
            xp.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Inserted successfully!!!");
            getInfo();
        }

        private void view_Click(object sender, EventArgs e)
        {
            getInfo();
        }
        public void getInfo()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from[dbo].[WorkingDaysAndTime]";
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            connection.Close();


        }

        private void update_Click(object sender, EventArgs e)
        {
            //string s = "";
            //foreach (Control connection in this.Controls)
            //{
            //    if (connection is CheckBox)
            //    {
            //        CheckBox b = (CheckBox)connection;
            //        if (b.Checked)
            //        {
            //            s = b.Text + "" + s;
            //        }
            //    }
            //}

            //connection.Open();
            //SqlCommand cmd = connection.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "update  [dbo].[WorkingDaysAndTime] set WorkingDays ='" + s + "' , NumOfWorkingHoursPerDay ='" + numOfWoringHoursPerDay.Value + "' ,StartTime = '" + startTime.Text + "' , EndTime ='" + endTime.Text + "' , TimeSlot='" + timeSlot.Text + "' where WoringDaysID = '"+ workingDayId.Text + "' ";
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //numOfWoringHoursPerDay.Value = 0;
            //startTime.Text = "";
            //endTime.Text = "";
            //timeSlot.Text = "";
            //workingDayId.Text = "";
            //getInfo();
            //MessageBox.Show("successfully updated");
            //SqlCommand("update tbl_Record set Name=@name,State=@state where ID=@id", con);

            SqlCommand xp = new SqlCommand("update [dbo].[WorkingDaysAndTime] set  NumOfWorkingHoursPerDay =@NumOfWorkingHoursPerDay ,StartTime =@startTime, EndTime =@endTime ,TimeSlot =@timeSlot ,Monday =@Monday ,Tuesday=@Tuesday,Wednesday=@Wednesday, Thursday=@Thursday,Friday =@Friday,Saturday =@Saturday ,Sunday =@Sunday where WoringDaysID = '" + workingDayId.Text + "' ", connection);

            xp.Parameters.AddWithValue("@NumOfWorkingHoursPerDay", numOfWoringHoursPerDay.Value);
            xp.Parameters.AddWithValue("@StartTime", startTime.Text);
            xp.Parameters.AddWithValue("@EndTime", endTime.Text);
            xp.Parameters.AddWithValue("@TimeSlot", timeSlot.Text);

            if (checkBox1.Checked == true)
            {

                xp.Parameters.AddWithValue("@Monday", checkBox1.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Monday", "");
            }
            if (checkBox2.Checked == true)
            {

                xp.Parameters.AddWithValue("@Tuesday", checkBox2.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Tuesday", "");
            }
            if (checkBox3.Checked == true)
            {

                xp.Parameters.AddWithValue("@Wednesday", checkBox3.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Wednesday", "");
            }
            if (checkBox4.Checked == true)
            {

                xp.Parameters.AddWithValue("@Thursday", checkBox4.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Thursday", "");
            }
            if (checkBox5.Checked == true)
            {

                xp.Parameters.AddWithValue("@Friday", checkBox5.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Friday", "");
            }
            if (checkBox6.Checked == true)
            {

                xp.Parameters.AddWithValue("@Saturday", checkBox6.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Saturday", "");
            }
            if (checkBox7.Checked == true)
            {

                xp.Parameters.AddWithValue("@Sunday", checkBox7.Text);
            }
            else
            {
                xp.Parameters.AddWithValue("@Sunday", "");
            }
            connection.Open();
            xp.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("updated successfully!!!");
            getInfo();



        }

        private void delete_Click(object sender, EventArgs e)
        {
            //string s = "";
            //foreach (Control connection in this.Controls)
            //{
            //    if (connection is CheckBox)
            //    {
            //        CheckBox b = (CheckBox)connection;
            //        if (b.Checked)
            //        {
            //            s = b.Text + "" + s;
            //        }
            //    }
            //}

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from  [dbo].[WorkingDaysAndTime]  where WoringDaysID = '" + workingDayId.Text + "' ";
            cmd.ExecuteNonQuery();
            connection.Close();
            numOfWoringHoursPerDay.Value = 0;
            startTime.Text = "";
            endTime.Text = "";
            timeSlot.Text = "";
            workingDayId.Text = "";
            getInfo();
            MessageBox.Show("successfully deleted");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            workingDayId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
