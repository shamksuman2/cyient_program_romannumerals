using System;

namespace cyient.program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter arabic no.: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                string romNum = "";
                while (num >= 1000)
                {
                    romNum += "M";
                    num -= 1000;
                }
                while (num >= 900)
                {
                    romNum += "CM";
                    num -= 900;
                }
                while (num >= 500)
                {
                    romNum += "D";
                    num -= 500;
                }
                while (num >= 400)
                {
                    romNum += "CD";
                    num -= 400;
                }
                while (num >= 100)
                {
                    romNum += "C";
                    num -= 100;
                }
                while (num >= 90)
                {
                    romNum += "XC";
                    num -= 90;
                }
                while (num >= 50)
                {
                    romNum += "L";
                    num -= 50;
                }
                while (num >= 40)
                {
                    romNum += "XL";
                    num -= 40;
                }
                while (num >= 10)
                {
                    romNum += "X";
                    num -= 10;
                }
                while (num >= 9)
                {
                    romNum += "IX";
                    num -= 9;
                }
                while (num >= 5)
                {
                    romNum += "V";
                    num -= 5;
                }
                while (num >= 4)
                {
                    romNum += "IV";
                    num -= 4;
                }
                while (num >= 1)
                {
                    romNum += "I";
                    num -= 1;
                }

                Console.WriteLine("Roman numeral is: " + romNum);
            }
            else
                Console.WriteLine("Error: no a arabic number");
        }
    }
}