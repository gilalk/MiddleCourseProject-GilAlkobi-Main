namespace ManagerForm
{
    partial class HomeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            this.userlbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hellolbl = new System.Windows.Forms.Label();
            this.myProfilebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userlbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.userlbl.Location = new System.Drawing.Point(299, 446);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(145, 51);
            this.userlbl.TabIndex = 10;
            this.userlbl.Text = "label1";
            this.userlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 326);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // hellolbl
            // 
            this.hellolbl.AutoSize = true;
            this.hellolbl.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hellolbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.hellolbl.Location = new System.Drawing.Point(251, 507);
            this.hellolbl.Name = "hellolbl";
            this.hellolbl.Size = new System.Drawing.Size(145, 51);
            this.hellolbl.TabIndex = 11;
            this.hellolbl.Text = "label1";
            // 
            // myProfilebtn
            // 
            this.myProfilebtn.FlatAppearance.BorderSize = 0;
            this.myProfilebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.myProfilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myProfilebtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myProfilebtn.Location = new System.Drawing.Point(328, 61);
            this.myProfilebtn.Name = "myProfilebtn";
            this.myProfilebtn.Size = new System.Drawing.Size(201, 34);
            this.myProfilebtn.TabIndex = 12;
            this.myProfilebtn.Text = "Go To My Profile";
            this.myProfilebtn.UseVisualStyleBackColor = true;
            this.myProfilebtn.Click += new System.EventHandler(this.myProfilebtn_Click);
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myProfilebtn);
            this.Controls.Add(this.hellolbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.pictureBox2);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(844, 603);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userlbl;
        private PictureBox pictureBox2;
        private Label hellolbl;
        private Button myProfilebtn;
    }
}
