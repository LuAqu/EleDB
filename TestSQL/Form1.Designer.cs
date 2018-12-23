namespace TestSQL
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInfo = new System.Windows.Forms.Label();
            this.descInfo = new System.Windows.Forms.Label();
            this.photoInfoBox = new System.Windows.Forms.PictureBox();
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
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(343, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(97, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Elephant";
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
            this.description.Location = new System.Drawing.Point(77, 141);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(60, 13);
            this.description.TabIndex = 2;
            this.description.Text = "Description";
            this.description.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(160, 91);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 3;
            // 
            // descField
            // 
            this.descField.Location = new System.Drawing.Point(160, 138);
            this.descField.Name = "descField";
            this.descField.Size = new System.Drawing.Size(100, 20);
            this.descField.TabIndex = 4;
            this.descField.TextChanged += new System.EventHandler(this.DescField_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(160, 249);
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
            this.PhotoUpload.Location = new System.Drawing.Point(534, 249);
            this.PhotoUpload.Name = "PhotoUpload";
            this.PhotoUpload.Size = new System.Drawing.Size(122, 23);
            this.PhotoUpload.TabIndex = 6;
            this.PhotoUpload.Text = "ADD PHOTO";
            this.PhotoUpload.UseVisualStyleBackColor = true;
            this.PhotoUpload.Click += new System.EventHandler(this.PhotoUpload_Click);
            // 
            // PhotoBox
            // 
            this.PhotoBox.Location = new System.Drawing.Point(500, 49);
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
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.photoInfoBox);
            this.tabPage2.Controls.Add(this.descInfo);
            this.tabPage2.Controls.Add(this.nameInfo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(102, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 8;
            this.name.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // nameInfo
            // 
            this.nameInfo.AutoSize = true;
            this.nameInfo.Location = new System.Drawing.Point(118, 159);
            this.nameInfo.Name = "nameInfo";
            this.nameInfo.Size = new System.Drawing.Size(38, 13);
            this.nameInfo.TabIndex = 2;
            this.nameInfo.Text = "Name:";
            this.nameInfo.Click += new System.EventHandler(this.label3_Click);
            // 
            // descInfo
            // 
            this.descInfo.AutoSize = true;
            this.descInfo.Location = new System.Drawing.Point(93, 199);
            this.descInfo.Name = "descInfo";
            this.descInfo.Size = new System.Drawing.Size(63, 13);
            this.descInfo.TabIndex = 3;
            this.descInfo.Text = "Description:";
            // 
            // photoInfoBox
            // 
            this.photoInfoBox.Location = new System.Drawing.Point(514, 136);
            this.photoInfoBox.Name = "photoInfoBox";
            this.photoInfoBox.Size = new System.Drawing.Size(190, 174);
            this.photoInfoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoInfoBox.TabIndex = 8;
            this.photoInfoBox.TabStop = false;
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
        private System.Windows.Forms.Label descInfo;
        private System.Windows.Forms.Label nameInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}