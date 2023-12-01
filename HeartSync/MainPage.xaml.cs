namespace HeartSync
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        
            private void LoginClicked(object sender, EventArgs e)
        {
            string currentUsername = entryUsernameInput.Text;
            string currentPassword = entryPasswordInput.Text;

            string staticUsername = "Jaymian-Lee";
            string staticPassword = "Sjee";

            if ( currentPassword == staticPassword && currentUsername == staticUsername)
            {

                DisplayAlert("Succesful", "Welcome to Heartsync " + staticUsername, "Okay!");

                try
                {
                    Navigation.PushAsync(new View.MusicTaste());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Navigation Exception: " + ex.Message);
                }
            }
            else
            {
                DisplayAlert("Error", "Username or Password is incorrect", "OK");
            }

        }
        private void SignupClicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new View.Signup());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Navigation Exception: " + ex.Message);
            }
        }
        private void ResetClicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new View.ForgotPassword());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Navigation Exception: " + ex.Message);
            }
        }
    }

}
