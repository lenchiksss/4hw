using System.Text;

namespace hw4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Employee employee1 = new Employee("Петро", 3000);
            Employee employee2 = new Employee("Марія", 2500);

            employee1 += 100;
            employee2 -= 200;

            if (employee1 == employee2)
            {
                Console.WriteLine("Зарплати працівників рівні.");
            }
            else
            {
                Console.WriteLine("Зарплати працівників не рівні.");
            }

            if (employee1 > employee2)
            {
                Console.WriteLine("Співробітник employee1 має вищу зарплату, ніж працівник employee2.");
            }
            else if (employee1 < employee2)
            {
                Console.WriteLine("Співробітник employee1 має нижчу зарплату, ніж працівник employee2.");
            }
            else
            {
                Console.WriteLine("Зарплати працівників рівні.");
            }

            bool equals = employee1.Equals(employee2);
            Console.WriteLine(equals);

            Console.WriteLine();

            Matrix matrix1 = new Matrix(2, 2);
            matrix1[0, 0] = 5;
            matrix1[0, 1] = 4;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 2;

            Matrix matrix2 = new Matrix(2, 2);
            matrix2[0, 0] = 5;
            matrix2[0, 1] = 4;
            matrix2[1, 0] = 3;
            matrix2[1, 1] = 2;

            Matrix result1 = matrix1 + matrix2;
            Matrix result2 = matrix1 - matrix2;
            Matrix result3 = matrix1 * matrix2;
            Matrix result4 = matrix1 * 3;

            Console.WriteLine("Додавання:");
            Print(result1);
            Console.WriteLine("Віднімання:");
            Print(result2);
            Console.WriteLine("Множення:");
            Print(result3);
            Console.WriteLine("Множення на число:");
            Print(result4);

            bool equals3 = matrix1.Equals(matrix2);
            Console.WriteLine(equals3);

            static void Print(Matrix matrix)
            {
                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix.Cols; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            City city1 = new City("Місто А", 10000);
            City city2 = new City("Місто Б", 50000);

            city1 += 50000;
            city2 -= 20000;

            if (city1 == city2)
            {
                Console.WriteLine("Населення міст рівне.");
            }
            else
            {
                Console.WriteLine("Населення міст не рівне.");
            }

            if (city1 > city2)
            {
                Console.WriteLine("Населення city1 більше, ніж населення city2.");
            }
            else if (city1 < city2)
            {
                Console.WriteLine("Населення city1 менше, ніж населення city2.");
            }
            else
            {
                Console.WriteLine("Населення міст рівне.");
            }

            bool equals1 = city1.Equals(city2);
            Console.WriteLine(equals1);

            Console.WriteLine();

            CreditCard card1 = new CreditCard("1234567890123456", 555, 100);
            CreditCard card2 = new CreditCard("9876543210987654", 777, 150000);

            if (card1 == 100)
            {
                Console.WriteLine("CVC коди карток співпадають.");
            }
            else
            {
                Console.WriteLine("CVC коди карток не співпадають.");
            }

            card1 += 5000;
            card2 -= 300;

            if (card1 == card2)
            {
                Console.WriteLine("Баланс однаковий.");
            }
            else
            {
                Console.WriteLine("Баланс не однаковий.");
            }

            if (card1 > card2)
            {
                Console.WriteLine("Баланс card1 більший, ніж баланс card2.");
            }
            else if (card1 < card2)
            {
                Console.WriteLine("Баланс card1 менше, ніж баланс card2.");
            }
            else
            {
                Console.WriteLine("Баланс однаковий.");
            }

            bool equals2 = card1.Equals(card2);
            Console.WriteLine(equals2);
        }
    }
}