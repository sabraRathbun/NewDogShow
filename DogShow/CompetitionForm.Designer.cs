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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstLbl = new System.Windows.Forms.Label();
            this.thirdLbl = new System.Windows.Forms.Label();
            this.secondLbl = new System.Windows.Forms.Label();
            this.selectDogOneBtn = new System.Windows.Forms.Button();
            this.saveComp = new System.Windows.Forms.Button();
            this.dogListView = new System.Windows.Forms.ListView();
            this.firstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dogBreedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classGroupComboBox = new System.Windows.Forms.ComboBox();
            this.selectDogThreeBtn = new System.Windows.Forms.Button();
            this.selectDogTwoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // selectDogOneBtn
            // 
            this.selectDogOneBtn.Location = new System.Drawing.Point(409, 12);
            this.selectDogOneBtn.Name = "selectDogOneBtn";
            this.selectDogOneBtn.Size = new System.Drawing.Size(100, 23);
            this.selectDogOneBtn.TabIndex = 14;
            this.selectDogOneBtn.Text = "Select Dog One";
            this.selectDogOneBtn.UseVisualStyleBackColor = true;
            this.selectDogOneBtn.Click += new System.EventHandler(this.SelectBtn_Click);
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
            // dogListView
            // 
            this.dogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameColumn,
            this.lastNameColumn,
            this.dogBreedColumn});
            this.dogListView.HideSelection = false;
            this.dogListView.Location = new System.Drawing.Point(515, 12);
            this.dogListView.Name = "dogListView";
            this.dogListView.Size = new System.Drawing.Size(484, 196);
            this.dogListView.TabIndex = 19;
            this.dogListView.UseCompatibleStateImageBehavior = false;
            this.dogListView.View = System.Windows.Forms.View.Details;
            this.dogListView.SelectedIndexChanged += new System.EventHandler(this.dogListView_SelectedIndexChanged);
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
            this.classGroupComboBox.Location = new System.Drawing.Point(12, 12);
            this.classGroupComboBox.Name = "classGroupComboBox";
            this.classGroupComboBox.Size = new System.Drawing.Size(202, 21);
            this.classGroupComboBox.TabIndex = 20;
            this.classGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.classGroupComboBox_SelectedIndexChanged);
            // 
            // selectDogThreeBtn
            // 
            this.selectDogThreeBtn.Location = new System.Drawing.Point(409, 71);
            this.selectDogThreeBtn.Name = "selectDogThreeBtn";
            this.selectDogThreeBtn.Size = new System.Drawing.Size(100, 23);
            this.selectDogThreeBtn.TabIndex = 21;
            this.selectDogThreeBtn.Text = "Select Dog Three";
            this.selectDogThreeBtn.UseVisualStyleBackColor = true;
            this.selectDogThreeBtn.Click += new System.EventHandler(this.selectDogThreeBtn_Click);
            // 
            // selectDogTwoBtn
            // 
            this.selectDogTwoBtn.Location = new System.Drawing.Point(409, 41);
            this.selectDogTwoBtn.Name = "selectDogTwoBtn";
            this.selectDogTwoBtn.Size = new System.Drawing.Size(100, 24);
            this.selectDogTwoBtn.TabIndex = 22;
            this.selectDogTwoBtn.Text = "Select Dog Two";
            this.selectDogTwoBtn.UseVisualStyleBackColor = true;
            this.selectDogTwoBtn.Click += new System.EventHandler(this.selectDogTwoBtn_Click);
            // 
            // CompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 457);
            this.Controls.Add(this.selectDogTwoBtn);
            this.Controls.Add(this.selectDogThreeBtn);
            this.Controls.Add(this.classGroupComboBox);
            this.Controls.Add(this.dogListView);
            this.Controls.Add(this.saveComp);
            this.Controls.Add(this.selectDogOneBtn);
            this.Controls.Add(this.secondLbl);
            this.Controls.Add(this.thirdLbl);
            this.Controls.Add(this.firstLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompetitionForm";
            this.Text = "CompetitionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label firstLbl;
        public System.Windows.Forms.Label thirdLbl;
        public System.Windows.Forms.Label secondLbl;
        public System.Windows.Forms.Button selectDogOneBtn;
        public System.Windows.Forms.Button saveComp;
        private System.Windows.Forms.ListView dogListView;
        private System.Windows.Forms.ColumnHeader firstNameColumn;
        private System.Windows.Forms.ColumnHeader lastNameColumn;
        private System.Windows.Forms.ColumnHeader dogBreedColumn;
        private System.Windows.Forms.ComboBox classGroupComboBox;
        public System.Windows.Forms.Button selectDogThreeBtn;
        public System.Windows.Forms.Button selectDogTwoBtn;
    }
}