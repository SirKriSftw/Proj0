using System;

class Accounts 
{
#region Account Properties
    public int accNo { get; set; }
    public string accName { get; set; }
    public string accType { get; set; }
    public double accBalance { get; set; }
    public bool accIsActive { get; set; }
    public string accEmail { get; set; }
#endregion
#region Account Methods
#region Withdrawl
public double Withdrawl(int amount)
{
    accBalance = accBalance - amount;
    return accBalance;   
}
#endregion
#region Deposit
public double Deposit(int amount)
{
    accBalance = accBalance + amount;
    return accBalance;   
}
#endregion
#region GetAccountDetails
public void GetAccountDetails()
{
    System.Console.WriteLine("--------------------------------");
    System.Console.WriteLine("Account No: " + accNo);
    System.Console.WriteLine("Name: " + accName);
    System.Console.WriteLine("Type: " + accType);
    System.Console.WriteLine("Balance: {0:C}", accBalance);
    System.Console.WriteLine("Email: " + accEmail);
    System.Console.WriteLine("--------------------------------");
}
#endregion
#region CheckBalance
public double CheckBalance()
{
    return accBalance;
}
#endregion
#endregion
}