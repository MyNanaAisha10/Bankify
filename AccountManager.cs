using System;

namespace BankApp;
public class AccountManager : IAccountManager 
{
    List<BankFeatures> information = new List<BankFeatures>();
    public void CreateAccount()
    {
        BankFeatures bankFeatures = new BankFeatures();
        Console.WriteLine("Enter First Name:");
        bankFeatures.FirstName = Console.ReadLine();
        Console.WriteLine("Enter Last Name:");
        bankFeatures.LastName = Console.ReadLine();
        Console.WriteLine("Enter Phone Number:");
        bankFeatures.PhoneNumber = Console.ReadLine();
        Console.WriteLine("Enter Email:");
        bankFeatures.Email = Console.ReadLine();
        Console.WriteLine("Enter Password:");
        bankFeatures.Password = Console.ReadLine();
        Console.WriteLine("Enter Account Type:");
        bankFeatures.AccountType = Console.ReadLine();
        Console.WriteLine("Enter Gender:");
        bankFeatures.Gender = Console.ReadLine();

        information.Add(bankFeatures);
        Console.WriteLine("Account Created Successfully");  
        

        
    }
    public void Login()
    {

    }
    
    public void Deposit()
    {

    }
    public void Withdraw()
    {

    }
    public void Transfer()
    {

    }
    public void CheckBalance()
    {

    }
    public void ViewProfile()
    {
        Console.WriteLine("Enter First Name:");
        string? firstName = Console.ReadLine();
        var check = information.Find(x => x.FirstName == firstName);
        Console.WriteLine("Enter Phone Number:");
        string? phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter Password:");
        string? password = Console.ReadLine();
        
    }
    public void EditProfile()
    {

    }
    public void DeleteAccount()
    {

    }
    public void Logout()
    {

    }

}   
  
 