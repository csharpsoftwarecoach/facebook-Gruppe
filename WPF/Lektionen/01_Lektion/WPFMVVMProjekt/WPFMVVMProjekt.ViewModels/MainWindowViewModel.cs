using Infrastructure.Presentation;

namespace WPFMVVMProjekt.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public IDelegateCommand StartCommand { get; set; }

        public MainWindowViewModel()
        {
            StartCommand = new DelegateCommand(StartCommandCallback);
        }

        private void StartCommandCallback(object obj)
        {
            Name = "Anton";
        }
    }
}
