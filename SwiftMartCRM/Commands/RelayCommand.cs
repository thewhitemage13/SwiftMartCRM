using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SwiftMart.Commands
{

    /// <summary>
    /// Represents a command that can execute an action and has a condition to check whether it can be executed.
    /// </summary>
    /// <remarks>
    /// This class implements the <see cref="ICommand"/> interface and is commonly used in the MVVM (Model-View-ViewModel) pattern 
    /// to decouple the UI from the logic.
    /// </remarks>
    public class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">The action to execute when the command is invoked.</param>
        /// <param name="canExecute">A function to check if the command can execute. If null, the command is always executable.</param>

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Determines whether the command can execute.
        /// </summary>
        /// <param name="parameter">The data to pass to the command when executed.</param>
        /// <returns>True if the command can execute, otherwise false.</returns>

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        /// <summary>
        /// Executes the action associated with the command.
        /// </summary>
        /// <param name="parameter">The data to pass to the command when executed.</param>
        public void Execute(object parameter)
        {
            execute(parameter);
        }

        /// <summary>
        /// Occurs when the <see cref="CanExecute"/> value changes.
        /// </summary>
        /// <remarks>
        /// This event is used to notify the UI (or command manager) that the executable state of the command has changed.
        /// </remarks>

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
