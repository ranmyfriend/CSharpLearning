namespace Login;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = LoginViewModel
		.Create()
		.WithUsername("")
		.WithPassword("")
		.WithBusy(false)
		.WithLoginEnabled(true)
		.WithLoginCommand();
	}
}