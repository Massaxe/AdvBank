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
            

        }

        private void user_Load(object sender, EventArgs e)
        {
            SocketManager.StartClient($"init_user_data,{StateData.personId}");
            StateData.userForm = this;
        }
        public static void SendMessageToUser(string messageToSend)
        {
            MessageBox.Show(messageToSend);
           
        }
        public void InitUserView()
        {
            MessageBox.Show("InitUserView");
            lbl_name.Text = StateData.name;
            lbl_name.Text = "Test";
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            
        }
    }
}
