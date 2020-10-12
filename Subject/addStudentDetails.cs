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
    public partial class addStudentDetails : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public addStudentDetails()
        {
            //it defines everything you see in form
            InitializeComponent();
        }

        private void btnGenerateId_Click_1(object sender, EventArgs e)
        {
            String yearSem = comboBoxYearSem.SelectedItem.ToString();
            String y;
            String s;

            if (yearSem == "Y1.S1")
            {

                y = "year 1";
                s = " semester 1";
            }

            else if (yearSem == "Y1.S2")
            {

                y = "year 1";
                s = " semester 2";

            }

            else if (yearSem == "Y2.S1")
            {

                y = "year 2";
                s = " semester 1";

            }

            else if (yearSem == "Y2.S2")
            {

                y = "year 2";
                s = " semester 2";

            }

            else if (yearSem == "Y3.S1")
            {

                y = "year 3";
                s = " semester 1";

            }

            else if (yearSem == "Y3.S2")
            {

                y = "year 3";
                s = " semester 2";

            }

            else if (yearSem == "Y4.S1")
            {

                y = "year 4";
                s = " semester 1";

            }

            else
            {

                y = "year 4";
                s = " semester 2";

            }









            String programme = textBoxProgramme.Text;

            String groupNo = textBoxGroupNo.Text;

            String subGroupNo = textBoxSubGroup.Text;

            String groupId = yearSem + "." + programme + "." + groupNo;

            String subGroupId = yearSem + "." + programme + "." + groupNo + "." + subGroupNo;


            //String groupId = comboBoxYearSem.SelectedItem.ToString() + " ." + textBoxProgramme.Text + "." + textBoxGroupNo;

            //String subGroupId = comboBoxYearSem.SelectedItem.ToString() + " ." + textBoxProgramme.Text + "." + textBoxGroupNo + "." + textBoxSubGroup.Text;


            conn.Open();

            String qry = "insert into student (YearSem,Programme,GroupNo,SubGroup,GroupId,SubGroupId,Year,Semester) values ('" + yearSem + "', '" + programme + "','" + groupNo + "' ,'" + subGroupNo + "','" + groupId + "','" + subGroupId + "','" + y + "','" + s + "')";
            //object allows to query and send commands to db
            SqlCommand cmd = new SqlCommand(qry, conn);
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = " insert into [student] (YearSem,Programme,GroupNo,SubGroup,GroupId,SubGroupId) values ( '" +comboBoxYearSem.SelectedItem.ToString() + "', '" + textBoxProgramme.Text+"','"+textBoxGroupNo+"' ,'"+ textBoxSubGroup.Text+"')";

            //execute commands such as transact-sql insert, delete, update and set statements
            cmd.ExecuteNonQuery();
            conn.Close();

            comboBoxYearSem.SelectedItem = -1;
            textBoxProgramme.Text = " ";
            textBoxGroupNo.Text = " ";
            textBoxSubGroup.Text = " ";




            //display_tagData();
            MessageBox.Show(" student details added successfully");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            editStudentDetails f2 = new editStudentDetails();
            f2.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewStudentDetails f2 = new viewStudentDetails();
            f2.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteStudentDetails f2 = new deleteStudentDetails();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashBoard d = new dashBoard();
            d.Show();
        }

        private void textBoxProgramme_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxYearSem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGroupNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSubGroup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
