namespace HeartSync.View;

public partial class Location : ContentPage
{
	public Location()
	{
		InitializeComponent();
	}

    private async void OnUseCurrentLocationClicked(object sender, EventArgs e)
    {
        try
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            if (location != null)
            {
                var placemarks = await Geocoding.GetPlacemarksAsync(location.Latitude, location.Longitude);
                var placemark = placemarks?.FirstOrDefault();
                if (placemark != null)
                {
                    countryEntry.Text = placemark.CountryName;
                    cityEntry.Text = placemark.Locality;
                }
                else
                {
                    countryEntry.Text = "";
                    cityEntry.Text = "";
                    // Optionally, inform the user that the address couldn't be found
                }
            }
            else
            {
                countryEntry.Text = "";
                cityEntry.Text = "";
                // Optionally, inform the user that the location couldn't be found
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions
            // Optionally, show an error message to the user
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

    private void ContinueClicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Homepage("Jaymian-Lee"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Navigation Exception: " + ex.Message);
        }
    }

}