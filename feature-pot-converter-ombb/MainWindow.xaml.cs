using System.Windows;

namespace feature_pot_converter_ombb
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = FeaturePotConverter.ConvertFeaturePots(Reel1.Text, Reel2.Text, Reel3.Text, Reel4.Text, Reel5.Text, Reel6.Text, 5).ToString();
        }
    }
}
