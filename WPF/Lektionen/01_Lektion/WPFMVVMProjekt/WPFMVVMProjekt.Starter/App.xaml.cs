using System.Windows;
using WPFMVVMProjekt.Views;

namespace WPFMVVMProjekt
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainView = new MainWindowView();
            mainView.ShowDialog();
        }
    }
}
