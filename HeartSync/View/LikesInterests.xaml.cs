namespace HeartSync.View;

public partial class LikesInterests : ContentPage
{
	public LikesInterests()
	{
		InitializeComponent();
	}

    private void ContinueClicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Location());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Navigation Exception: " + ex.Message);
        }
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back
        if (Navigation.NavigationStack.Count > 1)
        {
            await Navigation.PopAsync();
        }
    }
 }