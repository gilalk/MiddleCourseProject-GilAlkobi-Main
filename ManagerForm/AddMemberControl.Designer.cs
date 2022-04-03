namespace ManagerForm
{
    partial class AddMemberControl
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
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gendercmBox = new System.Windows.Forms.ComboBox();
            this.phoneNumbertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.emailErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneNumErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rolCmBox = new System.Windows.Forms.ComboBox();
            this.subjectCmBox = new System.Windows.Forms.ComboBox();
            this.firstNameErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNametxt
            // 
            this.firstNametxt.Location = new System.Drawing.Point(129, 46);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(150, 31);
            this.firstNametxt.TabIndex = 0;
            this.firstNametxt.TextChanged += new System.EventHandler(this.firstNametxt_TextChanged);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(520, 46);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(150, 31);
            this.emailtxt.TabIndex = 1;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged_1);
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(129, 514);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(150, 31);
            this.citytxt.TabIndex = 2;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(129, 433);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(150, 31);
            this.addresstxt.TabIndex = 3;
            // 
            // lastNametxt
            // 
            this.lastNametxt.Location = new System.Drawing.Point(129, 122);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(150, 31);
            this.lastNametxt.TabIndex = 7;
            this.lastNametxt.TextChanged += new System.EventHandler(this.lastNametxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Subject:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "City:";
            // 
            // gendercmBox
            // 
            this.gendercmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercmBox.FormattingEnabled = true;
            this.gendercmBox.Items.AddRange(new object[] {
            "male",
            "female"});
            this.gendercmBox.Location = new System.Drawing.Point(129, 203);
            this.gendercmBox.Name = "gendercmBox";
            this.gendercmBox.Size = new System.Drawing.Size(150, 33);
            this.gendercmBox.TabIndex = 16;
            // 
            // phoneNumbertxt
            // 
            this.phoneNumbertxt.Location = new System.Drawing.Point(520, 122);
            this.phoneNumbertxt.Name = "phoneNumbertxt";
            this.phoneNumbertxt.Size = new System.Drawing.Size(150, 31);
            this.phoneNumbertxt.TabIndex = 17;
            this.phoneNumbertxt.TextChanged += new System.EventHandler(this.phoneNumbertxt_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Date of Birth:";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(417, 250);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(281, 31);
            this.birthDatePicker.TabIndex = 21;
            this.birthDatePicker.Value = new System.DateTime(2022, 1, 24, 18, 42, 48, 0);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(457, 339);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(213, 108);
            this.addbtn.TabIndex = 22;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(457, 475);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(213, 108);
            this.backbtn.TabIndex = 23;
            this.backbtn.Text = "Go Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // emailErrorProvider1
            // 
            this.emailErrorProvider1.ContainerControl = this;
            // 
            // phoneNumErrorProvider1
            // 
            this.phoneNumErrorProvider1.ContainerControl = this;
            // 
            // rolCmBox
            // 
            this.rolCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolCmBox.FormattingEnabled = true;
            this.rolCmBox.Items.AddRange(new object[] {
            "teacher",
            "secretary",
            "janitor",
            "teacher assistant"});
            this.rolCmBox.Location = new System.Drawing.Point(129, 277);
            this.rolCmBox.Name = "rolCmBox";
            this.rolCmBox.Size = new System.Drawing.Size(150, 33);
            this.rolCmBox.TabIndex = 24;
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
            this.subjectCmBox.Location = new System.Drawing.Point(129, 353);
            this.subjectCmBox.Name = "subjectCmBox";
            this.subjectCmBox.Size = new System.Drawing.Size(150, 33);
            this.subjectCmBox.TabIndex = 25;
            // 
            // firstNameErrorProvider1
            // 
            this.firstNameErrorProvider1.ContainerControl = this;
            // 
            // lastNameErrorProvider1
            // 
            this.lastNameErrorProvider1.ContainerControl = this;
            // 
            // AddMemberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.subjectCmBox);
            this.Controls.Add(this.rolCmBox);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneNumbertxt);
            this.Controls.Add(this.gendercmBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.firstNametxt);
            this.Name = "AddMemberControl";
            this.Size = new System.Drawing.Size(844, 603);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstNametxt;
        private TextBox emailtxt;
        private TextBox citytxt;
        private TextBox addresstxt;
        private TextBox lastNametxt;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox gendercmBox;
        private TextBox phoneNumbertxt;
        private Label label2;
        private Label label9;
        private Label label10;
        private DateTimePicker birthDatePicker;
        private Button addbtn;
        private Button backbtn;
        private ErrorProvider emailErrorProvider1;
        private ErrorProvider phoneNumErrorProvider1;
        private ComboBox rolCmBox;
        private ComboBox subjectCmBox;
        private ErrorProvider firstNameErrorProvider1;
        private ErrorProvider lastNameErrorProvider1;
    }
}
