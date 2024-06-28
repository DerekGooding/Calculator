namespace Calculator;

public partial class Calculator : Form
{
    internal readonly Entry[] _entries;
    internal Operation _operation;
    internal Entry CurrentEntry => _entries[_operation == Operation.None ? 0 : 1];

    public Calculator()
    {
        InitializeComponent();
        _entries = new Entry[2];
        _entries[0] = new(resultBox);
        _entries[1] = new(resultBox);
    }

    #region ButtonClicks
    internal void Equals_Click(object sender, EventArgs e)
    {
        decimal result = CalculateOperation();

        Reset(result);
        resultBox.Text = result.ToString();
    }

    internal void Addition_Click(object sender, EventArgs e) => _operation = Operation.Add;
    internal void Division_Click(object sender, EventArgs e) => _operation = Operation.Div;
    internal void Subtract_Click(object sender, EventArgs e) => _operation = Operation.Sub;
    internal void Multiply_Click(object sender, EventArgs e) => _operation = Operation.Mul;

    internal void Number9_Click(object sender, EventArgs e) => AddToEnd('9');
    internal void Number8_Click(object sender, EventArgs e) => AddToEnd('8');
    internal void Number7_Click(object sender, EventArgs e) => AddToEnd('7');
    internal void Number6_Click(object sender, EventArgs e) => AddToEnd('6');
    internal void Number5_Click(object sender, EventArgs e) => AddToEnd('5');
    internal void Number4_Click(object sender, EventArgs e) => AddToEnd('4');
    internal void Number3_Click(object sender, EventArgs e) => AddToEnd('3');
    internal void Number2_Click(object sender, EventArgs e) => AddToEnd('2');
    internal void Number1_Click(object sender, EventArgs e) => AddToEnd('1');
    internal void Number0_Click(object sender, EventArgs e) => AddToEnd('0');

    internal void Clear_Click(object sender, EventArgs e) => Reset();

    internal void ClearCurrent_Click(object sender, EventArgs e) => CurrentEntry.Clear();

    internal void Keydot_Click(object sender, EventArgs e) => AddToEnd('.');

    internal void ToggleNegative_Click(object sender, EventArgs e) => CurrentEntry.ToggleNegative();
    #endregion

    #region Helpers
    internal void Reset(decimal firstEntry = 0)
    {
        _entries[0].Value = firstEntry == 0 ? string.Empty : $"{firstEntry}";
        _entries[1].Value = string.Empty;
        _operation = Operation.None;
    }

    internal void AddToEnd(char n) => CurrentEntry.AddToEnd(n);

    internal decimal CalculateOperation() => _operation switch
    {
        Operation.Add => _entries[0].Decimal + _entries[1].Decimal,
        Operation.Sub => _entries[0].Decimal - _entries[1].Decimal,
        Operation.Mul => _entries[0].Decimal * _entries[1].Decimal,
        Operation.Div => _entries[0].Decimal / _entries[1].Decimal,
        _ => 0,
    };
    #endregion
}