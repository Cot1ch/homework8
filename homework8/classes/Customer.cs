using System.Collections.Generic;


namespace homework8
{
    internal class Customer : Employee
    {
        List<Project> _Projects;
        public Customer(string name)
        {
            Name = name;
            _Projects = new List<Project>();
        }
        public List<Project> Projects
        {
            get { return _Projects; }
            set { _Projects = value; }
        }
    }
}
