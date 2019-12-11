using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimalGame
{
    public partial class MainPage : ContentPage
    {
        static int scores = 0;

        public MainPage()
        {
            InitializeComponent();

        }
        void ButtonClicked(object sender, System.EventArgs e)
        {
            ImageButton b = (ImageButton)sender;
            string answer = b.ClassId;

            if (answer == "dog")
            {
                scores++;
                DisplayAlert("Correct Answer!", "Scores: " + scores, "Continue");
                Navigation.PushAsync(new Page1());
                scores = 0;
            }
            else
            {
                DisplayAlert("Does not match!", "Game over", "Retry");
                scores = 0;
            }

        }


        //Previous Page Button Function
        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}   

