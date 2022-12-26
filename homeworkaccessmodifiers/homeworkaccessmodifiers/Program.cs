using System;

namespace homeworkaccessmodifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. User əlavə et");
            Console.WriteLine("2. Userlara bax");
            Console.WriteLine("3. Userlar üzrə axtarış et");
            string str1 = Console.ReadLine();
            User[] userArr = new User[0];
            User Nigar = new User(null);
            if (str1 == "1")
            {
                Console.WriteLine("Username-i daxil edin!");
                Nigar.Username = Console.ReadLine();
                Console.WriteLine("Password-u daxil edin!");
                Nigar.Password = Console.ReadLine();

                Array.Resize(ref userArr, userArr.Length + 1);

                userArr[userArr.Length - 1] = Nigar;
            }
            else if (str1 == "2")
            {
                for (int i=0; i<userArr.Length; i++)
                {
                    Console.WriteLine(userArr[i].Username); 
                }
            }


        }

    }
}
