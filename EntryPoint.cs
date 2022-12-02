using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordProject
{
    public class EntryPoint:Login
    {
        
        public void Input()
        {
            Console.WriteLine("Press '1' to login as an Academic Staff" +
                "\n\nPress '2' to login as a Non-Academic Staff \n\n");
            var input = Console.ReadKey();
            Console.Clear();
            Thread.Sleep(1000);
            

            if (input.Key == ConsoleKey.D1)
            {
                Console.WriteLine(".........................Loading........................");
                Thread.Sleep(2000);
                Academic();
                
            }
            else if (input.Key == ConsoleKey.D2)
            {
                NonAcademic();
            }
            else
            {
                Console.WriteLine("Ozuorh!!!!!!!!!!!!!! Select correct thing\n");
                Thread.Sleep(1200);
                Input();
            }
        }

        public void Entry()
        {
            Console.Write("\n\nPress 'ENTER' to continue");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
               
            }
            else
            {
                Console.WriteLine("You entered a wrong input");
                Entry();
            }

        }
    }
}
