using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordProject
{
    public interface IAcademicStaff 
    {
        public void Principal();

        void Admin();


        public void Teacher();

        public void ExamOfficer();
       


        
        

        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //private bool ParkingSpace { get; set; }
        public string IDCard { get; set;}

    }
}
