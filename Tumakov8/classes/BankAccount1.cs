using System;

namespace Tumakov8
{ 
    internal class BankAccount1
    {
        #region Fields
        private Guid _Id;
        private decimal _Balance;
        private Account _account;
        #endregion

        #region Constructors

        public BankAccount1(decimal balance, Account account)
        {
            _account = account;
            _Balance = balance;
            _Id = Guid.NewGuid();
        }
        public BankAccount1(decimal balance)
        {
            _Balance = balance;
            _Id = Guid.NewGuid();
        }
        public BankAccount1(Account account)
        {
            _account = account;
            _Id = Guid.NewGuid();
        }
        public BankAccount1()
        {
            _account = Account.Текущий;
            _Balance = 0;
            _Id = Guid.NewGuid();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Выводит информацию о банковском счёте
        /// </summary>
        /// <returns>-</returns>
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счёта: {_Id}");
            Console.WriteLine($"Баланс: {_Balance} рублей");
            Console.WriteLine($"Тип: {_account}\n");
        }

        /// <summary>
        /// Добавляет введённую сумму к сумме на счету. 
        /// </summary>
        /// <returns>-</returns>
        public void Put(decimal moneyy)
        {
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
                _Balance -= moneyy;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool MoneyTransfer(BankAccount1 bankAccount, decimal moneyy)
        {
            if (Remove(moneyy))
            {
                bankAccount.Put(moneyy);
                return (true);
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
