namespace BankApp;

public class BankMenu
{
    private IAccountManager silverBank;

    public BankMenu()
    {
        silverBank = new AccountManager();
    }

    public void Menu()
    {
        bool information = true;
        while (information)
        {
            Console.WriteLine("Welcome to the Silver Bank");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Transfer");
            Console.WriteLine("6. Check Balance");
            Console.WriteLine("7. View Profile");
            Console.WriteLine("8. Edit Profile");
            Console.WriteLine("9. Delete Account");
            Console.WriteLine("10. Logout");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your option:");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    silverBank.CreateAccount();
                    break;

                case 2:
                    silverBank.Login();
                    break;

                case 3:
                    Console.WriteLine("Enter your account number:");
                    string depositAccountNumber = Console.ReadLine()!;
                    Console.WriteLine("Enter the amount to deposit:");
                    decimal depositAmount = decimal.Parse(Console.ReadLine()!);
                    silverBank.Deposit(depositAccountNumber!, depositAmount);
                    break;

                case 4:
                    Console.WriteLine("Enter your account number:");
                    string withdrawAccountNumber = Console.ReadLine()!;
                    Console.WriteLine("Enter the amount to withdraw:");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine()!);
                    silverBank.Withdraw(withdrawAccountNumber, withdrawAmount);
                    break;

                case 5:
                    Console.WriteLine("Enter your account number:");
                    string senderAccountNumber = Console.ReadLine()!;
                    Console.WriteLine("Enter the recipient's account number:");
                    string recipientAccountNumber = Console.ReadLine()!;
                    Console.WriteLine("Enter the amount to transfer:");
                    decimal transferAmount = decimal.Parse(Console.ReadLine()!);
                    silverBank.Transfer(senderAccountNumber!, recipientAccountNumber!, transferAmount);
                    break;

                case 6:
                    Console.WriteLine("Enter your account number:");
                    string balanceAccountNumber = Console.ReadLine()!;
                    silverBank.CheckBalance(balanceAccountNumber!);
                    break;

                case 7:
                    Console.WriteLine("Enter your account number:");
                    string profileAccountNumber = Console.ReadLine()!;
                    silverBank.ViewProfile(profileAccountNumber!);
                    break;

                case 8:
                    Console.WriteLine("Enter your account number:");
                    string editProfileAccountNumber = Console.ReadLine()!;
                    silverBank.EditProfile(editProfileAccountNumber!);
                    break;

                case 9:
                    Console.WriteLine("Enter your account number:");
                    string deleteAccountNumber = Console.ReadLine()!;
                    silverBank.DeleteAccount(deleteAccountNumber!);
                    break;

                case 10:
                    silverBank.Logout();
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    information = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}