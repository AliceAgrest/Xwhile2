
using System;

namespace Xwhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //q1
            
            int num, maxNum = 0, lowNum = 0, diffrence = 0;
            Console.WriteLine("Enter a number ");
            num = int.Parse(Console.ReadLine());
            lowNum = num;
            maxNum = num;
            while(num != 0)
            {
                Console.WriteLine("Enter a number ");
                num = int.Parse(Console.ReadLine());
                if (num < lowNum && num != 0)
                    lowNum = num;
                if (num > maxNum)
                    maxNum = num;
            }
            diffrence = maxNum - lowNum;
            Console.WriteLine($"The diffrence between The highest number and the lowest num is {diffrence}");
            
            //q2
            int temp = 0,sum = 0, dayCount = 0;
            double avg;
            while(temp != 999)
            {
                Console.WriteLine("Enter a temp ");
                temp = int.Parse(Console.ReadLine());
                if (temp != 999)
                {
                    sum += temp;
                    dayCount++;
                }
            }
            avg = (double)sum / dayCount;
            Console.WriteLine($"The temp average is {avg}");
            
            //q3

            int startNum1 = 1, startNum = 0, N, fibonach = 0;
            Console.WriteLine("Enter a number ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("1");


            fibonach = startNum + startNum1;

            while (N > fibonach)
            {
                fibonach = fibonach + startNum;
                startNum++;
                Console.WriteLine(fibonach);
            }

            //q4
            int x, y;
            Console.WriteLine("Enter a number ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number ");
            y = int.Parse(Console.ReadLine());

            while (x >= 0)
            {
                x = x - y;
            }
            Console.WriteLine($"{x + y}");

            //q5
            char letter, guessLetter = ' ';
            Random rnd = new Random();

            letter = (char)rnd.Next('a','z');
            //letter = 'd';
            int chance = 1;
            bool guess = false;

            while (guess == false)
            {
                Console.WriteLine("Enter a guess ,between a - z: ");
                guessLetter = char.Parse(Console.ReadLine());
                guess = guessLetter == letter;
                if (guessLetter == letter && chance == 1)
                {
                    Console.WriteLine("You won!!!\n" +
                          $"Your number of chances you used {chance}");
                    guess = true;
                }
                else if (guessLetter == letter && chance < 5)
                {
                    Console.WriteLine("You won!!!\n" +
                          $"Your number of chances you used {chance}");
                    guess = true;
                }
                else if (chance == 5)
                {
                    Console.WriteLine("You lose , you used all your chances to win\n" +
                        $"The letter is {guessLetter}");
                    guess = true;
                }
                else
                {
                    chance++;
                }
                //chance++;
            }
       
            Console.ReadLine();
        }
    }
}
