using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace taskcheck.Models
{
    internal class Salary
    {
        private double Salary1;
        private string User_Name1;



        public string user_name
        {
            get { return User_Name1; }
            set
            {
                if (value == null || value ==string.Empty)
                {
                    Console.WriteLine("Invalid UserName");
                    
                }
                else
                {
                    User_Name1 = value;
                }
            }
        }

        public double salary
        {
            get { return Salary1; }
            set
            {
                if (value >= 350 && value <= 900)
                {
                    Salary1 = value;
                }
                else
                {
                    Console.WriteLine("out of range");
                }
            }
        }







        //public void CheckUserName()
        //{
        //    if (User_Name1 != null)
        //    {
        //        Console.WriteLine("my UserName is " + User_Name1);
        //    }

        //}

        //public void CheckSalary()
        //{
        //    if (Salary1== 0)
        //    {
        //        Console.WriteLine("not in range " );
        //    }
        //    else
        //    {
        //        Console.WriteLine("my salary is " + Salary1);
        //    }

        //}



    }
}
