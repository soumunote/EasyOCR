using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EasyOCR
{
    /// <summary>
    /// Interaction logic for ProgressWindow.xaml
    /// </summary>
    public partial class ProgressWindow : Window
    {
        string TargetFolderName { get; set; }
        string ResultFileName { get; set; }

        public ProgressWindow(string targetFolderName, string resultFileName)
        {
            InitializeComponent();

            TargetFolderName = targetFolderName;
            ResultFileName = resultFileName;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            doScan(TargetFolderName, ResultFileName);
        }

        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void doScan(string targetFolderName, string resultFileName)
        {
            var bitmapConverter = new Tesseract.BitmapToPixConverter();
            var tesseract = new Tesseract.TesseractEngine(@"C:\Program Files (x86)\Tesseract-OCR\tessdata", "jpn", @"digits");
            //tesseract.SetVariable("tessedit_char_whitelist", "0123456789");
            tesseract.DefaultPageSegMode = Tesseract.PageSegMode.SingleChar;
            MessageBox.Show(tesseract.Version);
            var fileNames = Directory.GetFiles(targetFolderName, "*.jpg");
            Array.ForEach(fileNames, fileName => {
                var originalBitmap = new System.Drawing.Bitmap(fileName);
                //MessageBox.Show($"{ originalBitmap.Width }*{ originalBitmap.Height }");
                var targetRect = new System.Drawing.Rectangle(2980, 140, 3700 - 2980, 330 - 140);
///                var targetRect = new System.Drawing.Rectangle(1500, 75, 1875 - 1500, 170 - 75);
                var targetBitmap = originalBitmap.Clone(targetRect, System.Drawing.Imaging.PixelFormat.DontCare);
                using (var page = tesseract.Process(bitmapConverter.Convert(targetBitmap)))
                {
                    MessageBox.Show(page.GetText());
                }

                var targetRect2 = new System.Drawing.Rectangle(1390, 1370, 2390 - 1390, 1530 - 1370);
///                var targetRect2 = new System.Drawing.Rectangle(720, 690, 1230 - 720, 800 - 690);
                var targetBitmap2 = originalBitmap.Clone(targetRect2, System.Drawing.Imaging.PixelFormat.DontCare);
                using (var page = tesseract.Process(bitmapConverter.Convert(targetBitmap2)))
                {
                    MessageBox.Show(page.GetText());
                }

            });
        }
    }
}
