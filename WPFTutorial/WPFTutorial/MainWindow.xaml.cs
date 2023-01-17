using System;
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
            myCalendar.SelectedDate = DateTime.Now;
        }

        private void myCalendar_SelectedDatesChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (myTextBlock != null)
            {
                myTextBlock.Text = myCalendar.SelectedDate.ToString();
            }
        }
    }
}
