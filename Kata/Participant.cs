using System;

namespace Kata
{
    public class Participant
    {
        private string name;
        private int telephoneNumber;
        private int zipCode;
        private string city;
        private string country;
        private string registreringsNumber;

        public string RegistrationNumber
        {
            get { return registreringsNumber; }
            set { registreringsNumber = value; }
        }


        public string Country
        {
            get { return country; }
            set { country = value; }
        }


        public string City
        {
            get { return city; }
            set
            {
                var validatCharArray = "abcdefghijklmnopqrstuvwxyzæøå1234567890".ToCharArray();

                var test = value.IndexOfAny(validatCharArray);


                if (value.IndexOfAny(validatCharArray) == -1)
                {
                    throw new ArgumentException();
                }
                city = value;
            }
        }


        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }


        public int TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }


        public string Name
        {
            get { return name; }
            set 
            {
                ValidateName(value);
                name = value; 
            }
        }

        private void ValidateName(string name)
        {
            if (String.IsNullOrEmpty(name))
            throw new ArgumentException();
        }
    }
}
