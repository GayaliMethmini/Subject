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
    public partial class editStudentDetails : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public editStudentDetails()
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
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();

            }
            conn.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String yearSem = comboBoxYearSem.SelectedItem.ToString();

            String programme = textBoxProgramme.Text;

            String groupNo = textBoxGroupNo.Text;

            String subGroupNo = textBoxSubGroup.Text;

            String groupId = yearSem + "." + programme + "." + groupNo;

            String subGroupId = yearSem + "." + programme + "." + groupNo + "." + subGroupNo;


            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [student] set  YearSem = '" + comboBoxYearSem.SelectedItem.ToString() + "', Programme ='" + textBoxProgramme.Text + "', GroupNo = '" + textBoxGroupNo.Text + "', SubGroup='" + textBoxSubGroup.Text + "',GroupId='" + groupId + "',SubGroupId='" + subGroupId + "'   where id='" + textBoxId.Text + "'";
            cmd.ExecuteNonQuery();

            conn.Close();

            textBoxId.Text = " ";
            comboBoxYearSem.SelectedItem = -1;
            textBoxProgramme.Text = " ";
            textBoxGroupNo.Text = " ";
            textBoxSubGroup.Text = " ";

            display_studentData();
            MessageBox.Show("student data  is updated successfully");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBoxYearSem.SelectedItem = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxProgramme.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxGroupNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxSubGroup.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStudentDetails d = new addStudentDetails();
            d.Show();
        }

    }
}