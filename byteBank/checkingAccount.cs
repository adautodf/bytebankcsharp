using bytebank;
using bytebank.Owner;

namespace bytebank
{
    public class checkingAccount
    {
        public customer owner;
        public string account;
        public int branch_number;
        public string agency_name;
        public double balance;

        public bool Withdraw(double value)
        {
            if (balance < value)
            {
                return false;
            }
            if (value < 0)
            {
                return false;
            }
            else
            {
                balance -= value;
                return true;
            }
        }

        public void Deposit(double value)
        {
            balance += value;
        }

        public bool Transfer(double value, checkingAccount destiny)
        {
            if (balance < value)
            {
                return false;
            }
            if (value < 0)
            {
                return false;
            }
            else
            {
                balance -= value;
                destiny.balance += value;
                return true;
            }
        }
    }
}