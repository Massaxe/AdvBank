using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Slut
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            StateData.userForm = this;
        }
        
        public static CreateAccountForm CAF;

        public void user_Load(object sender, EventArgs e)
        {
            SocketManager.StartClient($"init_user_data,{StateData.personId}");
            //StateData.userForm = this;
            InitUserView();
        }
        public static void SendMessageToUser(string messageToSend)
        {
            MessageBox.Show(messageToSend);
        }
        public void InitUserView()
        {
            lbl_name.Text = StateData.name;
            lbl_person_id.Text = StateData.personId;
            lbl_balance.Text = StateData.totalBalance.ToString();
            DisplayAccounts();
        }
        public void DisplayAccounts()
        {
            lb_accountListBox.BeginUpdate();
            lb_accountListBox.Items.Clear();
            foreach (Account a in StateData.accounts)
            {
                lb_accountListBox.Items.Add($"ID: {a.AccountId} | Balance: {a.AccountBalance}");
            }
            lb_accountListBox.EndUpdate();
            lb_accountListBox.Update();
            lb_accountListBox.Refresh();
        }
        private void lbl_name_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            CAF = new CreateAccountForm();
            CAF.Show();
        }

        private void btn_sendMoney_Click(object sender, EventArgs e)
        {
            SocketManager.StartClient($"send_money,{StateData.personId},{lb_accountListBox.SelectedIndex},{tbx_sendAmount.Text},{tbx_sendMoneyId.Text}");
        }

        private void btn_removeAccount_Click(object sender, EventArgs e)
        {
            SocketManager.StartClient($"remove_account,{StateData.personId},{lb_accountListBox.SelectedIndex}");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            InitUserView();

        }
    }
}
