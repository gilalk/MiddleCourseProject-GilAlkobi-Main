namespace ManagerForm
{
    partial class manageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.nevigatePanel = new System.Windows.Forms.Panel();
            this.crewBtn = new System.Windows.Forms.Button();
            this.studentsBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.screensPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.classBtn = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPanel.Controls.Add(this.classBtn);
            this.menuPanel.Controls.Add(this.logoutBtn);
            this.menuPanel.Controls.Add(this.nevigatePanel);
            this.menuPanel.Controls.Add(this.crewBtn);
            this.menuPanel.Controls.Add(this.studentsBtn);
            this.menuPanel.Controls.Add(this.homeBtn);
            this.menuPanel.Controls.Add(this.picturePanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(223, 651);
            this.menuPanel.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.Location = new System.Drawing.Point(0, 569);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(223, 82);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // nevigatePanel
            // 
            this.nevigatePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nevigatePanel.Location = new System.Drawing.Point(204, 150);
            this.nevigatePanel.Name = "nevigatePanel";
            this.nevigatePanel.Size = new System.Drawing.Size(19, 82);
            this.nevigatePanel.TabIndex = 5;
            // 
            // crewBtn
            // 
            this.crewBtn.FlatAppearance.BorderSize = 0;
            this.crewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crewBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crewBtn.Image = ((System.Drawing.Image)(resources.GetObject("crewBtn.Image")));
            this.crewBtn.Location = new System.Drawing.Point(0, 232);
            this.crewBtn.Name = "crewBtn";
            this.crewBtn.Size = new System.Drawing.Size(202, 82);
            this.crewBtn.TabIndex = 3;
            this.crewBtn.Text = "Crew";
            this.crewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.crewBtn.UseVisualStyleBackColor = true;
            this.crewBtn.Click += new System.EventHandler(this.crewBtn_Click);
            // 
            // studentsBtn
            // 
            this.studentsBtn.FlatAppearance.BorderSize = 0;
            this.studentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("studentsBtn.Image")));
            this.studentsBtn.Location = new System.Drawing.Point(0, 314);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(202, 82);
            this.studentsBtn.TabIndex = 2;
            this.studentsBtn.Text = "Students";
            this.studentsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.studentsBtn.UseVisualStyleBackColor = true;
            this.studentsBtn.Click += new System.EventHandler(this.studentsBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(0, 150);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(202, 82);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // picturePanel
            // 
            this.picturePanel.BackColor = System.Drawing.Color.SeaShell;
            this.picturePanel.Controls.Add(this.pictureBox1);
            this.picturePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.picturePanel.Location = new System.Drawing.Point(0, 0);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(223, 150);
            this.picturePanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.screensPanel);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(223, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 651);
            this.panel1.TabIndex = 1;
            // 
            // screensPanel
            // 
            this.screensPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.screensPanel.Location = new System.Drawing.Point(0, 48);
            this.screensPanel.Name = "screensPanel";
            this.screensPanel.Size = new System.Drawing.Size(844, 603);
            this.screensPanel.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(807, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // classBtn
            // 
            this.classBtn.FlatAppearance.BorderSize = 0;
            this.classBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classBtn.Image = ((System.Drawing.Image)(resources.GetObject("classBtn.Image")));
            this.classBtn.Location = new System.Drawing.Point(2, 402);
            this.classBtn.Name = "classBtn";
            this.classBtn.Size = new System.Drawing.Size(202, 82);
            this.classBtn.TabIndex = 6;
            this.classBtn.Text = "Classes";
            this.classBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.classBtn.UseVisualStyleBackColor = true;
            this.classBtn.Click += new System.EventHandler(this.classBtn_Click);
            // 
            // manageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.picturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Button crewBtn;
        private Button studentsBtn;
        private Button homeBtn;
        private Panel picturePanel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel nevigatePanel;
        private Button logoutBtn;
        private Panel screensPanel;
        private PictureBox pictureBox3;
        private Button classBtn;
    }
}