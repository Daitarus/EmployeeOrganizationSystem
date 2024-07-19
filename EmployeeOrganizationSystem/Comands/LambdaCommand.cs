using EmployeeOrganizationSystem.Comands.Base;

namespace EmployeeOrganizationSystem.Comands
{
    internal class LambdaCommand : Command
    {
        private readonly Action<object?> _executeAction;
        private readonly Func<object?, bool>? _canExecuteFunc;

        public LambdaCommand(Action<object?> executeAction, Func<object?, bool>? canExecuteFunc = null)
        {
            if (executeAction == null)
                throw new ArgumentNullException(nameof(executeAction));

            _executeAction = executeAction;
            _canExecuteFunc = canExecuteFunc;
        }

        public override bool CanExecute(object? parameter) => _canExecuteFunc?.Invoke(parameter) ?? true;

        public override void Execute(object? parameter) => _executeAction(parameter);
    }
}
