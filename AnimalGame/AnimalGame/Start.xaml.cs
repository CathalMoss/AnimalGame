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
	public partial class Start : ContentPage
	{
		public Start ()
		{
			InitializeComponent ();
		}
          
           // if users dont want to sign up they can just play the game
          void Handle_Clicked(object sender, System.EventArgs e)
          {
              Navigation.PushAsync(new MainPage());
              DisplayAlert("Welcome", "Complete these 10 questions by matching the animal with the text", "Continue");

          } 

        //sign up procedure code
        private async void SignInProcedure(object sender, EventArgs e)
        {
            //when button is cliked it will go onto the next page
            await Navigation.PushAsync(new MainPage());

            User user = new User(Entry_Username.Text, Entry_Password.Text);

            //checking information in user page
            if (user.CheckInformation())
            {
                //if sign up info successful it will output this alert
                DisplayAlert("Sign Up", "Welcome! " + Entry_Username.Text + " You have signed up successfully, Complete these 10 questions by matching the correct animal with the text." , "Continue");
            }
            else
            {
                //if sign up info not successful it will output this alert
                DisplayAlert("Sign Up", "Sign up not successful, Please try again", "Continue");
            }
        }
    }
}
