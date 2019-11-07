namespace DogShow
{
    partial class StartupForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.registrationBtn = new System.Windows.Forms.Button();
            this.dogListBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.competitionBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pastCompBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationBtn
            // 
            this.registrationBtn.BackColor = System.Drawing.Color.Black;
            this.registrationBtn.ForeColor = System.Drawing.Color.LawnGreen;
            this.registrationBtn.Location = new System.Drawing.Point(12, 260);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(198, 23);
            this.registrationBtn.TabIndex = 0;
            this.registrationBtn.Text = "Dog Registration";
            this.registrationBtn.UseVisualStyleBackColor = false;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // dogListBtn
            // 
            this.dogListBtn.BackColor = System.Drawing.Color.Black;
            this.dogListBtn.ForeColor = System.Drawing.Color.LawnGreen;
            this.dogListBtn.Location = new System.Drawing.Point(215, 260);
            this.dogListBtn.Name = "dogListBtn";
            this.dogListBtn.Size = new System.Drawing.Size(197, 23);
            this.dogListBtn.TabIndex = 1;
            this.dogListBtn.Text = "List of Currently Registered Dogs";
            this.dogListBtn.UseVisualStyleBackColor = false;
            this.dogListBtn.Click += new System.EventHandler(this.dogListBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(279, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // competitionBtn
            // 
            this.competitionBtn.BackColor = System.Drawing.Color.Black;
            this.competitionBtn.ForeColor = System.Drawing.Color.LawnGreen;
            this.competitionBtn.Location = new System.Drawing.Point(12, 289);
            this.competitionBtn.Name = "competitionBtn";
            this.competitionBtn.Size = new System.Drawing.Size(198, 23);
            this.competitionBtn.TabIndex = 5;
            this.competitionBtn.Text = "Compete";
            this.competitionBtn.UseVisualStyleBackColor = false;
            this.competitionBtn.Click += new System.EventHandler(this.competitionBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(215, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Judges/Judgement Form";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pastCompBtn
            // 
            this.pastCompBtn.BackColor = System.Drawing.Color.Black;
            this.pastCompBtn.ForeColor = System.Drawing.Color.LawnGreen;
            this.pastCompBtn.Location = new System.Drawing.Point(12, 318);
            this.pastCompBtn.Name = "pastCompBtn";
            this.pastCompBtn.Size = new System.Drawing.Size(400, 23);
            this.pastCompBtn.TabIndex = 7;
            this.pastCompBtn.Text = "Past Competitions";
            this.pastCompBtn.UseVisualStyleBackColor = false;
            this.pastCompBtn.Click += new System.EventHandler(this.pastCompBtn_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(424, 347);
            this.Controls.Add(this.pastCompBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.competitionBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dogListBtn);
            this.Controls.Add(this.registrationBtn);
            this.Name = "StartupForm";
            this.Text = "StartupForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registrationBtn;
        private System.Windows.Forms.Button dogListBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button competitionBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pastCompBtn;
    }
}