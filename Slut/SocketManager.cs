using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Slut
{
    class SocketManager
    {

        public static void StartClient(string sendData)
        {

            StateData.userForm = new User();
            // Buffert
            byte[] bytes = new byte[1024];

            try
            {
                // Uni IP  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 25565);

                // Socket
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Anslut med try-catch 
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    // Encode
                    byte[] msg = Encoding.UTF8.GetBytes($"{sendData}<EOM>");

                    // Skicka 
                    int bytesSent = sender.Send(msg);

                    // Ta emot  
                    int bytesRec = sender.Receive(bytes);
                    string messageInHuman = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    Debug.WriteLine(messageInHuman);
                    HandleData(messageInHuman);
                    
                    

                    // Släpp.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //Gör samma som på servern.
        public static void HandleData(string messageInHuman)
        {
            if (messageInHuman.IndexOf("login_success") > -1)
            {
                SavePersonId(GetPersonIdFromMessage(messageInHuman)[1]);
            }
            else if (messageInHuman.IndexOf("login_failed") > -1)
            {
                LoginForm.SendMessageToUser("login_failed");
            }
            else if(messageInHuman.IndexOf("login_admin") > -1)
            {
                LoginForm.SendMessageToUser("login_admin");
            }
            else if(messageInHuman.IndexOf("user_data") > -1)
            {
                HandleInitUserData(messageInHuman);
            }
        }

        //Sparar information till StateData. Läses senare av från Form för att visa upp för användare.
        public static void HandleInitUserData(string content)
        {
            User.SendMessageToUser(content);
            string[] contentArray = content.Split(',');
            StateData.name = contentArray[1];
            StateData.personId = contentArray[2];
            StateData.accounts = AccountSplit(contentArray, 3);
            StateData.userForm.InitUserView();
        }

        //Eftersom data är i inline string form måste den hanteras. Konto på annat sätt än överigt på grund av annat format.
        private static List<Account> AccountSplit(string[] messageArray, int startVal)
        {
            List<Account> accountList = new List<Account>();
            for (int i = startVal; i < messageArray.Length; i++)
            {
                string[] accountArray = messageArray[i].Split('-');
                double balance = double.Parse(accountArray[2]);
                StateData.totalBalance += balance;
                accountList.Add(new Account(accountArray[0], accountArray[1], balance));
            }
            return accountList;
        }


        public static string[] GetPersonIdFromMessage(string content)
        {
            return content.Split(',');
        }
        //StateData save
        public static void SavePersonId(string id)
        {
            StateData.personId = id;
            ShowUserForm();
        }
        //Visa UserForm om login lyckas.
        public static void ShowUserForm()
        {
            StateData.userForm.Show();
            StateData.loginForm.Visible = false;
        }
    }
}
