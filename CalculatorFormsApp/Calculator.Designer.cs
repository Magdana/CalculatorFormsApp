namespace CalculatorFormsApp
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            historyBox = new TextBox();
            inputBox = new TextBox();
            seven = new Label();
            eight = new Label();
            nine = new Label();
            division = new Label();
            erase1 = new Label();
            erase2 = new Label();
            four = new Label();
            five = new Label();
            six = new Label();
            multiplication = new Label();
            one = new Label();
            two = new Label();
            three = new Label();
            minus = new Label();
            equation = new Label();
            zero = new Label();
            point = new Label();
            plus = new Label();
            toggleSignButton = new Label();
            SuspendLayout();
            // 
            // historyBox
            // 
            historyBox.BorderStyle = BorderStyle.FixedSingle;
            historyBox.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            historyBox.Location = new Point(38, 31);
            historyBox.Name = "historyBox";
            historyBox.Size = new Size(400, 41);
            historyBox.TabIndex = 0;
            historyBox.TextAlign = HorizontalAlignment.Right;
            // 
            // inputBox
            // 
            inputBox.BorderStyle = BorderStyle.FixedSingle;
            inputBox.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            inputBox.Location = new Point(38, 67);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(400, 41);
            inputBox.TabIndex = 1;
            inputBox.TextAlign = HorizontalAlignment.Right;
            // 
            // seven
            // 
            seven.BorderStyle = BorderStyle.FixedSingle;
            seven.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            seven.Location = new Point(40, 133);
            seven.Name = "seven";
            seven.Size = new Size(50, 50);
            seven.TabIndex = 2;
            seven.Text = "7";
            seven.TextAlign = ContentAlignment.MiddleCenter;
            seven.Click += seven_Click;
            // 
            // eight
            // 
            eight.BorderStyle = BorderStyle.FixedSingle;
            eight.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            eight.Location = new Point(125, 133);
            eight.Name = "eight";
            eight.Size = new Size(50, 50);
            eight.TabIndex = 3;
            eight.Text = "8";
            eight.TextAlign = ContentAlignment.MiddleCenter;
            eight.Click += eight_Click;
            // 
            // nine
            // 
            nine.BorderStyle = BorderStyle.FixedSingle;
            nine.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            nine.Location = new Point(207, 133);
            nine.Name = "nine";
            nine.Size = new Size(50, 50);
            nine.TabIndex = 4;
            nine.Text = "9";
            nine.TextAlign = ContentAlignment.MiddleCenter;
            nine.Click += nine_Click;
            // 
            // division
            // 
            division.BorderStyle = BorderStyle.FixedSingle;
            division.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            division.Location = new Point(284, 133);
            division.Name = "division";
            division.Size = new Size(50, 50);
            division.TabIndex = 5;
            division.Text = "/";
            division.TextAlign = ContentAlignment.MiddleCenter;
            division.Click += division_Click;
            // 
            // erase1
            // 
            erase1.BorderStyle = BorderStyle.FixedSingle;
            erase1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            erase1.Location = new Point(368, 133);
            erase1.Name = "erase1";
            erase1.Size = new Size(70, 50);
            erase1.TabIndex = 6;
            erase1.Text = "CE";
            erase1.TextAlign = ContentAlignment.MiddleCenter;
            erase1.Click += erase1_Click;
            // 
            // erase2
            // 
            erase2.BorderStyle = BorderStyle.FixedSingle;
            erase2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            erase2.Location = new Point(368, 197);
            erase2.Name = "erase2";
            erase2.Size = new Size(70, 50);
            erase2.TabIndex = 7;
            erase2.Text = "C";
            erase2.TextAlign = ContentAlignment.MiddleCenter;
            erase2.Click += erase2_Click;
            // 
            // four
            // 
            four.BorderStyle = BorderStyle.FixedSingle;
            four.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            four.Location = new Point(40, 197);
            four.Name = "four";
            four.Size = new Size(50, 50);
            four.TabIndex = 8;
            four.Text = "4";
            four.TextAlign = ContentAlignment.MiddleCenter;
            four.Click += four_Click;
            // 
            // five
            // 
            five.BorderStyle = BorderStyle.FixedSingle;
            five.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            five.Location = new Point(125, 198);
            five.Name = "five";
            five.Size = new Size(50, 50);
            five.TabIndex = 9;
            five.Text = "5";
            five.TextAlign = ContentAlignment.MiddleCenter;
            five.Click += five_Click;
            // 
            // six
            // 
            six.BorderStyle = BorderStyle.FixedSingle;
            six.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            six.Location = new Point(207, 197);
            six.Name = "six";
            six.Size = new Size(50, 50);
            six.TabIndex = 10;
            six.Text = "6";
            six.TextAlign = ContentAlignment.MiddleCenter;
            six.Click += six_Click;
            // 
            // multiplication
            // 
            multiplication.BorderStyle = BorderStyle.FixedSingle;
            multiplication.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            multiplication.Location = new Point(284, 198);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(50, 50);
            multiplication.TabIndex = 11;
            multiplication.Text = "*";
            multiplication.TextAlign = ContentAlignment.MiddleCenter;
            multiplication.Click += multiplication_Click;
            // 
            // one
            // 
            one.BorderStyle = BorderStyle.FixedSingle;
            one.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            one.Location = new Point(40, 265);
            one.Name = "one";
            one.Size = new Size(50, 50);
            one.TabIndex = 12;
            one.Text = "1";
            one.TextAlign = ContentAlignment.MiddleCenter;
            one.Click += one_Click;
            // 
            // two
            // 
            two.BorderStyle = BorderStyle.FixedSingle;
            two.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            two.Location = new Point(125, 266);
            two.Name = "two";
            two.Size = new Size(50, 50);
            two.TabIndex = 13;
            two.Text = "2";
            two.TextAlign = ContentAlignment.MiddleCenter;
            two.Click += two_Click;
            // 
            // three
            // 
            three.BorderStyle = BorderStyle.FixedSingle;
            three.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            three.Location = new Point(207, 266);
            three.Name = "three";
            three.Size = new Size(50, 50);
            three.TabIndex = 14;
            three.Text = "3";
            three.TextAlign = ContentAlignment.MiddleCenter;
            three.Click += three_Click;
            // 
            // minus
            // 
            minus.BorderStyle = BorderStyle.FixedSingle;
            minus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            minus.Location = new Point(284, 265);
            minus.Name = "minus";
            minus.Size = new Size(50, 50);
            minus.TabIndex = 15;
            minus.Text = "-";
            minus.TextAlign = ContentAlignment.MiddleCenter;
            minus.Click += minus_Click;
            // 
            // equation
            // 
            equation.BorderStyle = BorderStyle.FixedSingle;
            equation.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            equation.Location = new Point(368, 266);
            equation.Name = "equation";
            equation.Size = new Size(70, 120);
            equation.TabIndex = 16;
            equation.Text = "=";
            equation.TextAlign = ContentAlignment.MiddleCenter;
            equation.Click += equation_Click;
            // 
            // zero
            // 
            zero.BorderStyle = BorderStyle.FixedSingle;
            zero.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            zero.Location = new Point(125, 336);
            zero.Name = "zero";
            zero.Size = new Size(50, 50);
            zero.TabIndex = 17;
            zero.Text = "0";
            zero.TextAlign = ContentAlignment.MiddleCenter;
            zero.Click += zero_Click;
            // 
            // point
            // 
            point.BorderStyle = BorderStyle.FixedSingle;
            point.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            point.Location = new Point(207, 337);
            point.Name = "point";
            point.Size = new Size(50, 50);
            point.TabIndex = 18;
            point.Text = ".";
            point.TextAlign = ContentAlignment.MiddleCenter;
            point.Click += point_Click;
            // 
            // plus
            // 
            plus.BorderStyle = BorderStyle.FixedSingle;
            plus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            plus.Location = new Point(284, 337);
            plus.Name = "plus";
            plus.Size = new Size(50, 50);
            plus.TabIndex = 19;
            plus.Text = "+";
            plus.TextAlign = ContentAlignment.MiddleCenter;
            plus.Click += plus_Click;
            // 
            // toggleSignButton
            // 
            toggleSignButton.BorderStyle = BorderStyle.FixedSingle;
            toggleSignButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toggleSignButton.Location = new Point(40, 336);
            toggleSignButton.Name = "toggleSignButton";
            toggleSignButton.Size = new Size(50, 50);
            toggleSignButton.TabIndex = 20;
            toggleSignButton.Text = "+/-";
            toggleSignButton.TextAlign = ContentAlignment.MiddleCenter;
            toggleSignButton.Click += toggleSignButton_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(toggleSignButton);
            Controls.Add(plus);
            Controls.Add(point);
            Controls.Add(zero);
            Controls.Add(equation);
            Controls.Add(minus);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(multiplication);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(erase2);
            Controls.Add(erase1);
            Controls.Add(division);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(inputBox);
            Controls.Add(historyBox);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox historyBox;
        private TextBox inputBox;
        private Label seven;
        private Label eight;
        private Label nine;
        private Label division;
        private Label erase1;
        private Label erase2;
        private Label four;
        private Label five;
        private Label six;
        private Label multiplication;
        private Label one;
        private Label two;
        private Label three;
        private Label minus;
        private Label equation;
        private Label zero;
        private Label point;
        private Label plus;
        private Label toggleSignButton;
    }
}