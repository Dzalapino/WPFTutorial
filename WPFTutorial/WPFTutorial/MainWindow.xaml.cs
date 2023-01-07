using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace WPFTutorial
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

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            myImage.Source = new BitmapImage(
                new Uri(@"/WPFTutorial;component/Images/homer_worried.png", UriKind.Relative));
        }
    }
}
