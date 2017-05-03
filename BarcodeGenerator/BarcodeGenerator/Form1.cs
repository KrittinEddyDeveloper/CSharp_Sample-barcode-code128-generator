using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace BarcodeGenerator
{
    public partial class Form1 : Form
    {
        private string barcodeDirectory = System.IO.Directory.GetCurrentDirectory() + @"\" + "temp_barcode.jpg";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtText.Text.Trim()))
            {
                MessageBox.Show(@"Please fill text for generate barcode!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var barcode = new Bitmap(GenerateBarcode(txtText.Text.Trim()));
                barcode.Save(barcodeDirectory,ImageFormat.Png);

                pbBarcode.ImageLocation = barcodeDirectory;
                lblBarcode.Text = txtText.Text.Trim();
                txtText.Text = string.Empty;

            }
        }

        private Image GenerateBarcode(string text)
        {
            try
            {
                using (MemoryStream mStream = new MemoryStream())
                {
                    BarcodeSymbology _symbology = BarcodeSymbology.Code128;
                    Image image = BarcodeDrawFactory.GetSymbology(_symbology).Draw(text, maxBarHeight: 70);
                    image.Save(mStream, ImageFormat.Jpeg);
                    return image;
                }
            }
            catch (Exception exception)
            {
                return null;
            }
        }

    }
}
