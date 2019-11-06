namespace DogShow
{
    partial class JudgementPage
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
            this.sizePointTxt = new System.Windows.Forms.TextBox();
            this.eyePointTxt = new System.Windows.Forms.TextBox();
            this.furColorPointTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPointsLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.furLengthPointTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectDogBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.eventNumTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.locationIdTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.classGroupComboBox = new System.Windows.Forms.ComboBox();
            this.dogView = new System.Windows.Forms.ListView();
            this.dogsFirstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dogsLastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dogsBreedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // sizePointTxt
            // 
            this.sizePointTxt.Enabled = false;
            this.sizePointTxt.Location = new System.Drawing.Point(13, 136);
            this.sizePointTxt.Name = "sizePointTxt";
            this.sizePointTxt.Size = new System.Drawing.Size(100, 20);
            this.sizePointTxt.TabIndex = 1;
            // 
            // eyePointTxt
            // 
            this.eyePointTxt.Enabled = false;
            this.eyePointTxt.Location = new System.Drawing.Point(13, 163);
            this.eyePointTxt.Name = "eyePointTxt";
            this.eyePointTxt.Size = new System.Drawing.Size(100, 20);
            this.eyePointTxt.TabIndex = 2;
            // 
            // furColorPointTxt
            // 
            this.furColorPointTxt.Enabled = false;
            this.furColorPointTxt.Location = new System.Drawing.Point(13, 190);
            this.furColorPointTxt.Name = "furColorPointTxt";
            this.furColorPointTxt.Size = new System.Drawing.Size(100, 20);
            this.furColorPointTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total: ";
            // 
            // totalPointsLbl
            // 
            this.totalPointsLbl.AutoSize = true;
            this.totalPointsLbl.Location = new System.Drawing.Point(53, 248);
            this.totalPointsLbl.Name = "totalPointsLbl";
            this.totalPointsLbl.Size = new System.Drawing.Size(0, 13);
            this.totalPointsLbl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size Point Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eye Color Point Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fur Color Point Value";
            // 
            // furLengthPointTxt
            // 
            this.furLengthPointTxt.Enabled = false;
            this.furLengthPointTxt.Location = new System.Drawing.Point(13, 217);
            this.furLengthPointTxt.Name = "furLengthPointTxt";
            this.furLengthPointTxt.Size = new System.Drawing.Size(100, 20);
            this.furLengthPointTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fur Length Point Value";
            // 
            // selectDogBtn
            // 
            this.selectDogBtn.Location = new System.Drawing.Point(11, 64);
            this.selectDogBtn.Name = "selectDogBtn";
            this.selectDogBtn.Size = new System.Drawing.Size(215, 23);
            this.selectDogBtn.TabIndex = 13;
            this.selectDogBtn.Text = "Select Dog";
            this.selectDogBtn.UseVisualStyleBackColor = true;
            this.selectDogBtn.Click += new System.EventHandler(this.selectDogBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(13, 286);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 14;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // eventNumTxt
            // 
            this.eventNumTxt.Location = new System.Drawing.Point(12, 12);
            this.eventNumTxt.Name = "eventNumTxt";
            this.eventNumTxt.Size = new System.Drawing.Size(75, 20);
            this.eventNumTxt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Event Number";
            // 
            // locationIdTxt
            // 
            this.locationIdTxt.Location = new System.Drawing.Point(12, 38);
            this.locationIdTxt.Name = "locationIdTxt";
            this.locationIdTxt.Size = new System.Drawing.Size(74, 20);
            this.locationIdTxt.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Location ID";
            // 
            // classGroupComboBox
            // 
            this.classGroupComboBox.FormattingEnabled = true;
            this.classGroupComboBox.Location = new System.Drawing.Point(223, 11);
            this.classGroupComboBox.Name = "classGroupComboBox";
            this.classGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.classGroupComboBox.TabIndex = 19;
            this.classGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.breedGroupComboBox_SelectedIndexChanged);
            // 
            // dogView
            // 
            this.dogView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dogsFirstNameColumn,
            this.dogsLastNameColumn,
            this.dogsBreedColumn});
            this.dogView.GridLines = true;
            this.dogView.HideSelection = false;
            this.dogView.Location = new System.Drawing.Point(364, 19);
            this.dogView.MultiSelect = false;
            this.dogView.Name = "dogView";
            this.dogView.Size = new System.Drawing.Size(397, 319);
            this.dogView.TabIndex = 20;
            this.dogView.UseCompatibleStateImageBehavior = false;
            this.dogView.View = System.Windows.Forms.View.Details;
            // 
            // dogsFirstNameColumn
            // 
            this.dogsFirstNameColumn.Text = "Dog\'s First Name";
            // 
            // dogsLastNameColumn
            // 
            this.dogsLastNameColumn.Text = "Dog\'s Last Name";
            // 
            // dogsBreedColumn
            // 
            this.dogsBreedColumn.Text = "Dog\'s Breed";
            // 
            // JudgementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 422);
            this.Controls.Add(this.dogView);
            this.Controls.Add(this.classGroupComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.locationIdTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eventNumTxt);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.selectDogBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.furLengthPointTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalPointsLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.furColorPointTxt);
            this.Controls.Add(this.eyePointTxt);
            this.Controls.Add(this.sizePointTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "JudgementPage";
            this.Text = "Judgement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sizePointTxt;
        private System.Windows.Forms.TextBox eyePointTxt;
        private System.Windows.Forms.TextBox furColorPointTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPointsLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox furLengthPointTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button selectDogBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox eventNumTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox locationIdTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox classGroupComboBox;
        private System.Windows.Forms.ListView dogView;
        private System.Windows.Forms.ColumnHeader dogsFirstNameColumn;
        private System.Windows.Forms.ColumnHeader dogsLastNameColumn;
        private System.Windows.Forms.ColumnHeader dogsBreedColumn;
    }
}