using BasicCorePrograms;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to Basic Programs");
        bool end = true;
        Console.WriteLine("1. FlipCoin\n2. LeapYear\n3. PowerOfTwo\n4. HarmonicNumbers\n5. PrimeFactors\n6. QuotientAndRemainder\n7. SwapTwoNumbers\n8. OddOrEven\n9. VowelOrConsonant\n10. LargestAmongThreeNumbers\n11. End the program");
        while (end)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flip = new FlipCoin();
                    flip.CheckFlip();
                    break;
                case 2:
                    LeapYear leap = new LeapYear();
                    leap.CheckLeap();
                    break;
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.CheckPower();
                    break;
                case 4:
                    HarmonicNumbers harmonic = new HarmonicNumbers();
                    harmonic.CheckHarmonic();
                    break;
                case 5:
                    PrimeFactors prime = new PrimeFactors();
                    prime.CheckPrime();
                    break;
                case 6:
                    QuotientAndRemainder quotient = new QuotientAndRemainder();
                    quotient.CheckQuotient();
                    break;
                case 7:
                    SwapTwoNumbers swap = new SwapTwoNumbers();
                    swap.CheckSwap();
                    break;
                case 8:
                    EvenOrOdd oddeven = new EvenOrOdd();
                    oddeven.CheckEvenOdd();
                    break;
                case 9:
                    VowelOrConsonant vowel = new VowelOrConsonant();
                    vowel.CheckVowelConsonant();
                    break;
                case 10:
                    LargestAmongThreeNumbers largest = new LargestAmongThreeNumbers();
                    largest.CheckLargeNum();
                    break;
                case 11:
                    end = false;
                    break;

                default:
                    Console.WriteLine("Enter proper option to Execute");
                    break;
            }
        }
    }
}


