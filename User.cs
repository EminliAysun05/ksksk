

using System.ComponentModel.Design;

namespace ksksk
{
    public class User: Account
    {
        private static int next_id;

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string fullname, string email, int id)
        {
            id = ++next_id;
            this.Fullname = fullname;
            this.Email = email;
            this.Id = id;
        }
        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8)
            {
                return false;
          
            }
            bool HasUpperCase = false;
            bool HasLowerCase = false;
            bool HasDigit = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    HasUpperCase = true;
                }
                else if (char.IsLower(c))
                {
                    HasLowerCase = true;
                }
                else if (char.IsDigit(c))
                {
                    HasDigit = true;
                }
            }
            return HasDigit && HasLowerCase && HasUpperCase;
        }

        public string ShowInfo()
        {
            return $"Fullname: {Fullname},Email: {Email},Id: {Id}";
        }

    }

   
    }

