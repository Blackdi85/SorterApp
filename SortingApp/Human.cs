using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace SortingApp
{
    public class Human
    {
        public string FirstName;
        public string LastName;
        public string FirstGivenName;
        public string SecondGivenName;
        public string ThirdGivenName;

        public void FromString(string str)
        {
            string[] arr = str.Split(' ');
            FirstName = arr.First();
            LastName = arr.Last();


            if (arr.Length > 2)
            {
                FirstGivenName = arr.ElementAt(1);
            }
            else { FirstGivenName = string.Empty; }

            if (arr.Length > 3)
            {
                SecondGivenName = arr.ElementAt(2);
            }
            else { SecondGivenName = string.Empty; }

            if (arr.Length > 4)
            {
                ThirdGivenName = arr.ElementAt(3);
            }
            else { ThirdGivenName = string.Empty; }

        }

        public override string ToString()

        {
            string TextOut = $"{FirstName} {FirstGivenName} {SecondGivenName} {ThirdGivenName} {LastName}";
            TextOut = Regex.Replace(TextOut, @"\s+", " "); // Remove spaces
            return TextOut;
        }

    }
}






