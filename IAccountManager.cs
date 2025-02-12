namespace BankApp;

public interface IAccountManager
{
    public void CreateAccount();
    public void Login();
    public void Deposit();
    public void Withdraw();
    public void Transfer();
    public void CheckBalance();
    public void ViewProfile();
    public void EditProfile();
    public void DeleteAccount();
    public void Logout();
}
