using System.Collections.Generic;


namespace homework8
{
    internal class Executor : Employee
    {
        List<Task> _Tasks;
        List<Project> _Projects;

        public Executor(string name, List<Task> tasks, List<Project> projects)
        {
            Name = name;
            _Tasks = tasks;
            _Projects = projects;
        }
        public Executor(string name)
        {
            Name = name;
            _Tasks = new List<Task>();
            _Projects = new List<Project>();
        }

        public List<Task> Tasks
        {
            get { return _Tasks; }
            set { _Tasks = value; }
        }
        public List<Project> Projects
        {
            get { return _Projects; }
            set { _Projects = value; }
        }
    }
}
