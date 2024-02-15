using Calculator;
namespace CalculatorUnitTests;

public class TestCalculator
{
    [Test]
    public void Test_CalculatorAdd_ReturnsCorrect()
    {
        //arrange
        int inputA = 7;
        int inputB = 4;
        int mathFunction = 1;
        double expected = 11;
        
        //act
        double actual = Calculator.CalculatorEngine.CalculateWebInputs(inputA,inputB,mathFunction);

        //assert
        Assert.AreEqual(expected,actual);
    }
}