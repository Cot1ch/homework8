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
            
        }
    }

    internal class Project
    {
        string _Discription;
        DateTime _DeadLine;
        Customer _Customer;
        Executor _TeamLid;
        List<string> _Tasks;
        ProjectStatuses _Status;

        public Project(string discription, DateTime deadLine, Customer customer, Executor teamLid, List<string> tasks, ProjectStatuses status)
        {
            _Discription = discription;
            _DeadLine = deadLine;
            _Customer = customer;
            _TeamLid = teamLid;
            _Tasks = tasks;
            _Status = status;
        }
        public string Discription
        {
            get { return _Discription; }
            set { _Discription = value; }
        }
        public DateTime DeadLine
        {
            get { return _DeadLine; }
            set { _DeadLine = value; }
        }
        public Customer Customer
        {
            get { return _Customer; }
            set { _Customer = value; }
        }
        public Executor TeamLid
        {
            get { return _TeamLid; }
            set { _TeamLid = value; }
        }
        public List<string> Tasks
        { 
            get { return _Tasks; } 
            set { _Tasks = value; }
        }
        public string Status
        {
            get { return Status; }
            set { Status = value; }
        }

        public override string ToString()
        {
            string retStr = $"======>\n{Discription}\n Дедлайн: {DeadLine}\nЗаказчик: {Customer}\nТимлид: {TeamLid}\nЗадачи: {Tasks}\nСтатус: {Status}";

            return "";
        }
    }
    internal abstract class Person
    {
        string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
    }
    internal class Customer : Person 
    { 
        List<Task> _Tasks;

        public Customer(string name, List<Task> tasks)
        {
            Name = name;
            _Tasks = tasks;
        }
        public List<Task> Tasks
        {
            get { return _Tasks; }
            set { _Tasks = value; }
        }

        
    }
    internal class Executor : Person
    {
        List<Task> _Tasks;

        public Executor(string name, List<Task> tasks)
        {
            Name = name;
            _Tasks = tasks;
        }

        public List<Task> Tasks
        {
            get { return _Tasks; }
            set { _Tasks = value; }
        }

    }

    internal class Task
    {
        string _Discription;
        DateTime _DeadLine;
        Customer _Customer;
        Executor _Executor;
        TaskStatuses _Status;
        List<Report> _Reports;
    }    
    internal class Report
    {
        string _Text;
        DateTime _Date;
        string _Executor;
    }
    enum ProjectStatuses
    {
        Проект, 
        Исполнение, 
        Закрыт
    }
    enum TaskStatuses
    {
        Назначена, 
        В_работе, 
        На_проверке, 
        Выполнена
    }
}
