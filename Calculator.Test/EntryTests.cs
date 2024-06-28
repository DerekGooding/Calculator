using System.Windows.Forms;

namespace Calculator.Test;

[TestClass]
public class EntityTests
{
    [TestMethod]
    public void Should_UpdateVisualWhenChanged()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];
        TextBox textbox = entry._textBox;
        const string expected = "!";

        calculator.AddToEnd(expected[0]);

        Assert.AreEqual(expected, textbox.Text);
    }

    [TestMethod]
    public void DecimalProperty_ShouldReturnDecimal()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];
        const decimal expected = 88.8m;

        entry.Value = $"{expected}";

        Assert.AreEqual(expected, entry.Decimal);
    }

    [TestMethod]
    public void IsNegativeProperty_ShouldBeTrue()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];

        entry.Value = "-5.5";

        Assert.IsTrue(entry.IsNegative);
    }

    [TestMethod]
    public void IsNegativeProperty_ShouldBeFalse()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];

        entry.Value = "5.5";

        Assert.IsFalse(entry.IsNegative);
    }

    [TestMethod]
    public void HasDecimableProperty_ShouldBeTrue()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];

        entry.Value = "5.5";

        Assert.IsTrue(entry.HasDecimal);
    }

    [TestMethod]
    public void HasDecimableProperty_ShouldBeFalse()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];

        entry.Value = "55";

        Assert.IsFalse(entry.HasDecimal);
    }

    [TestMethod]
    public void ToggleNegative_ShouldToggle()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];

        entry.Value = "-5.5";
        entry.ToggleNegative();

        Assert.IsFalse(entry.IsNegative);
    }

    [TestMethod]
    public void AddToEnd_ShouldAdd()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];
        const string original = "-5.5";
        const char endcap = '5';

        entry.Value = original;
        entry.AddToEnd(endcap);
        string expected = original + endcap;

        Assert.AreEqual(expected, entry.Value);
    }

    [TestMethod]
    public void Clear_ShouldClear()
    {
        Calculator calculator = new();
        Entry entry = calculator._entries[0];

        entry.Value = "-5.5";
        entry.Clear();

        Assert.AreEqual(string.Empty, entry.Value);
    }

}