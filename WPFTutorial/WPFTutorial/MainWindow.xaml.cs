using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Navigation;

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

            // Manipulate referenced textblock's properties
            theLastOfTextBlocks.Text = "Hello from the cs side!";
            theLastOfTextBlocks.Foreground = Brushes.Blue;

            // Add new items from code and add the new textblock to canvas
            Canvas canvas = new Canvas();
            TextBlock textBlockFromCode = new TextBlock();
            textBlockFromCode.Text = "Wow! You just created textblock from code. Nice.";
            textBlockFromCode.TextWrapping = TextWrapping.Wrap;

            // Append new text to the textblock by using Inlines.Add method
            textBlockFromCode.Inlines.Add(" And this is added using Inlines!");

            // Append new text with other formatting
            textBlockFromCode.Inlines.Add(new Bold(new Italic(new Run("\nNew text added using inlines but with cool formatting!")
            {
                FontFamily = new FontFamily("Comic Sans MS"),
                Foreground = (Brush)new BrushConverter().ConvertFromString("#d03753"),
                TextDecorations = TextDecorations.Underline
            })));

            // Add the items to the children collection of the window elements to make them visible
            canvas.Children.Add(textBlockFromCode);
            mainGrid.Children.Add(canvas);

            // position the textblock
            Canvas.SetLeft(textBlockFromCode, 10);
            Canvas.SetTop(textBlockFromCode, 250);
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
