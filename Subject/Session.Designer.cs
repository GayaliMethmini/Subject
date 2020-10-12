namespace Subject
{
    partial class Session
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Session));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labellec = new System.Windows.Forms.Label();
            this.labelsubj = new System.Windows.Forms.Label();
            this.labelsubCode = new System.Windows.Forms.Label();
            this.labeltag = new System.Windows.Forms.Label();
            this.labelgroup = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.labelduration = new System.Windows.Forms.Label();
            this.comboBoxlec = new System.Windows.Forms.ComboBox();
            this.comboBoxtag = new System.Windows.Forms.ComboBox();
            this.comboBoxgroup = new System.Windows.Forms.ComboBox();
            this.textBoxcount = new System.Windows.Forms.TextBox();
            this.textBoxduration = new System.Windows.Forms.TextBox();
            this.buttonaddsess = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSubcode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxsubj = new System.Windows.Forms.TextBox();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxsch = new System.Windows.Forms.TextBox();
            this.textBoxsrch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 39);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 43);
            this.label1.TabIndex = 43;
            this.label1.Text = "Session Details";
            // 
            // labellec
            // 
            this.labellec.AutoSize = true;
            this.labellec.BackColor = System.Drawing.Color.Transparent;
            this.labellec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellec.Location = new System.Drawing.Point(29, 138);
            this.labellec.Name = "labellec";
            this.labellec.Size = new System.Drawing.Size(110, 24);
            this.labellec.TabIndex = 44;
            this.labellec.Text = "Lecturer(s) :";
            // 
            // labelsubj
            // 
            this.labelsubj.AutoSize = true;
            this.labelsubj.BackColor = System.Drawing.Color.Transparent;
            this.labelsubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsubj.Location = new System.Drawing.Point(29, 178);
            this.labelsubj.Name = "labelsubj";
            this.labelsubj.Size = new System.Drawing.Size(88, 24);
            this.labelsubj.TabIndex = 45;
            this.labelsubj.Text = "Subject  :";
            // 
            // labelsubCode
            // 
            this.labelsubCode.AutoSize = true;
            this.labelsubCode.BackColor = System.Drawing.Color.Transparent;
            this.labelsubCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsubCode.Location = new System.Drawing.Point(29, 220);
            this.labelsubCode.Name = "labelsubCode";
            this.labelsubCode.Size = new System.Drawing.Size(139, 24);
            this.labelsubCode.TabIndex = 46;
            this.labelsubCode.Text = "Subject Code  :";
            // 
            // labeltag
            // 
            this.labeltag.AutoSize = true;
            this.labeltag.BackColor = System.Drawing.Color.Transparent;
            this.labeltag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltag.Location = new System.Drawing.Point(29, 261);
            this.labeltag.Name = "labeltag";
            this.labeltag.Size = new System.Drawing.Size(58, 24);
            this.labeltag.TabIndex = 47;
            this.labeltag.Text = "Tag  :";
            // 
            // labelgroup
            // 
            this.labelgroup.AutoSize = true;
            this.labelgroup.BackColor = System.Drawing.Color.Transparent;
            this.labelgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgroup.Location = new System.Drawing.Point(29, 304);
            this.labelgroup.Name = "labelgroup";
            this.labelgroup.Size = new System.Drawing.Size(190, 24);
            this.labelgroup.TabIndex = 48;
            this.labelgroup.Text = "Group/Sub-group ID :";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.BackColor = System.Drawing.Color.Transparent;
            this.labelcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcount.Location = new System.Drawing.Point(29, 349);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(136, 24);
            this.labelcount.TabIndex = 49;
            this.labelcount.Text = "Student count :";
            // 
            // labelduration
            // 
            this.labelduration.AutoSize = true;
            this.labelduration.BackColor = System.Drawing.Color.Transparent;
            this.labelduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelduration.Location = new System.Drawing.Point(29, 386);
            this.labelduration.Name = "labelduration";
            this.labelduration.Size = new System.Drawing.Size(90, 24);
            this.labelduration.TabIndex = 50;
            this.labelduration.Text = "Duration :";
            // 
            // comboBoxlec
            // 
            this.comboBoxlec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxlec.FormattingEnabled = true;
            this.comboBoxlec.Location = new System.Drawing.Point(225, 130);
            this.comboBoxlec.Name = "comboBoxlec";
            this.comboBoxlec.Size = new System.Drawing.Size(257, 32);
            this.comboBoxlec.TabIndex = 51;
            this.comboBoxlec.SelectedIndexChanged += new System.EventHandler(this.comboBoxlec_SelectedIndexChanged);
            // 
            // comboBoxtag
            // 
            this.comboBoxtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxtag.FormattingEnabled = true;
            this.comboBoxtag.Location = new System.Drawing.Point(225, 257);
            this.comboBoxtag.Name = "comboBoxtag";
            this.comboBoxtag.Size = new System.Drawing.Size(202, 32);
            this.comboBoxtag.TabIndex = 54;
            this.comboBoxtag.SelectedIndexChanged += new System.EventHandler(this.comboBoxtag_SelectedIndexChanged);
            // 
            // comboBoxgroup
            // 
            this.comboBoxgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxgroup.FormattingEnabled = true;
            this.comboBoxgroup.Location = new System.Drawing.Point(225, 300);
            this.comboBoxgroup.Name = "comboBoxgroup";
            this.comboBoxgroup.Size = new System.Drawing.Size(202, 32);
            this.comboBoxgroup.TabIndex = 55;
            this.comboBoxgroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxgroup_SelectedIndexChanged);
            // 
            // textBoxcount
            // 
            this.textBoxcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcount.Location = new System.Drawing.Point(225, 344);
            this.textBoxcount.Name = "textBoxcount";
            this.textBoxcount.Size = new System.Drawing.Size(89, 29);
            this.textBoxcount.TabIndex = 56;
            // 
            // textBoxduration
            // 
            this.textBoxduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxduration.Location = new System.Drawing.Point(225, 386);
            this.textBoxduration.Name = "textBoxduration";
            this.textBoxduration.Size = new System.Drawing.Size(89, 29);
            this.textBoxduration.TabIndex = 57;
            // 
            // buttonaddsess
            // 
            this.buttonaddsess.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonaddsess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddsess.Location = new System.Drawing.Point(168, 454);
            this.buttonaddsess.Name = "buttonaddsess";
            this.buttonaddsess.Size = new System.Drawing.Size(77, 37);
            this.buttonaddsess.TabIndex = 58;
            this.buttonaddsess.Text = "Add";
            this.buttonaddsess.UseVisualStyleBackColor = false;
            this.buttonaddsess.Click += new System.EventHandler(this.buttonaddsess_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxsearch.Location = new System.Drawing.Point(618, 36);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(183, 29);
            this.textBoxsearch.TabIndex = 60;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(575, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSubcode
            // 
            this.textBoxSubcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubcode.Location = new System.Drawing.Point(225, 218);
            this.textBoxSubcode.Name = "textBoxSubcode";
            this.textBoxSubcode.ReadOnly = true;
            this.textBoxSubcode.Size = new System.Drawing.Size(202, 29);
            this.textBoxSubcode.TabIndex = 63;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(618, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 262);
            this.dataGridView1.TabIndex = 64;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(575, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(769, 255);
            this.dataGridView2.TabIndex = 65;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // textBoxsubj
            // 
            this.textBoxsubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsubj.Location = new System.Drawing.Point(225, 175);
            this.textBoxsubj.Name = "textBoxsubj";
            this.textBoxsubj.ReadOnly = true;
            this.textBoxsubj.Size = new System.Drawing.Size(202, 29);
            this.textBoxsubj.TabIndex = 66;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(394, 454);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(77, 37);
            this.buttondelete.TabIndex = 70;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(279, 454);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(79, 37);
            this.buttonupdate.TabIndex = 68;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxid.Location = new System.Drawing.Point(279, 86);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(159, 29);
            this.textBoxid.TabIndex = 71;
            this.textBoxid.Visible = false;
            // 
            // textBoxsch
            // 
            this.textBoxsch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsch.ForeColor = System.Drawing.Color.Black;
            this.textBoxsch.Location = new System.Drawing.Point(891, 36);
            this.textBoxsch.Name = "textBoxsch";
            this.textBoxsch.Size = new System.Drawing.Size(179, 29);
            this.textBoxsch.TabIndex = 72;
            this.textBoxsch.TextChanged += new System.EventHandler(this.textBoxs1_TextChanged);
            // 
            // textBoxsrch
            // 
            this.textBoxsrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsrch.ForeColor = System.Drawing.Color.Black;
            this.textBoxsrch.Location = new System.Drawing.Point(1159, 36);
            this.textBoxsrch.Name = "textBoxsrch";
            this.textBoxsrch.Size = new System.Drawing.Size(185, 29);
            this.textBoxsrch.TabIndex = 73;
            this.textBoxsrch.TextChanged += new System.EventHandler(this.textBoxs2_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(848, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1116, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 75;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Search by Lecturer...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(886, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 77;
            this.label3.Text = "Search by Subject...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1160, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 78;
            this.label4.Text = "Search by GroupID...";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 37);
            this.button2.TabIndex = 79;
            this.button2.Text = "Consecutive Sessions";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(295, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 37);
            this.button3.TabIndex = 80;
            this.button3.Text = "Not Overlap Sessions";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 573);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 37);
            this.button4.TabIndex = 81;
            this.button4.Text = "Mark Not Availability";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(295, 573);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 37);
            this.button5.TabIndex = 82;
            this.button5.Text = "Parallel Sessions";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1356, 749);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxsrch);
            this.Controls.Add(this.textBoxsch);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.textBoxsubj);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSubcode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.buttonaddsess);
            this.Controls.Add(this.textBoxduration);
            this.Controls.Add(this.textBoxcount);
            this.Controls.Add(this.comboBoxgroup);
            this.Controls.Add(this.comboBoxtag);
            this.Controls.Add(this.comboBoxlec);
            this.Controls.Add(this.labelduration);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.labelgroup);
            this.Controls.Add(this.labeltag);
            this.Controls.Add(this.labelsubCode);
            this.Controls.Add(this.labelsubj);
            this.Controls.Add(this.labellec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Session";
            this.Text = "Session";
            this.Load += new System.EventHandler(this.Session_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labellec;
        private System.Windows.Forms.Label labelsubj;
        private System.Windows.Forms.Label labelsubCode;
        private System.Windows.Forms.Label labeltag;
        private System.Windows.Forms.Label labelgroup;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label labelduration;
        private System.Windows.Forms.ComboBox comboBoxlec;
        private System.Windows.Forms.ComboBox comboBoxtag;
        private System.Windows.Forms.ComboBox comboBoxgroup;
        private System.Windows.Forms.TextBox textBoxcount;
        private System.Windows.Forms.TextBox textBoxduration;
        private System.Windows.Forms.Button buttonaddsess;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSubcode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxsubj;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxsch;
        private System.Windows.Forms.TextBox textBoxsrch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}