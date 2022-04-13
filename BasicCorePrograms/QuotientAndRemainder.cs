using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
	public class QuotientAndRemainder
	{
		public void CheckQuotient()
		{
			int x, y, quot, rem;
			Console.Write("Enter first number:");
			x = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number:");
			y = Convert.ToInt32(Console.ReadLine());

			quot = x / y;
			rem = x % y;

			Console.WriteLine("Quotient is:" + quot);
			Console.WriteLine("Remainder is:" + rem);

		}
	}
}
