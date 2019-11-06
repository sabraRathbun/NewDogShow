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
            this.EventNumTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LocationIDTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.selectDogOneBtn.Text = "Select Doggos";
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
            // EventNumTxt
            // 
            this.EventNumTxt.Location = new System.Drawing.Point(13, 40);
            this.EventNumTxt.Name = "EventNumTxt";
            this.EventNumTxt.Size = new System.Drawing.Size(201, 20);
            this.EventNumTxt.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Event Number";
            // 
            // LocationIDTxt
            // 
            this.LocationIDTxt.Location = new System.Drawing.Point(13, 67);
            this.LocationIDTxt.Name = "LocationIDTxt";
            this.LocationIDTxt.Size = new System.Drawing.Size(201, 20);
            this.LocationIDTxt.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "LocationID";
            // 
            // CompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 457);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LocationIDTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EventNumTxt);
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
        private System.Windows.Forms.TextBox EventNumTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LocationIDTxt;
        private System.Windows.Forms.Label label5;
    }
}