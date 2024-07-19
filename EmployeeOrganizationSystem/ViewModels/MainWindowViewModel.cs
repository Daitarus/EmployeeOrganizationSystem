using CalculationServices.Interfaces;
using EmployeeOrganizationSystem.Comands;
using EmployeeOrganizationSystem.ViewModels.Base;
using System.Windows.Input;

namespace EmployeeOrganizationSystem.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        public ICommand ChangeTypeOperation { get; }

        private int _num1;
        public int Num1
        {
            get { return _num1; }
            set
            {
                Set(ref _num1, value);
                OnPropertyChanged(nameof(ResultNum));
            }
        }

        private int _num2;
        public int Num2
        {
            get { return _num2; }
            set
            {
                Set(ref _num2, value);
                OnPropertyChanged(nameof(ResultNum));
            }
        }

        public int ResultNum
        {
            get
            {
                if(_isSum)
                    return _calculationService.GetSum(_num1, _num2);
                else
                    return _calculationService.GetDifference(_num1, _num2);
            }
        }

        public string ButtonText
        {
            get
            {
                return ChangeButtonOperationSymbol();
            }
        }

        private readonly ISimpleCalculateService _calculationService;

        private bool _isSum = true;

        public MainWindowViewModel(ISimpleCalculateService simpleCalculateService)
        {
            _calculationService = simpleCalculateService;
            ChangeTypeOperation = new LambdaCommand(ExecuteChangeTypeOperation);
        }

        private void ExecuteChangeTypeOperation(object? parametr)
        {
            _isSum = !_isSum;
            OnPropertyChanged(nameof(ButtonText));
            OnPropertyChanged(nameof(ResultNum));
        }

        private string ChangeButtonOperationSymbol()
        {
            if(_isSum)
            {
                return "+";
            }
            else 
            { 
                return "-";
            }
        }
    }
}
