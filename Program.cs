using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            StudentManagement ob = new StudentManagement();
            Console.WriteLine("STUDENT DATABASE SYSTEM");
            Console.WriteLine("1.New Student\n 2.Old Student\n Enter the choice: ");
            ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                ob.newstudentdetails();
                ob.deptdetails();
                ob.fees();
                ob.newdisplay();

            }
            else if (ch == 2)
            {
                ob.oldstudent();
                ob.getdeptdetails();
                ob.updatefees();
                ob.results();
                ob.olddisplay();
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}
         
