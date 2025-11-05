namespace Calculator;

public class CalculationService
{
    public int Calculate(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        int result = 0;
        
        foreach (var num in numbers)
        { 
            result += int.Parse(num.ToString());
        }
        
        return result;
    }
}