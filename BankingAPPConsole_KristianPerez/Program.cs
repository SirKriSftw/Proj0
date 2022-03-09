using System;

namespace oops_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isBanking = true;
            int choice;
            Accounts newAcc = new Accounts();

            while(isBanking)
            {
                System.Console.WriteLine("1. Create new account");
                System.Console.WriteLine("2. Check Balance");
                System.Console.WriteLine("3. Withdrawl");
                System.Console.WriteLine("4. Deposit");
                System.Console.WriteLine("5. Get Details");
                System.Console.WriteLine("6. Exit");

                choice = Convert.ToInt32(System.Console.ReadLine());

                switch(choice)
                {
                    #region Create New Account
                    case 1:                        
                        System.Console.WriteLine("Enter Account Number");
                        newAcc.accNo = Convert.ToInt32(Console.ReadLine());    
                        System.Console.WriteLine("Enter Account Name");
                        newAcc.accName = System.Console.ReadLine();  
                        System.Console.WriteLine("Enter Account Balance");
                        newAcc.accBalance = Convert.ToDouble(Console.ReadLine());    
                        System.Console.WriteLine("Enter Account Type");
                        newAcc.accType = System.Console.ReadLine();    
                        System.Console.WriteLine("Enter Account Email");
                        newAcc.accEmail = System.Console.ReadLine();      
                    break;
                    #endregion
                    #region Check Balance
                    case 2:
                        System.Console.WriteLine(newAcc.CheckBalance());
                    break;
                    #endregion
                    #region Withdrawl
                    case 3:
                        System.Console.WriteLine("Enter amount to withdrawl");
                        newAcc.Withdrawl(Convert.ToDouble(Console.ReadLine()));
                        System.Console.WriteLine("Current Balance: {0:C}", newAcc.accBalance);
                    break;
                    #endregion
                    #region Deposit
                    case 4:
                        System.Console.WriteLine("Enter amount to deposit");
                        newAcc.Deposit(Convert.ToDouble(System.Console.ReadLine()));
                        System.Console.WriteLine("Current Balance: {0:C}", newAcc.accBalance);
                    break;
                    #endregion
                    case 5:
                        newAcc.GetAccountDetails();
                    break;
                    case 6:
                        isBanking = false;
                    break;
                    default:
                        System.Console.WriteLine("Sorry " + choice + " is an invalid option");
                    break;
                }
            }
        }
    }
}
