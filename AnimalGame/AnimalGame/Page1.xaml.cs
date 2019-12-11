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
	public partial class Page1 : ContentPage
	{
        //variables
        int scores=1;

        public Page1 ()
		{
			InitializeComponent ();
		}

        //buttonFunction for correct or incorrect answer
        void ButtonClicked(object sender, System.EventArgs e)
        {
            ImageButton b = (ImageButton)sender;
            string answer = b.ClassId;

            //if else statement for correct answer
            if (answer == "fish")
            {
                //adding score when correct image clicked and brings user to the next page
                scores=2;
                DisplayAlert("Correct Answer!", "Scores: " + scores, "Continue");
                Navigation.PushAsync(new Page2());
            }
            else
            {
                //reply if incorrect answer, brings user back to main page
                DisplayAlert("Does not match!", "Game over", "Retry");
                scores = 0;
                Navigation.PopToRootAsync();
            }
            
        }

        //Previous Page Button Function
        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}