using System;

namespace empManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Objects
            Manager manObj = new Manager(){
                empNo = 1,
                empName = "Nik",
                empSalary = 10000,
                empIsPermenant = true
            };

            Developer devObj = new Developer(){
                empNo = 2,
                empName = "Kris",
                empSalary = 5000,
                empIsPermenant = false
            };

            HR hrObj = new HR(){
                empNo = 3,
                empName = "Shelby",
                empSalary = 15000,
                empIsPermenant = true
            };
            #endregion
            #region Manager Object Tests
            System.Console.WriteLine("-----Manager Object-----");
            System.Console.WriteLine("Employee Number: " + manObj.empNo);
            System.Console.WriteLine("Name: " + manObj.empName);
            System.Console.WriteLine("Salary: " + manObj.empSalary);
            System.Console.WriteLine("Is Perminate: " + manObj.empIsPermenant);
            System.Console.WriteLine("10% of Salary: " + manObj.getBonus(10));
            #endregion
            #region Developer Object Tests
            System.Console.WriteLine("-----Developer Object-----");
            System.Console.WriteLine("Employee Number: " + devObj.empNo);
            System.Console.WriteLine("Name: " + devObj.empName);
            System.Console.WriteLine("Salary: " + devObj.empSalary);
            System.Console.WriteLine("Is Perminate: " + devObj.empIsPermenant);
            System.Console.WriteLine("10% of Salary: " + devObj.getBonus(10));
            #endregion
            #region HR Object Tests
            System.Console.WriteLine("-----HR Object-----");
            System.Console.WriteLine("Employee Number: " + hrObj.empNo);
            System.Console.WriteLine("Name: " + hrObj.empName);
            System.Console.WriteLine("Salary: " + hrObj.empSalary);
            System.Console.WriteLine("Is Perminate: " + hrObj.empIsPermenant);
            System.Console.WriteLine("10% of Salary: " + hrObj.getBonus(10));
            #endregion
        }
    }
}
