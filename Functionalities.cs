using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StaffRecordProject
{
    public class Functionalities : AllStaff
    {


        public void FunctionalitiesEntry() 
        {
            Console.WriteLine("\n---------------------------------------\n");
            Console.WriteLine("\n\nPress [1] to Add New Staff Role\nPress [2] to Remove Staff Role " +
                "\nPress [3] to Transfer Staff Role\nPress [4] to Change Role \nPress [5] to Delete\n\n");
            int select = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(select)
            {
                case 1:
                    AddStaffRole();
                    break;
                case 2:
                    RemoveStaffRole();
                    break;
                case 3:
                    TransferStaffRole();
                    break;
                case 4:
                    ChangeRole();
                    break;
                case 5:
                    Delete();
                    break;
                default: Console.WriteLine("Don't break my code you twat");
                    break;
                   // FunctionalitiesEntry
            }



            
        }


        public void AddStaffRole()
        {

        }

        public void RemoveStaffRole()
        {

        }

        public void TransferStaffRole()
        {
            
        }

        public void ChangeRole()
        {

        }

        public void Delete()
        {
                    
        }
        
    }
}
