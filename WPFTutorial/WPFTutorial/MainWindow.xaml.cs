using System.Windows;

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

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            /*            if (myTextBlock != null)
                        {
                            myTextBlock.FontSize = mySlider.Value;
                            myTextBlock.Text = "This is the font size: " + mySlider.Value.ToString();
                        }*/
        }
    }
}
