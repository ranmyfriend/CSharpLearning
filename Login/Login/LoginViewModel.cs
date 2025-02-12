using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    private string? username;

    [ObservableProperty]
    private string? password;

    [ObservableProperty]
    private bool isBusy;

    [ObservableProperty]
    private bool isLoginEnabled;

    public IRelayCommand? LoginCommand { get; private set; }

    // Fluent Interface Methods
    public static LoginViewModel Create() => new LoginViewModel();

    public LoginViewModel WithUsername(string username)
    {
        Username = username;
        return this;
    }

    public LoginViewModel WithPassword(string password)
    {
        Password = password;
        return this;
    }

    public LoginViewModel WithBusy(bool isBusy)
    {
        IsBusy = isBusy;
        return this;
    }

    public LoginViewModel WithLoginEnabled(bool isEnabled)
    {
        IsLoginEnabled = isEnabled;
        return this;
    }

    public LoginViewModel WithLoginCommand()
    {
        LoginCommand = new AsyncRelayCommand(ExecuteLogin);
        return this;
    }

    private async Task ExecuteLogin()
    {
        if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
        {
            await Shell.Current.DisplayAlert("Error", "Please enter valid credentials", "OK");
            return;
        }

        IsBusy = true;
        await Task.Delay(2000); // Simulating network request

        IsBusy = false;
        await Shell.Current.DisplayAlert("Success", "Login Successful!", "OK");
    }

}