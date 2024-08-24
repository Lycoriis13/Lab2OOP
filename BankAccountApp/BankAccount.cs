using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public double Balance { get; private set; }

        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public string Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return $"Ваш рахунок {AccountNumber} поповнено на {amount} грн. Поточний баланс: {Balance} грн.";
            }
            else
            {
                return "Сума поповнення має бути більше нуля.";
            }
        }

        public string Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return $"З вашого рахунку {AccountNumber} знято {amount} грн. Поточний баланс: {Balance} грн.";
            }
            else if (amount <= 0)
            {
                return "Сума зняття має бути більше нуля.";
            }
            else
            {
                return "Недостатньо коштів на рахунку.";
            }
        }

        public string ShowAccountInfo()
        {
            return $"Інформація про рахунок {AccountNumber}:\nБаланс: {Balance} грн.";
        }
    }


}
