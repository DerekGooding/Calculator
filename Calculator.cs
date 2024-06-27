namespace Calculator
{
	enum Operation
	{
		Add, Sub, Mul, Div
	}

	public partial class Calculator : Form
	{
		string first = "";
		string op = "";
		string second = "";

		decimal first_int = 0;
		decimal second_int = 0;
		decimal result = 0;

		byte opCount = 0;
		bool negativeOp1 = false;
		bool negativeOp2 = false;

		public Calculator()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (first == "") first = "0";     // Avoid any exceptions

			first_int = decimal.Parse(first);

			if (second == "") second = "0";     // Avoid any exceptions

			second_int = decimal.Parse(second);

			if (negativeOp1) first_int *= -1;
			if (negativeOp2) second_int *= -1;

			switch (op)
			{
				case "+": result = first_int + second_int; break;
				case "-": result = first_int - second_int; break;
				case "*": result = first_int * second_int; break;
				case "/": result = first_int / second_int; break;
			}

			first = "";
			op = "";
			second = "";
			first_int = 0;
			second_int = 0;
			opCount = 0;
			negativeOp1 = false;
			negativeOp2 = false;

			resultBox.Text = result.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			op = "+";
			opCount = 1;
		}

		private void divide_Click(object sender, EventArgs e)
		{
			op = "/";
			opCount = 1;
		}

		private void subtract_Click(object sender, EventArgs e)
		{
			op = "-";
			opCount = 1;
		}

		private void multiplier_Click(object sender, EventArgs e)
		{
			op = "*";
			opCount = 1;
		}

		private void number9_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += "9";
				resultBox.Text = first;
			}
			else
			{
				second += "9";
				resultBox.Text = second;
			}
		}

		private void number8_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += "8";
				resultBox.Text = first;
			}
			else
			{
				second += "8";
				resultBox.Text = second;
			}
		}

		private void number7_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += "7";
				resultBox.Text = first;
			}
			else
			{
				second += "7";
				resultBox.Text = second;
			}
		}

		private void number6_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += "6";
				resultBox.Text = first;
			}
			else
			{
				second += "6";
				resultBox.Text = second;
			}
		}

		private void number5_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += "5";
				resultBox.Text = first;
			}
			else
			{
				second += "5";
				resultBox.Text = second;
			}
		}

		private void number4_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += "4";
				resultBox.Text = first;
			}
			else
			{
				second += "4";
				resultBox.Text = second;
			}
		}

		private void number3_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += "3";
				resultBox.Text = first;
			}
			else
			{
				second += "3";
				resultBox.Text = second;
			}
		}

		private void number2_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += "2";
				resultBox.Text = first;
			}
			else
			{
				second += "2";
				resultBox.Text = second;
			}
		}

		private void number1_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += "1";
				resultBox.Text = first;
			}
			else
			{
				second += "1";
				resultBox.Text = second;
			}
		}

		private void zero_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += "0";
				resultBox.Text = first;
			}
			else
			{
				second += "0";
				resultBox.Text = second;
			}
		}

		private void clear_Click(object sender, EventArgs e)
		{
			first = "";
			op = "";
			second = "";
			first_int = 0;
			second_int = 0;
			opCount = 0;
			resultBox.Text = "";
		}

		private void clearCurrent_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first = "";
				resultBox.Text = first;
			}
			else
			{
				second = "";
				resultBox.Text = second;
			}
		}

		private void keydot_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				first += ".";
				resultBox.Text = first;
			}
			else
			{
				second += ".";
				resultBox.Text = second;
			}
		}

		private void toggleNegative_Click(object sender, EventArgs e)
		{
			if (opCount == 0)
			{
				if (!negativeOp1)
				{
					first = "-" + first;
					resultBox.Text = first;
				}
				else
				{
					first = first.Substring(1);
					resultBox.Text = first;
				}
			}
			else
			{
				if (!negativeOp2)
				{
					second = "-" + second;
					resultBox.Text = second;
				}
				else
				{
					second = second.Substring(1);
					resultBox.Text = second;
				}
			}
		}
	}
}
