namespace BankApp;
public class BankMenu
{
    public IAccountManager silverBank;
    public BankMenu()
    {
        silverBank = new AccountManager();
    }
    public void Menu()
    {
        bool information = false;
        while(information)
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
            Console.WriteLine("Enter your option:");
            int userChoice =  Convert.ToInt32(Console.ReadLine());
            switch(userChoice)
            {
                case 1:
                    silverBank.CreateAccount();
                    break;
                case 2:
                    Console.WriteLine("Enter Last Name:");
                    break;
                case 3:
                    Console.WriteLine("Enter Phone Number:");
                    break;
                case 4:
                    Console.WriteLine("Enter Email:");
                    break;
                


            }

        

        }        

    }
}
