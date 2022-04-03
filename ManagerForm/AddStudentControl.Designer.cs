namespace ManagerForm
{
    partial class AddStudentControl
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
            this.backbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumbertxt = new System.Windows.Forms.TextBox();
            this.gendercmBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.emergencytxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.firstNametxt = new System.Windows.Forms.TextBox();
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
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(516, 462);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(213, 108);
            this.backbtn.TabIndex = 45;
            this.backbtn.Text = "Go Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(516, 326);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(213, 108);
            this.addbtn.TabIndex = 44;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(476, 237);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(281, 31);
            this.birthDatePicker.TabIndex = 43;
            this.birthDatePicker.Value = new System.DateTime(2022, 2, 17, 23, 49, 33, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(534, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Date of Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Email:";
            // 
            // phoneNumbertxt
            // 
            this.phoneNumbertxt.Location = new System.Drawing.Point(579, 109);
            this.phoneNumbertxt.Name = "phoneNumbertxt";
            this.phoneNumbertxt.Size = new System.Drawing.Size(178, 31);
            this.phoneNumbertxt.TabIndex = 39;
            this.phoneNumbertxt.TextChanged += new System.EventHandler(this.phoneNumbertxt_TextChanged);
            // 
            // gendercmBox
            // 
            this.gendercmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercmBox.FormattingEnabled = true;
            this.gendercmBox.Items.AddRange(new object[] {
            "male",
            "female"});
            this.gendercmBox.Location = new System.Drawing.Point(188, 211);
            this.gendercmBox.Name = "gendercmBox";
            this.gendercmBox.Size = new System.Drawing.Size(150, 33);
            this.gendercmBox.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Emergency Contact:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "First Name:";
            // 
            // lastNametxt
            // 
            this.lastNametxt.Location = new System.Drawing.Point(188, 123);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(150, 31);
            this.lastNametxt.TabIndex = 30;
            // 
            // emergencytxt
            // 
            this.emergencytxt.Location = new System.Drawing.Point(188, 307);
            this.emergencytxt.Name = "emergencytxt";
            this.emergencytxt.Size = new System.Drawing.Size(150, 31);
            this.emergencytxt.TabIndex = 29;
            this.emergencytxt.TextChanged += new System.EventHandler(this.emergencytxt_TextChanged);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(188, 406);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(150, 31);
            this.addresstxt.TabIndex = 27;
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(188, 487);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(150, 31);
            this.citytxt.TabIndex = 26;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(579, 33);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(178, 31);
            this.emailtxt.TabIndex = 25;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // firstNametxt
            // 
            this.firstNametxt.Location = new System.Drawing.Point(188, 33);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(150, 31);
            this.firstNametxt.TabIndex = 24;
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
            // AddStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.emergencytxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.firstNametxt);
            this.Name = "AddStudentControl";
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

        private Button backbtn;
        private Button addbtn;
        private DateTimePicker birthDatePicker;
        private Label label10;
        private Label label9;
        private Label label2;
        private TextBox phoneNumbertxt;
        private ComboBox gendercmBox;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox lastNametxt;
        private TextBox emergencytxt;
        private TextBox addresstxt;
        private TextBox citytxt;
        private TextBox emailtxt;
        private TextBox firstNametxt;
        private ErrorProvider emailErrorProvider1;
        private ErrorProvider phoneNumErrorProvider1;
        private ErrorProvider emerganceErrorProvider1;
        private ErrorProvider firstNameErrorProvider1;
        private ErrorProvider lastNameErrorProvider1;
    }
}
