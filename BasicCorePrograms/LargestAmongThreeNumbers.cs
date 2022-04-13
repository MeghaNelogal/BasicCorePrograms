using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestAmongThreeNumbers
    {
        public void CheckLargeNum()
        {
            Console.WriteLine("Largest Number in between Three Numbers Program");
            int num1, num2, num3;
            Console.Write("Enter The 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The 2st number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The 3st number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }
}
