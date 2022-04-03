namespace ManagerForm
{
    partial class StudentControl
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
            this.techercmBox = new System.Windows.Forms.ComboBox();
            this.classcmBox = new System.Windows.Forms.ComboBox();
            this.studentcmBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infogrBox = new System.Windows.Forms.GroupBox();
            this.phoneNumberlbl = new System.Windows.Forms.Label();
            this.DOBlbl = new System.Windows.Forms.Label();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.firstNamelbl = new System.Windows.Forms.Label();
            this.fullInfoDgv = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.displayBtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.infogrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullInfoDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // techercmBox
            // 
            this.techercmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.techercmBox.FormattingEnabled = true;
            this.techercmBox.Location = new System.Drawing.Point(56, 65);
            this.techercmBox.Name = "techercmBox";
            this.techercmBox.Size = new System.Drawing.Size(182, 33);
            this.techercmBox.TabIndex = 0;
            this.techercmBox.SelectedValueChanged += new System.EventHandler(this.classcmBox_SelectedValueChanged);
            // 
            // classcmBox
            // 
            this.classcmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classcmBox.FormattingEnabled = true;
            this.classcmBox.Location = new System.Drawing.Point(321, 65);
            this.classcmBox.Name = "classcmBox";
            this.classcmBox.Size = new System.Drawing.Size(182, 33);
            this.classcmBox.TabIndex = 1;
            this.classcmBox.SelectionChangeCommitted += new System.EventHandler(this.studentcmBox_SelectedIndexChanged);
            // 
            // studentcmBox
            // 
            this.studentcmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentcmBox.FormattingEnabled = true;
            this.studentcmBox.Location = new System.Drawing.Point(597, 65);
            this.studentcmBox.Name = "studentcmBox";
            this.studentcmBox.Size = new System.Drawing.Size(182, 33);
            this.studentcmBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose Student";
            // 
            // infogrBox
            // 
            this.infogrBox.Controls.Add(this.phoneNumberlbl);
            this.infogrBox.Controls.Add(this.DOBlbl);
            this.infogrBox.Controls.Add(this.lastNamelbl);
            this.infogrBox.Controls.Add(this.firstNamelbl);
            this.infogrBox.Location = new System.Drawing.Point(25, 164);
            this.infogrBox.Name = "infogrBox";
            this.infogrBox.Size = new System.Drawing.Size(277, 344);
            this.infogrBox.TabIndex = 6;
            this.infogrBox.TabStop = false;
            this.infogrBox.Text = "General Info";
            // 
            // phoneNumberlbl
            // 
            this.phoneNumberlbl.AutoSize = true;
            this.phoneNumberlbl.Location = new System.Drawing.Point(69, 265);
            this.phoneNumberlbl.Name = "phoneNumberlbl";
            this.phoneNumberlbl.Size = new System.Drawing.Size(59, 25);
            this.phoneNumberlbl.TabIndex = 3;
            this.phoneNumberlbl.Text = "label7";
            // 
            // DOBlbl
            // 
            this.DOBlbl.AutoSize = true;
            this.DOBlbl.Location = new System.Drawing.Point(69, 199);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(59, 25);
            this.DOBlbl.TabIndex = 2;
            this.DOBlbl.Text = "label6";
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Location = new System.Drawing.Point(69, 129);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(59, 25);
            this.lastNamelbl.TabIndex = 1;
            this.lastNamelbl.Text = "label5";
            // 
            // firstNamelbl
            // 
            this.firstNamelbl.AutoSize = true;
            this.firstNamelbl.Location = new System.Drawing.Point(69, 66);
            this.firstNamelbl.Name = "firstNamelbl";
            this.firstNamelbl.Size = new System.Drawing.Size(59, 25);
            this.firstNamelbl.TabIndex = 0;
            this.firstNamelbl.Text = "label4";
            // 
            // fullInfoDgv
            // 
            this.fullInfoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullInfoDgv.Location = new System.Drawing.Point(321, 180);
            this.fullInfoDgv.Name = "fullInfoDgv";
            this.fullInfoDgv.RowHeadersWidth = 62;
            this.fullInfoDgv.RowTemplate.Height = 33;
            this.fullInfoDgv.Size = new System.Drawing.Size(488, 328);
            this.fullInfoDgv.TabIndex = 7;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(330, 525);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(198, 65);
            this.addbtn.TabIndex = 8;
            this.addbtn.Text = "Add New Student";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(689, 121);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(109, 29);
            this.selectAllCheckBox.TabIndex = 9;
            this.selectAllCheckBox.Text = "Select All";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // displayBtn
            // 
            this.displayBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.displayBtn.Location = new System.Drawing.Point(540, 109);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(128, 51);
            this.displayBtn.TabIndex = 10;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(597, 525);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(201, 65);
            this.editbtn.TabIndex = 11;
            this.editbtn.Text = "Edit Student";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.selectAllCheckBox);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.fullInfoDgv);
            this.Controls.Add(this.infogrBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentcmBox);
            this.Controls.Add(this.classcmBox);
            this.Controls.Add(this.techercmBox);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(844, 603);
            this.infogrBox.ResumeLayout(false);
            this.infogrBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullInfoDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox techercmBox;
        private ComboBox classcmBox;
        private ComboBox studentcmBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox infogrBox;
        private Label phoneNumberlbl;
        private Label DOBlbl;
        private Label lastNamelbl;
        private Label firstNamelbl;
        private DataGridView fullInfoDgv;
        private Button addbtn;
        private CheckBox selectAllCheckBox;
        private Button displayBtn;
        private Button editbtn;
    }
}
