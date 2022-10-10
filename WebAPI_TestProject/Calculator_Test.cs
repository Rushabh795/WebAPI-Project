namespace WebAPI_TestProject;

[TestClass]
public class Calculator_Test
{
    //Addition Tests
    [TestMethod]
    public void Addition_Only_Three_Positive_Numbers_One_Add_One_Mustbe_EqualTo_Two()
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.addittion(1, 1,0);
        Assert.AreEqual(2, result);
    }



    [TestMethod]
    public void Addition_Only_Two_Positive_Numbers_And_Check_It_Is_Instance_Of_Double_Type_Or_Not()
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.addittion(1, 1,0);
        Assert.AreEqual(2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

   

    [DataRow(-1, 2 , 1)]
    [TestMethod]
    public void Add_Only_Positive_Numbers_Check_The_First_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.addittion(left , right,expected);
        Assert.IsTrue(left > 0);
    }




    [DataRow(1, -2 , 1)]
    [TestMethod]
    public void Add_Only_Positive_Numbers_Check_The_Second_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.addittion(left, right,expected);
        Assert.IsTrue(right > 0);
    }



    [DataRow(1, -2, -1)]
    [TestMethod]
    public void Add_Only_Positive_Numbers_Check_The_Third_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.addittion(left, right, expected);
        Assert.IsTrue(expected > 0);
    }


    [DataRow(-1, -2 ,1)]
    [TestMethod]
    public void Add_Only_Positive_Numbers_Check_First_Number_And_Second_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.addittion(left, right,expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);

    }

    [DataRow(1, -2, -1)]
    [TestMethod]
    public void Add_Only_Positive_Numbers_Check_Second_Number_And_Third_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.addittion(left, right, expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);

    }


    [DataRow(1, 2, 3)]
    [TestMethod]
    public void Addition_Only_Two_Positive_Numbers_Mustbe_EqualTo_Expected_Value(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.addittion(left, right,expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);
        Assert.AreEqual(expected, result);

    }



    [DataRow(1, 2, 3)]
    [TestMethod]
    public void Addition_Only_Two_Positive_Numbers_Mustbe_EqualTo_Expected_Value_And_Checked_It_is_IsInstanceOfType_Double_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.addittion(left, right, expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);
        Assert.AreEqual(expected, result);
        Assert.IsInstanceOfType(result, typeof(double));

    }


    [TestMethod]
    public void Addition_Only_Three_Positive_Numbers_Must_be_equal_to_Three(double left, double right, double expected)
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.addittion(1, 1,1);
        Assert.AreEqual(3, result);
    }


    //Substraction Tests

    [TestMethod]
    public void Substraction_Only_Three_Positive_Numbers_One_Substract_Mustbe_EqualTo_Zero()
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.substraction(1, 1, 0);
        Assert.AreEqual(0, result);
    }



    [TestMethod]
    public void Substraction_Only_Two_Positive_Numbers_And_Check_It_Is_Instance_Of_Double_Type_Or_Not()
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.substraction(1, 1, 0);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }



    [DataRow(-1, 2, 1)]
    [TestMethod]
    public void Substraction_Positive_Numbers_Check_The_First_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.substraction(left, right, expected);
        Assert.IsTrue(left > 0);
    }




    [DataRow(1, -2, 1)]
    [TestMethod]
    public void Substraction_Positive_Numbers_Check_The_Second_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.substraction(left, right, expected);
        Assert.IsTrue(right > 0);
    }



    [DataRow(1, -2, -1)]
    [TestMethod]
    public void Substraction_Positive_Numbers_Check_The_Third_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.substraction(left, right, expected);
        Assert.IsTrue(expected > 0);
    }


    [DataRow(-1, -2, 1)]
    [TestMethod]
    public void Substraction_Positive_Numbers_Check_First_Number_And_Second_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.substraction(left, right, expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);

    }

    [DataRow(1, -2, -1)]
    [TestMethod]
    public void Substraction_Positive_Numbers_Check_Second_Number_And_Third_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.substraction(left, right, expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);

    }


    [DataRow(1, 2, 3)]
    [TestMethod]
    public void Substraction_Only_Two_Positive_Numbers_Mustbe_EqualTo_Expected_Value(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.substraction(left, right, expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);
        Assert.AreEqual(expected, result);

    }



    [DataRow(4, 1, 3)]
    [TestMethod]
    public void Substraction_Only_Two_Positive_Numbers_Mustbe_EqualTo_Expected_Value_And_Checked_It_is_IsInstanceOfType_Double_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.substraction(left, right, expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);
        Assert.AreEqual(expected, result);
        Assert.IsInstanceOfType(result, typeof(double));

    }


    [TestMethod]
    public void Substraction_Only_Three_Positive_Numbers_Must_be_equal_to_Three(double left, double right, double expected)
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.substraction(1, 1, 1);
        Assert.AreEqual(3, result);
    }

    //Multiplication

    [TestMethod]
    public void Multiplication_Only_Three_Positive_Numbers_One_Multiplication_By_Zero_Mustbe_EqualTo_Zero()
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.multiplication(1, 1, 0);
        Assert.AreEqual(0, result);
    }



    [TestMethod]
    public void Multiplication_Only_Two_Positive_Numbers_And_Check_It_Is_Instance_Of_Double_Type_Or_Not()
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.multiplication(1, 1, 0);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }



    [DataRow(-1, 2, 1)]
    [TestMethod]
    public void Multiplication_Positive_Numbers_Check_The_First_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.multiplication(left, right, expected);
        Assert.IsTrue(left > 0);
    }




    [DataRow(1, -2, 1)]
    [TestMethod]
    public void Multiplication_Positive_Numbers_Check_The_Second_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.multiplication(left, right, expected);
        Assert.IsTrue(right > 0);
    }



    [DataRow(1, -2, -1)]
    [TestMethod]
    public void Multiplication_Positive_Numbers_Check_The_Third_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.multiplication(left, right, expected);
        Assert.IsTrue(expected > 0);
    }


    [DataRow(-1, -2, 1)]
    [TestMethod]
    public void Multiplication_Positive_Numbers_Check_First_Number_And_Second_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.multiplication(left, right, expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);

    }

    [DataRow(1, -2, -1)]
    [TestMethod]
    public void Multiplication_Positive_Numbers_Check_Second_Number_And_Third_Number_Is_Negative_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.multiplication(left, right, expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);

    }


    [DataRow(1, 3, 3)]
    [TestMethod]
    public void Multiplication_Only_Two_Positive_Numbers_Mustbe_EqualTo_Expected_Value(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.multiplication(left, right, expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);
        Assert.AreEqual(expected, result);

    }



    [DataRow(3, 1, 3)]
    [TestMethod]
    public void Multiplication_Only_Two_Positive_Numbers_Mustbe_EqualTo_Expected_Value_And_Checked_It_is_IsInstanceOfType_Double_Or_Not(double left, double right, double expected)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.multiplication(left, right, expected);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);
        Assert.AreEqual(expected, result);
        Assert.IsInstanceOfType(result, typeof(double));

    }


    [TestMethod]
    public void Multiplication_Only_Three_Positive_Numbers_Must_be_MultiplyResult(double left, double right, double expected)
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.multiplication(1, 1, 1);
        Assert.AreEqual(1, result);
    }

    //Division

    [TestMethod]
    public void Division_One_Number_By_Zero()
    {
        Assert.ThrowsException<DivideByZeroException>(() => WebAPI_LibraryProject.Calculator_Logic.division(2, 0));

    }



    [TestMethod]
    public void Division_Only_Two_Positive_Numbers_And_Check_It_Is_Instance_Of_Double_Type_Or_Not()
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.division(1, 1);
        Assert.AreEqual(1, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }



    [DataRow(-1, 2)]
    [TestMethod]
    public void Division_Positive_Numbers_Check_The_First_Number_Is_Negative_Or_Not(double left, double right)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.division(left, right);
        Assert.IsTrue(left > 0);
    }




    [DataRow(1, -2)]
    [TestMethod]
    public void Division_Positive_Numbers_Check_The_Second_Number_Is_Negative_Or_Not(double left, double right)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.division(left, right);
        Assert.IsTrue(right > 0);
    }



    [DataRow(1, -2)]
    [TestMethod]
    public void Division_Positive_Numbers_Check_The_Number_Is_Divide_Or_Not(double left, double right)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.division(left, right);
        Assert.AreEqual(1, result);
    }


    [DataRow(-1, -2)]
    [TestMethod]
    public void Division_Positive_Numbers_Check_First_Number_And_Second_Number_Is_Negative_Or_Not(double left, double right)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.division(left, right);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);

    }

    [DataRow(1, -2)]
    [TestMethod]
    public void Division_Positive_Numbers_Check_Second_Number_Greater_Than_Zero_Or_Not(double left, double right)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.division(left, right);
        Assert.IsTrue(right > 0);

    }


    [DataRow(1, 3)]
    [TestMethod]
    public void Division_Only_Two_Positive_Numbers_Mustbe_EqualTo_Four_Value(double left, double right)
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.division(left, right);
        Assert.AreEqual(4, result);

    }



    [DataRow(3, 1)]
    [TestMethod]
    public void Division_Only_Two_Positive_Numbers_Mustbe_EqualTo_Expected_Value_And_Checked_It_is_IsInstanceOfType_Double_Or_Not(double left, double right)
    {

        var result = WebAPI_LibraryProject.Calculator_Logic.division(left, right);
        Assert.IsTrue(left > 0);
        Assert.IsTrue(right > 0);
        Assert.IsInstanceOfType(result, typeof(double));

    }


    [TestMethod]
    public void Division_Two_Positive_Numbers_Must_be_Divide(double left, double right )
    {
        var result = WebAPI_LibraryProject.Calculator_Logic.division(1, 1);
        Assert.AreEqual(1, result);
    }

}
