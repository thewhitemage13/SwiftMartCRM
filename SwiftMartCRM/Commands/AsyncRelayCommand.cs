using System.Windows.Input;

namespace SwiftMart.Commands
{

    /// <summary>
    /// Represents a command that can execute an asynchronous operation.
    /// </summary>
    /// <remarks>
    /// This class implements the <see cref="ICommand"/> interface and allows for executing asynchronous
    /// operations in a relay-command pattern, typically used in MVVM applications.
    /// </remarks>
    public class AsyncRelayCommand : ICommand
    {
        private readonly Func<Task> execute;
        private readonly Func<bool> canExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncRelayCommand"/> class.
        /// </summary>
        /// <param name="execute">The asynchronous action to execute when the command is invoked.</param>
        /// <param name="canExecute">A function that determines whether the command can be executed. If null, the command is always executable.</param>
        public AsyncRelayCommand(Func<Task> execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Occurs when the <see cref="CanExecute"/> value changes.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Determines whether the command can execute.
        /// </summary>
        /// <param name="parameter">The data to pass to the command when executed.</param>
        /// <returns>True if the command can execute, otherwise false.</returns>
        public bool CanExecute(object parameter) => canExecute == null || canExecute();

        /// <summary>
        /// Executes the asynchronous operation associated with the command.
        /// </summary>
        /// <param name="parameter">The data to pass to the command when executed.</param>

        public async void Execute(object parameter)
        {
            await execute();
        }

        /// <summary>
        /// Raises the <see cref="CanExecuteChanged"/> event, indicating that the command's executable state has changed.
        /// </summary>
        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    
    }
}
