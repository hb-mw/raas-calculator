using System.Runtime.InteropServices;

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
        
        if (numbers.StartsWith("//"))
        {
            spliters = numbers[2].ToString();
            var nums =  numbers.Split($"//{spliters}\n");
            numbers = nums[1];
        }
        
        int result = 0;
        var numbersArray = Splitter(numbers,spliters);

        var currentindex = 0;
        
        Dictionary<string,int> invalidInputs = [];
        
        foreach (var num in numbersArray)
        { 
            if (int.TryParse(num, out var numricresult))
            {
                invalidInputs[num]= currentindex;
                continue;
            }

            if (invalidInputs.Any())
            {
                var index = invalidInputs.First();
                throw new Exception($"Invalid input,{index.Key}:{index.Value}");
            }
            result += numricresult;
            currentindex++;
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

            var value = input[i].ToString();
            

            
            result.Add(input[i].ToString());
        }
        
        return result;
    }
}