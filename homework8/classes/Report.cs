using System;


namespace homework8
{
    internal class Report
    {
        string _Text;
        DateTime _Date;
        Executor _Executor;

        public Report(string text, DateTime date, Executor executor)
        {
            _Text = text;
            _Date = date;
            _Executor = executor;
        }
        public Report()
        {

        }
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public Executor Executor
        {
            get { return _Executor; }
            set { _Executor = value; }
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

        public override string ToString()
        {
            return $">>Текст отчёта: {Text}\n>>Дата: {Date} Ответственный: {Executor.Name}\n";
        }
    }
}
