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
using System.Windows.Shapes;

namespace LoadingControlSystem.View
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
          
        }

        private void ImageViewer1_Loaded(object sender, RoutedEventArgs e)
        {
            string path = System.Environment.CurrentDirectory + "\\110.png";//获取图片绝对路径
            BitmapImage image = new BitmapImage(new Uri(path, UriKind.Absolute));//打开图片
            ImageViewer1.Source = image;
        }
    }
}
