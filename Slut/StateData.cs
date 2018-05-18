using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slut
{
    class StateData
    {
        //Universell data som klienten ska använda sig av. Om göra bättre: gör denna inkapslad, inte så öppen.
        public static User userForm;
        public static LoginForm loginForm;
        public static string personId;
        public static string name;
        public static double totalBalance;
        public static List<Account> accounts;
    }
}
