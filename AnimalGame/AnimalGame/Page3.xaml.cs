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
	public partial class Page3 : ContentPage
	{
        //variables
        int scores = 3;
		public Page3 ()
		{
			InitializeComponent ();
		}

        //buttonFunction for correct or incorrect answer
        void ButtonClicked(object sender, System.EventArgs e)
        {
            ImageButton b = (ImageButton)sender;
            string answer = b.ClassId;

            //if else statement for answer
            if (answer == "mouse")
            {
                //scores adds up and brings user to the next page
                scores=4;
                DisplayAlert("Correct Answer!", "Scores: " + scores, "Continue");
                Navigation.PushAsync(new Page4());
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
        void Handle_Clicked(object sender, System.EventArgs e)
        {
  
            Navigation.PopAsync();
 
        }


    }
}