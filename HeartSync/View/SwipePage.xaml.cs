using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Controls;
using HeartSync.Models;

namespace HeartSync.View;

public partial class SwipePage : ContentPage
{
    public ObservableCollection<Profile> Profiles { get; private set; }
    private int _currentProfileIndex = 0;

    private Profile _currentProfile;
    public Profile CurrentProfile
    {
        get => _currentProfile;
        set
        {
            _currentProfile = value;
            OnPropertyChanged(nameof(CurrentProfile)); // Notify UI of change
        }
    }

    public ICommand SwipeLeftCommand { get; private set; }
    public ICommand SwipeRightCommand { get; private set; }
    public ICommand OnBackButtonCommand { get; private set; }

    public SwipePage()
    {
        InitializeComponent();
        InitializeProfiles();
        BindingContext = this;

        SwipeLeftCommand = new Command(ExecuteSwipeLeft);
        SwipeRightCommand = new Command(ExecuteSwipeRight);
        OnBackButtonCommand = new Command(OnBackButtonClicked);

        var panGesture = new PanGestureRecognizer();
        panGesture.PanUpdated += OnPanUpdated;
        SwipeCard.GestureRecognizers.Add(panGesture);

        if (Profiles.Any())
        {
            CurrentProfile = Profiles[_currentProfileIndex];
        }
    }

    private void InitializeProfiles()
    {
        Profiles = new ObservableCollection<Profile>
        {
            // Add your profiles here
            new Profile { Name = "Jaymian-Lee Reinartz", ImageUrl = "https://www.rpwebdesign.nl/wp-content/uploads/2023/10/Thumnbail-1-500x500.png"},
            new Profile { Name = "Noa Heutz", ImageUrl = "https://streetartcities.com/media/2/2cbe8dc2-7e8b-4743-9576-fff32d79ee11/orig.jpg"},
        };
    }
    private void OnBackButtonClicked()
    {
        // Implement the back button logic
        if (Navigation.NavigationStack.Count > 1)
        {
            Navigation.PopAsync();
        }
    }

    private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
        switch (e.StatusType)
        {
            case GestureStatus.Running:
                HandleCardMovement(e.TotalX, e.TotalY);
                break;
            case GestureStatus.Completed:
                HandleSwipeDirection(e.TotalX, e.TotalY);
                break;
        }
    }

    private void HandleCardMovement(double x, double y)
    {
        var screenWidth = DeviceDisplay.MainDisplayInfo.Width;
        SwipeCard.TranslationX = x;
        SwipeCard.TranslationY = y;
        SwipeCard.Rotation = (x / screenWidth) * 30; // Adjust rotation angle as needed
    }


    private void HandleSwipeDirection(double x, double y)
    {
        const double swipeThreshold = 20; // Adjust as needed for sensitivity
        if (Math.Abs(x) > swipeThreshold)
        {
            if (x > 0) // Right Swipe
            {
                SwipeRightAction();
            }
            else // Left Swipe
            {
                SwipeLeftAction();
            }
            LoadNextProfile();
        }
        else
        {
            ResetCardPosition();
        }
    }
    private void ExecuteSwipeLeft()
    {
        SwipeLeftAction();
        LoadNextProfile();
    }

    private void ExecuteSwipeRight()
    {
        SwipeRightAction();
        LoadNextProfile();
    }

    private void SwipeRightAction()
    {
        // Implement right swipe action
        DisplayAlert("Match", "You have matched with this profile!", "OK");
    }

    private void SwipeLeftAction()
    {
        // Implement left swipe action
        DisplayAlert("Ignore", "You have ignored this profile.", "OK");
    }

    private void LoadNextProfile()
    {
        _currentProfileIndex++;
        if (_currentProfileIndex < Profiles.Count)
        {
            CurrentProfile = Profiles[_currentProfileIndex];
            ResetCardPosition();
        }
        else
        {
            // Optionally, reset the profile index to start over
            _currentProfileIndex = 0;
            CurrentProfile = Profiles[_currentProfileIndex];
        }
    }
    private void OnSwipeLeftButtonClicked(object sender, EventArgs e)
    {
        ExecuteSwipeLeft();
    }

    private void OnSwipeRightButtonClicked(object sender, EventArgs e)
    {
        ExecuteSwipeRight();
    }
    private void ResetCardPosition()
    {
        SwipeCard.TranslationX = 0;
        SwipeCard.TranslationY = 0;
        SwipeCard.Rotation = 0;
    }
}