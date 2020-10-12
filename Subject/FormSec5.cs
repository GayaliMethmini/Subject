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
using DGVPrinterHelper;

namespace Subject
{
    public partial class FormSec5 : Form
    {
        SqlConnection connection = new SqlConnection(@"Server=tcp:team25.database.windows.net,1433;Initial Catalog=infinityTimeTable;Persist Security Info=False;User ID=teamInfinity;Password=adminTeam25;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public FormSec5()
        {
            InitializeComponent();
        }

        TimeSpan intervalSTime = new TimeSpan(12, 30, 0);
        TimeSpan intervalETime = new TimeSpan(1, 30, 0);

        string lecturer, studentGroup, room, fullNameLec;
        string type;

        string year, semester;
        string lecM;

        int workingDays = 5;
        int workingHrs = 9;
        int totalCells;
        int cellsPerGroup = 0;
        int timeGap = 60;
        int maxNumMod = 12;

        int m; //Sub Array Index
        int w;
        int p; //Lec Array Index
        int allZeroCheck;

        int gridRowCount;
        int hvMod = 0;

        int inStudentM = 0;
        int inLecM = 0;
        int inRoomM = 0;

        int roomCount;
        int subCount;
        int lecCount;
        int studentGCount;

        int[] timeSlot = new int[500];
        string[] moduleCode = new string[500];
        string[] lectureMCode = new string[500];
        string[] roomCode = new string[500];
        List<String> roomCodev = new List<String>();
        string[] groupYS = new string[500];

        string[] chooseMod = new string[500];
        string[] chooseLec = new string[500];
        string[] chooseRoom = new string[500];

        string nLine = Environment.NewLine;

        string ttName;
        string lecTitle;

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            room = comboBox3.SelectedItem.ToString();
            type = "loc";

            inRoomM = 1;

            createTimeTable(room, type);

            hvMod = 0;
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (inLecM == 1 || inStudentM == 1 || inRoomM == 1)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = ttName;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "SLIIT Time Table";
                printer.FooterSpacing = 15;
                //printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(dataGridView1);
            }
            else
            {
                MessageBox.Show("Fisrt Set the TimeTable", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //create timetable 

        private void createTimeTable(string comboSelect, string type)
        {
            ttName = comboSelect;

            dataGridView1.Rows.Clear();


            if (workingDays == 7)
            {
                if (timeGap == 30)
                {
                    gridRowCount = (workingHrs * 60 / timeGap) - 1;
                }
                else
                {
                    gridRowCount = (workingHrs * 60 / timeGap) + 1;
                }
                dataGridView1.RowCount = gridRowCount;
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "Period";
                dataGridView1.Columns[1].Name = "Monday";
                dataGridView1.Columns[2].Name = "Tuesday";
                dataGridView1.Columns[3].Name = "Wednesday";
                dataGridView1.Columns[4].Name = "Thursday";
                dataGridView1.Columns[5].Name = "Friday";
                dataGridView1.Columns[6].Name = "Saturday";
                dataGridView1.Columns[7].Name = "Sunday";
            }
            if (workingDays == 5)
            {
                if (timeGap == 30)
                {
                    gridRowCount = (workingHrs * 60 / timeGap);
                }
                else
                {
                    gridRowCount = (workingHrs * 60 / timeGap) + 1;
                }
                dataGridView1.RowCount = gridRowCount;
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Period";
                dataGridView1.Columns[1].Name = "Monday";
                dataGridView1.Columns[2].Name = "Tuesday";
                dataGridView1.Columns[3].Name = "Wednesday";
                dataGridView1.Columns[4].Name = "Thursday";
                dataGridView1.Columns[5].Name = "Friday";
            }

            TimeSpan startTime = new TimeSpan(8, 30, 0);
            TimeSpan periodTimeGap = new TimeSpan(0, timeGap, 0);

            for (int t = 0; t < gridRowCount; t++)
            {
                if (startTime == intervalSTime + periodTimeGap)
                {
                    dataGridView1.Rows[t].Cells[0].Value = intervalETime;
                    startTime = intervalETime + periodTimeGap;
                }
                else
                {
                    dataGridView1.Rows[t].Cells[0].Value = startTime;
                    startTime += periodTimeGap;
                }
            }

            totalCells = workingDays * (workingHrs * 60 / timeGap) - 5;

            if (type == "lec")
            {
                for (int a = 0; a < chooseMod.Length; a++)
                {
                    chooseLec[a] = "";
                }

                if (inStudentM == 1 || (inStudentM == 1 && inRoomM == 1))
                {
                    p = 0;
                    allZeroCheck = 0;

                    for (int i = 0; i < lecCount; i++)
                    {
                        if (lectureMCode[3 * i] == comboSelect.Split(' ')[comboSelect.Split(' ').Length - 1])
                        {
                            lecM = lectureMCode[(3 * i) + 1];
                        }
                    }

                    for (int v = 0; v < subCount; v++)
                    {
                        if (moduleCode[(8 * v) + 7] != "")
                        {

                            if (lecM == moduleCode[(8 * v) + 7])
                            {
                                for (int u = 0; u < chooseMod.Length; u++)
                                {

                                    if (chooseMod[u] != "" && chooseMod[u].Split(' ')[0] == moduleCode[8 * v])
                                    {

                                        hvMod = 1;

                                        chooseLec[p] = chooseMod[u] + " " + nLine + "Y" + moduleCode[(8 * v) + 1] + "S" + moduleCode[(8 * v) + 2] + " " + nLine + chooseMod[u].Split(' ')[2];

                                        p += 1;
                                    }

                                    if (chooseMod[u] != "" && chooseMod[u].Split(' ')[0] != moduleCode[8 * v])
                                    {
                                        chooseLec[p] = "";
                                        p += 1;
                                        allZeroCheck += 1;
                                    }
                                }

                                if (allZeroCheck == p)
                                {

                                    hvMod = 1;

                                    p = 0;

                                    if ((int.Parse(moduleCode[(8 * v) + 3]) * 60) >= timeGap)
                                    {
                                        for (int r = 0; r < int.Parse(moduleCode[(8 * v) + 3]) * 60 / timeGap; r++)
                                        {
                                            chooseLec[p + r] = moduleCode[8 * v] + " " + "(Lecture)" + " " + nLine + "Y" + moduleCode[(8 * v) + 1] + "S" + moduleCode[(8 * v) + 2] + " " + nLine + selectRandomRoom(roomCodev);
                                        }
                                        p += int.Parse(moduleCode[(8 * v) + 3]) * 60 / timeGap;
                                        loadRoomArray(roomCodev, roomCode, roomCount);
                                    }
                                    if ((int.Parse(moduleCode[(8 * v) + 4]) * 60) >= timeGap)
                                    {
                                        for (int r1 = 0; r1 < int.Parse(moduleCode[(8 * v) + 4]) * 60 / timeGap; r1++)
                                        {
                                            chooseLec[p + r1] = moduleCode[8 * v] + " " + "(Lab)" + " " + nLine + "Y" + moduleCode[(8 * v) + 1] + "S" + moduleCode[(8 * v) + 2] + " " + nLine + selectRandomRoom(roomCodev);
                                        }
                                        p += int.Parse(moduleCode[(8 * v) + 4]) * 60 / timeGap;
                                        loadRoomArray(roomCodev, roomCode, roomCount);
                                    }
                                    if ((int.Parse(moduleCode[(8 * v) + 5]) * 60) >= timeGap)
                                    {
                                        for (int r2 = 0; r2 < int.Parse(moduleCode[(8 * v) + 5]) * 60 / timeGap; r2++)
                                        {
                                            chooseLec[p + r2] = moduleCode[8 * v] + " " + "(Tute)" + " " + nLine + "Y" + moduleCode[(8 * v) + 1] + "S" + moduleCode[(8 * v) + 2] + " " + nLine + selectRandomRoom(roomCodev);
                                        }
                                        p += int.Parse(moduleCode[(8 * v) + 5]) * 60 / timeGap;
                                        loadRoomArray(roomCodev, roomCode, roomCount);
                                    }
                                    if ((int.Parse(moduleCode[(8 * v) + 6]) * 60) >= timeGap)
                                    {
                                        for (int r3 = 0; r3 < int.Parse(moduleCode[(8 * v) + 6]) * 60 / timeGap; r3++)
                                        {
                                            chooseLec[p + r3] = moduleCode[8 * v] + " " + "(Evaluation)" + " " + nLine + "Y" + moduleCode[(8 * v) + 1] + "S" + moduleCode[(8 * v) + 2] + " " + nLine + selectRandomRoom(roomCodev);
                                        }
                                        p += int.Parse(moduleCode[(8 * v) + 6]) * 60 / timeGap;
                                        loadRoomArray(roomCodev, roomCode, roomCount);
                                    }
                                }
                            }
                        }
                    }

                    w = 0;

                    if (p <= totalCells)
                    {
                        for (int f = 1; f < workingDays + 1; f++)
                        {
                            for (int d = 0; d < gridRowCount - 1; d++)
                            {
                                if (chooseLec[w] != "" && d != (4 * 60 / timeGap) && hvMod == 1)
                                {
                                    dataGridView1.Rows[d].Cells[f].Value = chooseLec[w];
                                    w += 1;
                                }
                                if (d == (4 * 60 / timeGap))
                                {
                                    dataGridView1.Rows[d].Cells[f].Value = "*";
                                }
                                if (chooseLec[w] == "")
                                {
                                    w += 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (p >= totalCells)
                        {
                            MessageBox.Show("Can't Exceed the Maximum Number of Time Solts", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    p = 0;

                    for (int i = 0; i < lecCount; i++)
                    {
                        if (lectureMCode[3 * i] == comboSelect.Split(' ')[comboSelect.Split(' ').Length - 1])
                        {
                            lecM = lectureMCode[(3 * i) + 1];
                        }
                    }

                    for (int v = 0; v < subCount; v++)
                    {
                        if (moduleCode[(8 * v) + 7] != "")
                        {
                            if (lecM == moduleCode[(8 * v) + 7])
                            {
                                hvMod = 1;

                                if ((int.Parse(moduleCode[(8 * v) + 3]) * 60) >= timeGap)
                                {
                                    for (int r = 0; r < int.Parse(moduleCode[(8 * v) + 3]) * 60 / timeGap; r++)
                                    {
                                        chooseLec[p + r] = moduleCode[8 * v] + " " + "(Lecture)" + " " + nLine + "Y" + moduleCode[(8 * v) + 1] + "S" + moduleCode[(8 * v) + 2] + " " + nLine + selectRandomRoom(roomCodev);
                                    }
                                    p += int.Parse(moduleCode[(8 * v) + 3]) * 60 / timeGap;
                                    loadRoomArray(roomCodev, roomCode, roomCount);
                                }
                                if ((int.Parse(moduleCode[(8 * v) + 4]) * 60) >= timeGap)
                                {
                                    for (int r1 = 0; r1 < int.Parse(moduleCode[(8 * v) + 4]) * 60 / timeGap; r1++)
                                    {
                                        chooseLec[p + r1] = moduleCode[8 * v] + " " + "(Lab)" + " " + nLine + "Y" + moduleCode[(8 * v) + 1] + "S" + moduleCode[(8 * v) + 2] + " " + nLine + selectRandomRoom(roomCodev);
                                    }
                                    p += int.Parse(moduleCode[(8 * v) + 4]) * 60 / timeGap;
                                    loadRoomArray(roomCodev, roomCode, roomCount);
                                }
                                if ((int.Parse(moduleCode[(8 * v) + 5]) * 60) >= timeGap)
                                {
                                    for (int r2 = 0; r2 < int.Parse(moduleCode[(8 * v) + 5]) * 60 / timeGap; r2++)
                                    {
                                        chooseLec[p + r2] = moduleCode[8 * v] + " " + "(Tute)" + " " + nLine + "Y" + moduleCode[(8 * v) + 1] + "S" + moduleCode[(8 * v) + 2] + " " + nLine + selectRandomRoom(roomCodev);
                                    }
                                    p += int.Parse(moduleCode[(8 * v) + 5]) * 60 / timeGap;
                                    loadRoomArray(roomCodev, roomCode, roomCount);
                                }
                                if ((int.Parse(moduleCode[(8 * v) + 6]) * 60) >= timeGap)
                                {
                                    for (int r3 = 0; r3 < int.Parse(moduleCode[(8 * v) + 6]) * 60 / timeGap; r3++)
                                    {
                                        chooseLec[p + r3] = moduleCode[8 * v] + " " + "(Evaluation)" + " " + nLine + "Y" + moduleCode[(8 * v) + 1] + "S" + moduleCode[(8 * v) + 2] + " " + nLine + selectRandomRoom(roomCodev);
                                    }
                                    p += int.Parse(moduleCode[(8 * v) + 6]) * 60 / timeGap;
                                    loadRoomArray(roomCodev, roomCode, roomCount);
                                }
                            }
                        }
                    }

                    w = 0;

                    if (p <= totalCells)
                    {
                        for (int f = 1; f < workingDays + 1; f++)
                        {
                            for (int d = 0; d < gridRowCount - 1; d++)
                            {
                                if (chooseLec[w] != "" && d != (4 * 60 / timeGap) && hvMod == 1)
                                {
                                    dataGridView1.Rows[d].Cells[f].Value = chooseLec[w];
                                    w += 1;
                                }
                                if (d == (4 * 60 / timeGap))
                                {
                                    dataGridView1.Rows[d].Cells[f].Value = "*";
                                }
                                if (chooseLec[w] == "")
                                {
                                    w += 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (p >= totalCells)
                        {
                            MessageBox.Show("Can't Exceed the Maximum Number of Time Solts", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        }
                    }
                }


            }

            if (type == "group")
            {
                int totalTime = 0;

                for (int a = 0; a < chooseMod.Length; a++)
                {
                    chooseMod[a] = "";
                }

                for (int i = 0; i < studentGCount; i++)
                {
                    if (groupYS[3 * i] == comboSelect)
                    {
                        year = groupYS[(3 * i) + 1];
                        semester = groupYS[(3 * i) + 2];
                    }
                }

                m = 0;

                for (int k = 0; k < subCount; k++)
                {
                    if (moduleCode[(8 * k) + 1] == year && moduleCode[(8 * k) + 2] == semester)
                    {
                        hvMod = 1;

                        if ((int.Parse(moduleCode[(8 * k) + 3]) * 60) >= timeGap)
                        {
                            for (int r = 0; r < int.Parse(moduleCode[(8 * k) + 3]) * 60 / timeGap; r++)
                            {
                                chooseMod[m + r] = moduleCode[8 * k] + " " + "(Lecture)" + " " + nLine + selectRandomRoom(roomCodev);
                            }
                            m += int.Parse(moduleCode[(8 * k) + 3]) * 60 / timeGap;
                            loadRoomArray(roomCodev, roomCode, roomCount);
                        }
                        if ((int.Parse(moduleCode[(8 * k) + 4]) * 60) >= timeGap)
                        {
                            for (int r1 = 0; r1 < int.Parse(moduleCode[(8 * k) + 4]) * 60 / timeGap; r1++)
                            {
                                chooseMod[m + r1] = moduleCode[8 * k] + " " + "(Lab)" + " " + nLine + selectRandomRoom(roomCodev);
                            }
                            m += int.Parse(moduleCode[(8 * k) + 4]) * 60 / timeGap;
                            loadRoomArray(roomCodev, roomCode, roomCount);
                        }
                        if ((int.Parse(moduleCode[(8 * k) + 5]) * 60) >= timeGap)
                        {
                            for (int r2 = 0; r2 < int.Parse(moduleCode[(8 * k) + 5]) * 60 / timeGap; r2++)
                            {
                                chooseMod[m + r2] = moduleCode[8 * k] + " " + "(Tute)" + " " + nLine + selectRandomRoom(roomCodev);
                            }
                            m += int.Parse(moduleCode[(8 * k) + 5]) * 60 / timeGap;
                            loadRoomArray(roomCodev, roomCode, roomCount);
                        }
                        if ((int.Parse(moduleCode[(8 * k) + 6]) * 60) >= timeGap)
                        {
                            for (int r3 = 0; r3 < int.Parse(moduleCode[(8 * k) + 6]) * 60 / timeGap; r3++)
                            {
                                chooseMod[m + r3] = moduleCode[8 * k] + " " + "(Evaluation)" + " " + nLine + selectRandomRoom(roomCodev);
                            }
                            m += int.Parse(moduleCode[(8 * k) + 6]) * 60 / timeGap;
                            loadRoomArray(roomCodev, roomCode, roomCount);
                        }

                        totalTime += int.Parse(moduleCode[(8 * k) + 3]);
                        totalTime += int.Parse(moduleCode[(8 * k) + 4]);
                        totalTime += int.Parse(moduleCode[(8 * k) + 5]);
                        totalTime += int.Parse(moduleCode[(8 * k) + 6]);
                    }
                }

                cellsPerGroup = (totalTime * 60) / timeGap;

                w = 0;

                if (cellsPerGroup <= totalCells && subCount <= maxNumMod)
                {
                    for (int f = 1; f < workingDays + 1; f++)
                    {
                        for (int d = 0; d < gridRowCount - 1; d++)
                        {
                            if (chooseMod[w] != "" && d != (4 * 60 / timeGap) && hvMod == 1)
                            {
                                dataGridView1.Rows[d].Cells[f].Value = chooseMod[w];
                                w += 1;
                            }
                            if (d == (4 * 60 / timeGap))
                            {
                                dataGridView1.Rows[d].Cells[f].Value = "*";
                            }
                            if (chooseMod[w] == "")
                            {
                                w += 1;
                            }
                        }
                    }

                }
                else
                {
                    if (cellsPerGroup >= totalCells)
                    {
                        MessageBox.Show("Can't Exceed the Maximum Number of Time Solts", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Can't Exceed the Maximum Number of Modules Per Semester", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }

                }
            }

            if (type == "loc")
            {
                for (int a = 0; a < chooseMod.Length; a++)
                {
                    chooseRoom[a] = "";
                }

                if (inStudentM == 1 || (inStudentM == 1 && inLecM == 1))
                {
                    p = 0;
                    allZeroCheck = 0;

                    for (int u = 0; u < chooseMod.Length; u++)
                    {
                        hvMod = 1;

                        if (chooseMod[u] != "" && chooseMod[u].Split(' ')[2] == nLine + comboSelect)
                        {
                            hvMod = 1;

                            chooseRoom[p] = chooseMod[u].Split(' ')[0] + " " + chooseMod[u].Split(' ')[1] + " " + nLine + "Y" + getYSLFromMCode(chooseMod[u].Split(' ')[0], moduleCode, lectureMCode)[0] + "S" + getYSLFromMCode(chooseMod[u].Split(' ')[0], moduleCode, lectureMCode)[1] + " " + nLine + getYSLFromMCode(chooseMod[u].Split(' ')[0], moduleCode, lectureMCode)[2];
                            p += 1;
                        }

                        if (chooseMod[u] != "" && chooseMod[u].Split(' ')[2] != nLine + comboSelect)
                        {
                            chooseRoom[p] = "";
                            p += 1;
                        }
                    }

                    w = 0;

                    if (p <= totalCells)
                    {
                        for (int f = 1; f < workingDays + 1; f++)
                        {
                            for (int d = 0; d < gridRowCount - 1; d++)
                            {
                                if (chooseRoom[w] != "" && d != (4 * 60 / timeGap) && hvMod == 1)
                                {
                                    dataGridView1.Rows[d].Cells[f].Value = chooseRoom[w];
                                    w += 1;
                                }
                                if (d == (4 * 60 / timeGap))
                                {
                                    dataGridView1.Rows[d].Cells[f].Value = "*";
                                }
                                if (chooseRoom[w] == "")
                                {
                                    w += 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (p >= totalCells)
                        {
                            MessageBox.Show("Can't Exceed the Maximum Number of Time Solts", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    hvMod = 1;
                    p = 0;

                    string module = selectRandomSub(moduleCode, subCount);
                    string lecTime = getYSLFromMCode(module, moduleCode, lectureMCode)[3];
                    string labTime = getYSLFromMCode(module, moduleCode, lectureMCode)[4];
                    string tuteTime = getYSLFromMCode(module, moduleCode, lectureMCode)[5];
                    string evaluationTime = getYSLFromMCode(module, moduleCode, lectureMCode)[6];


                    if ((int.Parse(lecTime) * 60) >= timeGap)
                    {
                        for (int r = 0; r < int.Parse(lecTime) * 60 / timeGap; r++)
                        {
                            chooseRoom[p + r] = module + " " + "(Lecture)" + " " + nLine + "Y" + getYSLFromMCode(module, moduleCode, lectureMCode)[0] + "S" + getYSLFromMCode(module, moduleCode, lectureMCode)[1] + " " + nLine + getYSLFromMCode(module, moduleCode, lectureMCode)[2];
                        }
                        p += int.Parse(lecTime) * 60 / timeGap;
                    }
                    if ((int.Parse(labTime) * 60) >= timeGap)
                    {
                        for (int r1 = 0; r1 < int.Parse(labTime) * 60 / timeGap; r1++)
                        {
                            chooseRoom[p + r1] = module + " " + "(Lab)" + " " + nLine + "Y" + getYSLFromMCode(module, moduleCode, lectureMCode)[0] + "S" + getYSLFromMCode(module, moduleCode, lectureMCode)[1] + " " + nLine + getYSLFromMCode(module, moduleCode, lectureMCode)[2];
                        }
                        p += int.Parse(labTime) * 60 / timeGap;
                    }
                    if ((int.Parse(tuteTime) * 60) >= timeGap)
                    {
                        for (int r2 = 0; r2 < int.Parse(tuteTime) * 60 / timeGap; r2++)
                        {
                            chooseRoom[p + r2] = module + " " + "(Tute)" + " " + nLine + "Y" + getYSLFromMCode(module, moduleCode, lectureMCode)[0] + "S" + getYSLFromMCode(module, moduleCode, lectureMCode)[1] + " " + nLine + getYSLFromMCode(module, moduleCode, lectureMCode)[2];
                        }
                        p += int.Parse(tuteTime) * 60 / timeGap;
                    }
                    if ((int.Parse(evaluationTime) * 60) >= timeGap)
                    {
                        for (int r3 = 0; r3 < int.Parse(evaluationTime) * 60 / timeGap; r3++)
                        {
                            chooseRoom[p + r3] = module + " " + "(Evaluation)" + " " + nLine + "Y" + getYSLFromMCode(module, moduleCode, lectureMCode)[0] + "S" + getYSLFromMCode(module, moduleCode, lectureMCode)[1] + " " + nLine + getYSLFromMCode(module, moduleCode, lectureMCode)[2];
                        }
                        p += int.Parse(evaluationTime) * 60 / timeGap;
                    }

                    w = 0;

                    if (p <= totalCells)
                    {
                        for (int f = 1; f < workingDays + 1; f++)
                        {
                            for (int d = 0; d < gridRowCount - 1; d++)
                            {
                                if (chooseRoom[w] != "" && d != (4 * 60 / timeGap) && hvMod == 1)
                                {
                                    dataGridView1.Rows[d].Cells[f].Value = chooseRoom[w];
                                    w += 1;
                                }
                                if (d == (4 * 60 / timeGap))
                                {
                                    dataGridView1.Rows[d].Cells[f].Value = "*";
                                }
                                if (chooseRoom[w] == "")
                                {
                                    w += 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (p >= totalCells)
                        {
                            MessageBox.Show("Can't Exceed the Maximum Number of Time Solts", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        //

        private string selectRandomSub(string[] arr, int count)
        {
            Random ran = new Random();
            int index = ran.Next(count);
            string sub = arr[8 * index];
            return sub;
        }

        private string selectRandomRoom(List<string> arr)
        {
            Random ran = new Random();
            int index = ran.Next(arr.Count);
            string room = arr[index];
            arr.RemoveAt(index);
            return room;
        }

        private List<string> loadRoomArray(List<string> arr1, string[] arr2, int count)
        {
            arr1.Clear();
            for (int i = 0; i < count; i++)
            {
                arr1.Add(arr2[i]);
            }
            return arr1;
        }
        private string[] getLecTitle(string[] arr2, string lec, int count)
        {
            string[] arr = new string[2];
            for (int i = 0; i < count; i++)
            {
                if (arr2[(3 * i)] == lec)
                {
                    arr[0] = arr2[(3 * i) + 2];
                }
            }
            return arr;
        }
        private string[] getYSLFromMCode(string modCode, string[] arr2, string[] arr3)
        {
            string[] arr1 = new string[8];
            for (int i = 0; i < arr2.Length / 8; i++)
            {
                if (arr2[8 * i] != "")
                {
                    if (arr2[(8 * i)] == modCode)
                    {
                        arr1[0] = arr2[(8 * i) + 1];
                        arr1[1] = arr2[(8 * i) + 2];
                        arr1[3] = arr2[(8 * i) + 3];
                        arr1[4] = arr2[(8 * i) + 4];
                        arr1[5] = arr2[(8 * i) + 5];
                        arr1[6] = arr2[(8 * i) + 6];
                        arr1[7] = arr2[(8 * i) + 7];
                    }
                }
            }

            for (int j = 0; j < arr3.Length / 3; j++)
            {
                if (arr3[3 * j] != "")
                {
                    if (arr3[(3 * j) + 1] == arr1[7])
                    {
                        arr1[2] = arr3[(3 * j) + 2] + " " + arr3[(3 * j)];
                    }
                }
            }

            return arr1;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentGroup = comboBox2.SelectedItem.ToString();
            type = "group";

            inStudentM = 1;

            createTimeTable(studentGroup, type);

            hvMod = 0;
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lecturer = comboBox1.SelectedItem.ToString();

            lecTitle = getLecTitle(lectureMCode, lecturer, lecCount)[0];

            fullNameLec = lecTitle + " " + lecturer;

            type = "lec";

            inLecM = 1;

            createTimeTable(fullNameLec, type);

            hvMod = 0;
        }

        


        private void FormSec5_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Lecturers]";

            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                lectureMCode[3 * i] = data.Rows[i][1].ToString();
                lectureMCode[(3 * i) + 1] = data.Rows[i][8].ToString();
                lectureMCode[(3 * i) + 2] = data.Rows[i][6].ToString();
                comboBox1.Items.Add(lectureMCode[3 * i]);
            }

            lecCount = data.Rows.Count;

            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from [student]";

            cmd2.ExecuteNonQuery();
            DataTable data2 = new DataTable();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
            sqlDataAdapter2.Fill(data2);

            for (int i = 0; i < data2.Rows.Count; i++)
            {
                groupYS[3 * i] = data2.Rows[i][1].ToString();
                groupYS[(3 * i) + 1] = data2.Rows[i][7].ToString();
                groupYS[(3 * i) + 2] = data2.Rows[i][8].ToString();
                comboBox2.Items.Add(groupYS[3 * i]);
            }

            studentGCount = data2.Rows.Count;

            SqlCommand cmd3 = connection.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from [Location]";

            cmd3.ExecuteNonQuery();
            DataTable data3 = new DataTable();
            SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter(cmd3);
            sqlDataAdapter3.Fill(data3);

            for (int i = 0; i < data3.Rows.Count; i++)
            {
                roomCode[i] = data3.Rows[i][2].ToString();
                roomCodev.Add(data3.Rows[i][2].ToString());
                comboBox3.Items.Add(roomCode[i]);
            }

            roomCount = roomCodev.Count;

            SqlCommand cmd4 = connection.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select * from [Subject]";

            cmd4.ExecuteNonQuery();
            DataTable data4 = new DataTable();
            SqlDataAdapter sqlDataAdapter4 = new SqlDataAdapter(cmd4);
            sqlDataAdapter4.Fill(data4);

            for (int i = 0; i < data4.Rows.Count; i++)
            {
                moduleCode[8 * i] = data4.Rows[i][0].ToString();
                moduleCode[(8 * i) + 1] = data4.Rows[i][2].ToString();
                moduleCode[(8 * i) + 2] = data4.Rows[i][3].ToString();
                moduleCode[(8 * i) + 3] = data4.Rows[i][4].ToString();
                moduleCode[(8 * i) + 4] = data4.Rows[i][5].ToString();
                moduleCode[(8 * i) + 5] = data4.Rows[i][6].ToString();
                moduleCode[(8 * i) + 6] = data4.Rows[i][7].ToString();
                moduleCode[(8 * i) + 7] = data4.Rows[i][1].ToString();
            }

            subCount = data4.Rows.Count;

            SqlCommand cmd5 = connection.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select * from [WorkingDaysAndTime]";

            cmd5.ExecuteNonQuery();
            DataTable data5 = new DataTable();
            SqlDataAdapter sqlDataAdapter5 = new SqlDataAdapter(cmd5);
            sqlDataAdapter5.Fill(data5);

            for (int i = 0; i < data5.Rows.Count; i++)
            {
                timeSlot[i] = int.Parse(data5.Rows[i][4].ToString());
            }

            connection.Close();


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            dashBoard newForm = new dashBoard();
            newForm.Show();
            this.Hide();
        }
    }
}
