using System;
using System.Collections.Generic;
using System.Text;

//project name
namespace AnimalGame
{
    //page name
    public class User
    {
        //storing models in a database - empty constructor with two empty constructors
        public int Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public User() { }

        //class with two parameters
        public User(String Username, String Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        //checking the information
        public bool CheckInformation()
        {
            //storing username, then using username on welcome pop up box
            if (!this.Username.Equals("") && this.Password.Equals(""))
                return false;
            else
                return true;

        }
    }
}
