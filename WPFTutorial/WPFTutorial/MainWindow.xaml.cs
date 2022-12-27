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

        private void cbCheese_Unchecked(object sender, RoutedEventArgs e)
        {
            lbCheese.Background = Brushes.White;
        }

        private void cbCheese_Checked(object sender, RoutedEventArgs e)
        {
            lbCheese.Background = Brushes.Gray;
        }

        private void cbParent_Changed(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbParent.IsChecked == true);
            cbCheese.IsChecked = newVal;
            cbTuna.IsChecked = newVal;
            cbHam.IsChecked = newVal;
            cbPepperoni.IsChecked = newVal;
        }
        private void cbToppings_Changed(object sender, RoutedEventArgs e)
        {
            cbParent.IsChecked = null;
            if (cbCheese.IsChecked == true && cbTuna.IsChecked == true && cbHam.IsChecked == true && cbPepperoni.IsChecked == true)
            {
                cbParent.IsChecked = true;
            }
            if (cbCheese.IsChecked == false && cbTuna.IsChecked == false && cbHam.IsChecked == false && cbPepperoni.IsChecked == false)
            {
                cbParent.IsChecked = false;
            }
        }
    }
}
