using System.Windows;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;

namespace DeckApp.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = App.Current.Services.GetService<MainViewModel>();
        }

        private void OnAddWorkspaceButtonClicked(object sender, RoutedEventArgs e)
        {
            MainViewModel viewmodel = (MainViewModel)DataContext;
            viewmodel?.Add();
        }
    }
}
