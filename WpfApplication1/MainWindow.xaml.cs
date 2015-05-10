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
using System.Net.Http;
using System.IO;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:8000");
            //HttpResponseMessage message = client.GetAsync("OK").Result;

            try
            {
                //message.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
                //Stream result = message.Content.ReadAsStreamAsync().Result;
                image.Source = new BitmapImage(new Uri("http://localhost:10941/api/values/a"));

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
