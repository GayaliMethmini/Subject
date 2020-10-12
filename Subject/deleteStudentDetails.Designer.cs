namespace Subject
{
    partial class deleteStudentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteStudentDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxSubGroupId = new System.Windows.Forms.TextBox();
            this.textBoxGroupId = new System.Windows.Forms.TextBox();
            this.subGroupId = new System.Windows.Forms.Label();
            this.groupId = new System.Windows.Forms.Label();
            this.textBoxSubGroup = new System.Windows.Forms.TextBox();
            this.subGroup = new System.Windows.Forms.Label();
            this.textBoxGroupNo = new System.Windows.Forms.TextBox();
            this.groupNo = new System.Windows.Forms.Label();
            this.textBoxProgramme = new System.Windows.Forms.TextBox();
            this.comboBoxYearSem = new System.Windows.Forms.ComboBox();
            this.yearsem = new System.Windows.Forms.Label();
            this.st_subgroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_groupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_subGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_groupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_programme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_year_sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programme = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 43);
            this.label1.TabIndex = 43;
            this.label1.Text = "Student Details";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(466, 382);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(173, 29);
            this.textBoxId.TabIndex = 42;
            this.textBoxId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(641, 594);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 38);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxSubGroupId
            // 
            this.textBoxSubGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubGroupId.Location = new System.Drawing.Point(899, 512);
            this.textBoxSubGroupId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSubGroupId.Name = "textBoxSubGroupId";
            this.textBoxSubGroupId.Size = new System.Drawing.Size(162, 29);
            this.textBoxSubGroupId.TabIndex = 40;
            // 
            // textBoxGroupId
            // 
            this.textBoxGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupId.Location = new System.Drawing.Point(466, 507);
            this.textBoxGroupId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGroupId.Name = "textBoxGroupId";
            this.textBoxGroupId.Size = new System.Drawing.Size(173, 29);
            this.textBoxGroupId.TabIndex = 39;
            // 
            // subGroupId
            // 
            this.subGroupId.AutoSize = true;
            this.subGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGroupId.Location = new System.Drawing.Point(747, 512);
            this.subGroupId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subGroupId.Name = "subGroupId";
            this.subGroupId.Size = new System.Drawing.Size(135, 24);
            this.subGroupId.TabIndex = 38;
            this.subGroupId.Text = "Sub - Group ID";
            // 
            // groupId
            // 
            this.groupId.AutoSize = true;
            this.groupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupId.Location = new System.Drawing.Point(301, 505);
            this.groupId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupId.Name = "groupId";
            this.groupId.Size = new System.Drawing.Size(85, 24);
            this.groupId.TabIndex = 37;
            this.groupId.Text = "Group ID";
            // 
            // textBoxSubGroup
            // 
            this.textBoxSubGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubGroup.Location = new System.Drawing.Point(899, 462);
            this.textBoxSubGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSubGroup.Name = "textBoxSubGroup";
            this.textBoxSubGroup.Size = new System.Drawing.Size(162, 29);
            this.textBoxSubGroup.TabIndex = 36;
            // 
            // subGroup
            // 
            this.subGroup.AutoSize = true;
            this.subGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGroup.Location = new System.Drawing.Point(746, 466);
            this.subGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subGroup.Name = "subGroup";
            this.subGroup.Size = new System.Drawing.Size(140, 24);
            this.subGroup.TabIndex = 35;
            this.subGroup.Text = "Sub - group No";
            // 
            // textBoxGroupNo
            // 
            this.textBoxGroupNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupNo.Location = new System.Drawing.Point(466, 466);
            this.textBoxGroupNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGroupNo.Name = "textBoxGroupNo";
            this.textBoxGroupNo.Size = new System.Drawing.Size(173, 29);
            this.textBoxGroupNo.TabIndex = 34;
            // 
            // groupNo
            // 
            this.groupNo.AutoSize = true;
            this.groupNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNo.Location = new System.Drawing.Point(301, 467);
            this.groupNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupNo.Name = "groupNo";
            this.groupNo.Size = new System.Drawing.Size(93, 24);
            this.groupNo.TabIndex = 33;
            this.groupNo.Text = "Group No";
            // 
            // textBoxProgramme
            // 
            this.textBoxProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProgramme.Location = new System.Drawing.Point(899, 417);
            this.textBoxProgramme.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProgramme.Name = "textBoxProgramme";
            this.textBoxProgramme.Size = new System.Drawing.Size(162, 29);
            this.textBoxProgramme.TabIndex = 32;
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
            this.comboBoxYearSem.Location = new System.Drawing.Point(466, 420);
            this.comboBoxYearSem.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxYearSem.Name = "comboBoxYearSem";
            this.comboBoxYearSem.Size = new System.Drawing.Size(173, 32);
            this.comboBoxYearSem.TabIndex = 30;
            // 
            // yearsem
            // 
            this.yearsem.AutoSize = true;
            this.yearsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsem.Location = new System.Drawing.Point(301, 420);
            this.yearsem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearsem.Name = "yearsem";
            this.yearsem.Size = new System.Drawing.Size(139, 24);
            this.yearsem.TabIndex = 29;
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
            // programme
            // 
            this.programme.AutoSize = true;
            this.programme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programme.Location = new System.Drawing.Point(747, 420);
            this.programme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.programme.Name = "programme";
            this.programme.Size = new System.Drawing.Size(109, 24);
            this.programme.TabIndex = 31;
            this.programme.Text = "Programme";
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
            this.dataGridView1.Location = new System.Drawing.Point(305, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 243);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
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
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textBoxSubGroupId);
            this.Controls.Add(this.textBoxGroupId);
            this.Controls.Add(this.subGroupId);
            this.Controls.Add(this.groupId);
            this.Controls.Add(this.textBoxSubGroup);
            this.Controls.Add(this.subGroup);
            this.Controls.Add(this.textBoxGroupNo);
            this.Controls.Add(this.groupNo);
            this.Controls.Add(this.textBoxProgramme);
            this.Controls.Add(this.comboBoxYearSem);
            this.Controls.Add(this.yearsem);
            this.Controls.Add(this.programme);
            this.Controls.Add(this.dataGridView1);
            this.Name = "deleteStudentDetails";
            this.Text = "deleteStudentDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxSubGroupId;
        private System.Windows.Forms.TextBox textBoxGroupId;
        private System.Windows.Forms.Label subGroupId;
        private System.Windows.Forms.Label groupId;
        private System.Windows.Forms.TextBox textBoxSubGroup;
        private System.Windows.Forms.Label subGroup;
        private System.Windows.Forms.TextBox textBoxGroupNo;
        private System.Windows.Forms.Label groupNo;
        private System.Windows.Forms.TextBox textBoxProgramme;
        private System.Windows.Forms.ComboBox comboBoxYearSem;
        private System.Windows.Forms.Label yearsem;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_subgroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_groupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_subGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_groupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_programme;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_year_sem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label programme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}