using System.Windows.Input;

namespace Configurator.ViewModel
{
    public class RelayCommand : ICommand
    {
        private Action execute;
        private Action<object> execute2;
        private Func<bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }
        public RelayCommand(Action<object> execute2, Func<bool> canExecute = null)
        {
            this.execute2 = execute2 ?? throw new ArgumentNullException(nameof(execute2));
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute();
        }

        public void Execute(object parameter)
        {
            execute();
        }
        public void Execute2(object parameter)
        {
            execute2(parameter);
        }

    }
}
