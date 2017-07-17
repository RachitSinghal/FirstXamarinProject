using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trails
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Grid1.TranslateTo(0, 400, 4000, Easing.SpringIn);
            Grid1.RotateTo(180, 3000, Easing.CubicInOut);
            Label1.RotateTo(90, 3000, Easing.CubicInOut);
            Grid1.FadeTo(0.3, 5000, Easing.BounceIn);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Review", "Did you liked the annimation ? ", "Yes", "No");
        }

        private async void Button_Clicked_2Async(object sender, EventArgs e)
        {
            String color = await DisplayActionSheet("Choose the background color", "Don't Change","destruction", "Blue", "Green", "yellow");
            if (color == "Blue")
            {
                BackgroundColor = Color.Blue;
            }
            else if (color == "Green")
            {
                BackgroundColor = Color.Green;
            }
            else if (color == "yellow")
            {
                BackgroundColor = Color.Yellow;
            }
        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Label2.Text = Slider1.Value.ToString();
        }
    }
}
