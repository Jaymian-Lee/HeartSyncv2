namespace HeartSync.View;

public partial class MusicTaste : ContentPage
{
	public MusicTaste()
	{
		InitializeComponent();
	}

	private void ContinueClicked(object sender, EventArgs e)
	{
        try
        {
            Navigation.PushAsync(new LikesInterests());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Navigation Exception: " + ex.Message);
        }
    }

}