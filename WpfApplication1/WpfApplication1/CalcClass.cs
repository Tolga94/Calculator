using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class CalcClass
    {
        private static char op = ' ';
		private double number1 = 0;
		private double number2 = 0;

		public double calculate()
		{
			switch(op)
			{
				case '+':
					return number1 + number2;
				case '-':
					return number1 - number2;
				case '*':
					return number1 * number2;
				case '/':
					return number1 / number2;
			}

			return 0;
		}

		public void setOp(char x)
		{
			op = x;
		}

		public void setNumber1(double x)
		{
			number1 = x;
		}

		public void setNumber2(double x)
		{
			number2 = x;
		}

    }
}
