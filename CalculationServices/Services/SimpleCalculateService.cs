using CalculationServices.Interfaces;

namespace CalculationServices.Services
{
    public class SimpleCalculateService : ISimpleCalculateService
    {
        public int GetSum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int GetDifference(int minuendNum, int subtrahendNum)
        {
            return minuendNum - subtrahendNum;
        }
    }
}
