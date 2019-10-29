namespace DogShow
{
    partial class CompetitionForm
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
            this.Dog1Box = new System.Windows.Forms.ListBox();
            this.dog2Box = new System.Windows.Forms.ListBox();
            this.dog3Box = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstLbl = new System.Windows.Forms.Label();
            this.thirdLbl = new System.Windows.Forms.Label();
            this.secondLbl = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.saveComp = new System.Windows.Forms.Button();
            this.dog1LastName = new System.Windows.Forms.ListBox();
            this.dog2LastName = new System.Windows.Forms.ListBox();
            this.dog3LastName = new System.Windows.Forms.ListBox();
            this.dogListView = new System.Windows.Forms.ListView();
            this.firstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dogBreedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classGroupComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Dog1Box
            // 
            this.Dog1Box.FormattingEnabled = true;
            this.Dog1Box.Location = new System.Drawing.Point(118, 13);
            this.Dog1Box.Name = "Dog1Box";
            this.Dog1Box.Size = new System.Drawing.Size(99, 121);
            this.Dog1Box.TabIndex = 1;
            // 
            // dog2Box
            // 
            this.dog2Box.FormattingEnabled = true;
            this.dog2Box.Location = new System.Drawing.Point(223, 13);
            this.dog2Box.Name = "dog2Box";
            this.dog2Box.Size = new System.Drawing.Size(99, 121);
            this.dog2Box.TabIndex = 4;
            // 
            // dog3Box
            // 
            this.dog3Box.FormattingEnabled = true;
            this.dog3Box.Location = new System.Drawing.Point(328, 12);
            this.dog3Box.Name = "dog3Box";
            this.dog3Box.Size = new System.Drawing.Size(99, 121);
            this.dog3Box.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "1st Place";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "3rd Place";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "2nd Place";
            // 
            // firstLbl
            // 
            this.firstLbl.AutoSize = true;
            this.firstLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLbl.Location = new System.Drawing.Point(300, 227);
            this.firstLbl.Name = "firstLbl";
            this.firstLbl.Size = new System.Drawing.Size(0, 22);
            this.firstLbl.TabIndex = 11;
            // 
            // thirdLbl
            // 
            this.thirdLbl.AutoSize = true;
            this.thirdLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLbl.Location = new System.Drawing.Point(534, 317);
            this.thirdLbl.Name = "thirdLbl";
            this.thirdLbl.Size = new System.Drawing.Size(0, 22);
            this.thirdLbl.TabIndex = 12;
            // 
            // secondLbl
            // 
            this.secondLbl.AutoSize = true;
            this.secondLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLbl.Location = new System.Drawing.Point(65, 303);
            this.secondLbl.Name = "secondLbl";
            this.secondLbl.Size = new System.Drawing.Size(0, 22);
            this.secondLbl.TabIndex = 13;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(642, 595);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(100, 23);
            this.selectBtn.TabIndex = 14;
            this.selectBtn.Text = "Select Dog";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // saveComp
            // 
            this.saveComp.Location = new System.Drawing.Point(145, 397);
            this.saveComp.Name = "saveComp";
            this.saveComp.Size = new System.Drawing.Size(414, 23);
            this.saveComp.TabIndex = 15;
            this.saveComp.Text = "Save Competition";
            this.saveComp.UseVisualStyleBackColor = true;
            this.saveComp.Click += new System.EventHandler(this.SaveComp_Click);
            // 
            // dog1LastName
            // 
            this.dog1LastName.FormattingEnabled = true;
            this.dog1LastName.Location = new System.Drawing.Point(433, 13);
            this.dog1LastName.Name = "dog1LastName";
            this.dog1LastName.Size = new System.Drawing.Size(99, 121);
            this.dog1LastName.TabIndex = 16;
            // 
            // dog2LastName
            // 
            this.dog2LastName.FormattingEnabled = true;
            this.dog2LastName.Location = new System.Drawing.Point(538, 12);
            this.dog2LastName.Name = "dog2LastName";
            this.dog2LastName.Size = new System.Drawing.Size(99, 121);
            this.dog2LastName.TabIndex = 17;
            // 
            // dog3LastName
            // 
            this.dog3LastName.FormattingEnabled = true;
            this.dog3LastName.Location = new System.Drawing.Point(643, 12);
            this.dog3LastName.Name = "dog3LastName";
            this.dog3LastName.Size = new System.Drawing.Size(99, 121);
            this.dog3LastName.TabIndex = 18;
            // 
            // dogListView
            // 
            this.dogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameColumn,
            this.lastNameColumn,
            this.dogBreedColumn});
            this.dogListView.HideSelection = false;
            this.dogListView.Location = new System.Drawing.Point(792, 13);
            this.dogListView.Name = "dogListView";
            this.dogListView.Size = new System.Drawing.Size(484, 605);
            this.dogListView.TabIndex = 19;
            this.dogListView.UseCompatibleStateImageBehavior = false;
            this.dogListView.View = System.Windows.Forms.View.Details;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.Text = "Dog\'s First Name";
            this.firstNameColumn.Width = 127;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.Text = "Dog\'s Last Name";
            this.lastNameColumn.Width = 192;
            // 
            // dogBreedColumn
            // 
            this.dogBreedColumn.Text = "Dog\'s Breed";
            this.dogBreedColumn.Width = 163;
            // 
            // classGroupComboBox
            // 
            this.classGroupComboBox.FormattingEnabled = true;
            this.classGroupComboBox.Location = new System.Drawing.Point(13, 175);
            this.classGroupComboBox.Name = "classGroupComboBox";
            this.classGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.classGroupComboBox.TabIndex = 20;
            this.classGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.classGroupComboBox_SelectedIndexChanged);
            // 
            // CompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 630);
            this.Controls.Add(this.classGroupComboBox);
            this.Controls.Add(this.dogListView);
            this.Controls.Add(this.dog3LastName);
            this.Controls.Add(this.dog2LastName);
            this.Controls.Add(this.dog1LastName);
            this.Controls.Add(this.saveComp);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.secondLbl);
            this.Controls.Add(this.thirdLbl);
            this.Controls.Add(this.firstLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dog3Box);
            this.Controls.Add(this.dog2Box);
            this.Controls.Add(this.Dog1Box);
            this.Name = "CompetitionForm";
            this.Text = "CompetitionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox Dog1Box;
        public System.Windows.Forms.ListBox dog2Box;
        public System.Windows.Forms.ListBox dog3Box;
        public System.Windows.Forms.Label firstLbl;
        public System.Windows.Forms.Label thirdLbl;
        public System.Windows.Forms.Label secondLbl;
        public System.Windows.Forms.Button selectBtn;
        public System.Windows.Forms.Button saveComp;
        public System.Windows.Forms.ListBox dog1LastName;
        public System.Windows.Forms.ListBox dog2LastName;
        public System.Windows.Forms.ListBox dog3LastName;
        private System.Windows.Forms.ListView dogListView;
        private System.Windows.Forms.ColumnHeader firstNameColumn;
        private System.Windows.Forms.ColumnHeader lastNameColumn;
        private System.Windows.Forms.ColumnHeader dogBreedColumn;
        private System.Windows.Forms.ComboBox classGroupComboBox;
    }
}