using System;


namespace Tumakov8
{
    internal class BankTransaction
    {
        DateTime _Time;
        decimal _Amount;

        public DateTime Time
        { 
            get { return _Time; } 
        }
        public decimal Amount
        { 
            get { return _Amount; } 
        }

        public BankTransaction(decimal amount)
        {
            _Amount = amount;
            _Time = DateTime.Now;
        }

        public string Info()
        {
            return $"{(_Amount < 0 ? "Снято" : "Положено")}: {Math.Abs(_Amount)} рублей.\nВремя: {_Time}\n";
        }
    }
}
