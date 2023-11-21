using System.Windows;

namespace Morpion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Déplacé dans App.xaml.cs :
            //
            // DataContext = new MainViewModel();
        }
    }
}
