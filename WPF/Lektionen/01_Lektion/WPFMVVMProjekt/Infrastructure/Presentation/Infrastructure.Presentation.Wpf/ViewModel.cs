using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Infrastructure.Presentation
{
    public class ViewModel : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        public virtual void NotifyPropertyChanging([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }

        public virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
