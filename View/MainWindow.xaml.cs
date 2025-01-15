using System.Windows;
using System.Windows.Controls;

namespace WPF_TestingApp_DJ
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


        private void ToolBar_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // AdjustFilterTextWidth();
        }

        private void FilterText_TextChanged(object sender, TextChangedEventArgs e)
        {
            // AdjustFilterTextWidth();
        }

        private void AdjustFilterTextWidth()
        {
            double availableWidth = tb.ActualWidth
                                  - dismissButton.Width
                                  - filterText.Margin.Left
                                  - filterText.Margin.Right
                                  - dismissButton.Margin.Left
                                  - dismissButton.Margin.Right
                                  - 50; // Additional padding

            filterText.Width = Math.Max(0, availableWidth);
        }

    }
}