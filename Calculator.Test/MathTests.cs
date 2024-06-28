namespace Calculator.Test;

[TestClass]
public class MathTests
{
    [TestMethod]
    public void Calculate_FailedParse_ShouldReturnZero()
    {
        Calculator calculator = new();
        const string a = "abc";
        const string b = "abc";
        const decimal expected = 0;

        calculator._entries[0].Value = a;
        calculator._entries[1].Value = b;
        calculator._operation = Operation.Add;

        decimal actual = calculator.CalculateOperation();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Calculate_NoOperation_ShouldReturnZero()
    {
        Calculator calculator = new();
        const string a = "5";
        const string b = "5";
        const decimal expected = 0;

        calculator._entries[0].Value = a;
        calculator._entries[1].Value = b;
        calculator._operation = Operation.None;

        decimal actual = calculator.CalculateOperation();

        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("1", "2")]
    [DataRow("2000", "5000")]
    [DataRow("-1", "10")]
    [DataRow("0.99999", "0.99999")]
    [DataRow("-1.5", "10")]
    public void Addition_ShouldCalculate(string a, string b)
    {
        Calculator calculator = new();
        decimal expected = decimal.Parse(a) + decimal.Parse(b);

        calculator._entries[0].Value = a;
        calculator._entries[1].Value = b;
        calculator._operation = Operation.Add;

        decimal actual = calculator.CalculateOperation();

        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("1", "2")]
    [DataRow("2000", "5000")]
    [DataRow("-1", "10")]
    [DataRow("0.99999", "0.99999")]
    [DataRow("-1.5", "10")]
    public void Substraction_ShouldCalculate(string a, string b)
    {
        Calculator calculator = new();
        decimal expected = decimal.Parse(a) - decimal.Parse(b);

        calculator._entries[0].Value = a;
        calculator._entries[1].Value = b;
        calculator._operation = Operation.Sub;

        decimal actual = calculator.CalculateOperation();

        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("1", "2")]
    [DataRow("2000", "5000")]
    [DataRow("-1", "10")]
    [DataRow("0.99999", "0.99999")]
    [DataRow("-1.5", "10")]
    public void Multiplication_ShouldCalculate(string a, string b)
    {
        Calculator calculator = new();
        decimal expected = decimal.Parse(a) * decimal.Parse(b);

        calculator._entries[0].Value = a;
        calculator._entries[1].Value = b;
        calculator._operation = Operation.Mul;

        decimal actual = calculator.CalculateOperation();

        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("1", "2")]
    [DataRow("2000", "5000")]
    [DataRow("-1", "10")]
    [DataRow("0.99999", "0.99999")]
    [DataRow("-1.5", "10")]
    public void Division_ShouldCalculate(string a, string b)
    {
        Calculator calculator = new();
        decimal expected = decimal.Parse(a) / decimal.Parse(b);

        calculator._entries[0].Value = a;
        calculator._entries[1].Value = b;
        calculator._operation = Operation.Div;

        decimal actual = calculator.CalculateOperation();

        Assert.AreEqual(expected, actual);
    }
}