namespace ManagerForm
{
    partial class ProfileUserControl
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
            this.components = new System.ComponentModel.Container();
            this.backBtn = new System.Windows.Forms.Button();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.newPasswordtxt = new System.Windows.Forms.TextBox();
            this.verifyPasswordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.changePasswordgrBox = new System.Windows.Forms.GroupBox();
            this.changePassbtn = new System.Windows.Forms.Button();
            this.changeDetbtn = new System.Windows.Forms.Button();
            this.firstNamelbl = new System.Windows.Forms.Label();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.rolelbl = new System.Windows.Forms.Label();
            this.subjectlbl = new System.Windows.Forms.Label();
            this.birthDatelbl = new System.Windows.Forms.Label();
            this.detailsGrBox = new System.Windows.Forms.GroupBox();
            this.changeDetailsgrBox = new System.Windows.Forms.GroupBox();
            this.saveDetsbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.phoneNumbertxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.subjectCmBox = new System.Windows.Forms.ComboBox();
            this.roleCmBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.emailErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneNumberErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.firstNameErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.changePasswordgrBox.SuspendLayout();
            this.detailsGrBox.SuspendLayout();
            this.changeDetailsgrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(122, 530);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(134, 56);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(169, 54);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(150, 31);
            this.usernametxt.TabIndex = 0;
            // 
            // newPasswordtxt
            // 
            this.newPasswordtxt.Location = new System.Drawing.Point(169, 119);
            this.newPasswordtxt.Name = "newPasswordtxt";
            this.newPasswordtxt.Size = new System.Drawing.Size(150, 31);
            this.newPasswordtxt.TabIndex = 1;
            // 
            // verifyPasswordtxt
            // 
            this.verifyPasswordtxt.Location = new System.Drawing.Point(169, 189);
            this.verifyPasswordtxt.Name = "verifyPasswordtxt";
            this.verifyPasswordtxt.Size = new System.Drawing.Size(150, 31);
            this.verifyPasswordtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Verify Password:";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(105, 226);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(134, 56);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // changePasswordgrBox
            // 
            this.changePasswordgrBox.Controls.Add(this.saveBtn);
            this.changePasswordgrBox.Controls.Add(this.label3);
            this.changePasswordgrBox.Controls.Add(this.label2);
            this.changePasswordgrBox.Controls.Add(this.label1);
            this.changePasswordgrBox.Controls.Add(this.verifyPasswordtxt);
            this.changePasswordgrBox.Controls.Add(this.newPasswordtxt);
            this.changePasswordgrBox.Controls.Add(this.usernametxt);
            this.changePasswordgrBox.Location = new System.Drawing.Point(446, 291);
            this.changePasswordgrBox.Name = "changePasswordgrBox";
            this.changePasswordgrBox.Size = new System.Drawing.Size(346, 295);
            this.changePasswordgrBox.TabIndex = 3;
            this.changePasswordgrBox.TabStop = false;
            this.changePasswordgrBox.Text = "Change Password";
            // 
            // changePassbtn
            // 
            this.changePassbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changePassbtn.Location = new System.Drawing.Point(512, 209);
            this.changePassbtn.Name = "changePassbtn";
            this.changePassbtn.Size = new System.Drawing.Size(217, 76);
            this.changePassbtn.TabIndex = 2;
            this.changePassbtn.Text = "Change Password";
            this.changePassbtn.UseVisualStyleBackColor = true;
            this.changePassbtn.Click += new System.EventHandler(this.changePassbtn_Click);
            // 
            // changeDetbtn
            // 
            this.changeDetbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeDetbtn.FlatAppearance.BorderSize = 3;
            this.changeDetbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.changeDetbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeDetbtn.Location = new System.Drawing.Point(512, 155);
            this.changeDetbtn.Name = "changeDetbtn";
            this.changeDetbtn.Size = new System.Drawing.Size(217, 50);
            this.changeDetbtn.TabIndex = 1;
            this.changeDetbtn.Text = "Change Details";
            this.changeDetbtn.UseVisualStyleBackColor = true;
            this.changeDetbtn.Click += new System.EventHandler(this.changeDetbtn_Click);
            // 
            // firstNamelbl
            // 
            this.firstNamelbl.AutoSize = true;
            this.firstNamelbl.Location = new System.Drawing.Point(35, 44);
            this.firstNamelbl.Name = "firstNamelbl";
            this.firstNamelbl.Size = new System.Drawing.Size(59, 25);
            this.firstNamelbl.TabIndex = 0;
            this.firstNamelbl.Text = "label1";
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Location = new System.Drawing.Point(189, 44);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(59, 25);
            this.lastNamelbl.TabIndex = 1;
            this.lastNamelbl.Text = "label2";
            // 
            // rolelbl
            // 
            this.rolelbl.AutoSize = true;
            this.rolelbl.Location = new System.Drawing.Point(356, 44);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(59, 25);
            this.rolelbl.TabIndex = 2;
            this.rolelbl.Text = "label3";
            // 
            // subjectlbl
            // 
            this.subjectlbl.AutoSize = true;
            this.subjectlbl.Location = new System.Drawing.Point(511, 44);
            this.subjectlbl.Name = "subjectlbl";
            this.subjectlbl.Size = new System.Drawing.Size(59, 25);
            this.subjectlbl.TabIndex = 3;
            this.subjectlbl.Text = "label4";
            // 
            // birthDatelbl
            // 
            this.birthDatelbl.AutoSize = true;
            this.birthDatelbl.Location = new System.Drawing.Point(675, 40);
            this.birthDatelbl.Name = "birthDatelbl";
            this.birthDatelbl.Size = new System.Drawing.Size(59, 25);
            this.birthDatelbl.TabIndex = 4;
            this.birthDatelbl.Text = "label5";
            // 
            // detailsGrBox
            // 
            this.detailsGrBox.Controls.Add(this.birthDatelbl);
            this.detailsGrBox.Controls.Add(this.subjectlbl);
            this.detailsGrBox.Controls.Add(this.rolelbl);
            this.detailsGrBox.Controls.Add(this.lastNamelbl);
            this.detailsGrBox.Controls.Add(this.firstNamelbl);
            this.detailsGrBox.Location = new System.Drawing.Point(31, 20);
            this.detailsGrBox.Name = "detailsGrBox";
            this.detailsGrBox.Size = new System.Drawing.Size(790, 88);
            this.detailsGrBox.TabIndex = 0;
            this.detailsGrBox.TabStop = false;
            this.detailsGrBox.Text = "General Details";
            // 
            // changeDetailsgrBox
            // 
            this.changeDetailsgrBox.Controls.Add(this.saveDetsbtn);
            this.changeDetailsgrBox.Controls.Add(this.label9);
            this.changeDetailsgrBox.Controls.Add(this.label10);
            this.changeDetailsgrBox.Controls.Add(this.label11);
            this.changeDetailsgrBox.Controls.Add(this.phoneNumbertxt);
            this.changeDetailsgrBox.Controls.Add(this.emailtxt);
            this.changeDetailsgrBox.Controls.Add(this.citytxt);
            this.changeDetailsgrBox.Controls.Add(this.subjectCmBox);
            this.changeDetailsgrBox.Controls.Add(this.roleCmBox);
            this.changeDetailsgrBox.Controls.Add(this.label7);
            this.changeDetailsgrBox.Controls.Add(this.label6);
            this.changeDetailsgrBox.Controls.Add(this.label5);
            this.changeDetailsgrBox.Controls.Add(this.label4);
            this.changeDetailsgrBox.Controls.Add(this.label8);
            this.changeDetailsgrBox.Controls.Add(this.addresstxt);
            this.changeDetailsgrBox.Controls.Add(this.lastNametxt);
            this.changeDetailsgrBox.Controls.Add(this.firstNametxt);
            this.changeDetailsgrBox.Location = new System.Drawing.Point(31, 125);
            this.changeDetailsgrBox.Name = "changeDetailsgrBox";
            this.changeDetailsgrBox.Size = new System.Drawing.Size(357, 399);
            this.changeDetailsgrBox.TabIndex = 5;
            this.changeDetailsgrBox.TabStop = false;
            this.changeDetailsgrBox.Text = "Change Details";
            // 
            // saveDetsbtn
            // 
            this.saveDetsbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveDetsbtn.Location = new System.Drawing.Point(91, 348);
            this.saveDetsbtn.Name = "saveDetsbtn";
            this.saveDetsbtn.Size = new System.Drawing.Size(107, 43);
            this.saveDetsbtn.TabIndex = 6;
            this.saveDetsbtn.Text = "Save";
            this.saveDetsbtn.UseVisualStyleBackColor = true;
            this.saveDetsbtn.Click += new System.EventHandler(this.saveDetsbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 71;
            this.label9.Text = "Phone Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 70;
            this.label10.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 25);
            this.label11.TabIndex = 69;
            this.label11.Text = "City:";
            // 
            // phoneNumbertxt
            // 
            this.phoneNumbertxt.Location = new System.Drawing.Point(160, 314);
            this.phoneNumbertxt.Name = "phoneNumbertxt";
            this.phoneNumbertxt.Size = new System.Drawing.Size(150, 31);
            this.phoneNumbertxt.TabIndex = 68;
            this.phoneNumbertxt.TextChanged += new System.EventHandler(this.phoneNumbertxt_TextChanged);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(160, 277);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(150, 31);
            this.emailtxt.TabIndex = 67;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(160, 240);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(150, 31);
            this.citytxt.TabIndex = 66;
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
            this.subjectCmBox.Location = new System.Drawing.Point(160, 161);
            this.subjectCmBox.Name = "subjectCmBox";
            this.subjectCmBox.Size = new System.Drawing.Size(150, 33);
            this.subjectCmBox.TabIndex = 65;
            // 
            // roleCmBox
            // 
            this.roleCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCmBox.FormattingEnabled = true;
            this.roleCmBox.Items.AddRange(new object[] {
            "teacher",
            "secretary",
            "janitor",
            "teacher assistant"});
            this.roleCmBox.Location = new System.Drawing.Point(160, 121);
            this.roleCmBox.Name = "roleCmBox";
            this.roleCmBox.Size = new System.Drawing.Size(150, 33);
            this.roleCmBox.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Role:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "First Name:";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(160, 203);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(150, 31);
            this.addresstxt.TabIndex = 58;
            // 
            // lastNametxt
            // 
            this.lastNametxt.Location = new System.Drawing.Point(160, 78);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(150, 31);
            this.lastNametxt.TabIndex = 57;
            this.lastNametxt.TextChanged += new System.EventHandler(this.lastNametxt_TextChanged);
            // 
            // firstNametxt
            // 
            this.firstNametxt.Location = new System.Drawing.Point(160, 37);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(150, 31);
            this.firstNametxt.TabIndex = 56;
            this.firstNametxt.TextChanged += new System.EventHandler(this.firstNametxt_TextChanged);
            // 
            // emailErrorProvider1
            // 
            this.emailErrorProvider1.ContainerControl = this;
            // 
            // phoneNumberErrorProvider1
            // 
            this.phoneNumberErrorProvider1.ContainerControl = this;
            // 
            // firstNameErrorProvider1
            // 
            this.firstNameErrorProvider1.ContainerControl = this;
            // 
            // lastNameErrorProvider1
            // 
            this.lastNameErrorProvider1.ContainerControl = this;
            // 
            // ProfileUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.changeDetailsgrBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.changePasswordgrBox);
            this.Controls.Add(this.changePassbtn);
            this.Controls.Add(this.changeDetbtn);
            this.Controls.Add(this.detailsGrBox);
            this.Name = "ProfileUserControl";
            this.Size = new System.Drawing.Size(844, 603);
            this.changePasswordgrBox.ResumeLayout(false);
            this.changePasswordgrBox.PerformLayout();
            this.detailsGrBox.ResumeLayout(false);
            this.detailsGrBox.PerformLayout();
            this.changeDetailsgrBox.ResumeLayout(false);
            this.changeDetailsgrBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button backBtn;
        private TextBox usernametxt;
        private TextBox newPasswordtxt;
        private TextBox verifyPasswordtxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveBtn;
        private GroupBox changePasswordgrBox;
        private Button changePassbtn;
        private Button changeDetbtn;
        private Label firstNamelbl;
        private Label lastNamelbl;
        private Label rolelbl;
        private Label subjectlbl;
        private Label birthDatelbl;
        private GroupBox detailsGrBox;
        private GroupBox changeDetailsgrBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox phoneNumbertxt;
        private TextBox emailtxt;
        private TextBox citytxt;
        private ComboBox subjectCmBox;
        private ComboBox roleCmBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private TextBox addresstxt;
        private TextBox lastNametxt;
        private TextBox firstNametxt;
        private Button saveDetsbtn;
        private ErrorProvider emailErrorProvider1;
        private ErrorProvider phoneNumberErrorProvider1;
        private ErrorProvider firstNameErrorProvider1;
        private ErrorProvider lastNameErrorProvider1;
    }
}
