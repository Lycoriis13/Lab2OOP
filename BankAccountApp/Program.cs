using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Створюємо об'єкт банківського рахунку з початковим балансом 1000 грн
            BankAccount account = new BankAccount("12345", 1000.0);

            // Виводимо інформацію про рахунок
            account.ShowAccountInfo();

            // Поповнюємо рахунок на 500 грн
            account.Deposit(500.0);

            // Знімаємо 200 грн
            account.Withdraw(200.0);

            // Спроба зняти 1500 грн, що більше ніж доступно на рахунку
            account.Withdraw(1500.0);

            // Виводимо кінцеву інформацію про рахунок
            account.ShowAccountInfo();
        }


    }
}
