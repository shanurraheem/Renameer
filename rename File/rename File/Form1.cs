using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODI;

namespace rename_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static FolderBrowserDialog output = new FolderBrowserDialog();
        private static FileDialog imageToProcess = new OpenFileDialog();


        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            DialogResult op = output.ShowDialog();
            if (op == DialogResult.OK)
            {
                
                txtOutputPath.Text = Path.GetFileName(output.SelectedPath);
                groupBox1.Enabled = true;
            }
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            DialogResult ip = imageToProcess.ShowDialog();
            if (ip == DialogResult.OK)
            {
                txtInputPath.Text = Path.GetFileName(imageToProcess.FileName);
            }
        }



        private void btnShow_Click(object sender, EventArgs e)
        {
            if (imageToProcess.FileName.ToString() != string.Empty)
            {

                Bitmap image = new Bitmap(imageToProcess.FileName.ToString());
                PicBox.Image = image;
                PicBox.SizeMode = PictureBoxSizeMode.Zoom;
                
            }
            else
            {
                MessageBox.Show("Please Select a File First!...", "Error!");
            }
        }


        private string ExtractTextFromImage(string filePath)
        {
            Document modiDocument = new Document();
            modiDocument.Create(filePath);
            modiDocument.OCR(MiLANGUAGES.miLANG_ENGLISH);
            MODI.Image modiImage = (modiDocument.Images[0] as MODI.Image);
            string extractedText = modiImage.Layout.Text;
            modiDocument.Close();
            return extractedText;
        }



        private void btnTextGet_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(imageToProcess.FileName.ToString());
            string path = imageToProcess.FileName.ToString();
            string text = ExtractTextFromImage(path);

            string rawIntegers = string.Empty;
            //rawIntegers = Regex.Match(text, @"\d+").ToString();
            txtget.Text = string.Empty;
            txtget.Text = text;
            
        }
    }
}
