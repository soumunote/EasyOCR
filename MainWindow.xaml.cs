using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EasyOCR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdYes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly().Location);

            var resultFileName = System.IO.Path.Combine(this.imageFolderName.Text, "scanResult.txt");
            var wnd = new ProgressWindow(this.imageFolderName.Text, resultFileName);
            wnd.Owner = this;
            wnd.ShowDialog();
        }

        private void cmdClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
