namespace WebAPI_LibraryProject;

public class Calculator_Logic
{
    //This is the logic part of addition
    public static double addittion(double left, double right, double expected)
    {
        return left + right;
    }

    //This is the logic part of subtraction
    public static double substraction(double left, double right, double expected)
    {
        return left - right;
    }

    //This is the logic part of Multiplication
    public static double multiplication(double left, double right, double expected)
    {
        return left * right;
    }

    //This is the logic part of Division

    public static double division(double left, double right)
    {
        if (right != 0)
        {
            return left / right;
        }
        else
        {
            throw new DivideByZeroException();
        }
    }
}

