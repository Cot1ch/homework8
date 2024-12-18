using System.Collections.Generic;


namespace homework8
{
    internal class Customer : Employee
    {
        List<Task> _Tasks;
        List<Report> _Reports;
        public Customer(string name)
        {
            Name = name;
            _Tasks = new List<Task>();
            _Reports = new List<Report>();
        }
        public List<Report> Reports
        {
            get { return _Reports; }
            set { _Reports = value; }
        }
        public List<Task> Tasks
        {
            get { return _Tasks; }
            set { _Tasks = value; }
        }
    }
}
