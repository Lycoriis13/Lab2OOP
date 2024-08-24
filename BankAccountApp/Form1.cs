using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        private BankAccount account;
        public Form1()
        {
            InitializeComponent();
            account = new BankAccount("12345", 1000.0); // Ініціалізація рахунку
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnDeposit_Click_1(object sender, EventArgs e)
        {

            if (double.TryParse(txtAmount.Text, out double amount))
            {
                lblResult.Text = account.Deposit(amount);
            }
            else
            {
                lblResult.Text = "Введіть правильну суму.";
            }
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;
            if (double.TryParse(txtInitialBalance.Text, out double initialBalance))
            {
                account = new BankAccount(accountNumber, initialBalance);
                lblResult.Text = "Account created successfully.\n" + account.ShowAccountInfo();
            }
            else
            {
                MessageBox.Show("Please enter a valid initial balance.");
            }
        }

        private void btnWithdraw_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out double amount))
            {
                lblResult.Text = account.Withdraw(amount);
            }
            else
            {
                lblResult.Text = "Введіть правильну суму.";
            }
        }

    }
}
