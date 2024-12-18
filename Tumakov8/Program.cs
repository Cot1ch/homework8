using System;
using System.Collections.Generic;


namespace Tumakov8
{
    internal class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        static void Task1()
        {
            Console.WriteLine("Упражнение 9.1\n");

            BankAccount1 account1 = new BankAccount1();
            account1.PrintInfo();
            BankAccount1 account2 = new BankAccount1(100000);
            account2.PrintInfo();
            BankAccount1 account3 = new BankAccount1(BankAccount1.Account.Сберегательный);
            account3.PrintInfo();
            BankAccount1 account4 = new BankAccount1(200000, BankAccount1.Account.Сберегательный);
            account4.PrintInfo();
        }

        static void Task2()
        {
            Console.WriteLine("Упражнение 9.2");

            BankAccount2 bankAccount1 = new BankAccount2(10000000, BankAccount2.Account.Текущий);
            BankAccount2 bankAccount2 = new BankAccount2();

            bankAccount1.PrintInfo();
            bankAccount2.PrintInfo();

            bool flag2 = true;
            do
            {
                Console.WriteLine(">\nВыберите дальнейшее действие: выход/новый перевод\n>");
                string input = Console.ReadLine().ToLower();
                if (input == "выход")
                {
                    flag2 = false;
                }
                else if (input.StartsWith("новый"))
                {
                    Console.WriteLine("Введите сумму перевода");
                    if (bankAccount2.MoneyTransfer(bankAccount1, GetAmount()))
                    {
                        Console.WriteLine("===>Перевод выполнен<===");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Не хватает средств");
                    }
                }
                else
                {
                    Console.WriteLine("ахаха, смешно. Tакого ответа нет");
                }
            }
            while (flag2);
            
            bankAccount1.PrintInfo();
            bankAccount2.PrintInfo();
        }

        static void Task3()
        {
            Console.WriteLine("Упражнение 9.3");

            BankAccount3 bankAccount1 = new BankAccount3(10000000, BankAccount3.Account.Текущий);
            BankAccount3 bankAccount2 = new BankAccount3();

            Console.WriteLine(bankAccount1.ToString());
            Console.WriteLine(bankAccount2.ToString());

            bool flag2 = true;
            do
            {
                Console.WriteLine(">\nВыберите дальнейшее действие: выход/новый перевод\n>");
                string input = Console.ReadLine().ToLower();
                if (input == "выход")
                {
                    flag2 = false;
                }
                else if (input.StartsWith("новый"))
                {
                    Console.WriteLine("Введите сумму перевода");
                    if (bankAccount2.MoneyTransfer(bankAccount1, GetAmount()))
                    {
                        Console.WriteLine("===>Перевод выполнен<===");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Не хватает средств");
                    }
                }
                else
                {
                    Console.WriteLine("ахаха, смешно. Tакого ответа нет");
                }
            }
            while (flag2);

            Console.WriteLine(bankAccount1.ToString());
            Console.WriteLine(bankAccount2.ToString());
        }

        static void Task4()
        {
            Console.WriteLine("\nДомашнее задание 9.1\n");

            List<Song> songs = new List<Song>
            {
                new Song() { Name = "Seek and Destroy", Author = "Metallica", Previous = null }
            };
            songs.Add(new Song() { Name = "Nothing else Matters", Author = "Metallica", Previous = songs[0] });
            songs.Add(new Song() { Name = "Papercut", Author = "Linkin Park", Previous = songs[1] });
            songs.Add(new Song() { Name = "From the Inside", Author = "Linkin Park"});
            songs.Add(new Song());
            
            
            foreach (Song s in songs)
            {
                Console.WriteLine(s.Title());
            }

            if (songs[1].Equals(songs[1].Previous))
            {
                Console.WriteLine("Песни идентичны");
            }
            else
            {
                Console.WriteLine(">\nКомпозиции не идентичны\n>");
            }
        }

        static decimal GetAmount()
        {
            bool flag = true;
            decimal number;
            do
            {
                bool isNumber = decimal.TryParse(Console.ReadLine(), out number);
                if (isNumber && number >= 0)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести неотрицательное число");
                }
            }
            while (flag);

            return number;
        }
    }
}
