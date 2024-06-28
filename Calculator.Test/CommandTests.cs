using System.Windows.Forms;

namespace Calculator.Test;

[TestClass]
public class CommandTests
{
    [TestMethod]
    public void Equals_Click_ShouldPerformCalculation()
    {
        Calculator calculator = new();
        TextBox textBox = calculator._entries[0]._textBox;

        calculator.Number5_Click(new object(), EventArgs.Empty);
        calculator.Multiply_Click(new object(), EventArgs.Empty);
        calculator.Number5_Click(new object(), EventArgs.Empty);
        calculator.Equals_Click(new object(), EventArgs.Empty);

        Assert.AreEqual("25", textBox.Text);
    }

    [TestMethod]
    public void Addition_Click_ShouldUpdateOperation()
    {
        Calculator calculator = new();

        calculator.Addition_Click(new object(), EventArgs.Empty);

        Assert.AreEqual(Operation.Add, calculator._operation);
    }

    [TestMethod]
    public void Division_Click_ShouldUpdateOperation()
    {
        Calculator calculator = new();

        calculator.Subtract_Click(new object(), EventArgs.Empty);

        Assert.AreEqual(Operation.Sub, calculator._operation);
    }

    [TestMethod]
    public void Subtract_Click_ShouldUpdateOperation()
    {
        Calculator calculator = new();

        calculator.Multiply_Click(new object(), EventArgs.Empty);

        Assert.AreEqual(Operation.Mul, calculator._operation);
    }

    [TestMethod]
    public void Multiply_Click_ShouldUpdateOperation()
    {
        Calculator calculator = new();

        calculator.Division_Click(new object(), EventArgs.Empty);

        Assert.AreEqual(Operation.Div, calculator._operation);
    }

    [TestMethod]
    public void Keydot_Click_ShouldAddDecimal()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];

        calculator.Number5_Click(new object(), EventArgs.Empty);
        calculator.Keydot_Click(new object(), EventArgs.Empty);
        calculator.Number5_Click(new object(), EventArgs.Empty);

        Assert.AreEqual(5.5m, entry.Decimal);
    }

    [TestMethod]
    public void Keydot_Click_Twice_ShouldNotAddDecimal()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];

        calculator.Number5_Click(new object(), EventArgs.Empty);
        calculator.Keydot_Click(new object(), EventArgs.Empty);
        calculator.Number5_Click(new object(), EventArgs.Empty);
        calculator.Keydot_Click(new object(), EventArgs.Empty);
        calculator.Number5_Click(new object(), EventArgs.Empty);

        Assert.AreEqual(5.55m, entry.Decimal);
    }
}