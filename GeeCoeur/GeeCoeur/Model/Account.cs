using System;
using System.Collections.Generic;

namespace GeeCoeur.Model
{
    public class Account
    {
        public Account()
        {
            Status = new bool[3];
            Games = new List<string>();
            Movies = new List<string>();
            TvShows = new List<string>();
            Books = new List<string>();
            Music = new List<string>();
            Skills = new List<Skill>();
        }

        //Basic info
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Pseudo { get; set; }
        public DateTime Birthday { get; set; }
        public int SexualOrientation { get; set; }

        //Status
        public bool[] Status { get; set; }

        //Interests
        public List<string> Games { get; set; }
        public List<string> Movies { get; set; }
        public List<string> TvShows { get; set; }
        public List<string> Books { get; set; }
        public List<string> Music { get; set; }

        //Work
        public Work Work { get; set; }

        //Skills
        public List<Skill> Skills { get; set; }
    }
}