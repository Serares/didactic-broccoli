using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    internal class SRPBadExample
    {
        public class UserOperations
        {
            public void SaveUser(string userName, string email)
            {

            }

            public void SendEmail(string email, string message)
            {

            }
        }
    }
}
/**
 ❗To adhere to this principle 
You have to separate the behaviors 
public class UserSaver
{
public void SaveUser(string userName, string email)
{
// Save user to a database.
}
}
public class EmailSender
{
public void SendEmail(string email, string message)
{
// Send an email to the user.
}
}
*/
