using System;
using System.Collections.Generic;
using System.IO;


namespace Tumakov8
{
    internal class BankAccount3
    {
        #region Fields
        private Guid _Id;
        private decimal _Balance;
        private Account _account;
        private Queue<BankTransaction> _Queue;
        #endregion

        #region Constructors

        public BankAccount3(decimal balance, Account account)
        {
            _account = account;
            _Balance = balance;
            _Id = Guid.NewGuid();
            _Queue = new Queue<BankTransaction>();
        }
        public BankAccount3()
        {
            _account = Account.Текущий;
            _Balance = 0;
            _Id = Guid.NewGuid();
            _Queue = new Queue<BankTransaction>();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Выводит информацию о банковском счёте
        /// </summary>
        /// <returns>-</returns>
        public override string ToString()
        {
            string retStr = $"\nНомер счёта: {_Id}";
            retStr += $"\nБаланс: {_Balance} рублей";
            retStr += $"\nТип: {_account}\n";

            foreach (BankTransaction transaction in _Queue)
            {
                retStr += transaction.Info();
            }
            return retStr;
        }

        /// <summary>
        /// Добавляет введённую сумму к сумме на счету. 
        /// </summary>
        /// <returns>-</returns>
        public void Put(decimal moneyy)
        {
            BankTransaction bt = new BankTransaction(moneyy);
            Dispose(bt);
            _Queue.Enqueue(bt);

            _Balance += moneyy;
        }

        /// <summary>
        /// Проверяет, можно ли снять введённую сумму.
        /// Если да, то вычитает её со счёта, 
        /// в противном случае уведомляет пользователя о невозможности операции.
        /// </summary>
        /// <returns>Значение типа bool</returns>
        public bool Remove(decimal moneyy)
        {
            if (moneyy <= _Balance)
            {
                BankTransaction bt = new BankTransaction(-moneyy);
                Dispose(bt);
                _Queue.Enqueue(bt);

                _Balance -= moneyy;
                return true;
            }
            return false;
        }
        public bool MoneyTransfer(BankAccount3 bankAccount, decimal moneyy)
        {
            if (bankAccount.Remove(moneyy))
            {
                this.Put(moneyy);
                return true;
            }
            return false;
        }
        #endregion
        public void Dispose(BankTransaction transaction)
        {
            string str = $"===========\nНомер счёта: {_Id}\n{transaction.Info()}";
            File.AppendAllText($"{Directory.GetCurrentDirectory()}//..//..//..//resourses//out.txt", str);

            GC.SuppressFinalize(this);
        }

        public enum Account
        {
            Текущий, Сберегательный
        }
    }
}
