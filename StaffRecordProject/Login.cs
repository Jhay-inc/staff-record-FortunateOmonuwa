using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordProject
{

    public class Login : Functionalities
    {
        private string email;

        public string Email { get => email; set => email = value; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string IDCard { get; set; }


        public void Academic()
        {
            Console.WriteLine("\n\nPress '1' to login as a principal\n\nPress '2' to login as a Teacher\n\nPress '3' to login as an Exam Officer\n\n");
            var enter = int.Parse(Console.ReadLine());
            Console.Clear();

            Thread.Sleep(1000);

            switch (enter)

            {
                case 1:
                    Principal();
                    FunctionalitiesEntry();
                    break;
                case 2:
                    Teacher();
                    break;
                case 3:
                    ExamOfficer();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    break;
            }

        }

        public void NonAcademic()
        {

        }

        public void Principal()
        {
            Console.WriteLine("Press '1' to continue as 'Principal' \n\nPress '2' switch to Admin Role");
            int selection = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (selection)
            {
                case 1:
                    StaffLogin(Email, Password);

                    break;

                case 2:
                    Admin();
                    break;
            }
            Console.Clear();

        }

        public void Admin()
        {
            StaffLogin(Email, Password);

        }

        public void ExamOfficer()
        {
            StaffLogin(Email, Password);
        }



        public void Teacher()
        {
            StaffLogin(Email, Password);
        }

        public string StaffLogin(string email, string password)
        {
            Email = email;
            Password = password;

            Console.Write("Please Enter Your Email: ");
            email = Console.ReadLine();
            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("No break my code weyrey");
                StaffLogin(email, password);
            }

            Console.Write("Please Enter Your Password: ");
            password = Console.ReadLine();

            if(string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Use your brain and input a password");
                StaffLogin(email, password);
            }
            return "-----------------Welcome---------------";
        }
    }
}
           
         

          