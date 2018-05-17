using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slut
{
    class Account
    {
        string accountId;
        string accountType;
        double accountBalance;

        public Account(string accountId, string accountType, double accountBalance)
        {
            this.accountId = accountId;
            this.accountType = accountType;
            this.accountBalance = accountBalance;
        }

        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }
        }
        public string AccountId
        {
            get
            {
                return accountId;
            }
        }
        public string AccountType
        {
            get
            {
                return accountType;
            }
        }

    }
}
