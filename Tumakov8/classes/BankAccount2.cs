using System;
using System.Collections.Generic;

namespace Tumakov8
{
    internal class BankAccount2
    {
        #region Fields
        private Guid _Id;
        private decimal _Balance;
        private Account _account;
        private Queue<BankTransaction> _Queue;
        #endregion

        #region Constructors

        public BankAccount2(decimal balance, Account account)
        {
            _account = account;
            _Balance = balance;
            _Id = Guid.NewGuid();
            _Queue = new Queue<BankTransaction>();
        }
        public BankAccount2()
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
        public void PrintInfo()
        {
            Console.WriteLine($"\nНомер счёта: {_Id}");
            Console.WriteLine($"Баланс: {_Balance} рублей");
            Console.WriteLine($"Тип: {_account}");
            foreach (BankTransaction transaction in _Queue)
            {
                Console.WriteLine(transaction.Info());
            }
        }

        /// <summary>
        /// Добавляет введённую сумму к сумме на счету. 
        /// </summary>
        /// <returns>-</returns>
        public void Put(decimal moneyy)
        {
            BankTransaction bt = new BankTransaction(moneyy);
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
                _Queue.Enqueue(bt);

                _Balance -= moneyy;
                return true;
            }
            return false;            
        }

        /// <summary>
        /// Метод переводит (вычитает и прибавляет) сумму с одного счёта на другой
        /// </summary>
        /// <returns></returns>
        public bool MoneyTransfer(BankAccount2 bankAccount, decimal moneyy)
        {
            if (bankAccount.Remove(moneyy))
            {
                this.Put(moneyy);                
                return true;
            }
            return false;
        }
        #endregion

        public enum Account
        {
            Текущий, Сберегательный
        }
    }
}
