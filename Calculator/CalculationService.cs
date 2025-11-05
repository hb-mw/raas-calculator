namespace Calculator;

public class CalculationService
{
    public int Calculate(string numbers)
    {
        string spliters = ",";
        
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        if (numbers.Contains("|"))
        {
            spliters += '|';
        }
        
        int result = 0;
        var numbersArray = Splitter(numbers,spliters);
        
        foreach (var num in numbersArray)
        { 
            result += int.Parse(num);
        }
        
        return result;
    }

    /// <summary>
    /// This will Take a splitters array and return the string as only numbers.
    /// </summary>
    /// <param name="input">The numbers input to split</param>
    /// <param name="splitters"></param>
    /// <returns>A string represents only number with no splitters</returns>
    private List<string> Splitter(string input,string splitters)
    {
        List<string> result = [];
        for (int i = 0; i < input.Length; i++)
        {
            if (splitters.Contains(input[i]))
            {
                continue;
            }
            
            result.Add(input[i].ToString());
        }
        
        return result;
    }
}