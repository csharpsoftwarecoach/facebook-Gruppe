using System;

namespace Infrastructure.Presentation
{
    public sealed class DelegateCommand : DelegateCommand<object>, IDelegateCommand
    {
        public DelegateCommand(Action<object> executeAction, Predicate<object> canExecute = null)
            : base(executeAction, canExecute) { }

        public DelegateCommand(Action executeAction, Func<bool> canExecute = null)
            : base(executeAction, canExecute) { }
    }

    public class DelegateCommand<T> : IDelegateCommand
    {
        private readonly Action<T> _execute;
        private readonly Predicate<T> _canExecute;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
            => this._canExecute?.Invoke(parameter is T t ? t : default) ?? true;

        public void Execute(object parameter)
            => this._execute(parameter is T t ? t : default);

        public void RaiseCanExecuteChanged()
            => this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);


        public DelegateCommand(Action<T> execute, Predicate<T> canExecute = null)
        {
            this._execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this._canExecute = canExecute;
        }

        protected DelegateCommand(Action execute, Func<bool> canExecute = null)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));

            this._execute = o => execute();

            if (canExecute != null)
                this._canExecute = o => canExecute();
        }
    }
}