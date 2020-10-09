using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Infrastructure.Presentation
{
    public interface IViewModel : INotifyPropertyChanging, INotifyPropertyChanged
    {
        void NotifyPropertyChanging([CallerMemberName] string propertyName = null);
        void NotifyPropertyChanged([CallerMemberName] string propertyName = null);
    }
}
