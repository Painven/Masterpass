using MasterpassDesktop.ViewModels;
using System.Windows;

namespace MasterpassDesktop;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        var vm = new MainWindowViewModel();
        var mainWindow = new MainWindow();
        mainWindow.DataContext = vm;
        mainWindow.Show();
    }
}
