using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page1());
            };

            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedPage1());
            };


            Item5.Clicked += async (sender, e) =>
            {
                var answer = await DisplayAlert("Questions?",
                    "Would you like to play a game", "Yes", "No");
                Debug.WriteLine("Answer: " + answer);
            };

        }
    }
}
