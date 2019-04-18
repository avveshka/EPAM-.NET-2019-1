using System;
using User_defined_exceptions;

namespace BankAccountSimulation
{
	public class SavingBankAccount : BankAccount
	{
		protected int withdrawCount = 0;

		public SavingBankAccount(string accountOwnerName, string accountNumber)
			: base(accountOwnerName, accountNumber)
		{
			this.MinAccountBalance = 20000m;
			this.MaxDepositAmount = 50000m;
			InteresetRate = 3.5m;
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

            if (withdrawCount >= 3)
			{
				throw new MaxWithdrawCountExceptionException("You can not withdraw amount more than thrice");
			}

			if (AccountBalance - amount <= MinAccountBalance)
			{
				throw new OutOfMinBalanceException("You can not withdraw amount from your Savings Account as Minimum Balance limit is reached");
			}

			AccountBalance = AccountBalance - amount;
			withdrawCount++;

			TransactionSummary = string.Format("{0}\n Withdraw:{1}", TransactionSummary, amount);
		}

		public override void GenerateAccountReport()
		{
			Console.WriteLine("Saving Account Report");
			base.GenerateAccountReport();

			if (AccountBalance < 15000)
			{
				throw new OutOfMinBalanceForReportException("Insifficient amount of funds to generate report");
			}

			Console.WriteLine("Sending Email for Account {0}", AccountNumber);
		}
	}
}
