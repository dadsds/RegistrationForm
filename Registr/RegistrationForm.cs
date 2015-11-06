using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registr
{
    class RegistrationForm
    {
        //git github 
        // Пароль має складатись з 8 символів або більше, серед них букви нижнього регістру, верхнього регістру, цифри (PassWord123).
        // Якщо задаємо пароль, що не містить чогось з переліченого вище - клас викидає виключення.
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException("Password setting error");
                }
                if (value.Length < 8)
                {
                    throw new ArgumentException("Password must have more than 8 symbols");
                }
                if (value.Contains(" "))
                {
                    throw new ArgumentException("Password can't have a space symbol");
                }
                bool c1 = false;
                bool c2 = false;
                bool c3 = false;
                foreach (var item in value)
                {
                    if (item >= 'a' && item <= 'z')
                    {
                        c1 = true;
                    }
                    if (item >= 'A' && item <= 'Z')
                    {
                        c2 = true;
                    }
                    if (item >= '0' && item <= '9')
                    {
                        c3 = true;
                    }
                }
                if (!(c1 && c2 && c3))
                {
                    throw new ArgumentException("Password must have upper and lower symbols and numbers");
                }
                password = value;
            }
        }

        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException("Login setting error");
                }
                if (value[0] >= '0' && value[0] <= '9')
                {
                    throw new Exception("Login must begin from letter");
                }
                if (value.Contains(" "))
                {
                    throw new Exception("Login can't have a space symbol");
                }
                login = value;
            }
        }
        /// <summary>
        /// Always return new capcha
        /// </summary>
        public string Capcha
        {
            get
            {
                List<char> symbols = new List<char>();
                for (int i = 'a'; i <= 'z'; i++)
                {
                    symbols.Add((char)(i));
                }
                for (int i = 'A'; i <= 'Z'; i++)
                {
                    symbols.Add((char)(i));
                }
                for (int i = '0'; i <= '9'; i++)
                {
                    symbols.Add((char)(i));
                }
                string result = "";
                Random rand = new Random();
                for (int i = 0; i < 5; i++)
                {
                    result += symbols[rand.Next(0, symbols.Count)];
                }
                return result;
            }
        }

    }



}
