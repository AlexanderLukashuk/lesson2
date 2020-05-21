using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) задание
            Console.WriteLine("***** task 1 *****");
            int num1, num2, num3;
            string input;
            Console.Write("Enter first number: ");
            input = Console.ReadLine();
            num1 = int.Parse(input);
            Console.Write("Enter second number: ");
            input = Console.ReadLine();
            num2 = int.Parse(input);
            Console.Write("Enter third number: ");
            input = Console.ReadLine();
            num3 = int.Parse(input);

            Console.WriteLine($"{num1}  {num2}  {num3}");

            // 2) задание
            Console.WriteLine("***** task 2 *****");
            num1 = 5;
            num2 = 10;
            num3 = 21;

            Console.WriteLine($"{num1}");
            Console.WriteLine($"{num2}");
            Console.WriteLine($"{num3}");

            // 3) задание
            Console.WriteLine("***** task 3 *****");
            int centimeters, meters;
            Console.Write("Enter centimeters: ");
            input = Console.ReadLine();
            centimeters = int.Parse(input);
            meters = centimeters / 100;
            Console.WriteLine($"Meters: {meters}");

            // 4) задание
            Console.WriteLine("***** task 4 *****");
            int days = 234;
            int weeksCount;
            weeksCount = days / 7;
            Console.WriteLine("Weeks: {0}", weeksCount);

            // 5) задание
            Console.WriteLine("***** task 5 *****");
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
            Console.WriteLine("***** task 6 *****");
            bool A = true;
            bool B = false;
            bool C = false;

            if (A || B)
            {
                Console.WriteLine("Working 6.a");
            }

            if (A && B)
            {
                Console.WriteLine("Working 8.b");
            }

            if (B || C)
            {
                Console.WriteLine("Working 8.c");
            }

            // 7) задание
            Console.WriteLine("***** task 7 *****");
            double circleRadius, squareSide;
            double areaOfCircle, areaOfSquare;

            Console.Write("Enter radius: ");
            input = Console.ReadLine();
            circleRadius = double.Parse(input);

            Console.Write("Enter side of a square: ");
            input = Console.ReadLine();
            squareSide = double.Parse(input);

            areaOfCircle = Math.Pow(circleRadius, 2) * Math.PI;
            areaOfSquare = Math.Pow(squareSide, 2);

            if (areaOfSquare > areaOfCircle)
            {
                Console.WriteLine($"Area of Square({areaOfSquare}) > Area of circle({areaOfCircle})");
            }
            else
            {
                Console.WriteLine($"Area of circle({areaOfCircle}) > Area of Square({areaOfSquare})");
            }

            // 8) задание
            Console.WriteLine("***** task 8 *****");
            double mass1, mass2, volume1, volume2;
            double density1, density2;

            Console.Write("Enter mass for the first body: ");
            input = Console.ReadLine();
            mass1 = double.Parse(input);

            Console.Write("Enter mass for the second body: ");
            input = Console.ReadLine();
            mass2 = double.Parse(input);

            Console.Write("Enter volume for the first body: ");
            input = Console.ReadLine();
            volume1 = double.Parse(input);

            Console.Write("Enter volume for the second body: ");
            input = Console.ReadLine();
            volume2 = double.Parse(input);

            density1 = mass1 * volume1;
            density2 = mass2 * volume2;

            Console.WriteLine($"First body density = {density1}");
            Console.WriteLine($"Second body densisty = {density2}");

            // 9) задание
            Console.WriteLine("***** task 9 *****");
            double U1, U2, R1, R2, I1, I2;

            Console.Write("Enter U1: ");
            input = Console.ReadLine();
            U1 = double.Parse(input);

            Console.Write("Enter U2: ");
            input = Console.ReadLine();
            U2 = double.Parse(input);

            Console.Write("Enter R1: ");
            input = Console.ReadLine();
            R1 = double.Parse(input);

            Console.Write("Enter R2: ");
            input = Console.ReadLine();
            R2 = double.Parse(input);

            I1 = U1 / R1;
            I2 = U2 / R2;

            if (I1 > I2)
            {
                Console.WriteLine("I1 > I2");
            }
            else
            {
                Console.WriteLine("I2 > I1");
            }

            // 10) задание
            Console.WriteLine("***** task 10 *****");

            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine($"{i}");
            }

            int b;
            while (true)
            {
                Console.Write("Enter b: ");
                input = Console.ReadLine();
                b = int.Parse(input);

                if (b > 10)
                {
                    break;
                }
            }

            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine($"{Math.Pow(i, 2)}");
            }

            int a;
            while (true)
            {
                Console.Write("Enter a: ");
                input = Console.ReadLine();
                a = int.Parse(input);

                if (a < 50)
                {
                    break;
                }
            }

            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine($"{Math.Pow(i, 3)}");
            }

            Console.Write("Enter a: ");
            input = Console.ReadLine();
            a = int.Parse(input);

            Console.Write("Enter b: ");
            input = Console.ReadLine();
            b = int.Parse(input);

            for (int i = a; i <= b; i++)
            {
                Console.Write($"{i} ");
            }





        }
    }
}
