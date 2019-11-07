namespace DogShow
{
    partial class PastCompetitions
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
            this.ClassGroupComboBox = new System.Windows.Forms.ComboBox();
            this.EventNumTxt = new System.Windows.Forms.TextBox();
            this.LocationNumTxt = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstLbl = new System.Windows.Forms.Label();
            this.ThirdLbl = new System.Windows.Forms.Label();
            this.SecondLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClassGroupComboBox
            // 
            this.ClassGroupComboBox.FormattingEnabled = true;
            this.ClassGroupComboBox.Location = new System.Drawing.Point(13, 13);
            this.ClassGroupComboBox.Name = "ClassGroupComboBox";
            this.ClassGroupComboBox.Size = new System.Drawing.Size(148, 21);
            this.ClassGroupComboBox.TabIndex = 0;
            this.ClassGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.BreedGroupBox_SelectedIndexChanged);
            // 
            // EventNumTxt
            // 
            this.EventNumTxt.Location = new System.Drawing.Point(13, 41);
            this.EventNumTxt.Name = "EventNumTxt";
            this.EventNumTxt.Size = new System.Drawing.Size(148, 20);
            this.EventNumTxt.TabIndex = 1;
            // 
            // LocationNumTxt
            // 
            this.LocationNumTxt.Location = new System.Drawing.Point(13, 68);
            this.LocationNumTxt.Name = "LocationNumTxt";
            this.LocationNumTxt.Size = new System.Drawing.Size(148, 20);
            this.LocationNumTxt.TabIndex = 2;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(167, 11);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(181, 23);
            this.EnterBtn.TabIndex = 3;
            this.EnterBtn.Text = "Enter EventNum And Location ID";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Event Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Place";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Second Place";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Third Place";
            // 
            // FirstLbl
            // 
            this.FirstLbl.AutoSize = true;
            this.FirstLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLbl.Location = new System.Drawing.Point(276, 187);
            this.FirstLbl.Name = "FirstLbl";
            this.FirstLbl.Size = new System.Drawing.Size(51, 22);
            this.FirstLbl.TabIndex = 9;
            this.FirstLbl.Text = "First";
            // 
            // ThirdLbl
            // 
            this.ThirdLbl.AutoSize = true;
            this.ThirdLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdLbl.Location = new System.Drawing.Point(469, 258);
            this.ThirdLbl.Name = "ThirdLbl";
            this.ThirdLbl.Size = new System.Drawing.Size(58, 22);
            this.ThirdLbl.TabIndex = 10;
            this.ThirdLbl.Text = "Third";
            // 
            // SecondLbl
            // 
            this.SecondLbl.AutoSize = true;
            this.SecondLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondLbl.Location = new System.Drawing.Point(85, 258);
            this.SecondLbl.Name = "SecondLbl";
            this.SecondLbl.Size = new System.Drawing.Size(79, 22);
            this.SecondLbl.TabIndex = 11;
            this.SecondLbl.Text = "Second";
            // 
            // PastCompetitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 427);
            this.Controls.Add(this.SecondLbl);
            this.Controls.Add(this.ThirdLbl);
            this.Controls.Add(this.FirstLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.LocationNumTxt);
            this.Controls.Add(this.EventNumTxt);
            this.Controls.Add(this.ClassGroupComboBox);
            this.Name = "PastCompetitions";
            this.Text = "PastCompetitions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassGroupComboBox;
        private System.Windows.Forms.TextBox EventNumTxt;
        private System.Windows.Forms.TextBox LocationNumTxt;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FirstLbl;
        private System.Windows.Forms.Label ThirdLbl;
        private System.Windows.Forms.Label SecondLbl;
    }
}