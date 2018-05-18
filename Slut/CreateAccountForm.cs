using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slut
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void rb_salaryAccount_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Skapa konto
        public void CreateNewAccount()
        {
            string accountType = "-1";
            if (rb_salaryAccount.Checked)
            {
                accountType = "0";
            }
            else if (rb_savingsAccount.Checked)
            {
                accountType = "1";
            }
            else
            {
                MessageBox.Show("Please select an account type!");
            }
            if (accountType != "-1")
            {
                string cNAString = $"new_account,{StateData.personId},{tbx_initBalance.Text},{accountType},{StateData.accounts.Count}";
                SocketManager.StartClient(cNAString);
            }
            else {MessageBox.Show("Something went wrong!");}
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            CreateNewAccount();
            this.Close();
        }
    }
}
