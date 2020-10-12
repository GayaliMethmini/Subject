﻿using System;
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
    public partial class viewStudentDetails : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public viewStudentDetails()
        {
            InitializeComponent();
            display_studentData();
        }

        public void display_studentData()
        {

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from [student] order by Id desc";
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
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();

            }
            conn.Close();
        }
            private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStudentDetails d = new addStudentDetails();
            d.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            //type of object command execute
            //text sql text command
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from [student] where GroupId ='" + textBoxSearch.Text + "'";
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
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
            }
            conn.Close();
            textBoxSearch.Text = " ";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            display_studentData();
        }
    }
}