using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public static class Tasks
    {
        public static void Task1()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter three float numbers:");
            float number1, number2, number3;

            Console.Write("Number 1: ");
            var input1 = Console.ReadLine();

            Console.Write("Number 2: ");
            var input2 = Console.ReadLine();

            Console.Write("Number 3: ");
            var input3 = Console.ReadLine();

            if (float.TryParse(input1, out number1) && float.TryParse(input1, out number2) && float.TryParse(input1, out number3))
            {
                bool allNumbersInRange = (number1 >= -5 && number1 <= 5) &&
                                         (number2 >= -5 && number2 <= 5) &&
                                         (number3 >= -5 && number3 <= 5);

                if (allNumbersInRange)
                {
                    Console.WriteLine("Усі введені числа знаходяться в діапазоні [-5, 5].");
                }
                else
                {
                    Console.WriteLine("Не всі введені числа знаходяться в діапазоні [-5, 5].");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Помилка вводу");
            }
        }

        public static void Task2()
        {
            Console.WriteLine("Task 2");
            Console.Write("Number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Number 3: ");
            int num3 = int.Parse(Console.ReadLine());


            int max = Math.Max(num1, Math.Max(num2, num3));
            int min = Math.Min(num1, Math.Min(num2, num3));

            Console.WriteLine("Maximum number: " + max);
            Console.WriteLine("Minimum number: " + min);
            Console.ReadLine();
        }

        public static void Task3()
        {
            Console.WriteLine("Введіть назву помилки: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 400:
                    DisplayHttpError(HTTPError.BadRequest);
                    break;

                case 401:
                    DisplayHttpError(HTTPError.Unauthorized);
                    break;
                case 402:
                    DisplayHttpError(HTTPError.PaymentRequired);
                    break;
            }                
        }

        public static void DisplayHttpError(HTTPError error)
        {
            Console.WriteLine("Код помилки: " + (int)error);
            Console.WriteLine("Назва помилки: " + error.ToString());
        }

        public static void Task4()
        {
            Console.WriteLine("Введіть ім'я: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введіть породу: ");
            var mark = Console.ReadLine();
            Console.WriteLine("Введіть вік: ");
            var age = int.Parse(Console.ReadLine());

            var myDog = new Dog
            {
                Name = name,
                Mark = mark,
                Age = age,
            };

            Console.WriteLine(myDog);

        }
    }
}


