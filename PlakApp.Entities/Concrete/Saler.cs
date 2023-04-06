using PlakApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlakApp.Entities.Concrete
{
    public class Saler: BaseEntity
    {
      
        public string UserName { get; set; }
        

        private string _sifre;

        public string Password
        {
            get { return _sifre; }
            set
            {
                if (IsValidPassword(value) == true)
                {
                    _sifre = sha256_hash(value);
                }

                else
                {
                    throw new Exception("Şifre En az 8 karakter uzunluğunda olmalıdır.\r\n En az 2 büyük  harf, 3 küçük harf içermelidir.  !, :, +, * karakterlerinden en az 2 tanesini içermelidir.");
                }
            }



        }
        public string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(Password)).Select(l => l.ToString("X2")));
            }
        }

        static bool IsValidPassword(string password)
        {
            int upperCase = 0, lowerCase = 0, specialChars = 0;

            if (password.Length <= 8)
                return false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    upperCase++;
                else if (char.IsLower(c))
                    lowerCase++;
                else if (c == '!' || c == ':' || c == '+' || c == '*')
                    specialChars++;
            }

            return upperCase >= 2 && lowerCase >= 3 && specialChars >= 2;
        }

    }

}
