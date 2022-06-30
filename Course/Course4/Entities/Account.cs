using Course4.Entities.Exceptions;

namespace Course4.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if(balance < 0 || withdrawLimit < 0)
            {
                throw new DomainException("Neither the balance or the withdraw limit can be negative.");
            }
            Number = number;
            Holder = holder;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if(amount < 0)
            {
                throw new DomainException("Amount of deposit can't be negative.");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= WithdrawLimit && Balance-amount >= 0)
            {
                Balance -= amount;
            }
            else
            {
                throw new DomainException("Can't withdraw that amount, verify your limit or your atual balance.\n");
            }
        }
    }
}
