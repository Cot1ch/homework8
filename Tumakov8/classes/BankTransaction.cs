using System;


namespace Tumakov8
{
    internal class BankTransaction
    {
        #region Fields
        DateTime _Time;
        decimal _Amount;
        #endregion

        #region Properties
        public DateTime Time
        { 
            get { return _Time; } 
        }
        public decimal Amount
        { 
            get { return _Amount; } 
        }
        #endregion

        #region Constructors
        public BankTransaction(decimal amount)
        {
            _Amount = amount;
            _Time = DateTime.Now;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Метод возвращает информацию об операции со счётом:  
        /// Операция : сумма. Время проведения операции
        /// </summary>
        /// <returns>Строка string</returns>
        public string Info()
        {
            return $"{(_Amount < 0 ? "Снято" : "Положено")}: {Math.Abs(_Amount)} рублей.\nВремя: {_Time}\n";
        }
        #endregion
    }
}
