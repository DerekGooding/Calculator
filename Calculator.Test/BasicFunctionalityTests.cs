namespace Calculator.Test;

[TestClass]
public class BasicFunctionalityTests
{
    [TestMethod]
    public void Calulculator_ShouldInitialize()
    {
        Calculator calculator = new();

        Assert.IsNotNull(calculator);
    }

    [TestMethod]
    public void Calulculator_ShouldHaveTwoEntries()
    {
        Calculator calculator = new();

        Assert.AreEqual(calculator._entries.Length, 2);
    }

    [TestMethod]
    public void Calculate_Should_CarryOverFirstResult()
    {
        Calculator calculator = new();
        const string a = "1";
        const string b = "20";

        calculator._entries[0].Value = a;
        calculator._entries[1].Value = b;
        calculator._operation = Operation.Add;
        decimal result = calculator.CalculateOperation();
        calculator.Equals_Click(new object(), EventArgs.Empty);

        Assert.AreEqual(result, calculator._entries[0].Decimal);
    }
}