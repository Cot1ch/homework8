using System.Collections.Generic;


namespace homework8
{
    internal class Executor : Employee
    {
        private Dictionary<Task, Report> _TaskAndReports;
        public Executor(string name)
        {
            Name = name;
            Dictionary<Task, Report> _Tasks = new Dictionary<Task, Report>();
        }

        public Dictionary<Task, Report> TaskAndReports
        {
            get { return _TaskAndReports; }
            set { _TaskAndReports = value; }
        }                 
    }
}
