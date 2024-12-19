using System;
using System.Collections.Generic;


namespace homework8
{
    internal class Project
    {
        #region Fields
        string _Discription;
        DateTime _DeadLine;
        Customer _Customer;
        Executor _TeamLid;
        List<Task> _Tasks;
        ProjectStatuses _Status;
        #endregion

        #region Constructors
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
        #endregion

        #region Properties
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
        #endregion

        #region Methods
        /// <summary>
        /// Проверяет, все ли задачи проекиы выполнены
        /// </summary>
        /// <returns>Значение типа bool</returns>
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

        /// <summary>
        /// Метод возвращает информацию о проекте
        /// </summary>
        /// <returns>Строка string</returns>
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

        /// <summary>
        /// Выводит новый статус проекта
        /// </summary>
        public void ChangeStatus()
        {
            Console.WriteLine($"\n\n\nСтатус проекта изменён! Новый статус: {Status}\n\n\n");
        }
        #endregion
    }
}
