namespace Subject
{
    partial class editStudentDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editStudentDetails));
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textBoxSubGroup = new System.Windows.Forms.TextBox();
            this.subGroup = new System.Windows.Forms.Label();
            this.textBoxGroupNo = new System.Windows.Forms.TextBox();
            this.groupNo = new System.Windows.Forms.Label();
            this.textBoxProgramme = new System.Windows.Forms.TextBox();
            this.programme = new System.Windows.Forms.Label();
            this.yearsem = new System.Windows.Forms.Label();
            this.st_subgroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_groupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_subGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_groupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_programme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_year_sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxYearSem = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(444, 397);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(179, 29);
            this.textBoxId.TabIndex = 41;
            this.textBoxId.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(637, 564);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 38);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBoxSubGroup
            // 
            this.textBoxSubGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubGroup.Location = new System.Drawing.Point(882, 489);
            this.textBoxSubGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSubGroup.Name = "textBoxSubGroup";
            this.textBoxSubGroup.Size = new System.Drawing.Size(169, 29);
            this.textBoxSubGroup.TabIndex = 39;
            // 
            // subGroup
            // 
            this.subGroup.AutoSize = true;
            this.subGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGroup.Location = new System.Drawing.Point(698, 492);
            this.subGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subGroup.Name = "subGroup";
            this.subGroup.Size = new System.Drawing.Size(140, 24);
            this.subGroup.TabIndex = 38;
            this.subGroup.Text = "Sub - group No";
            // 
            // textBoxGroupNo
            // 
            this.textBoxGroupNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupNo.Location = new System.Drawing.Point(444, 496);
            this.textBoxGroupNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGroupNo.Name = "textBoxGroupNo";
            this.textBoxGroupNo.Size = new System.Drawing.Size(179, 29);
            this.textBoxGroupNo.TabIndex = 37;
            // 
            // groupNo
            // 
            this.groupNo.AutoSize = true;
            this.groupNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNo.Location = new System.Drawing.Point(281, 499);
            this.groupNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupNo.Name = "groupNo";
            this.groupNo.Size = new System.Drawing.Size(93, 24);
            this.groupNo.TabIndex = 36;
            this.groupNo.Text = "Group No";
            // 
            // textBoxProgramme
            // 
            this.textBoxProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProgramme.Location = new System.Drawing.Point(882, 445);
            this.textBoxProgramme.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProgramme.Name = "textBoxProgramme";
            this.textBoxProgramme.Size = new System.Drawing.Size(169, 29);
            this.textBoxProgramme.TabIndex = 35;
            // 
            // programme
            // 
            this.programme.AutoSize = true;
            this.programme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programme.Location = new System.Drawing.Point(698, 450);
            this.programme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.programme.Name = "programme";
            this.programme.Size = new System.Drawing.Size(109, 24);
            this.programme.TabIndex = 34;
            this.programme.Text = "Programme";
            // 
            // yearsem
            // 
            this.yearsem.AutoSize = true;
            this.yearsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsem.Location = new System.Drawing.Point(281, 448);
            this.yearsem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearsem.Name = "yearsem";
            this.yearsem.Size = new System.Drawing.Size(139, 24);
            this.yearsem.TabIndex = 32;
            this.yearsem.Text = "Year & Semester";
            // 
            // st_subgroupId
            // 
            this.st_subgroupId.HeaderText = "Sub - Group ID";
            this.st_subgroupId.MinimumWidth = 6;
            this.st_subgroupId.Name = "st_subgroupId";
            // 
            // st_groupId
            // 
            this.st_groupId.HeaderText = "Group ID";
            this.st_groupId.MinimumWidth = 6;
            this.st_groupId.Name = "st_groupId";
            // 
            // st_subGroup
            // 
            this.st_subGroup.HeaderText = "Sub Group No";
            this.st_subGroup.MinimumWidth = 6;
            this.st_subGroup.Name = "st_subGroup";
            // 
            // st_groupNo
            // 
            this.st_groupNo.HeaderText = "Group No";
            this.st_groupNo.MinimumWidth = 6;
            this.st_groupNo.Name = "st_groupNo";
            // 
            // st_programme
            // 
            this.st_programme.HeaderText = "Programme";
            this.st_programme.MinimumWidth = 6;
            this.st_programme.Name = "st_programme";
            // 
            // st_year_sem
            // 
            this.st_year_sem.HeaderText = "Year & Semester";
            this.st_year_sem.MinimumWidth = 6;
            this.st_year_sem.Name = "st_year_sem";
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // comboBoxYearSem
            // 
            this.comboBoxYearSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYearSem.FormattingEnabled = true;
            this.comboBoxYearSem.Items.AddRange(new object[] {
            "Y1.S1",
            "Y1.S2",
            "Y2.S1",
            "Y2.S2",
            "Y3.S1",
            "Y3.S2",
            "Y4.S1",
            "Y4.S2"});
            this.comboBoxYearSem.Location = new System.Drawing.Point(444, 445);
            this.comboBoxYearSem.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxYearSem.Name = "comboBoxYearSem";
            this.comboBoxYearSem.Size = new System.Drawing.Size(179, 32);
            this.comboBoxYearSem.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.st_year_sem,
            this.st_programme,
            this.st_groupNo,
            this.st_subGroup,
            this.st_groupId,
            this.st_subgroupId});
            this.dataGridView1.Location = new System.Drawing.Point(285, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(766, 271);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 43);
            this.label2.TabIndex = 44;
            this.label2.Text = "Student Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 39);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBoxSubGroup);
            this.Controls.Add(this.subGroup);
            this.Controls.Add(this.textBoxGroupNo);
            this.Controls.Add(this.groupNo);
            this.Controls.Add(this.textBoxProgramme);
            this.Controls.Add(this.programme);
            this.Controls.Add(this.yearsem);
            this.Controls.Add(this.comboBoxYearSem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "editStudentDetails";
            this.Text = "editStudentDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBoxSubGroup;
        private System.Windows.Forms.Label subGroup;
        private System.Windows.Forms.TextBox textBoxGroupNo;
        private System.Windows.Forms.Label groupNo;
        private System.Windows.Forms.TextBox textBoxProgramme;
        private System.Windows.Forms.Label programme;
        private System.Windows.Forms.Label yearsem;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_subgroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_groupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_subGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_groupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_programme;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_year_sem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ComboBox comboBoxYearSem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}