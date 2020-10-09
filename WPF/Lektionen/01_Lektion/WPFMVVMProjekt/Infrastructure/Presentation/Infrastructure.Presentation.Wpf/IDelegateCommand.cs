using System.Windows.Input;

namespace Infrastructure.Presentation
{
    public interface IDelegateCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}
