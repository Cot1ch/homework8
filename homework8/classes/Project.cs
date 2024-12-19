using System;
using System.Collections.Generic;


namespace homework8
{
    internal class Project
    {
        string _Discription;
        DateTime _DeadLine;
        Customer _Customer;
        Executor _TeamLid;
        List<Task> _Tasks;
        ProjectStatuses _Status;

        public Project()
        {
            _Tasks = new List<Task>();
            _Status = ProjectStatuses.Проект;
        }

        public Project(string discription, DateTime deadLine, Customer customer, Executor teamLid, List<Task> tasks)
        {
            _Discription = discription;
            _DeadLine = deadLine;
            _Customer = customer;
            _TeamLid = teamLid;
            _Tasks = tasks;
            _Status = ProjectStatuses.Проект;
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
        public List<Task> Tasks
        {
            get { return _Tasks; }
            set { _Tasks = value; }
        }
        public ProjectStatuses Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public bool CheckTaskStatuses()
        {
            foreach (Task task in _Tasks)
            {
                if (task.Status != TaskStatuses.Выполнена)
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string tasks = String.Empty;
            foreach (Task task in _Tasks)
            {
                tasks += task.ToString();
            }
            string retStr = $"======>\nПроект: {Discription}\nДедлайн: {DeadLine}\nЗаказчик: {Customer.Name}\nТимлид: {TeamLid.Name}\nЗадачи: {tasks}\nСтатус: {Status}";

            return retStr;
        }
        public void ChangeStatus()
        {
            Console.WriteLine($"\t\t\t\t\tСтатус проекта изменён! Новый статус: {Status}");
        }
        public DateTime EnterDate()
        {
            DateTime date = DateTime.Now;
            bool flag = true;
            Console.WriteLine("Введите дату в формате dd.MM.yyyy");
            do
            {
                if (DateTime.TryParse(Console.ReadLine(), out DateTime resultDate) && resultDate >= DateTime.Now)
                {
                    date = resultDate;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Введите реальную дату в формате dd.MM.yyyy");
                }
            }
            while (flag);
            return date;
        }
    }
}
