using System;
using System.Collections.Generic;


namespace homework8
{
    internal class Program
    {
        static void Main()
        {
            Taska();
        }

        /// <summary>
        /// Task Manager
        /// </summary>
        static void Taska()
        {
            List<Project> projects = new List<Project>();

            Executor petya = new Executor("Петя");
            Executor vasya = new Executor("Вася");
            Executor semen = new Executor("Семен");
            Executor dasha = new Executor("Даша");
            Executor anya = new Executor("Аня");
            Executor nastystpnv = new Executor("Настя");
            Executor grisha = new Executor("Гриша");
            Executor dimoooon = new Executor("Дима");
            Executor salavat = new Executor("Салават");
            Executor kolya = new Executor("Коля");
            Executor kolyan = new Executor("Колян");


            Customer igor = new Customer("Игорь");

            List<Executor> customers = new List<Executor>()
            {
                petya, vasya, semen, dasha, anya, nastystpnv, grisha, dimoooon, salavat, kolya, kolyan
            };

            Project project = new Project();
            project.Discription = "Приложение-напоминалка о кормежке кота";
            project.DeadLine = DateTime.Now.AddDays(50);
            project.Customer = igor;
            project.TeamLid = nastystpnv;

            Console.WriteLine(project.ToString());
            projects.Add(project);
            igor.Projects.Add(project);

            //Создаем задачи

            List<Task> tasks = new List<Task>();

            Task task1 = new Task()
            {
                Discription = "Составить список угроз",
                DeadLine = DateTime.Now.AddDays(30),
            };

            Task task2 = new Task()
            {
                Discription = "Составить график кормежки",
                DeadLine = DateTime.Now.AddDays(20),
            };

            Task task3 = new Task()
            {
                Discription = "Реализовать архитектуру приложения",
                DeadLine = DateTime.Now.AddDays(40),
            };

            Task task4 = new Task()
            {
                Discription = "Создать пользовательский интерфейс",
                DeadLine = DateTime.Now.AddDays(40),
            };

            Task task5 = new Task()
            {
                Discription = "Внедрение синхронизации между устройствами",
                DeadLine = DateTime.Now.AddDays(40),
            };

            Task task6 = new Task()
            {
                Discription = "Тестирование приложения",
                DeadLine = DateTime.Now.AddDays(45),
            };

            Task task7 = new Task()
            {
                Discription = "Реализация звукового вывода уведомлений на всех устройствах",
                DeadLine = DateTime.Now.AddDays(40),
            };

            Task task8 = new Task()
            {
                Discription = "Дополнить список угроз",
                DeadLine = DateTime.Now.AddDays(49),
            };

            Task task9 = new Task()
            {
                Discription = "Принести тимлиду воды",
                DeadLine = DateTime.Now.AddDays(49),
            };

            Task task10 = new Task()
            {
                Discription = "Подготовить к релизу",
                DeadLine = DateTime.Now.AddDays(47),
            };

            //Выдаем задачи. Семён и Салават отказались от задач, передав их Васе и Пете соотв.

            task1.Customer = project.TeamLid;
            task1.Executor = dimoooon;

            task2.Customer = semen;
            task2.Executor = vasya;

            task3.Customer = project.TeamLid;
            task3.Executor = anya;

            task4.Customer = salavat;
            task4.Executor = petya;

            task5.Customer = project.TeamLid;
            task5.Executor = dasha;

            task6.Customer = project.TeamLid;
            task6.Executor = kolya;

            task7.Customer = project.TeamLid;
            task7.Executor = kolyan;

            task8.Customer = project.TeamLid;
            task8.Executor = grisha;

            task9.Customer = project.TeamLid;
            task9.Executor = salavat;

            task10.Customer = project.TeamLid;
            task10.Executor = semen;

            tasks.AddRange(new List<Task>() { task1, task2, task3, task4, task5, task6, task7, task8, task9, task10 });
            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].Status = TaskStatuses.В_работе;
            }
            project.Tasks.AddRange(tasks);

            //Меняем статус проекта
            project.Status = ProjectStatuses.Исполнение;
            project.ChangeStatus();
            Console.WriteLine(project.ToString());
            
            //Фабрикуем отчетики
            Report report1 = new Report()
            {
                Text = "Список угроз составлен: <>",
                Date = DateTime.Now,
                Executor = task1.Executor
            };
            task1.Reports.Add(report1);

            Report report2 = new Report()
            {
                Text = "График составлен",
                Date = DateTime.Now,
                Executor = task2.Executor
            };
            task2.Reports.Add(report2);

            Report report3 = new Report()
            {
                Text = "Пользователь будет рад интерфейсу, так как он хотя бы есть",
                Date = DateTime.Now,
                Executor = task3.Executor
            };
            task3.Reports.Add(report3);

            Report report4 = new Report()
            {
                Text = "Синхронизируется даже с пылесосом",
                Date = DateTime.Now,
                Executor = task4.Executor
            };
            task4.Reports.Add(report4);

            Report report5 = new Report()
            {
                Text = "Тесты пройдены",
                Date = DateTime.Now.AddDays(-2),
                Executor = task5.Executor
            };
            task5.Reports.Add(report5);

            Report report6 = new Report()
            {
                Text = "Орет как петух в деревне",
                Date = DateTime.Now,
                Executor = task6.Executor
            };
            task6.Reports.Add(report6);

            Report report7 = new Report()
            {
                Text = "Список угроз дополнен",
                Date = DateTime.Now,
                Executor = task7.Executor
            };
            task7.Reports.Add(report7);

            Report report8 = new Report()
            {
                Text = "Тимлид не умрет от жажды",
                Date = DateTime.Now,
                Executor = task8.Executor
            };
            task8.Reports.Add(report8);

            Report report9 = new Report()
            {
                Text = "К релизу готово",
                Date = DateTime.Now,
                Executor = task9.Executor
            };
            task9.Reports.Add(report9);

            Report report10 = new Report()
            {
                Text = "Список угроз составлен: <>",
                Date = DateTime.Now,
                Executor = task10.Executor
            };
            task10.Reports.Add(report10);

            //По всем задачам сделаны отчеты, задачи на проверке
            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].Status = TaskStatuses.На_проверке;
            }
            //Задачи проверены
            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].Status = TaskStatuses.Выполнена;
            }

            if (project.CheckTaskStatuses())
            {
                //Меняем статус проекта
                project.Status = ProjectStatuses.Закрыт;
                project.ChangeStatus();
                Console.WriteLine(project.ToString());
            }
            else
            {
                Console.WriteLine("Не все задачи выполнены!");
            }
        }

        //Тут была попытка написать прогу,
        //все данные в которую бы вводил пользователь

            //static void FullTaska()
            //{

            //    Project project = new Project();

            //    bool flag = true;
            //    do
            //    {
            //        Console.WriteLine("Для завершения сеанса введите 'Выход', иначе работа с программой продолжится");
            //        string input = Console.ReadLine().ToLower();
            //        if (project.CheckTaskStatuses() || input == "выход")
            //        {
            //            flag = false;
            //        }
            //        else
            //        {

            //        }

            //        if (!project.CheckTaskStatuses())
            //        {
            //            Console.WriteLine("Не все задачи выполнены!");
            //        }
            //    }
            //    while (flag);
            //}
        }
}
