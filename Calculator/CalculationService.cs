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
        var numbersArray = numbers.Split(',');
        
        foreach (var num in numbersArray)
        { 
            result += int.Parse(num);
        }
        
        return result;
    }
}