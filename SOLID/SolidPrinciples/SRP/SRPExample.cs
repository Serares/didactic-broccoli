using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    internal class SRPExample
    {
        public class UserProfile
        {
            public string UserName { get; set; }
            public string Email { get; set; }

            public class UserProfileManager
            {
                public void SaveUserProfile(UserProfile user)
                {

                }
            }
        }
    }
}
