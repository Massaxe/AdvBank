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
        SocketManager sM;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SocketManager.StartClient(tbx_name.Text);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
