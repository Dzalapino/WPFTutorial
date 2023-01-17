using System;
using System.Windows;
using System.Windows.Controls;

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
            myCalendar.SelectedDate = DateTime.Now;
        }

        private void myCalendar_SelectedDatesChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (myTextBlock != null)
            {
                myTextBlock.Text = myCalendar.SelectedDate.ToString();
            }
        }

        private void myDatePicker_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            MessageBox.Show("Date has been changed to " + (sender as DatePicker).SelectedDate ?? "null");
        }
    }
}
