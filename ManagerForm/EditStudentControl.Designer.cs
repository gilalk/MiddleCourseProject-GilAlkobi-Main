namespace ManagerForm
{
    partial class EditStudentControl
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
            this.studentcmBox = new System.Windows.Forms.ComboBox();
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.emergencytxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.phoneNumbertxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.saveChangesbtn = new System.Windows.Forms.Button();
            this.emailErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneNumErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.emerganceErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.firstNameErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emerganceErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentcmBox
            // 
            this.studentcmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentcmBox.FormattingEnabled = true;
            this.studentcmBox.Location = new System.Drawing.Point(123, 75);
            this.studentcmBox.Name = "studentcmBox";
            this.studentcmBox.Size = new System.Drawing.Size(182, 33);
            this.studentcmBox.TabIndex = 0;
            this.studentcmBox.SelectedValueChanged += new System.EventHandler(this.studentcmBox_SelectedValueChanged);
            // 
            // firstNametxt
            // 
            this.firstNametxt.Location = new System.Drawing.Point(179, 147);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(150, 31);
            this.firstNametxt.TabIndex = 1;
            this.firstNametxt.TextChanged += new System.EventHandler(this.firstNametxt_TextChanged);
            // 
            // lastNametxt
            // 
            this.lastNametxt.Location = new System.Drawing.Point(179, 221);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(150, 31);
            this.lastNametxt.TabIndex = 2;
            this.lastNametxt.TextChanged += new System.EventHandler(this.lastNametxt_TextChanged);
            // 
            // emergencytxt
            // 
            this.emergencytxt.Location = new System.Drawing.Point(179, 297);
            this.emergencytxt.Name = "emergencytxt";
            this.emergencytxt.Size = new System.Drawing.Size(150, 31);
            this.emergencytxt.TabIndex = 3;
            this.emergencytxt.TextChanged += new System.EventHandler(this.emergencytxt_TextChanged_1);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(179, 375);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(150, 31);
            this.addresstxt.TabIndex = 4;
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(179, 454);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(150, 31);
            this.citytxt.TabIndex = 5;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(524, 147);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(150, 31);
            this.emailtxt.TabIndex = 6;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged_1);
            // 
            // phoneNumbertxt
            // 
            this.phoneNumbertxt.Location = new System.Drawing.Point(524, 221);
            this.phoneNumbertxt.Name = "phoneNumbertxt";
            this.phoneNumbertxt.Size = new System.Drawing.Size(150, 31);
            this.phoneNumbertxt.TabIndex = 7;
            this.phoneNumbertxt.TextChanged += new System.EventHandler(this.phoneNumbertxt_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Emergency Contact:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Student Name:";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(503, 431);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(161, 76);
            this.backbtn.TabIndex = 48;
            this.backbtn.Text = "Go Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(602, 327);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(161, 76);
            this.removebtn.TabIndex = 47;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // saveChangesbtn
            // 
            this.saveChangesbtn.Location = new System.Drawing.Point(401, 327);
            this.saveChangesbtn.Name = "saveChangesbtn";
            this.saveChangesbtn.Size = new System.Drawing.Size(161, 76);
            this.saveChangesbtn.TabIndex = 46;
            this.saveChangesbtn.Text = "Save Changes";
            this.saveChangesbtn.UseVisualStyleBackColor = true;
            this.saveChangesbtn.Click += new System.EventHandler(this.saveChangesbtn_Click);
            // 
            // emailErrorProvider1
            // 
            this.emailErrorProvider1.ContainerControl = this;
            // 
            // phoneNumErrorProvider1
            // 
            this.phoneNumErrorProvider1.ContainerControl = this;
            // 
            // emerganceErrorProvider1
            // 
            this.emerganceErrorProvider1.ContainerControl = this;
            // 
            // firstNameErrorProvider1
            // 
            this.firstNameErrorProvider1.ContainerControl = this;
            // 
            // lastNameErrorProvider1
            // 
            this.lastNameErrorProvider1.ContainerControl = this;
            // 
            // EditStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.saveChangesbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumbertxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.emergencytxt);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.firstNametxt);
            this.Controls.Add(this.studentcmBox);
            this.Name = "EditStudentControl";
            this.Size = new System.Drawing.Size(844, 603);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emerganceErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox studentcmBox;
        private TextBox firstNametxt;
        private TextBox lastNametxt;
        private TextBox emergencytxt;
        private TextBox addresstxt;
        private TextBox citytxt;
        private TextBox emailtxt;
        private TextBox phoneNumbertxt;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label9;
        private Label label2;
        private Label label4;
        private Button backbtn;
        private Button removebtn;
        private Button saveChangesbtn;
        private ErrorProvider emailErrorProvider1;
        private ErrorProvider phoneNumErrorProvider1;
        private ErrorProvider emerganceErrorProvider1;
        private ErrorProvider firstNameErrorProvider1;
        private ErrorProvider lastNameErrorProvider1;
    }
}
