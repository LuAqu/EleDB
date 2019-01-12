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
using System.Text.RegularExpressions;
using System.Collections;

namespace EleDB
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

            ArrayList types = dbToolbox.retrieveTypes();
            foreach (var val in types)
            {
                this.typeField.Items.Add(val);
                this.typeEditField.Items.Add(val);
            }

            this.numberInfo.Text = dbToolbox.getCount().ToString();
        }
            

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String name = this.nameField.Text;
            String desc = this.descField.Text;
            String photo = ImageToBase64(this.PhotoBox.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
            String alternate_photo = ImageToBase64(this.photoBox2.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
            String price = this.priceField.Text;
            String source = this.sourceField.Text;
            String type = this.typeField.Text;
            String origin = this.originField.Text;
            String acquisition = this.acquisitionField.Text;
            String dimensions = this.dimensionField1.Text + "x" + this.dimensionField2.Text + "x" + this.dimensionField3.Text;
            String location = this.locField.Text;

            dbToolbox.insertRecord("Elephants", name, desc, photo, alternate_photo, price, source, type, origin, acquisition, dimensions, location);
            MessageBox.Show(name + " has been added to the collection!", "SUCCESS", MessageBoxButtons.OK);

            int next = Int32.Parse(this.numberInfo.Text) + 1;
            this.numberInfo.Text = next.ToString();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void PhotoUpload_Click(object sender, EventArgs e)
        {
            if (this.PhotoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PhotoBox.Image = Image.FromFile(PhotoDialog.FileName.ToString());
                this.PhotoBox.Visible = true;
            }
        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                if (image != null) {
                    image.Save(ms, format);
                    byte[] imageBytes = ms.ToArray();

                    // Convert byte[] to Base64 String
                    return Convert.ToBase64String(imageBytes);
                }
                return null;
            }
        }

        public Image Base64ToImage(string base64String)
        {
            if (!base64String.Equals(""))
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
            return null;
        }

        public string ImageToBase64Alt(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                Bitmap bitMap = new Bitmap(image);

                Image newImage = bitMap;
                if (newImage != null)
                {
                    newImage.Save(ms, format);
                    byte[] imageBytes = ms.ToArray();

                    // Convert byte[] to Base64 String
                    return Convert.ToBase64String(imageBytes);
                }
                return null;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            Elephant elephant = dbToolbox.retrieveRecords(this.searchText.Text);

            this.idEditField.Text = elephant.Id;
            this.nameEditField.Text = elephant.Name;
            this.descEditField.Text = elephant.Description;
            this.photoEditBox1.Image = Base64ToImage(elephant.Photo);
            this.photoEditBox2.Image = Base64ToImage(elephant.AlternatePhoto);
            this.priceEditField.Text = elephant.Price;
            this.sourceEditField.Text = elephant.Source;
            this.typeEditField.SelectedIndex = get_combobox_index(this.typeEditField, elephant.Type);
            this.originEditField.Text = elephant.Origin;
            this.methodEditField.SelectedIndex = get_combobox_index(this.methodEditField, elephant.Acquisition);
            string[] dimensions = elephant.Dimensions.Split('x');
            this.tabPage2.Text = dimensions[0];
            this.dimensionEditField2.Text = dimensions[1];
            this.dimensionEditField3.Text = dimensions[2];
            this.locationEditField.Text = elephant.Location;
        }

        private int get_combobox_index(ComboBox combobox, String item)
        {
            int i = 0;
            var lst = combobox.Items.Cast<String>();
            foreach (var s in lst)
            {
                if (s.Equals(item))
                    return i;

                i++;
            }
            return 0;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void originLab_Click(object sender, EventArgs e)
        {

        }

        private void locBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void originInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void newTypeButton_Click(object sender, EventArgs e)
        {
            String type = this.newTypeField.Text;

            dbToolbox.insertTypeRecord(type);
            MessageBox.Show("SUCCESS", name + " has been added to the type list!", MessageBoxButtons.OK);
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void PhotoUpload2_Click(object sender, EventArgs e)
        {
            if (this.PhotoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.photoBox2.Image = Image.FromFile(PhotoDialog.FileName.ToString());
                this.photoBox2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String id = this.idEditField.Text;
            String name = this.nameEditField.Text;
            String desc = this.descEditField.Text;
            String photo = ImageToBase64Alt(this.photoEditBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
            String alternate_photo = ImageToBase64Alt(this.photoEditBox2.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
            String price = this.priceEditField.Text;
            String source = this.sourceEditField.Text;
            String type = this.typeEditField.Text;
            String origin = this.originEditField.Text;
            String acquisition = this.methodEditField.Text;
            String dimensions = this.tabPage2.Text + " x " + this.dimensionEditField2.Text + " x " + this.dimensionEditField3.Text;
            String location = this.locationEditField.Text;

            dbToolbox.updateRecord("Elephants", id, name, desc, photo, alternate_photo, price, source, type, origin, acquisition, dimensions, location);
            MessageBox.Show(name + " has been modified!", "SUCCESS", MessageBoxButtons.OK);
        }

        private void editPhotoButton1_Click(object sender, EventArgs e)
        {
            if (this.PhotoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.photoEditBox1.Image = Image.FromFile(PhotoDialog.FileName.ToString());
                this.photoEditBox1.Visible = true;
            }
        }

        private void editPhotoButton2_Click(object sender, EventArgs e)
        {
            if (this.PhotoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.photoEditBox2.Image = Image.FromFile(PhotoDialog.FileName.ToString());
                this.photoEditBox2.Visible = true;
            }
        }
    }
}
