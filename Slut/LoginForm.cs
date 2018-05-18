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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            StateData.loginForm = this;
        }
        //Skickar information via SocketManager till servern som lyssnar. Format av information finns i server koden. 
        private void login_btn_Click(object sender, EventArgs e)
        {
            SocketManager.StartClient($"{tbx_person_id.Text},{tbx_name.Text},login");
        }
        private void btn_reg_Click(object sender, EventArgs e)
        {
            SocketManager.StartClient($"{tbx_person_id.Text},{tbx_name.Text},reg");
        }
        public static void SendMessageToUser(string messageToSend)
        {
            MessageBox.Show(messageToSend);
        }
    }
}
