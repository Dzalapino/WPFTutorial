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

        private void rbKorwin_Checked(object sender, RoutedEventArgs e)
        {
            lbResult.Content = "Nice one, someone is smart :---)))";
            lbResult.Foreground = Brushes.LightGreen;
        }

        private void rbMemtzen_Checked(object sender, RoutedEventArgs e)
        {
            lbResult.Content = "Nice one, someone is smart :---)))";
            lbResult.Foreground = Brushes.LightGreen;
        }

        private void rbDuda_Checked(object sender, RoutedEventArgs e)
        {
            lbResult.Content = "Maybe think a little bit longer pal....";
            lbResult.Foreground = Brushes.IndianRed;
        }

        private void rbTusk_Checked(object sender, RoutedEventArgs e)
        {
            lbResult.Content = "Maybe think a little bit longer pal....";
            lbResult.Foreground = Brushes.IndianRed;
        }

        private void rbZananberg_Checked(object sender, RoutedEventArgs e)
        {
            lbResult.Content = "Maybe think a little bit longer pal....";
            lbResult.Foreground = Brushes.IndianRed;
        }
    }
}
