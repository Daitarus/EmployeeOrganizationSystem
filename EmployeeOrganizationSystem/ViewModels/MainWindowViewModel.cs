using CalculationServices.Interfaces;
using EmployeeOrganizationSystem.ViewModels.Base;

namespace EmployeeOrganizationSystem.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private int _num1;
        public int Num1
        {
            get { return _num1; }
            set
            {
                _num1 = value;
                OnPropertyChanged(nameof(Num1));
                OnPropertyChanged(nameof(ResultNum));
            }
        }

        private int _num2;
        public int Num2
        {
            get { return _num2; }
            set
            {
                _num2 = value;
                OnPropertyChanged(nameof(Num2));
                OnPropertyChanged(nameof(ResultNum));
            }
        }

        public int ResultNum
        {
            get
            {
                return _calculationService.GetSum(_num1, _num2);
            }
        }

        private ISimpleCalculateService _calculationService;

        public MainWindowViewModel(ISimpleCalculateService simpleCalculateService)
        {
            _calculationService = simpleCalculateService;
        }
    }
}
