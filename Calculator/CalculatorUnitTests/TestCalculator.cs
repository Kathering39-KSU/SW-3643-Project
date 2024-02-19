using Calculator;
namespace CalculatorUnitTests;

public class TestCalculator
{
    [Test]
    public void Test_CalculatorAdd_ReturnsCorrect()
    {
        //arrange
        var inputA = 7;
        var inputB = 4;
        var mathFunction = 1;
        var expected = 11;
        
        //act
        var actual = Calculator.CalculatorEngine.CalculateWebInputs(inputA,inputB,mathFunction);

        //assert
        Assert.AreEqual(expected,actual);
    }
}