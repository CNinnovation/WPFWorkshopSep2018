using System;
using System.Windows.Input;

namespace TheBestMVVMFrameworkInTown.Commands
{
    public class DelegateCommand : ICommand
    {
        private Action _action;
        private Func<bool> _canExecute;

        public DelegateCommand(Action action, Func<bool> canExecute)
        {
            _action = action ?? throw new ArgumentNullException(nameof(action));
            _canExecute = canExecute;
        }

        public DelegateCommand(Action action)
            : this(action, null) { }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => _canExecute?.Invoke() ?? true;
        public void Execute(object parameter) => _action();
    }
}
