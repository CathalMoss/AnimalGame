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
        static string bomb = new Random().Next(1, 4).ToString();
        static int scores = 0;

        public MainPage()
        {
            InitializeComponent();
            
        }
        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //game over
            if(button.Text== bomb)
            {
                await DisplayAlert("Bomb Exploaded", "Game over", "retry");
                bomb = new Random().Next(1, 4).ToString();
                scores = 0;
            } else
            {
                scores += 1;
                await DisplayAlert("Bomb Defused!", "Scores: " + scores, "Continue");
                bomb = new Random().Next(1, 4).ToString();
            }

        }
    }
}
