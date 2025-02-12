namespace BankApp;

public interface IAccountManager
{
    void CreateAccount();
    void Login();
    void Deposit(string accountNumber, decimal amount);
    void Withdraw(string accountNumber, decimal amount);
    void Transfer(string senderAccountNumber, string recipientAccountNumber, decimal amount);
    void CheckBalance(string accountNumber);
    void ViewProfile(string accountNumber);
    void EditProfile(string accountNumber);
    void DeleteAccount(string accountNumber);
    void Logout();
}