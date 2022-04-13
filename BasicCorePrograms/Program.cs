using BasicCorePrograms;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to Basic Programs");
        bool end = true;
        Console.WriteLine("1. FlipCoin\n2. LeapYear\n3. PowerOfTwo\n4. HarmonicNumbers\n5. End the program");
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
                    end = false;
                    break;

                default:
                    Console.WriteLine("Enter proper option to Execute");
                    break;
            }
        }
    }
}


