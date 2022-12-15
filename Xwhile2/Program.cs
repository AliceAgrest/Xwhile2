
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
            //q1
        //
        public static int NumberInNumber(int num, int inNum)
        {
            int count = 0;
            int oneNum = 0;

            while (num > 0)
            {
                oneNum = num % 10;
                if (oneNum == inNum)
                    count++;
                num /= 10;
            }

            return count;
        }

        //q2
        //
        public static int RndNum(int num1, int num2)
        {
            int rnd1;
            Random rnd = new Random();
            rnd1 = rnd.Next(num1 , num2);

            return rnd1;
        }

        //q3
        //
        public static int EvenNumbers (int num)
        {
            int evenCount = 0;
            int digitNumber;

            for(int i = 0; i < num; i++)
            {
                digitNumber = num % 10;

                if (digitNumber % 2 == 0)
                    evenCount++;

                num /= 10;
            }
            return evenCount;
        }

        public static int DividesNum (int num1,int num2)
        {
            int i = 2;
            int min = Math.Min(num1, num2);

            while((num1 % i != 0) && (num2 % i != 0) && (i <= min))
            {
                i++;
            }
            if ((num1 % i != 0) && (num2 % i != 0))
                i = -1;

            return i;
        }
        static void Main(string[] args)
        {
            //q1
            /*int digit;

            digit = NumberInNumber(1024 , 0);
            Console.WriteLine(digit);

            digit = NumberInNumber(33546, 3);
            Console.WriteLine(digit);

            digit = NumberInNumber(1457 , 0);
            Console.WriteLine(digit);

            digit = NumberInNumber(10000 , 1);
            Console.WriteLine(digit);
            
            //q2
            int num1 = 1, num2 = 1;

            while (num1 > 0 && num2 > 0)
            {
                Console.WriteLine("Enter a number: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter another number: ");
                num2 = int.Parse(Console.ReadLine());

                int show = RndNum(num1, num2);
                Console.WriteLine(show);
                int show = RndNum(num1, num2);
                Console.WriteLine(show);
                int show = RndNum(num1, num2);
                Console.WriteLine(show);
                int show = RndNum(num1, num2);
                Console.WriteLine(show);
                int show = RndNum(num1, num2);
                Console.WriteLine(show);

                for(int i = 0; i < 5;i++)
                {
                    int show = RndNum(num1, num2);
                    Console.WriteLine(show);

                    RndNum(num1, num2);
                }
            }
            //q3
            int num1, num = 1;

            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            int show1 = EvenNumbers(num1);

            while (num > 0)
            {
                Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());

                int show = EvenNumbers(num);

                if (num > num1)
                    num1 = num;
            }
            Console.WriteLine(num1);
            */
            //q4
            int num1, num2;

            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            num2 = int.Parse(Console.ReadLine());

            int show = DividesNum(num1, num2);
            Console.WriteLine(show);

            Console.ReadLine();
            
            Console.ReadLine();
        }
    }
}
