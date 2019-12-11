using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimalGame
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page7 : ContentPage
	{
        //variables
        int scores = 7;
        public Page7()
        {
            InitializeComponent();
        }
        //buttonFunction for correct or incorrect answer
        void ButtonClicked(object sender, System.EventArgs e)
        {
            ImageButton b = (ImageButton)sender;
            string answer = b.ClassId;
            //if else statement for answer
            if (answer == "skunk")
            {
                //scores adds up and brings user to the next page
                scores = 8;
                DisplayAlert("Correct Answer!", "Scores: " + scores, "Continue");
                Navigation.PushAsync(new Page8());
            }
            else
            {
                //wrong answer the game ends and brings user to the start page
                DisplayAlert("Does not match!", "Game over", "Retry");
                scores = 0;
                Navigation.PopToRootAsync();

            }
        }

 
        //previous page button function
        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}