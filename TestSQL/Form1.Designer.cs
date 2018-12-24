namespace EleDB
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.descField = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.PhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.PhotoUpload = new System.Windows.Forms.Button();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.name = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.descInfo = new System.Windows.Forms.Label();
            this.nameInfo = new System.Windows.Forms.Label();
            this.photoInfoBox = new System.Windows.Forms.PictureBox();
            this.descInfoLab = new System.Windows.Forms.Label();
            this.nameInfoLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateInfo = new System.Windows.Forms.Label();
            this.locInfoLab = new System.Windows.Forms.Label();
            this.locInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genderInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.locBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoInfoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(10, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(276, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "EleDB: Add a new Elephant";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(77, 222);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(63, 13);
            this.description.TabIndex = 2;
            this.description.Text = "Description:";
            this.description.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(160, 94);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 3;
            // 
            // descField
            // 
            this.descField.Location = new System.Drawing.Point(160, 222);
            this.descField.Multiline = true;
            this.descField.Name = "descField";
            this.descField.Size = new System.Drawing.Size(198, 98);
            this.descField.TabIndex = 4;
            this.descField.TextChanged += new System.EventHandler(this.DescField_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(547, 351);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(100, 23);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "ADD";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // PhotoDialog
            // 
            this.PhotoDialog.FileName = "Photo";
            // 
            // PhotoUpload
            // 
            this.PhotoUpload.Location = new System.Drawing.Point(536, 298);
            this.PhotoUpload.Name = "PhotoUpload";
            this.PhotoUpload.Size = new System.Drawing.Size(122, 23);
            this.PhotoUpload.TabIndex = 6;
            this.PhotoUpload.Text = "ADD PHOTO";
            this.PhotoUpload.UseVisualStyleBackColor = true;
            this.PhotoUpload.Click += new System.EventHandler(this.PhotoUpload_Click);
            // 
            // PhotoBox
            // 
            this.PhotoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoBox.Location = new System.Drawing.Point(504, 91);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(190, 174);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoBox.TabIndex = 7;
            this.PhotoBox.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(-2, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(802, 442);
            this.tabControl.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.locBox);
            this.tabPage1.Controls.Add(this.genderBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Controls.Add(this.nameField);
            this.tabPage1.Controls.Add(this.PhotoUpload);
            this.tabPage1.Controls.Add(this.PhotoBox);
            this.tabPage1.Controls.Add(this.descField);
            this.tabPage1.Controls.Add(this.description);
            this.tabPage1.Controls.Add(this.Submit);
            this.tabPage1.Controls.Add(this.Title);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(102, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 8;
            this.name.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.genderInfo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.locInfo);
            this.tabPage2.Controls.Add(this.locInfoLab);
            this.tabPage2.Controls.Add(this.dateInfo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.descInfo);
            this.tabPage2.Controls.Add(this.nameInfo);
            this.tabPage2.Controls.Add(this.searchButton);
            this.tabPage2.Controls.Add(this.photoInfoBox);
            this.tabPage2.Controls.Add(this.descInfoLab);
            this.tabPage2.Controls.Add(this.nameInfoLab);
            this.tabPage2.Controls.Add(this.searchText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // descInfo
            // 
            this.descInfo.AutoSize = true;
            this.descInfo.Location = new System.Drawing.Point(151, 262);
            this.descInfo.Name = "descInfo";
            this.descInfo.Size = new System.Drawing.Size(0, 13);
            this.descInfo.TabIndex = 11;
            // 
            // nameInfo
            // 
            this.nameInfo.AutoSize = true;
            this.nameInfo.Location = new System.Drawing.Point(151, 92);
            this.nameInfo.Name = "nameInfo";
            this.nameInfo.Size = new System.Drawing.Size(0, 13);
            this.nameInfo.TabIndex = 10;
            // 
            // photoInfoBox
            // 
            this.photoInfoBox.Location = new System.Drawing.Point(505, 92);
            this.photoInfoBox.Name = "photoInfoBox";
            this.photoInfoBox.Size = new System.Drawing.Size(190, 174);
            this.photoInfoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoInfoBox.TabIndex = 8;
            this.photoInfoBox.TabStop = false;
            // 
            // descInfoLab
            // 
            this.descInfoLab.AutoSize = true;
            this.descInfoLab.Location = new System.Drawing.Point(82, 262);
            this.descInfoLab.Name = "descInfoLab";
            this.descInfoLab.Size = new System.Drawing.Size(63, 13);
            this.descInfoLab.TabIndex = 3;
            this.descInfoLab.Text = "Description:";
            // 
            // nameInfoLab
            // 
            this.nameInfoLab.AutoSize = true;
            this.nameInfoLab.Location = new System.Drawing.Point(107, 92);
            this.nameInfoLab.Name = "nameInfoLab";
            this.nameInfoLab.Size = new System.Drawing.Size(38, 13);
            this.nameInfoLab.TabIndex = 2;
            this.nameInfoLab.Text = "Name:";
            this.nameInfoLab.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date Added:";
            // 
            // dateInfo
            // 
            this.dateInfo.AutoSize = true;
            this.dateInfo.Location = new System.Drawing.Point(151, 220);
            this.dateInfo.Name = "dateInfo";
            this.dateInfo.Size = new System.Drawing.Size(0, 13);
            this.dateInfo.TabIndex = 13;
            // 
            // locInfoLab
            // 
            this.locInfoLab.AutoSize = true;
            this.locInfoLab.Location = new System.Drawing.Point(94, 177);
            this.locInfoLab.Name = "locInfoLab";
            this.locInfoLab.Size = new System.Drawing.Size(51, 13);
            this.locInfoLab.TabIndex = 14;
            this.locInfoLab.Text = "Location:";
            // 
            // locInfo
            // 
            this.locInfo.AutoSize = true;
            this.locInfo.Location = new System.Drawing.Point(151, 177);
            this.locInfo.Name = "locInfo";
            this.locInfo.Size = new System.Drawing.Size(0, 13);
            this.locInfo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender:";
            // 
            // genderInfo
            // 
            this.genderInfo.AutoSize = true;
            this.genderInfo.Location = new System.Drawing.Point(152, 135);
            this.genderInfo.Name = "genderInfo";
            this.genderInfo.Size = new System.Drawing.Size(0, 13);
            this.genderInfo.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "EleDB: Search for an existing Elephant";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(630, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(514, 22);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 20);
            this.searchText.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Location:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "M",
            "F",
            "X"});
            this.genderBox.Location = new System.Drawing.Point(160, 137);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(100, 21);
            this.genderBox.TabIndex = 21;
            // 
            // locBox
            // 
            this.locBox.Location = new System.Drawing.Point(160, 179);
            this.locBox.Name = "locBox";
            this.locBox.Size = new System.Drawing.Size(100, 20);
            this.locBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoInfoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox descField;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.OpenFileDialog PhotoDialog;
        private System.Windows.Forms.Button PhotoUpload;
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox photoInfoBox;
        private System.Windows.Forms.Label descInfoLab;
        private System.Windows.Forms.Label nameInfoLab;
        private System.Windows.Forms.Label descInfo;
        private System.Windows.Forms.Label nameInfo;
        private System.Windows.Forms.Label dateInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label locInfo;
        private System.Windows.Forms.Label locInfoLab;
        private System.Windows.Forms.Label genderInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.TextBox locBox;
    }
}