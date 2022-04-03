namespace SchoolManagement_MyMidProj
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logolbl = new System.Windows.Forms.Label();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ForgotPasswordlbl = new System.Windows.Forms.Label();
            this.SignInbtn = new System.Windows.Forms.Button();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.userNamelbl = new System.Windows.Forms.Label();
            this.signInlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.logolbl);
            this.panel1.Controls.Add(this.logoPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 450);
            this.panel1.TabIndex = 0;
            // 
            // logolbl
            // 
            this.logolbl.AutoSize = true;
            this.logolbl.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logolbl.Location = new System.Drawing.Point(30, 357);
            this.logolbl.Name = "logolbl";
            this.logolbl.Size = new System.Drawing.Size(237, 27);
            this.logolbl.TabIndex = 1;
            this.logolbl.Text = "Manage Your Succsess";
            // 
            // logoPicBox
            // 
            this.logoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicBox.Image")));
            this.logoPicBox.Location = new System.Drawing.Point(12, 68);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(273, 286);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 0;
            this.logoPicBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ForgotPasswordlbl);
            this.panel2.Controls.Add(this.SignInbtn);
            this.panel2.Controls.Add(this.passwordtxt);
            this.panel2.Controls.Add(this.usernametxt);
            this.panel2.Controls.Add(this.passwordlbl);
            this.panel2.Controls.Add(this.userNamelbl);
            this.panel2.Controls.Add(this.signInlbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 450);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ForgotPasswordlbl
            // 
            this.ForgotPasswordlbl.AutoSize = true;
            this.ForgotPasswordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForgotPasswordlbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ForgotPasswordlbl.Location = new System.Drawing.Point(153, 310);
            this.ForgotPasswordlbl.Name = "ForgotPasswordlbl";
            this.ForgotPasswordlbl.Size = new System.Drawing.Size(138, 20);
            this.ForgotPasswordlbl.TabIndex = 15;
            this.ForgotPasswordlbl.Text = "Forgot Password?";
            // 
            // SignInbtn
            // 
            this.SignInbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.SignInbtn.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignInbtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.SignInbtn.Location = new System.Drawing.Point(159, 357);
            this.SignInbtn.Name = "SignInbtn";
            this.SignInbtn.Size = new System.Drawing.Size(132, 67);
            this.SignInbtn.TabIndex = 14;
            this.SignInbtn.Text = "Enter";
            this.SignInbtn.UseVisualStyleBackColor = false;
            this.SignInbtn.Click += new System.EventHandler(this.SignInbtn_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.passwordtxt.Location = new System.Drawing.Point(101, 260);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(251, 31);
            this.passwordtxt.TabIndex = 13;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.usernametxt.Location = new System.Drawing.Point(101, 157);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(251, 31);
            this.usernametxt.TabIndex = 12;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordlbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.passwordlbl.Location = new System.Drawing.Point(150, 211);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(155, 32);
            this.passwordlbl.TabIndex = 11;
            this.passwordlbl.Text = "Password:";
            // 
            // userNamelbl
            // 
            this.userNamelbl.AutoSize = true;
            this.userNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNamelbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userNamelbl.Location = new System.Drawing.Point(150, 110);
            this.userNamelbl.Name = "userNamelbl";
            this.userNamelbl.Size = new System.Drawing.Size(161, 32);
            this.userNamelbl.TabIndex = 10;
            this.userNamelbl.Text = "Username:";
            // 
            // signInlbl
            // 
            this.signInlbl.AutoSize = true;
            this.signInlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signInlbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signInlbl.Location = new System.Drawing.Point(147, 27);
            this.signInlbl.Name = "signInlbl";
            this.signInlbl.Size = new System.Drawing.Size(164, 52);
            this.signInlbl.TabIndex = 9;
            this.signInlbl.Text = "Sign In";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label logolbl;
        private PictureBox logoPicBox;
        private Panel panel2;
        private Label ForgotPasswordlbl;
        private Button SignInbtn;
        private TextBox passwordtxt;
        private TextBox usernametxt;
        private Label passwordlbl;
        private Label userNamelbl;
        private Label signInlbl;
        private PictureBox pictureBox1;
    }
}