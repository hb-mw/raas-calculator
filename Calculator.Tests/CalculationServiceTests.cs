using System.Collections;

namespace Calculator.Tests;

public class Tests
{
    private CalculationService _service;
    [SetUp]
    public void Setup()
    {
        _service = new CalculationService();
    }

    [Test]
    public void CaluclationOfEmptyStringReturnsZero()
    {
        var result = _service.Calculate("");
        
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void CaluclationOfSingleStringReturnsOne()
    {
        var result = _service.Calculate("1");
        
        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void CaluclationOfZeroValueStringReturnsZero()
    {
        var result = _service.Calculate("0");
        
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void CaluclationOfNullStringReturnsZero()
    {
        var result = _service.Calculate(null!);
        
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    [TestCase("1,2",3)]
    [TestCase("0,0",0)]
    [TestCase("5,5",10)]
    public void CaluclationOf2StringReturnsSum(string input, int expectedResult)
    {
        var result = _service.Calculate(input);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void CalcualtionOfStringsWithCommaShouldReturnValidResult()
    {
        var result = _service.Calculate("1,2");
        
        Assert.That(result, Is.EqualTo(3));
    }
    
    [Test]
    [TestCase("1,1,1,1,1,1,1,1,1,1",10)]
    [TestCase("2,2,2,2,2,2,2,2,2,2",20)]
    public void CaluclationOfLongInputStringReturnsSum(string input, int expectedResult)
    {
        var result = _service.Calculate(input);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void CaclualtionOfStringWithStickSperatorAndCommaShouldReturnSum()
    {
        var result = _service.Calculate("1,|2");
        
        Assert.That(result, Is.EqualTo(3));
    }
}