using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumbers
    {
        public void CheckHarmonic()
        {
            Console.WriteLine("Harmonic Number Program");
            double Num, harmonic = 0;
            Console.Write("Enter Number For Harmonic sereis no. :");
            Num = Convert.ToInt32(Console.ReadLine());

            for (double i = 1; i <= Num; i++)
            {
                harmonic = harmonic + (1 / i);
            }
            Console.WriteLine("Harmonic Number of Number {0} is : {1}", Num, harmonic);
        }
    }
}
