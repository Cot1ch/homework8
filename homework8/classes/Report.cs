using System;


namespace homework8
{
    internal class Report
    {
        #region Fields
        string _Text;
        DateTime _Date;
        Executor _Executor;
        #endregion

        #region Constructors
        public Report(string text, DateTime date, Executor executor)
        {
            _Text = text;
            _Date = date;
            _Executor = executor;
        }
        public Report()
        { }
        #endregion

        #region Properties
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
        #endregion

        #region Methods

        /// <summary>
        /// Метод возвращает информацию об отчете. 
        /// Текст /Дата /Ответственный
        /// </summary>
        /// <returns>Строка string</returns>
        public override string ToString()
        {
            return $">>Текст отчёта: {Text}\n>>Дата: {Date} Ответственный: {Executor.Name}\n";
        }
        #endregion
    }
}
