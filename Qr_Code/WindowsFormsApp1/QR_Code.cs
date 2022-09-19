using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace WindowsFormsApp1
{
    public partial class QR_Code : Form
    {
        public QR_Code()
        {
            InitializeComponent();
        }

        private void image1_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            BarcodeWriter qrcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions()
            {
                Width = 450,
                Height = 150,
                Margin = 0,
                PureBarcode = false,
                GS1Format = true
            };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            qrcodeWriter.Renderer = new BitmapRenderer();
            qrcodeWriter.Format = BarcodeFormat.DATA_MATRIX;
            qrcodeWriter.Options = encodingOptions;
            Bitmap bitmap = qrcodeWriter.Write(textData.Text);
            Graphics g = Graphics.FromImage(bitmap);
            image1.Image = bitmap;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (image1.Image == null)
                return;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Png |*. png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    image1.Image.Save(saveFileDialog.FileName);
            }
        }
        
    }
}
