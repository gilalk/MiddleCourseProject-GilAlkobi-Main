namespace ManagerForm
{
    partial class ClassesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addClassGrBox = new System.Windows.Forms.GroupBox();
            this.createClassBtn = new System.Windows.Forms.Button();
            this.classNametxt = new System.Windows.Forms.TextBox();
            this.classCodetxt = new System.Windows.Forms.TextBox();
            this.subjectCmBox = new System.Windows.Forms.ComboBox();
            this.teacherCmBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.matchGrBox = new System.Windows.Forms.GroupBox();
            this.matchBtn = new System.Windows.Forms.Button();
            this.classesCmBox = new System.Windows.Forms.ComboBox();
            this.teacherCmBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentsCmBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.removeGrBox = new System.Windows.Forms.GroupBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.classesCmBox2 = new System.Windows.Forms.ComboBox();
            this.teacherCmBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.studentsCmBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addClassGrBox.SuspendLayout();
            this.matchGrBox.SuspendLayout();
            this.removeGrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addClassGrBox
            // 
            this.addClassGrBox.Controls.Add(this.createClassBtn);
            this.addClassGrBox.Controls.Add(this.classNametxt);
            this.addClassGrBox.Controls.Add(this.classCodetxt);
            this.addClassGrBox.Controls.Add(this.subjectCmBox);
            this.addClassGrBox.Controls.Add(this.teacherCmBox);
            this.addClassGrBox.Controls.Add(this.label4);
            this.addClassGrBox.Controls.Add(this.label3);
            this.addClassGrBox.Controls.Add(this.label2);
            this.addClassGrBox.Controls.Add(this.label1);
            this.addClassGrBox.Location = new System.Drawing.Point(35, 55);
            this.addClassGrBox.Name = "addClassGrBox";
            this.addClassGrBox.Size = new System.Drawing.Size(366, 450);
            this.addClassGrBox.TabIndex = 0;
            this.addClassGrBox.TabStop = false;
            this.addClassGrBox.Text = "Add Class";
            // 
            // createClassBtn
            // 
            this.createClassBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createClassBtn.Location = new System.Drawing.Point(102, 344);
            this.createClassBtn.Name = "createClassBtn";
            this.createClassBtn.Size = new System.Drawing.Size(164, 69);
            this.createClassBtn.TabIndex = 8;
            this.createClassBtn.Text = "Create Class";
            this.createClassBtn.UseVisualStyleBackColor = true;
            this.createClassBtn.Click += new System.EventHandler(this.createClassBtn_Click);
            // 
            // classNametxt
            // 
            this.classNametxt.Location = new System.Drawing.Point(157, 277);
            this.classNametxt.Name = "classNametxt";
            this.classNametxt.Size = new System.Drawing.Size(150, 31);
            this.classNametxt.TabIndex = 7;
            // 
            // classCodetxt
            // 
            this.classCodetxt.Location = new System.Drawing.Point(157, 210);
            this.classCodetxt.Name = "classCodetxt";
            this.classCodetxt.Size = new System.Drawing.Size(150, 31);
            this.classCodetxt.TabIndex = 6;
            // 
            // subjectCmBox
            // 
            this.subjectCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectCmBox.FormattingEnabled = true;
            this.subjectCmBox.Items.AddRange(new object[] {
            "physics",
            "English",
            "Mathematics",
            "History",
            "Bible",
            "Spanish",
            "Hebrew",
            "Civics"});
            this.subjectCmBox.Location = new System.Drawing.Point(157, 135);
            this.subjectCmBox.Name = "subjectCmBox";
            this.subjectCmBox.Size = new System.Drawing.Size(182, 33);
            this.subjectCmBox.TabIndex = 5;
            // 
            // teacherCmBox
            // 
            this.teacherCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherCmBox.FormattingEnabled = true;
            this.teacherCmBox.Location = new System.Drawing.Point(157, 60);
            this.teacherCmBox.Name = "teacherCmBox";
            this.teacherCmBox.Size = new System.Drawing.Size(182, 33);
            this.teacherCmBox.TabIndex = 4;
            this.teacherCmBox.SelectedValueChanged += new System.EventHandler(this.subjectCmBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher:";
            // 
            // matchGrBox
            // 
            this.matchGrBox.Controls.Add(this.matchBtn);
            this.matchGrBox.Controls.Add(this.classesCmBox);
            this.matchGrBox.Controls.Add(this.teacherCmBox2);
            this.matchGrBox.Controls.Add(this.label7);
            this.matchGrBox.Controls.Add(this.studentsCmBox);
            this.matchGrBox.Controls.Add(this.label6);
            this.matchGrBox.Controls.Add(this.label5);
            this.matchGrBox.Location = new System.Drawing.Point(462, 20);
            this.matchGrBox.Name = "matchGrBox";
            this.matchGrBox.Size = new System.Drawing.Size(339, 276);
            this.matchGrBox.TabIndex = 1;
            this.matchGrBox.TabStop = false;
            this.matchGrBox.Text = "Match Students And Classes";
            // 
            // matchBtn
            // 
            this.matchBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matchBtn.Location = new System.Drawing.Point(81, 220);
            this.matchBtn.Name = "matchBtn";
            this.matchBtn.Size = new System.Drawing.Size(164, 47);
            this.matchBtn.TabIndex = 9;
            this.matchBtn.Text = "Match";
            this.matchBtn.UseVisualStyleBackColor = true;
            this.matchBtn.Click += new System.EventHandler(this.matchBtn_Click);
            // 
            // classesCmBox
            // 
            this.classesCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classesCmBox.FormattingEnabled = true;
            this.classesCmBox.Location = new System.Drawing.Point(122, 106);
            this.classesCmBox.Name = "classesCmBox";
            this.classesCmBox.Size = new System.Drawing.Size(182, 33);
            this.classesCmBox.TabIndex = 6;
            // 
            // teacherCmBox2
            // 
            this.teacherCmBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherCmBox2.FormattingEnabled = true;
            this.teacherCmBox2.Location = new System.Drawing.Point(122, 47);
            this.teacherCmBox2.Name = "teacherCmBox2";
            this.teacherCmBox2.Size = new System.Drawing.Size(182, 33);
            this.teacherCmBox2.TabIndex = 5;
            this.teacherCmBox2.SelectedIndexChanged += new System.EventHandler(this.classesCmBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Students:";
            // 
            // studentsCmBox
            // 
            this.studentsCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentsCmBox.FormattingEnabled = true;
            this.studentsCmBox.Location = new System.Drawing.Point(122, 170);
            this.studentsCmBox.Name = "studentsCmBox";
            this.studentsCmBox.Size = new System.Drawing.Size(182, 33);
            this.studentsCmBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Classes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Teacher:";
            // 
            // removeGrBox
            // 
            this.removeGrBox.Controls.Add(this.removeBtn);
            this.removeGrBox.Controls.Add(this.classesCmBox2);
            this.removeGrBox.Controls.Add(this.teacherCmBox3);
            this.removeGrBox.Controls.Add(this.label8);
            this.removeGrBox.Controls.Add(this.studentsCmBox2);
            this.removeGrBox.Controls.Add(this.label9);
            this.removeGrBox.Controls.Add(this.label10);
            this.removeGrBox.Location = new System.Drawing.Point(462, 311);
            this.removeGrBox.Name = "removeGrBox";
            this.removeGrBox.Size = new System.Drawing.Size(339, 276);
            this.removeGrBox.TabIndex = 2;
            this.removeGrBox.TabStop = false;
            this.removeGrBox.Text = "Remove Students From Classes";
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeBtn.Location = new System.Drawing.Point(81, 220);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(164, 47);
            this.removeBtn.TabIndex = 9;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // classesCmBox2
            // 
            this.classesCmBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classesCmBox2.FormattingEnabled = true;
            this.classesCmBox2.Location = new System.Drawing.Point(122, 106);
            this.classesCmBox2.Name = "classesCmBox2";
            this.classesCmBox2.Size = new System.Drawing.Size(182, 33);
            this.classesCmBox2.TabIndex = 6;
            this.classesCmBox2.SelectedValueChanged += new System.EventHandler(this.studentsCmBox2_SelectedIndexChanged);
            // 
            // teacherCmBox3
            // 
            this.teacherCmBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherCmBox3.FormattingEnabled = true;
            this.teacherCmBox3.Location = new System.Drawing.Point(122, 47);
            this.teacherCmBox3.Name = "teacherCmBox3";
            this.teacherCmBox3.Size = new System.Drawing.Size(182, 33);
            this.teacherCmBox3.TabIndex = 5;
            this.teacherCmBox3.SelectedValueChanged += new System.EventHandler(this.classesCmBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Students:";
            // 
            // studentsCmBox2
            // 
            this.studentsCmBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentsCmBox2.FormattingEnabled = true;
            this.studentsCmBox2.Location = new System.Drawing.Point(122, 170);
            this.studentsCmBox2.Name = "studentsCmBox2";
            this.studentsCmBox2.Size = new System.Drawing.Size(182, 33);
            this.studentsCmBox2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Classes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Teacher:";
            // 
            // ClassesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.removeGrBox);
            this.Controls.Add(this.matchGrBox);
            this.Controls.Add(this.addClassGrBox);
            this.Name = "ClassesControl";
            this.Size = new System.Drawing.Size(844, 603);
            this.addClassGrBox.ResumeLayout(false);
            this.addClassGrBox.PerformLayout();
            this.matchGrBox.ResumeLayout(false);
            this.matchGrBox.PerformLayout();
            this.removeGrBox.ResumeLayout(false);
            this.removeGrBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox addClassGrBox;
        private Button createClassBtn;
        private TextBox classNametxt;
        private TextBox classCodetxt;
        private ComboBox subjectCmBox;
        private ComboBox teacherCmBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox matchGrBox;
        private ComboBox studentsCmBox;
        private Label label6;
        private Label label5;
        private Button matchBtn;
        private ComboBox classesCmBox;
        private ComboBox teacherCmBox2;
        private Label label7;
        private GroupBox removeGrBox;
        private Button removeBtn;
        private ComboBox classesCmBox2;
        private ComboBox teacherCmBox3;
        private Label label8;
        private ComboBox studentsCmBox2;
        private Label label9;
        private Label label10;
    }
}
