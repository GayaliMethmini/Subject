namespace Subject
{
    partial class addStudentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStudentDetails));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelempId = new System.Windows.Forms.Label();
            this.comboBoxYearSem = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGenerateId = new System.Windows.Forms.Button();
            this.textBoxProgramme = new System.Windows.Forms.TextBox();
            this.textBoxGroupNo = new System.Windows.Forms.TextBox();
            this.textBoxSubGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 43);
            this.label1.TabIndex = 43;
            this.label1.Text = "Student Details";
            // 
            // labelempId
            // 
            this.labelempId.AutoSize = true;
            this.labelempId.BackColor = System.Drawing.Color.Transparent;
            this.labelempId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelempId.Location = new System.Drawing.Point(194, 175);
            this.labelempId.Name = "labelempId";
            this.labelempId.Size = new System.Drawing.Size(139, 24);
            this.labelempId.TabIndex = 44;
            this.labelempId.Text = "Year & Semester";
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
            this.comboBoxYearSem.Location = new System.Drawing.Point(450, 172);
            this.comboBoxYearSem.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxYearSem.Name = "comboBoxYearSem";
            this.comboBoxYearSem.Size = new System.Drawing.Size(221, 32);
            this.comboBoxYearSem.TabIndex = 55;
            this.comboBoxYearSem.SelectedIndexChanged += new System.EventHandler(this.comboBoxYearSem_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(640, 494);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 37);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(509, 494);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 37);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGenerateId
            // 
            this.btnGenerateId.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateId.Location = new System.Drawing.Point(324, 494);
            this.btnGenerateId.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateId.Name = "btnGenerateId";
            this.btnGenerateId.Size = new System.Drawing.Size(128, 37);
            this.btnGenerateId.TabIndex = 52;
            this.btnGenerateId.Text = "Generate ID";
            this.btnGenerateId.UseVisualStyleBackColor = false;
            this.btnGenerateId.Click += new System.EventHandler(this.btnGenerateId_Click_1);
            // 
            // textBoxProgramme
            // 
            this.textBoxProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProgramme.Location = new System.Drawing.Point(450, 239);
            this.textBoxProgramme.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProgramme.Name = "textBoxProgramme";
            this.textBoxProgramme.Size = new System.Drawing.Size(221, 29);
            this.textBoxProgramme.TabIndex = 47;
            this.textBoxProgramme.TextChanged += new System.EventHandler(this.textBoxProgramme_TextChanged);
            // 
            // textBoxGroupNo
            // 
            this.textBoxGroupNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupNo.Location = new System.Drawing.Point(450, 299);
            this.textBoxGroupNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGroupNo.Name = "textBoxGroupNo";
            this.textBoxGroupNo.Size = new System.Drawing.Size(221, 29);
            this.textBoxGroupNo.TabIndex = 46;
            this.textBoxGroupNo.TextChanged += new System.EventHandler(this.textBoxGroupNo_TextChanged);
            // 
            // textBoxSubGroup
            // 
            this.textBoxSubGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubGroup.Location = new System.Drawing.Point(450, 367);
            this.textBoxSubGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSubGroup.Name = "textBoxSubGroup";
            this.textBoxSubGroup.Size = new System.Drawing.Size(221, 29);
            this.textBoxSubGroup.TabIndex = 45;
            this.textBoxSubGroup.TextChanged += new System.EventHandler(this.textBoxSubGroup_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Programme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Group No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Sub - group No";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(774, 494);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(77, 37);
            this.btnView.TabIndex = 59;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // addStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxYearSem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnGenerateId);
            this.Controls.Add(this.textBoxProgramme);
            this.Controls.Add(this.textBoxGroupNo);
            this.Controls.Add(this.textBoxSubGroup);
            this.Controls.Add(this.labelempId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "addStudentDetails";
            this.Text = "addStudentDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelempId;
        private System.Windows.Forms.ComboBox comboBoxYearSem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGenerateId;
        private System.Windows.Forms.TextBox textBoxProgramme;
        private System.Windows.Forms.TextBox textBoxGroupNo;
        private System.Windows.Forms.TextBox textBoxSubGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnView;
    }
}