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





   




}
