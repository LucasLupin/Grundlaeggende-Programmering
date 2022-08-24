using System;
namespace PersonObjekter
{
    internal class Person
    {
        private string email;
        private string password;
        private string name;

        public DateTime DoB { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "" || value.All(Char.IsDigit)) name = null;
                else name = value;
            }
        }

        public int Age { get { return GetAge(); } }
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DoB.Year;
            if (today < new DateTime(today.Year, DoB.Month, DoB.Day)) age--;
            return age;
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@") && value.Contains("."))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Email skal havde @ og .");
                    email = null;
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                bool isNumber = false;
                bool isLower = false;
                bool isUpper = false;


                if (value.Length < 6)
                {
                    Console.WriteLine("Skal mindst havde 6 karaktere");
                    password = null;
                }

                foreach (char c in value)
                {
                    if (char.IsUpper(c)) { isUpper = true;  }
                    if (char.IsLower(c)) { isLower = true; }
                    if (char.IsDigit(c)) { isNumber = true; }
                }

                if(isUpper == true && isLower == true && isNumber == true)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Koden skal inde holde små, store bogstaver og Tal");
                    password = null;
                }
            }
        }

    }
}

