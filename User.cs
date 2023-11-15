using System;

namespace task
{
    public abstract class User : Account
    {
        private string password;
        private static int _id = 1;

        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        

        public string Password
        {
            get => password;
            set
            {
                if (PasswordChecker(value))
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Password is incorrect");
                }
            }
        }

        public User(string fullname, string email, string password, int id)
        {
            Fullname = fullname;
            Email = email;
            Password = password;
            Id = ++_id;
        }
        public  void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Fullname: {Fullname} - Email: {Email}");
        }
    }
}

        









