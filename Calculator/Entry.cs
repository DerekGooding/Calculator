namespace Calculator;

public class Entry(TextBox textBox)
{
    internal readonly TextBox _textBox = textBox;
    internal string _value = string.Empty;
    public string Value
    {
        get => _value;
        set
        {
            _value = value;
            _textBox.Text = value;
        }
    }
    public decimal Decimal => decimal.TryParse(Value, out decimal result) ? result : 0;
    public bool IsNegative => Value[0] == '-';
    public bool HasDecimal => Value.Any(x => x == '.');
    public void ToggleNegative() => Value = IsNegative ? Value[1..] : '-' + Value;
    public void AddToEnd(char c) => Value = (c == '.' && HasDecimal) ? Value : Value + c;
    public void Clear() => Value = string.Empty;
}
