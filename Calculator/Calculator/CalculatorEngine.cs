namespace Calculator;

public class CalculatorEngine
{
   //A and B
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

    public static double CalculateIsEqual(double inputA, double inputB)//compare A & B
    {
        var resultIsEqual = (inputA == inputB);
        return resultIsEqual;
    }
    
    public static double CalculatePower(double inputA, double inputB) //A raised to the power of B
    {
        var resultPower = Math.Pow(inputA, inputB);
        return resultPower;
    }

    public static double CalculateLog(double inputA, double inputB) //A log B
    {
        var resultLog = Math.Log(inputA, inputB);
        return resultLog;
    }

    public static double CalculateRoot(double inputA, double inputB) // B squareroot of A
    {
        var resultRoot = Math.Pow(inputA, (1 / inputB));
        return resultRoot;
    }
    // A only
    public static double CalculateFactorial(double inputA) //A!
    {
        var resultFactorial =1;
        while (inputA != 0)
        {
            resultFactorial = resultFactorial * inputA
            inputA--;
        }
        return resultFactorial;
    }

    public static double CalculateSine(double inputA) //Sin(A)
    {
        var resultSine = Math.Sin(inputA);
        return resultSine;
    }

    public static double CalculateCosine(double inputA) //Cos(A)
    {
        var resultCosine = Math.Cos(inputA);
        return resultCosine;
    }

    public static double CalculateTangent(double inputA) //Tan(A)
    {
        var resultTangent = Math.Tan(inputA);
        return resultTangent;
    }

    public static double CalculateOneDiv(double inputA) // 1 / A
    {
        var resultOneDiv = (1 / A);
        return resultOneDiv;
    }
}
