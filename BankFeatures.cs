namespace BankApp;

public class BankFeatures
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string AccountType { get; set; }
    public string Gender { get; set; }

    public BankFeatures(string firstName, string lastName, string phoneNumber, string email, string password, string accountType, string gender)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        Password = password;
        AccountType = accountType;
        Gender = gender;
    }

    public void DisplayProfile()
    {
        Console.WriteLine("Profile Information:");
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Account Type: {AccountType}");
        Console.WriteLine($"Gender: {Gender}");
    }

    public void EditProfile()
    {
        Console.WriteLine("Enter new first name:");
        FirstName = Console.ReadLine()!;

        Console.WriteLine("Enter new last name:");
        LastName = Console.ReadLine()!;

        Console.WriteLine("Enter new phone number:");
        PhoneNumber = Console.ReadLine()!;

        Console.WriteLine("Enter new email:");
        Email = Console.ReadLine()!;

        Console.WriteLine("Enter new password:");
        Password = Console.ReadLine()!;

        Console.WriteLine("Enter new account type:");
        AccountType = Console.ReadLine()!;

        Console.WriteLine("Enter new gender:");
        Gender = Console.ReadLine()!;

        Console.WriteLine("Profile updated successfully!");
    }
}