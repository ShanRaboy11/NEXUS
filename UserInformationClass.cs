using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXUS
{
    public interface Users
    {

    }
    public abstract class UserInformationClass
    {
        private int userID;
        private List<string> name;
        private List<string> contactInfo;
        private List<string> email;
        private List<string> username;
        private List<string> password;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public List<string> Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public List<string> Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
