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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SocketManager.StartClient($"{tbx_person_id.Text},{tbx_name.Text},login");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
