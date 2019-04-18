using System;
using User_defined_exceptions;

namespace BankAccountSimulation
{
    public class CurrentBankAccount : BankAccount
    {
        public CurrentBankAccount(string accountOwnerName, string accountNumber)
            : base(accountOwnerName, accountNumber)
        {
            this.MinAccountBalance = 0m;
            this.MaxDepositAmount = 100000000m;
            InteresetRate = .25m;
        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("You can not deposit amount less than zero");
            }

            if (amount >= MaxDepositAmount)
            {
                throw new OutOfMaxDepositAmountException(string.Format("You can not deposit amount greater than {0}", MaxDepositAmount.ToString()));
            }

            AccountBalance = AccountBalance + amount;
            TransactionSummary = string.Format("{0}\n Deposit:{1}", TransactionSummary, amount);
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("You can not withdraw amount less than zero");
            }

            if (AccountBalance - amount <= MinAccountBalance)
            {
                throw new OutOfMinBalanceException("You can not withdraw amount from your Current Account as Minimum Balance limit is reached");
            }

            AccountBalance = AccountBalance - amount;
            TransactionSummary = string.Format("{0}\n Withdraw:{1}", TransactionSummary, amount);
        }

        public override void GenerateAccountReport()
        {
            Console.WriteLine("Current Account Report");
            base.GenerateAccountReport();
        }
    }
}
