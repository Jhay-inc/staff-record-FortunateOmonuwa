using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordProject
{
    public class Database : AllStaff
    {
        public Database() 
        {
            List<AllStaff> staff = new List<AllStaff>();
            //staff.Add(new AllStaff (FirstName, LastName, Email, Password));
        
        
        }   
        public int ID;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Password;
        public string Role;
    }

}
