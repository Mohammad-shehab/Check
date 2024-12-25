// enter username 


using taskcheck.Models;

Console.WriteLine("Enter your username");
string username = Console.ReadLine();

Salary salary = new Salary();


salary.user_name = username;

Console.WriteLine("Enter your salary");
double salary1 = Convert.ToDouble(Console.ReadLine());
salary.salary = salary1;
//salary.CheckSalary();