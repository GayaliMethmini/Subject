namespace Subject
{
    partial class Lecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturer));
            this.label1 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelempId = new System.Windows.Forms.Label();
            this.labelfaculty = new System.Windows.Forms.Label();
            this.labeldep = new System.Windows.Forms.Label();
            this.labelcenter = new System.Windows.Forms.Label();
            this.labelbuilding = new System.Windows.Forms.Label();
            this.labellevel = new System.Windows.Forms.Label();
            this.buttonaddlec = new System.Windows.Forms.Button();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxempId = new System.Windows.Forms.TextBox();
            this.textBoxfac = new System.Windows.Forms.TextBox();
            this.textBoxdep = new System.Windows.Forms.TextBox();
            this.textBoxcenter = new System.Windows.Forms.TextBox();
            this.textBoxbuild = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxlevel = new System.Windows.Forms.ComboBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxsubj = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lecturer Details";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(139, 177);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(71, 24);
            this.labelname.TabIndex = 5;
            this.labelname.Text = "Name :";
            // 
            // labelempId
            // 
            this.labelempId.AutoSize = true;
            this.labelempId.BackColor = System.Drawing.Color.Transparent;
            this.labelempId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelempId.Location = new System.Drawing.Point(139, 138);
            this.labelempId.Name = "labelempId";
            this.labelempId.Size = new System.Drawing.Size(128, 24);
            this.labelempId.TabIndex = 6;
            this.labelempId.Text = "Employee ID :";
            // 
            // labelfaculty
            // 
            this.labelfaculty.AutoSize = true;
            this.labelfaculty.BackColor = System.Drawing.Color.Transparent;
            this.labelfaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfaculty.Location = new System.Drawing.Point(139, 220);
            this.labelfaculty.Name = "labelfaculty";
            this.labelfaculty.Size = new System.Drawing.Size(80, 24);
            this.labelfaculty.TabIndex = 7;
            this.labelfaculty.Text = "Faculty :";
            // 
            // labeldep
            // 
            this.labeldep.AutoSize = true;
            this.labeldep.BackColor = System.Drawing.Color.Transparent;
            this.labeldep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldep.Location = new System.Drawing.Point(139, 262);
            this.labeldep.Name = "labeldep";
            this.labeldep.Size = new System.Drawing.Size(117, 24);
            this.labeldep.TabIndex = 8;
            this.labeldep.Text = "Department :";
            // 
            // labelcenter
            // 
            this.labelcenter.AutoSize = true;
            this.labelcenter.BackColor = System.Drawing.Color.Transparent;
            this.labelcenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcenter.Location = new System.Drawing.Point(139, 307);
            this.labelcenter.Name = "labelcenter";
            this.labelcenter.Size = new System.Drawing.Size(76, 24);
            this.labelcenter.TabIndex = 9;
            this.labelcenter.Text = "Center :";
            // 
            // labelbuilding
            // 
            this.labelbuilding.AutoSize = true;
            this.labelbuilding.BackColor = System.Drawing.Color.Transparent;
            this.labelbuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbuilding.Location = new System.Drawing.Point(139, 350);
            this.labelbuilding.Name = "labelbuilding";
            this.labelbuilding.Size = new System.Drawing.Size(88, 24);
            this.labelbuilding.TabIndex = 10;
            this.labelbuilding.Text = "Building :";
            // 
            // labellevel
            // 
            this.labellevel.AutoSize = true;
            this.labellevel.BackColor = System.Drawing.Color.Transparent;
            this.labellevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellevel.Location = new System.Drawing.Point(139, 395);
            this.labellevel.Name = "labellevel";
            this.labellevel.Size = new System.Drawing.Size(70, 24);
            this.labellevel.TabIndex = 11;
            this.labellevel.Text = "Level  :";
            // 
            // buttonaddlec
            // 
            this.buttonaddlec.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonaddlec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddlec.Location = new System.Drawing.Point(239, 508);
            this.buttonaddlec.Name = "buttonaddlec";
            this.buttonaddlec.Size = new System.Drawing.Size(77, 37);
            this.buttonaddlec.TabIndex = 18;
            this.buttonaddlec.Text = "Add";
            this.buttonaddlec.UseVisualStyleBackColor = false;
            this.buttonaddlec.Click += new System.EventHandler(this.buttonaddlec_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.Location = new System.Drawing.Point(277, 176);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(221, 29);
            this.textBoxname.TabIndex = 20;
            // 
            // textBoxempId
            // 
            this.textBoxempId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxempId.Location = new System.Drawing.Point(277, 135);
            this.textBoxempId.Name = "textBoxempId";
            this.textBoxempId.Size = new System.Drawing.Size(221, 29);
            this.textBoxempId.TabIndex = 21;
            // 
            // textBoxfac
            // 
            this.textBoxfac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfac.Location = new System.Drawing.Point(277, 218);
            this.textBoxfac.Name = "textBoxfac";
            this.textBoxfac.Size = new System.Drawing.Size(221, 29);
            this.textBoxfac.TabIndex = 22;
            // 
            // textBoxdep
            // 
            this.textBoxdep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdep.Location = new System.Drawing.Point(277, 260);
            this.textBoxdep.Name = "textBoxdep";
            this.textBoxdep.Size = new System.Drawing.Size(221, 29);
            this.textBoxdep.TabIndex = 23;
            // 
            // textBoxcenter
            // 
            this.textBoxcenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcenter.Location = new System.Drawing.Point(277, 305);
            this.textBoxcenter.Name = "textBoxcenter";
            this.textBoxcenter.Size = new System.Drawing.Size(221, 29);
            this.textBoxcenter.TabIndex = 24;
            // 
            // textBoxbuild
            // 
            this.textBoxbuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbuild.Location = new System.Drawing.Point(277, 349);
            this.textBoxbuild.Name = "textBoxbuild";
            this.textBoxbuild.Size = new System.Drawing.Size(221, 29);
            this.textBoxbuild.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(533, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(811, 247);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsearch.Location = new System.Drawing.Point(632, 133);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(353, 29);
            this.textBoxsearch.TabIndex = 33;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(589, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxlevel
            // 
            this.comboBoxlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxlevel.FormattingEnabled = true;
            this.comboBoxlevel.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Senior Lecturer(HG)\t",
            "Senior Lecturer\t",
            "Lecturer\t",
            "Assistant Lecturer",
            "Instructors\t"});
            this.comboBoxlevel.Location = new System.Drawing.Point(277, 392);
            this.comboBoxlevel.Name = "comboBoxlevel";
            this.comboBoxlevel.Size = new System.Drawing.Size(221, 32);
            this.comboBoxlevel.TabIndex = 37;
            // 
            // buttonupdate
            // 
            this.buttonupdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(341, 508);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(79, 37);
            this.buttonupdate.TabIndex = 38;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(443, 508);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(77, 37);
            this.buttondelete.TabIndex = 40;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
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
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Subject  :";
            // 
            // comboBoxsubj
            // 
            this.comboBoxsubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxsubj.FormattingEnabled = true;
            this.comboBoxsubj.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Senior Lecturer(HG)\t",
            "Senior Lecturer\t",
            "Lecturer\t",
            "Assistant Lecturer",
            "Instructors\t"});
            this.comboBoxsubj.Location = new System.Drawing.Point(277, 441);
            this.comboBoxsubj.Name = "comboBoxsubj";
            this.comboBoxsubj.Size = new System.Drawing.Size(221, 32);
            this.comboBoxsubj.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(677, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 77;
            this.label3.Text = "Search by EmployeeID...";
            // 
            // Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1356, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxsubj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.comboBoxlevel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxbuild);
            this.Controls.Add(this.textBoxcenter);
            this.Controls.Add(this.textBoxdep);
            this.Controls.Add(this.textBoxfac);
            this.Controls.Add(this.textBoxempId);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.buttonaddlec);
            this.Controls.Add(this.labellevel);
            this.Controls.Add(this.labelbuilding);
            this.Controls.Add(this.labelcenter);
            this.Controls.Add(this.labeldep);
            this.Controls.Add(this.labelfaculty);
            this.Controls.Add(this.labelempId);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label1);
            this.Name = "Lecturer";
            this.Text = "Lecturer";
            this.Load += new System.EventHandler(this.Lecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelempId;
        private System.Windows.Forms.Label labelfaculty;
        private System.Windows.Forms.Label labeldep;
        private System.Windows.Forms.Label labelcenter;
        private System.Windows.Forms.Label labelbuilding;
        private System.Windows.Forms.Label labellevel;
        private System.Windows.Forms.Button buttonaddlec;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxempId;
        private System.Windows.Forms.TextBox textBoxfac;
        private System.Windows.Forms.TextBox textBoxdep;
        private System.Windows.Forms.TextBox textBoxcenter;
        private System.Windows.Forms.TextBox textBoxbuild;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxlevel;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxsubj;
        private System.Windows.Forms.Label label3;
    }
}