
using CalculatorEngine;

namespace CalculatorUnitTests;

public class TestCalculator
{
    [Test]
    /*public void Test_CalculatorAdd_ReturnsCorrect()
     {
         //arrange
         double inputA = 7;
         int inputB = 4;
         int mathFunction = 1;
         double expected = 11;

         //act
         var actual = Calculator.CalculatorEngine.CalculateWebInputs(inputA,inputB,mathFunction);

         //assert
         Assert.AreEqual(expected,actual);
     }
     */
    public void Test_CalculatorAdd_ReturnsCorrect()
    {
        //arrange
        double inputA = 7;
        var    inputB = 4;
        double expected = 11;
        //act
        var actual = CalculatorEngine.CalculatorEngine.CalculateSum(inputA, inputB);
        //assert
        Assert.AreEqual(expected,actual);


    }
    [Test]
    public void Test_CalculatorDifference_ReturnsCorrect()
    {
        //arrange
        double inputA = 20;
        var    inputB = 10;
        double expected = 10;
        //act
        var actual = CalculatorEngine.CalculatorEngine.CalculateDifference(inputA, inputB);
        //assert
        Assert.AreEqual(expected,actual);
    }
    [Test]
    public void Test_CalculatorProduct_ReturnsCorrect()
    {
        //arrange
        double inputA = 10;
        var    inputB = 10;
        double expected = 100;
        //act
        var actual = CalculatorEngine.CalculatorEngine.CalculateProduct(inputA, inputB);
        //assert
        Assert.AreEqual(expected,actual);
    }
    [Test]
    public void Test_CalculatorDivide_ReturnsCorrect()
    {
        //arrange
        double inputA = 100;
        var    inputB = 10;
        double expected = 10;
        //act
        var actual = CalculatorEngine.CalculatorEngine.CalculateDivision(inputA, inputB);
        //assert
        Assert.AreEqual(expected,actual);
    }
    [Test]
    public void Test_CalculatorDivideByZero_ReturnsCorrect()//unfinished not sure about error
    {
        //arrange
        double inputA = 10;
        var    inputB = 0;
        double expected = 100;
        //act
        var actual = CalculatorEngine.CalculatorEngine.CalculateProduct(inputA, inputB);
        //assert
        Assert.That(true,"Dividing by zero is null",actual);
    }


    
}