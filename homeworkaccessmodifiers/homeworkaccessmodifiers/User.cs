using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkaccessmodifiers
{
    internal class User
    {
        private string _username;
        private string _password;
        public User(string username)
        {
            
           
        }
        public string Username
        {
            get => _username;
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                    _username = value;

            }
             
            
        }
        public string Password
        {
            get => _password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {

                    if (HasDigit(value)&& HasUpper(value)&& HasLower(value)&& value.Length>=8&& value.Length<=25 )
                    {
                        _password = value;


                    }
                }
                else
                    Console.WriteLine("Passwordu duzgun daxil edin!");



            }

        }
        public bool HasDigit(string str)
        {
            for (int i=0; i<str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;

                }
            }
            Console.WriteLine("Reqem daxil edin!");
            return false;


        }
        public bool HasUpper(string str)
        {
            for (int i=0; i<str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    return true;
                }
            }
            Console.WriteLine("Min. 1 Boyuk herf daxil edin!");
            return false;

        }
        public bool HasLower(string str)
        {
            for (int i=0; i<str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    return true;

                }
            }
            Console.WriteLine("Min. 1 Kichik herf daxil edin!");
            return false;

        }


        
}
}
