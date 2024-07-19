namespace CalculationServices.Interfaces
{
    public interface ISimpleCalculateService
    {
        /// <summary>
        /// Получение суммы двух чисел
        /// </summary>
        /// <param name="num1">Первое слагаемое</param>
        /// <param name="num2">Второе слагаемое</param>
        /// <returns>Сумма двух слогаемых</returns>
        public int GetSum(int num1, int num2);

        /// <summary>
        /// Получение разности двух чисел
        /// </summary>
        /// <param name="minuendNum">Уменьшаемое число</param>
        /// <param name="subtrahendNum">Вычитаемое число</param>
        /// <returns>Разность двух чисел</returns>
        public int GetDifference(int minuendNum, int subtrahendNum);
    }
}
