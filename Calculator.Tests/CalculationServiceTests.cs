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
    public void CaluclationOfNullStringReturnsZero()
    {
        var result = _service.Calculate(null!);
        
        Assert.That(result, Is.EqualTo(0));
    }
    
}