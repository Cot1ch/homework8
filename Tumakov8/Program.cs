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
        /// <summary>
        /// Упражнение 9.1. 
        /// В классе банковский счет, созданном в предыдущих упражнениях, удалить методы заполнения полей.
        /// Вместо этих методов создать конструкторы. Переопределить конструктор по умолчанию, 
        /// создать конструктор для заполнения поля баланс, конструктор для заполнения поля тип банковского счета,
        /// конструктор для заполнения баланса и типа банковского счета.
        /// Каждый конструктор должен вызывать метод, генерирующий номер счета.
        /// </summary>
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

        /// <summary>
        /// Упражнение 9.2. 
        /// Создать новый класс BankTransaction, который будет хранить информацию о всех банковских операциях.
        /// При изменении баланса счета создается новый объект класса BankTransaction, 
        /// который содержит текущую дату и время, добавленную или снятую со счета сумму. 
        /// Поля класса должны быть только для чтения (readonly). Конструктору класса передается один параметр – сумма.
        /// В классе банковский счет добавить закрытое поле типа System.Collections.Queue, которое будет хранить объекты класса BankTransaction 
        /// для данного банковского счета; изменить методы снятия со счета и добавления на счет так,
        /// чтобы в них создавался объект класса BankTransaction и каждый объект добавлялся в переменную типа System.Collections.Queue.
        /// </summary>
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
                    Console.WriteLine("Tакого ответа нет");
                }
            }
            while (flag2);
            
            bankAccount1.PrintInfo();
            bankAccount2.PrintInfo();
        }

        /// <summary>
        /// Упражнение 9.3. 
        /// В классе банковский счет создать метод Dispose, который данные о проводках из очереди запишет в файл.
        /// Не забудьте внутри метода Dispose вызвать метод GC.SuppressFinalize, который сообщает системе, 
        /// что она не должна вызывать метод завершения для указанного объекта.
        /// </summary>
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
                    Console.WriteLine("ахаха, смешно. Но такого ответа нет");
                }
            }
            while (flag2);

            Console.WriteLine(bankAccount1.ToString());
            Console.WriteLine(bankAccount2.ToString());
        }

        /// <summary>
        /// Домашнее задание 9.1. 
        /// В класс Song (из домашнего задания 8.2) добавить следующие конструкторы:
        /// 1) параметры конструктора – название и автор песни, указатель на предыдущую песню инициализировать null.
        /// 2) параметры конструктора – название, автор песни, предыдущая песня.
        /// Добавить конструктор по умолчанию
        /// </summary>
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
        
        /// <summary>
        /// Метод возвращает введенныю сумму типа decimal. Ввод до победного
        /// </summary>
        /// <returns>Число типа decimal</returns>
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
