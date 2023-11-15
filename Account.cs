using System;

namespace task
{
    abstract class Account
    {
        public  bool PasswordChecker(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            if (!password.Any(Char.IsUpper)) 
            {
                return false;
            }
            if (!password.Any(Char.IsLower))
            {
                return false;
            }
            if (password.Any(Char.IsNumber))
            {
                return false;
            }
            return true;
        }
        

    }

}