using System;
using System.Windows;
using System.Windows.Media;

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

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            var rnd = new Random();
            myLabel.Foreground = new SolidColorBrush(Color.FromArgb(255, (byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256)));
            ++myLabel.FontSize;
        }

        private void MyButton_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            myLabel.Foreground = Brushes.Black;
            --myLabel.FontSize;
        }

        private void MyButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            myButton.BorderThickness = new Thickness(4, 4, 4, 4);
        }

        private void MyButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            myButton.BorderThickness = new Thickness(2, 2, 2, 2);
        }
    }
}
