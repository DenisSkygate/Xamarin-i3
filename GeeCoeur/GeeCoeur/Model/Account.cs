using System;
using System.Collections.Generic;

namespace GeeCoeur.Model
{
    public class Account
    {
        public Account()
        {
            Skills = new List<string>();

            Games = new List<string>();
            Movies = new List<string>();
            TvShows = new List<string>();
            Books = new List<string>();
            Music = new List<string>();

            Work = new Work();
        }

        //Basic info
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Pseudo { get; private set; }
        public DateTime Birthday { get; private set; }
        public int SexualOrientation { get; private set; }

        //Status
        public int Status { get; private set; }

        //Interests
        public List<string> Games { get; private set; }
        public List<string> Movies { get; private set; }
        public List<string> TvShows { get; private set; }
        public List<string> Books { get; private set; }
        public List<string> Music { get; private set; }

        //Work
        public Work Work { get; private set; }

        //Skills
        public List<string> Skills { get; private set; }

        public void SetSignUpInfo(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void SetBasicInfo(DateTime birthday, string firstName = null, string lastName = null, string username = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Pseudo = username;
            Birthday = birthday;
        }
    }
}