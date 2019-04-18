using System;
using User_defined_exceptions;

namespace BankAccountSimulation
{
    public class Program
    {
        public delegate void DepositAndWithdraw(decimal amount);
        public delegate void OtherOperation();
        public static int exceptionCount = 0;
        static void Main(string[] args)
        {
            BankAccount savingAccount = new SavingBankAccount("Sarvesh", "S12345");
            BankAccount currentAccount = new CurrentBankAccount("Mark", "C12345");

            TryCatch(savingAccount.Deposit, 40000);
            //try
            //{
            //    savingAccount.Deposit(40000);
            //}
            //catch(ArgumentException e)
            //{
            //    exceptionCount++;
            //    Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            //}
            //catch(OutOfMaxDepositAmountException e)
            //{
            //    exceptionCount++;
            //    Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            //}

            for (int i = 0; i < 3; i++)
            {
                TryCatch(savingAccount.Withdraw, 1000);
                //try
                //{
                //    savingAccount.Withdraw(1000);
                //}
                //catch (ArgumentException e)
                //{
                //    exceptionCount++;
                //    Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
                //}
                //catch (MaxWithdrawCountExceptionException e)
                //{
                //    exceptionCount++;
                //    Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
                //}
                //catch (OutOfMinBalanceException e)
                //{
                //    exceptionCount++;
                //    Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
                //}
            }

            // Generate Report
            TryCatch(savingAccount.GenerateAccountReport);
            //try
            //{
            //    savingAccount.GenerateAccountReport();
            //}
            //catch(OutOfMinBalanceForReportException e)
            //{
            //    exceptionCount++;
            //    Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            //}

            Console.WriteLine();
            TryCatch(currentAccount.Deposit, 190000);
            //try
            //{
            //    currentAccount.Deposit(190000);
            //}
            //catch (ArgumentException e)
            //{
            //    exceptionCount++;
            //    Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            //}
            //catch (OutOfMaxDepositAmountException e)
            //{
            //    exceptionCount++;
            //    Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            //}

            TryCatch(currentAccount.Withdraw, 1000);
            //try
            //{
            //    currentAccount.Withdraw(1000);
            //}
            //catch (ArgumentException e)
            //{
            //    exceptionCount++;
            //    Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            //}
            //catch (OutOfMinBalanceException e)
            //{
            //    exceptionCount++;
            //    Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            //}

            TryCatch(currentAccount.GenerateAccountReport);
            //currentAccount.GenerateAccountReport();

            Console.ReadLine();
        }

        public static void TryCatch(DepositAndWithdraw depositAndWithdraw, decimal amount)
        {
            try
            {
                depositAndWithdraw(amount);
            }
            catch (ArgumentException e)
            {
                exceptionCount++;
                Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            }
            catch (OutOfMaxDepositAmountException e)
            {
                exceptionCount++;
                Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            }
            catch (MaxWithdrawCountExceptionException e)
            {
                exceptionCount++;
                Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            }
            catch (OutOfMinBalanceException e)
            {
                exceptionCount++;
                Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            }
        }

        public static void TryCatch(OtherOperation otherOperation)
        {
            try
            {
                otherOperation();
            }
            catch (OutOfMinBalanceForReportException e)
            {
                exceptionCount++;
                Console.WriteLine($"{exceptionCount}) {e.Message} {DateTime.Now}");
            }
        }
    }
}