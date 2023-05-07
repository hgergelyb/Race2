using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    public class User
    {
        private int iId;
        private string sName;
        private int iAge;

        public User(string name, int age)
        {
            sName = name;
            iAge = age;
 //           _id = 
        }

        public string GetName()
        {
            return sName;
        }
        public int GetAge()
        {
            return iAge;
        }
    }
}
