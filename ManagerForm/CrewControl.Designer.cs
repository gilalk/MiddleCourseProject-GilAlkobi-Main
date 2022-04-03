namespace ManagerForm
{
    partial class CrewControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.editbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sortcmbox = new System.Windows.Forms.ComboBox();
            this.sortbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.selectAllcbx = new System.Windows.Forms.CheckBox();
            this.dispInfobtn = new System.Windows.Forms.Button();
            this.fullInfoDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subjectlbl = new System.Windows.Forms.Label();
            this.rolelbl = new System.Windows.Forms.Label();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.firstNamelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crewMemberscmBox = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullInfoDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.editbtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.sortcmbox);
            this.panel2.Controls.Add(this.sortbtn);
            this.panel2.Controls.Add(this.addbtn);
            this.panel2.Controls.Add(this.selectAllcbx);
            this.panel2.Controls.Add(this.dispInfobtn);
            this.panel2.Controls.Add(this.fullInfoDGV);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.crewMemberscmBox);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 603);
            this.panel2.TabIndex = 1;
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(654, 202);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(136, 87);
            this.editbtn.TabIndex = 10;
            this.editbtn.Text = "Edit Member";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sort Members By:";
            // 
            // sortcmbox
            // 
            this.sortcmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortcmbox.FormattingEnabled = true;
            this.sortcmbox.Items.AddRange(new object[] {
            "Id",
            "First Name",
            "Gender"});
            this.sortcmbox.Location = new System.Drawing.Point(640, 414);
            this.sortcmbox.Name = "sortcmbox";
            this.sortcmbox.Size = new System.Drawing.Size(182, 33);
            this.sortcmbox.TabIndex = 8;
            // 
            // sortbtn
            // 
            this.sortbtn.Location = new System.Drawing.Point(658, 479);
            this.sortbtn.Name = "sortbtn";
            this.sortbtn.Size = new System.Drawing.Size(136, 87);
            this.sortbtn.TabIndex = 7;
            this.sortbtn.Text = "Sort";
            this.sortbtn.UseVisualStyleBackColor = true;
            this.sortbtn.Click += new System.EventHandler(this.sortbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(654, 82);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(136, 87);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "Add New Member";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // selectAllcbx
            // 
            this.selectAllcbx.AutoSize = true;
            this.selectAllcbx.Location = new System.Drawing.Point(70, 121);
            this.selectAllcbx.Name = "selectAllcbx";
            this.selectAllcbx.Size = new System.Drawing.Size(109, 29);
            this.selectAllcbx.TabIndex = 5;
            this.selectAllcbx.Text = "Select All";
            this.selectAllcbx.UseVisualStyleBackColor = true;
            // 
            // dispInfobtn
            // 
            this.dispInfobtn.Location = new System.Drawing.Point(51, 185);
            this.dispInfobtn.Name = "dispInfobtn";
            this.dispInfobtn.Size = new System.Drawing.Size(136, 87);
            this.dispInfobtn.TabIndex = 4;
            this.dispInfobtn.Text = "Display";
            this.dispInfobtn.UseVisualStyleBackColor = true;
            this.dispInfobtn.Click += new System.EventHandler(this.dispInfobtn_Click);
            // 
            // fullInfoDGV
            // 
            this.fullInfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullInfoDGV.Location = new System.Drawing.Point(40, 331);
            this.fullInfoDGV.Name = "fullInfoDGV";
            this.fullInfoDGV.RowHeadersWidth = 62;
            this.fullInfoDGV.RowTemplate.Height = 33;
            this.fullInfoDGV.Size = new System.Drawing.Size(583, 259);
            this.fullInfoDGV.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subjectlbl);
            this.groupBox1.Controls.Add(this.rolelbl);
            this.groupBox1.Controls.Add(this.lastNamelbl);
            this.groupBox1.Controls.Add(this.firstNamelbl);
            this.groupBox1.Location = new System.Drawing.Point(361, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 272);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Info";
            // 
            // subjectlbl
            // 
            this.subjectlbl.AutoSize = true;
            this.subjectlbl.Location = new System.Drawing.Point(96, 220);
            this.subjectlbl.Name = "subjectlbl";
            this.subjectlbl.Size = new System.Drawing.Size(59, 25);
            this.subjectlbl.TabIndex = 3;
            this.subjectlbl.Text = "label4";
            this.subjectlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rolelbl
            // 
            this.rolelbl.AutoSize = true;
            this.rolelbl.Location = new System.Drawing.Point(96, 166);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(59, 25);
            this.rolelbl.TabIndex = 2;
            this.rolelbl.Text = "label4";
            this.rolelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Location = new System.Drawing.Point(96, 108);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(59, 25);
            this.lastNamelbl.TabIndex = 1;
            this.lastNamelbl.Text = "label3";
            this.lastNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNamelbl
            // 
            this.firstNamelbl.AutoSize = true;
            this.firstNamelbl.Location = new System.Drawing.Point(96, 52);
            this.firstNamelbl.Name = "firstNamelbl";
            this.firstNamelbl.Size = new System.Drawing.Size(59, 25);
            this.firstNamelbl.TabIndex = 0;
            this.firstNamelbl.Text = "label2";
            this.firstNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crew Member Name:";
            // 
            // crewMemberscmBox
            // 
            this.crewMemberscmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crewMemberscmBox.FormattingEnabled = true;
            this.crewMemberscmBox.Location = new System.Drawing.Point(40, 65);
            this.crewMemberscmBox.Name = "crewMemberscmBox";
            this.crewMemberscmBox.Size = new System.Drawing.Size(182, 33);
            this.crewMemberscmBox.TabIndex = 0;
            // 
            // CrewControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panel2);
            this.Name = "CrewControl1";
            this.Size = new System.Drawing.Size(844, 603);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullInfoDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox crewMemberscmBox;
        private CheckBox selectAllcbx;
        private Button dispInfobtn;
        private DataGridView fullInfoDGV;
        private Label subjectlbl;
        private Label rolelbl;
        private Label lastNamelbl;
        private Label firstNamelbl;
        private Button sortbtn;
        private Button addbtn;
        private ComboBox sortcmbox;
        private Label label2;
        private Button editbtn;
    }
}
