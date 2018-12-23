using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQL
{
    public partial class Form1 : Form
    {
        DatabaseToolbox dbToolbox;
        FileStream fs;
        BinaryReader br;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbToolbox = new DatabaseToolbox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            dbToolbox.insertRecord("Elephants", this.nameField.Text, this.descField.Text, ImageToBase64(this.PhotoBox.Image, System.Drawing.Imaging.ImageFormat.Jpeg));
            //dbToolbox.insertRecord("Elephants", "description", this.DescField.Text);
            //dbToolbox.insertImageRecord("Elephants", "Photo", ImageToBase64(this.PhotoBox.Image, System.Drawing.Imaging.ImageFormat.Jpeg));

            //this.PhotoBox.Image = Base64ToImage(dbToolbox.getImage());
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void PhotoUpload_Click(object sender, EventArgs e)
        {
            string filename = "";
            if (this.PhotoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PhotoBox.Image = Image.FromFile(PhotoDialog.FileName.ToString());
                this.PhotoBox.Visible = true;
            }
            MessageBox.Show(filename, "File Content at path: " + filename, MessageBoxButtons.OK);
        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                return Convert.ToBase64String(imageBytes);
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void DescField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
