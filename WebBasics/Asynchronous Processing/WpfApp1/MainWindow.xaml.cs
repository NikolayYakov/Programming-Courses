using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowImage(image1, "https://http.cat/100");
            ShowImage(image2, "https://http.cat/101");
            ShowImage(image3, "https://http.cat/102");
            ShowImage(image4, "https://http.cat/200");
            ShowImage(image5, "https://http.cat/201");
            ShowImage(image6, "https://http.cat/202");
            

        }

        private void ShowImage(Image image, string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var result = httpClient.GetAsync(url).GetAwaiter().GetResult();
                byte[] imageBytes = result.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
                image.Source = LoadImage(imageBytes);
            }
           
        }
        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}
