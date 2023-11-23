namespace HeartSync.View;

public partial class Homepage : ContentPage
{
	public Homepage(string username)
	{
		InitializeComponent();

        welcomeLabel.Text = "Welcome to Heartsync " + username + "!";
    }
}