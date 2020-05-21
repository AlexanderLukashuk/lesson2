using System;

namespace lesson2_1
{
    class PracticalWork
    {
        static void Main(string[] args)
        {
            string input;
            // 1 задание
            Console.WriteLine("***** Task 1 ******");
            double x, y;
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            x = double.Parse(input);
            y = 7 * Math.Pow(x, 2) - 3 * x + 4;
            Console.WriteLine($"y =  {y}");

            // 2) задание
            Console.WriteLine("***** Task 2 ******");
            double radius, circumference;
            Console.Write("Enter radius: ");
            input = Console.ReadLine();
            radius = double.Parse(input);
            circumference = 2 * Math.PI * radius;
            Console.WriteLine($"Circunference = {circumference}");

            // 3) задание
            Console.WriteLine("***** Task 3 ******");
            int centimeters, meters;
            Console.Write("Enter centimeters: ");
            input = Console.ReadLine();
            centimeters = int.Parse(input);
            meters = centimeters / 100;
            Console.WriteLine($"Meters: {meters}");

            // 4) задание
            Console.WriteLine("***** Task 4 ******");
            int days = 234;
            int weeksCount;
            weeksCount = days / 7;
            Console.WriteLine("Weeks: {0}", weeksCount);

            // 5) задание
            Console.WriteLine("***** Task 5 ******");
            int number = 0;
            int numberOfTens, numberOfUnits, amount, multiplicationResult;
            while (true)
            {
                Console.Write("Enter two-digit number: ");
                input = Console.ReadLine();
                number = int.Parse(input);

                if (number > 9 && number < 100)
                {
                    break;
                }
            }

            numberOfTens = number / 10;
            numberOfUnits = number % 10;
            amount = numberOfTens + numberOfUnits;
            multiplicationResult = numberOfTens * numberOfUnits;
            Console.WriteLine("Number of tens =  {0}", numberOfTens);
            Console.WriteLine("Number of units = {0}", numberOfUnits);
            Console.WriteLine("Amount = {0}", amount);
            Console.WriteLine("Multiplication result = {0}", multiplicationResult);

            // 6) задание
            Console.WriteLine("***** Task 6 ******");
            int fourDigitNumber = -1;
            while (true)
            {
                Console.Write("Enter four-digit number: ");
                input = Console.ReadLine();
                fourDigitNumber = int.Parse(input);

                if (fourDigitNumber > 999 && fourDigitNumber < 10000)
                {
                    break;
                }
            }

            int tmp1 = fourDigitNumber;
            int tmp2;
            amount = 0;
            multiplicationResult = 1;
            while (tmp1 > 0)
            {
                tmp2 = tmp1 % 10;
                amount += tmp2;
                multiplicationResult *= tmp2;
                tmp1 = (tmp1 - tmp2) / 10;
            }

            Console.WriteLine("Amount = {0}", amount);
            Console.WriteLine("Multiplication result = {0}", multiplicationResult);

            // 7) задание
            Console.WriteLine("***** Task 7 ******");
            int xNumber = 456;
            int temp1 = xNumber % 10;
            int temp2 = (xNumber - temp1) / 10 % 10;
            xNumber /= 100;
            xNumber *= 100;
            xNumber = xNumber + temp1 * 10 + temp2;

            Console.WriteLine($"X = {xNumber}");

            // 8) задание
            Console.WriteLine("***** Task 8 ******");
            bool X = true, Y = true;

            if (!X && !Y)
            {
                Console.WriteLine("Working 8.a");
            }

            if (X || (!X && Y))
            {
                Console.WriteLine("Working 8.b");
            }

            if ((!X && Y) || Y)
            {
                Console.WriteLine("Working 8.c");
            }

            Y = false;

            if (!X && !Y)
            {
                Console.WriteLine("Working 8.a");
            }

            if (X || (!X && Y))
            {
                Console.WriteLine("Working 8.b");
            }

            if ((!X && Y) || Y)
            {
                Console.WriteLine("Working 8.c");
            }

            Y = true;
            X = false;

            if (!X && !Y)
            {
                Console.WriteLine("Working 8.a");
            }

            if (X || (!X && Y))
            {
                Console.WriteLine("Working 8.b");
            }

            if ((!X && Y) || Y)
            {
                Console.WriteLine("Working 8.c");
            }

            Y = false;

            if (!X && !Y)
            {
                Console.WriteLine("Working 8.a");
            }

            if (X || (!X && Y))
            {
                Console.WriteLine("Working 8.b");
            }

            if ((!X && Y) || Y)
            {
                Console.WriteLine("Working 8.c");
            }
        }
    }
}
