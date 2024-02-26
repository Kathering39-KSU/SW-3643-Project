using System.Diagnostics;
using CalculatorEngine;

namespace CalculatorEngine;
public class CalculatorEngine
{
    /*public static var CalculateWebInputs(double inputA,double inputB, int mathFunction)
    {
        double functionResult = 1.0;
        switch (mathFunction)
        {
            case 1:
                functionResult = (inputA + inputB);
                break;
            case 2:
                functionResult = (inputA - inputB);
                break;
            case 3:
                functionResult = (inputA * inputB);
                break;
            case 4:
                functionResult = (inputA / inputB);
                break;
            case 5:
                functionResult= (inputA.CompareTo(inputB));
                break;
            case 6:
                functionResult = Math.Pow(inputA, inputB);
                break;
            case 7:
                functionResult = Math.Log(inputA, inputB);
                break;
            case 8:
                functionResult = Math.Pow(inputA, (1/inputB));
                break;
            case 9:
                while (inputA !=0)
                {
                    functionResult = functionResult * inputA;
                    inputA--;
                }
                break;
            case 10:
                functionResult = Math.Asin((double)inputA);
                break;
            case 11:
                functionResult = Math.Acos((double)inputA);
                break;
            case 12:
                functionResult = Math.Atan((double)inputA);
                break;
            case 13:
                functionResult = (1 / (double)inputA);
                break;
        }
        return functionResult;
    }
*/
    public static double CalculateSum(double inputA, double inputB)//adds 2 floating point numbers together
    {
        var resultSum = (inputA + inputB);
        return resultSum;
    }

    public static double CalculateDifference(double inputA, double inputB)//subtracts inputB from inputA
    {
        var resultDifference = (inputA - inputB);
        return resultDifference;
    }

    public static double CalculateProduct(double inputA, double inputB)//multiply inputA by inputB
    {
        var resultProduct = inputA * inputB;
        return resultProduct;
    }

    public static double CalculateDivision(double inputA,double inputB)//divide inputA by input B 
    {
 var resultDividedNumber = inputA / inputB;
        return resultDividedNumber;
    }
}