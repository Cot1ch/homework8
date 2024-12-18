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

        static void Taska()
        {
            Project project = new Project();
            project.Discription = "Task Manager";
            DateTime.TryParse("22/12/2024", out DateTime result);
            project.DeadLine = result;
            project.Customer = new Customer("Петя");
            project.TeamLid = new Executor("Вася");


            Task task1 = new Task()
            {
                Discription = "",
                DeadLine = Task.EnterDate(),
                Customer = project.Customer,
                Executor = project.TeamLid,
                Status = TaskStatuses.Назначена
            };
            project.Tasks.Add(task1);


            Console.WriteLine(project.ToString());
        }
    }
}
