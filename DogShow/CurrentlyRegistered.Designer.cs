namespace DogShow
{
    partial class CurrentlyRegistered
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
            this.forwardBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.dogNameLbl = new System.Windows.Forms.Label();
            this.dogBreedLbl = new System.Windows.Forms.Label();
            this.dogClassLbl = new System.Windows.Forms.Label();
            this.dogGenderLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forwardBtn
            // 
            this.forwardBtn.Location = new System.Drawing.Point(400, 234);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(153, 89);
            this.forwardBtn.TabIndex = 0;
            this.forwardBtn.Text = "->";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Enabled = false;
            this.backBtn.Location = new System.Drawing.Point(12, 234);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(153, 89);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "<-";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dogNameLbl
            // 
            this.dogNameLbl.AutoSize = true;
            this.dogNameLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogNameLbl.Location = new System.Drawing.Point(222, 46);
            this.dogNameLbl.Name = "dogNameLbl";
            this.dogNameLbl.Size = new System.Drawing.Size(116, 24);
            this.dogNameLbl.TabIndex = 2;
            this.dogNameLbl.Text = "Dog Name";
            // 
            // dogBreedLbl
            // 
            this.dogBreedLbl.AutoSize = true;
            this.dogBreedLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogBreedLbl.Location = new System.Drawing.Point(12, 134);
            this.dogBreedLbl.Name = "dogBreedLbl";
            this.dogBreedLbl.Size = new System.Drawing.Size(71, 24);
            this.dogBreedLbl.TabIndex = 3;
            this.dogBreedLbl.Text = "Breed";
            // 
            // dogClassLbl
            // 
            this.dogClassLbl.AutoSize = true;
            this.dogClassLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogClassLbl.Location = new System.Drawing.Point(248, 134);
            this.dogClassLbl.Name = "dogClassLbl";
            this.dogClassLbl.Size = new System.Drawing.Size(66, 24);
            this.dogClassLbl.TabIndex = 4;
            this.dogClassLbl.Text = "Class";
            // 
            // dogGenderLbl
            // 
            this.dogGenderLbl.AutoSize = true;
            this.dogGenderLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogGenderLbl.Location = new System.Drawing.Point(467, 134);
            this.dogGenderLbl.Name = "dogGenderLbl";
            this.dogGenderLbl.Size = new System.Drawing.Size(86, 24);
            this.dogGenderLbl.TabIndex = 5;
            this.dogGenderLbl.Text = "Gender";
            // 
            // CurrentlyRegistered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 338);
            this.Controls.Add(this.dogGenderLbl);
            this.Controls.Add(this.dogClassLbl);
            this.Controls.Add(this.dogBreedLbl);
            this.Controls.Add(this.dogNameLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.forwardBtn);
            this.Name = "CurrentlyRegistered";
            this.Text = "CurrentlyRegistered";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label dogNameLbl;
        private System.Windows.Forms.Label dogBreedLbl;
        private System.Windows.Forms.Label dogClassLbl;
        private System.Windows.Forms.Label dogGenderLbl;
    }
}