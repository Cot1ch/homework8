using System;
using System.Collections.Generic;


namespace homework8
{
    internal class Task
    {
        #region Fields
        string _Discription;
        DateTime _DeadLine;
        Employee _Customer;
        Executor _Executor;
        TaskStatuses _Status;
        Report _Report;
        #endregion

        #region Constructors
        public Task(string discription, DateTime deadLine, Employee customer, Executor executor, TaskStatuses status, Report report)
        {
            _Discription = discription;
            _DeadLine = deadLine;
            _Customer = customer;
            _Executor = executor;
            _Status = status;
            _Report = report;
        }
        public Task()
        {
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
        public Employee Customer
        {
            get { return _Customer; }
            set { _Customer = value; }
        }
        public Executor Executor
        {
            get { return _Executor; }
            set { _Executor = value; }
        }
        public TaskStatuses Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public Report report
        {
            get { return _Report; }
            set { _Report = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Возвращает информацию о задаче
        /// </summary>
        /// <returns>Строка string</returns>
        public override string ToString()
        {
            string retStr = String.Empty;

            retStr += "\n========================\n";
            retStr += $"Описание:\n{Discription}\n";
            retStr += $"Дедлайн: {DeadLine}\n";
            retStr += $"Заказчик: {Customer.Name}\n";
            retStr += $"Исполнитель: {Executor.Name}\n";
            retStr += $"Статус задачи: {Status}\n";
            if (report != null)
            {
                retStr += $"Отчет:\n";
                retStr += report.ToString();
            }
            retStr += "========================\n";

            return retStr;
        }
        #endregion
    }
}
