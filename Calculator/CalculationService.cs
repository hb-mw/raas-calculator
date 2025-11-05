namespace Calculator;

public class CalculationService
{
    public int Calculate(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }
        return int.Parse(numbers);
    }
}