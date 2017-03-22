using HostSideViews;
using System;
using System.AddIn.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HostWpfApplication
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private AutomationHost mhost;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            string path = Environment.CurrentDirectory;
            string[] warnings = AddInStore.Update(path);
            foreach(string warning in warnings)
            {
                Console.WriteLine(warning);
            }
            IList<AddInToken> tokens = AddInStore.FindAddIns(typeof(ImageProcessorHostView), path);
            lstAddIns.ItemsSource = tokens;
            mhost = new AutomationHost(this.mProgress);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BitmapSource source = (BitmapSource)(pic.Source);
            int stride = source.PixelWidth * source.Format.BitsPerPixel / 8;
            stride = stride + (stride % 4) * 4;
            int arraySize = stride * source.PixelHeight * source.Format.BitsPerPixel / 8;
            byte[] originalPixels = new byte[arraySize];
            source.CopyPixels(originalPixels, stride, 0);

            AddInToken token = (AddInToken)lstAddIns.SelectedItem;
            if(token==null)
            {
                return;
            }
            HostSideViews.ImageProcessorHostView addin = token.Activate<HostSideViews.ImageProcessorHostView>(AddInSecurityLevel.Internet);
            
            byte[] changedPixels = addin.ProcessImageBytes(originalPixels);

            BitmapSource newSource = BitmapSource.Create(source.PixelWidth, source.PixelHeight, source.DpiX, source.DpiY, source.Format, source.Palette, changedPixels, stride);

            pic.Source = newSource;
        }
    }
}
