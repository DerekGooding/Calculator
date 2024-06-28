namespace Calculator;

partial class Calculator
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		equals = new Button();
		plus = new Button();
		subtract = new Button();
		multiplier = new Button();
		divide = new Button();
		resultBox = new TextBox();
		zero = new Button();
		number9 = new Button();
		number8 = new Button();
		number7 = new Button();
		number4 = new Button();
		number5 = new Button();
		number6 = new Button();
		number1 = new Button();
		number2 = new Button();
		number3 = new Button();
		clear = new Button();
		clearCurrent = new Button();
		keydot = new Button();
		toggleNegative = new Button();
		SuspendLayout();
		// 
		// equals
		// 
		equals.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		equals.Location = new Point(336, 483);
		equals.Name = "equals";
		equals.Size = new Size(99, 80);
		equals.TabIndex = 0;
		equals.Text = "=";
		equals.UseVisualStyleBackColor = true;
		equals.Click += Equals_Click;
		// 
		// plus
		// 
		plus.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		plus.Location = new Point(336, 419);
		plus.Name = "plus";
		plus.Size = new Size(99, 80);
		plus.TabIndex = 1;
		plus.Text = "+";
		plus.UseVisualStyleBackColor = true;
		plus.Click += Addition_Click;
		// 
		// subtract
		// 
		subtract.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		subtract.Location = new Point(336, 344);
		subtract.Name = "subtract";
		subtract.Size = new Size(99, 80);
		subtract.TabIndex = 2;
		subtract.Text = "--";
		subtract.UseVisualStyleBackColor = true;
		subtract.Click += Subtract_Click;
		// 
		// multiplier
		// 
		multiplier.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		multiplier.Location = new Point(336, 270);
		multiplier.Name = "multiplier";
		multiplier.Size = new Size(99, 80);
		multiplier.TabIndex = 3;
		multiplier.Text = "*";
		multiplier.UseVisualStyleBackColor = true;
		multiplier.Click += Multiply_Click;
		// 
		// divide
		// 
		divide.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		divide.Location = new Point(336, 194);
		divide.Name = "divide";
		divide.Size = new Size(99, 80);
		divide.TabIndex = 4;
		divide.Text = " /";
		divide.UseVisualStyleBackColor = true;
		divide.Click += Division_Click;
		// 
		// resultBox
		// 
		resultBox.BackColor = Color.FromArgb(10, 20, 45);
		resultBox.BorderStyle = BorderStyle.FixedSingle;
		resultBox.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point);
		resultBox.ForeColor = Color.FromArgb(204, 204, 204);
		resultBox.Location = new Point(-1, -3);
		resultBox.Multiline = true;
		resultBox.Name = "resultBox";
		resultBox.Size = new Size(338, 199);
		resultBox.TabIndex = 5;
		// 
		// zero
		// 
		zero.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		zero.Location = new Point(108, 483);
		zero.Name = "zero";
		zero.Size = new Size(116, 80);
		zero.TabIndex = 6;
		zero.Text = "0";
		zero.UseVisualStyleBackColor = true;
		zero.Click += Number0_Click;
		// 
		// number9
		// 
		number9.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		number9.Location = new Point(-1, 194);
		number9.Name = "number9";
		number9.Size = new Size(116, 98);
		number9.TabIndex = 7;
		number9.Text = "9";
		number9.UseVisualStyleBackColor = true;
		number9.Click += Number9_Click;
		// 
		// number8
		// 
		number8.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		number8.Location = new Point(108, 194);
		number8.Name = "number8";
		number8.Size = new Size(116, 98);
		number8.TabIndex = 8;
		number8.Text = "8";
		number8.UseVisualStyleBackColor = true;
		number8.Click += Number8_Click;
		// 
		// number7
		// 
		number7.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		number7.Location = new Point(221, 194);
		number7.Name = "number7";
		number7.Size = new Size(116, 98);
		number7.TabIndex = 9;
		number7.Text = "7";
		number7.UseVisualStyleBackColor = true;
		number7.Click += Number7_Click;
		// 
		// number4
		// 
		number4.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		number4.Location = new Point(221, 290);
		number4.Name = "number4";
		number4.Size = new Size(116, 98);
		number4.TabIndex = 12;
		number4.Text = "4";
		number4.UseVisualStyleBackColor = true;
		number4.Click += Number4_Click;
		// 
		// number5
		// 
		number5.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		number5.Location = new Point(108, 290);
		number5.Name = "number5";
		number5.Size = new Size(116, 98);
		number5.TabIndex = 11;
		number5.Text = "5";
		number5.UseVisualStyleBackColor = true;
		number5.Click += Number5_Click;
		// 
		// number6
		// 
		number6.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		number6.Location = new Point(-1, 290);
		number6.Name = "number6";
		number6.Size = new Size(116, 98);
		number6.TabIndex = 10;
		number6.Text = "6";
		number6.UseVisualStyleBackColor = true;
		number6.Click += Number6_Click;
		// 
		// number1
		// 
		number1.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		number1.Location = new Point(221, 386);
		number1.Name = "number1";
		number1.Size = new Size(116, 98);
		number1.TabIndex = 15;
		number1.Text = "1";
		number1.UseVisualStyleBackColor = true;
		number1.Click += Number1_Click;
		// 
		// number2
		// 
		number2.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		number2.Location = new Point(108, 386);
		number2.Name = "number2";
		number2.Size = new Size(116, 98);
		number2.TabIndex = 14;
		number2.Text = "2";
		number2.UseVisualStyleBackColor = true;
		number2.Click += Number2_Click;
		// 
		// number3
		// 
		number3.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point);
		number3.Location = new Point(-1, 386);
		number3.Name = "number3";
		number3.Size = new Size(116, 98);
		number3.TabIndex = 13;
		number3.Text = "3";
		number3.UseVisualStyleBackColor = true;
		number3.Click += Number3_Click;
		// 
		// clear
		// 
		clear.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point);
		clear.Location = new Point(336, -3);
		clear.Name = "clear";
		clear.Size = new Size(99, 101);
		clear.TabIndex = 16;
		clear.Text = " C";
		clear.UseVisualStyleBackColor = true;
		clear.Click += Clear_Click;
		// 
		// clearCurrent
		// 
		clearCurrent.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point);
		clearCurrent.Location = new Point(336, 95);
		clearCurrent.Name = "clearCurrent";
		clearCurrent.Size = new Size(99, 101);
		clearCurrent.TabIndex = 17;
		clearCurrent.Text = "CE";
		clearCurrent.UseVisualStyleBackColor = true;
		clearCurrent.Click += ClearCurrent_Click;
		// 
		// keydot
		// 
		keydot.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point);
		keydot.Location = new Point(221, 483);
		keydot.Name = "keydot";
		keydot.Size = new Size(116, 80);
		keydot.TabIndex = 18;
		keydot.Text = " .";
		keydot.UseVisualStyleBackColor = true;
		keydot.Click += Keydot_Click;
		// 
		// toggleNegative
		// 
		toggleNegative.Font = new Font("Franklin Gothic Medium", 40F, FontStyle.Regular, GraphicsUnit.Point);
		toggleNegative.Location = new Point(-1, 483);
		toggleNegative.Name = "toggleNegative";
		toggleNegative.Size = new Size(110, 80);
		toggleNegative.TabIndex = 19;
		toggleNegative.Text = "(-)";
		toggleNegative.UseVisualStyleBackColor = true;
		toggleNegative.Click += ToggleNegative_Click;
		// 
		// Calculator
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(10, 20, 45);
		ClientSize = new Size(434, 561);
		Controls.Add(toggleNegative);
		Controls.Add(keydot);
		Controls.Add(clearCurrent);
		Controls.Add(clear);
		Controls.Add(number1);
		Controls.Add(number2);
		Controls.Add(number3);
		Controls.Add(number4);
		Controls.Add(number5);
		Controls.Add(number6);
		Controls.Add(number7);
		Controls.Add(number8);
		Controls.Add(number9);
		Controls.Add(zero);
		Controls.Add(resultBox);
		Controls.Add(divide);
		Controls.Add(multiplier);
		Controls.Add(subtract);
		Controls.Add(plus);
		Controls.Add(equals);
		FormBorderStyle = FormBorderStyle.FixedToolWindow;
		Name = "Calculator";
		Text = "Calculator";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button equals;
	private Button plus;
	private Button subtract;
	private Button multiplier;
	private Button divide;
	private TextBox resultBox;
	private Button zero;
	private Button number9;
	private Button number8;
	private Button number7;
	private Button number4;
	private Button number5;
	private Button number6;
	private Button number1;
	private Button number2;
	private Button number3;
	private Button clear;
	private Button clearCurrent;
	private Button keydot;
	private Button toggleNegative;
}
