using Bankify;
using System.Collections.Generic;

namespace BankApp;

public class AccountManager : IAccountManager
{
    private List<Account> accounts;
    private Account currentAccount;

    public AccountManager()
    {
        accounts = new List<Account>();
    }

    public void CreateAccount()
    {
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine()!;

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine()!;

        Console.WriteLine("Enter Phone Number:");
        string phoneNumber = Console.ReadLine()!;

        Console.WriteLine("Enter Email:");
        string email = Console.ReadLine()!;

        Console.WriteLine("Enter Password:");
        string password = Console.ReadLine()!;

        Console.WriteLine("Enter Account Type:");
        string accountType = Console.ReadLine()!;

        Console.WriteLine("Enter Gender:");
        string gender = Console.ReadLine()!;

        BankFeatures profile = new BankFeatures(firstName!, lastName!, phoneNumber!, email!, password!, accountType!, gender!);

        string accountNumber = phoneNumber.Substring(1);

        Console.WriteLine("Enter initial deposit:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal balance))
        {
            Console.WriteLine("Invalid amount. Please enter a valid number.");
            return;
        }

        Account newAccount = new Account(accountNumber, balance, profile);
        accounts.Add(newAccount);

        Console.WriteLine($"Account created successfully! Your account number is: {newAccount.AccountNumber}");
    }

    public void Login()
    {
        Console.WriteLine("Enter your account number:");
        string accountNumber = Console.ReadLine()!;

        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine()!;

        Account account = accounts.Find(acc => acc.AccountNumber == accountNumber && acc.Profile.Password == password)!;

        if (account != null)
        {
            currentAccount = account;
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Invalid account number or password.");
        }
    }

    public void Deposit(string accountNumber, decimal amount)
    {
        if (currentAccount == null)
        {
            Console.WriteLine("You must be logged in to deposit.");
            return;
        }

        Console.WriteLine("Enter the amount to deposit:");
        if (!decimal.TryParse(Console.ReadLine(), out amount))
        {
            Console.WriteLine("Invalid amount. Please enter a valid number.");
            return;
        }

        currentAccount.Balance += amount;
        Console.WriteLine($"Deposit successful! New balance: {currentAccount.Balance}");
    }

    public void Withdraw(string accountNumber, decimal balance)
    {
        if (currentAccount == null)
        {
            Console.WriteLine("You must be logged in to withdraw.");
            return;
        }

        Console.WriteLine("Enter the amount to withdraw:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid amount. Please enter a valid number.");
            return;
        }

        if (amount > currentAccount.Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            currentAccount.Balance -= amount;
            Console.WriteLine($"Withdrawal successful! New balance: {currentAccount.Balance}");
        }
    }

    public void Transfer(string senderAccountNumber, string recipientAccountNumber, decimal amount)
    {
        if (currentAccount == null)
        {
            Console.WriteLine("You must be logged in to transfer.");
            return;
        }

        Console.WriteLine("Enter the recipient's account number:");
         recipientAccountNumber = Console.ReadLine()!;

        Console.WriteLine("Enter the amount to transfer:");
        if (!decimal.TryParse(Console.ReadLine(), out amount))
        {
            Console.WriteLine("Invalid amount. Please enter a valid number.");
            return;
        }

        Account recipientAccount = accounts.Find(acc => acc.AccountNumber == recipientAccountNumber)!;

        if (recipientAccount == null)
        {
            Console.WriteLine("Recipient account not found.");
            return;
        }

        if (amount > currentAccount.Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            currentAccount.Balance -= amount;
            recipientAccount.Balance += amount;
            Console.WriteLine($"Transfer successful! New balance: {currentAccount.Balance}");
        }
    }

    public void CheckBalance(string accountNumber)
    {
        if (currentAccount == null)
        {
            Console.WriteLine("You must be logged in to check your balance.");
            return;
        }

        Console.WriteLine($"Your current balance is: {currentAccount.Balance}");
    }

    public void ViewProfile(string accountNumber)
    {
        if (currentAccount == null)
        {
            Console.WriteLine("You must be logged in to view your profile.");
            return;
        }

        currentAccount.Profile.DisplayProfile();
    }

    public void EditProfile(string accountNumber)
    {
        if (currentAccount == null)
        {
            Console.WriteLine("You must be logged in to edit your profile.");
            return;
        }

        currentAccount.Profile.EditProfile();
    }

    public void DeleteAccount(string accountNumber)
    {
        if (currentAccount == null)
        {
            Console.WriteLine("You must be logged in to delete your account.");
            return;
        }

        accounts.Remove(currentAccount);
        currentAccount = null!;
        Console.WriteLine("Account deleted successfully!");
    }

    public void Logout()
    {
        if (currentAccount == null)
        {
            Console.WriteLine("You are not logged in.");
            return;
        }

        currentAccount = null!;
        Console.WriteLine("Logged out successfully!");
    }
}