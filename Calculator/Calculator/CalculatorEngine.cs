﻿using System.Diagnostics;
namespace Calculator;
public class CalculatorEngine
{
    public static double CalculateWebInputs(int inputA, int inputB, int mathFunction)
    {
        double functionResult = 0.0;
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
                functionResult = ((double)inputA / (double)inputB);
                break;
            case 5:
                functionResult = (inputA - inputB);
                break;
            case 6:
                functionResult = (inputA ^ inputB);
                break;
            case 7:
                functionResult = Math.Log((double)inputA, (double)inputB);
                break;
            case 8:
                functionResult = 0;
                break;
            case 9:
                functionResult = (inputA!);
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
}