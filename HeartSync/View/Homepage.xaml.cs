using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Newtonsoft.Json.Linq;

namespace HeartSync.View;

public partial class Homepage : ContentPage
{
	public Homepage(string username)
	{
		InitializeComponent();
        LoadRandomQuote();
    }

    private readonly HttpClient _httpClient = new HttpClient();

    /* private void HomeToolbarItem_Clicked(object sender, EventArgs e)
     {
         Navigation.PushAsync(new MainPage());
     }*/
    private void StartSwiping(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new SwipePage());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Navigation Exception: " + ex.Message);
        }
    }
    private async void LoadRandomQuote()
    {
        string quote = await GetRandomQuoteAsync();
        quoteLabel.Text = quote ?? "Fout bij het laden van de quote.";
    }


    private async Task<string> GetRandomQuoteAsync()
    {
        try
        {
            var response = await _httpClient.GetStringAsync("https://type.fit/api/quotes");
            var quotesArray = JArray.Parse(response);
            var randomIndex = new Random().Next(0, quotesArray.Count);
            var quoteObject = quotesArray[randomIndex];
            var quoteText = quoteObject["text"].ToString();
            var quoteAuthor = quoteObject["author"]?.ToString() ?? "Onbekend";
            return $"\"{quoteText}\"";
        }
        catch (Exception ex)
        {
            // Log de fout
            return null;
        }
    }
    
}