namespace ManagerForm
{
    partial class EditMemberControl
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
            this.crewMemberscmBox = new System.Windows.Forms.ComboBox();
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.phoneNumbertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveChangesbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.roleCmBox = new System.Windows.Forms.ComboBox();
            this.subjectCmBox = new System.Windows.Forms.ComboBox();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.emailErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneNumErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.firstNameErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // crewMemberscmBox
            // 
            this.crewMemberscmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crewMemberscmBox.FormattingEnabled = true;
            this.crewMemberscmBox.Location = new System.Drawing.Point(136, 81);
            this.crewMemberscmBox.Name = "crewMemberscmBox";
            this.crewMemberscmBox.Size = new System.Drawing.Size(193, 33);
            this.crewMemberscmBox.TabIndex = 0;
            this.crewMemberscmBox.SelectedValueChanged += new System.EventHandler(this.crewMemberscmBox_SelectedValueChanged);
            // 
            // firstNametxt
            // 
            this.firstNametxt.Location = new System.Drawing.Point(157, 153);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(150, 31);
            this.firstNametxt.TabIndex = 1;
            this.firstNametxt.TextChanged += new System.EventHandler(this.firstNametxt_TextChanged);
            // 
            // lastNametxt
            // 
            this.lastNametxt.Location = new System.Drawing.Point(157, 230);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(150, 31);
            this.lastNametxt.TabIndex = 2;
            this.lastNametxt.TextChanged += new System.EventHandler(this.lastNametxt_TextChanged);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(157, 521);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(150, 31);
            this.addresstxt.TabIndex = 5;
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(534, 125);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(150, 31);
            this.citytxt.TabIndex = 6;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(534, 202);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(150, 31);
            this.emailtxt.TabIndex = 7;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged_1);
            // 
            // phoneNumbertxt
            // 
            this.phoneNumbertxt.Location = new System.Drawing.Point(534, 284);
            this.phoneNumbertxt.Name = "phoneNumbertxt";
            this.phoneNumbertxt.Size = new System.Drawing.Size(150, 31);
            this.phoneNumbertxt.TabIndex = 8;
            this.phoneNumbertxt.TextChanged += new System.EventHandler(this.phoneNumbertxt_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Role:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Subject:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Crew Member Name:";
            // 
            // saveChangesbtn
            // 
            this.saveChangesbtn.Location = new System.Drawing.Point(432, 394);
            this.saveChangesbtn.Name = "saveChangesbtn";
            this.saveChangesbtn.Size = new System.Drawing.Size(161, 76);
            this.saveChangesbtn.TabIndex = 23;
            this.saveChangesbtn.Text = "Save Changes";
            this.saveChangesbtn.UseVisualStyleBackColor = true;
            this.saveChangesbtn.Click += new System.EventHandler(this.saveChangesbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(633, 394);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(161, 76);
            this.removebtn.TabIndex = 24;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(534, 498);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(161, 76);
            this.backbtn.TabIndex = 25;
            this.backbtn.Text = "Go Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
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
            this.roleCmBox.Location = new System.Drawing.Point(157, 312);
            this.roleCmBox.Name = "roleCmBox";
            this.roleCmBox.Size = new System.Drawing.Size(150, 33);
            this.roleCmBox.TabIndex = 26;
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
            this.subjectCmBox.Location = new System.Drawing.Point(157, 447);
            this.subjectCmBox.Name = "subjectCmBox";
            this.subjectCmBox.Size = new System.Drawing.Size(150, 33);
            this.subjectCmBox.TabIndex = 27;
            // 
            // subjectTxt
            // 
            this.subjectTxt.Location = new System.Drawing.Point(157, 391);
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(150, 31);
            this.subjectTxt.TabIndex = 28;
            // 
            // emailErrorProvider1
            // 
            this.emailErrorProvider1.ContainerControl = this;
            // 
            // phoneNumErrorProvider1
            // 
            this.phoneNumErrorProvider1.ContainerControl = this;
            // 
            // firstNameErrorProvider1
            // 
            this.firstNameErrorProvider1.ContainerControl = this;
            // 
            // lastNameErrorProvider1
            // 
            this.lastNameErrorProvider1.ContainerControl = this;
            // 
            // EditMemberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.subjectTxt);
            this.Controls.Add(this.subjectCmBox);
            this.Controls.Add(this.roleCmBox);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.saveChangesbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumbertxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.firstNametxt);
            this.Controls.Add(this.crewMemberscmBox);
            this.Name = "EditMemberControl";
            this.Size = new System.Drawing.Size(844, 603);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox crewMemberscmBox;
        private TextBox firstNametxt;
        private TextBox lastNametxt;
        private TextBox addresstxt;
        private TextBox citytxt;
        private TextBox emailtxt;
        private TextBox phoneNumbertxt;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label2;
        private Label label4;
        private Button saveChangesbtn;
        private Button removebtn;
        private Button backbtn;
        private ComboBox roleCmBox;
        private ComboBox subjectCmBox;
        private TextBox subjectTxt;
        private ErrorProvider emailErrorProvider1;
        private ErrorProvider phoneNumErrorProvider1;
        private ErrorProvider firstNameErrorProvider1;
        private ErrorProvider lastNameErrorProvider1;
    }
}
