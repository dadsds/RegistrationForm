// Реєстраційна форма. Створити клас RegistrationForm, в цьому класі створити властивості Password (string), Login (string), Capcha (string).
// Створити приватні поля trueLogin, truePassword (strings). Ці поля заповнюються в коді.
// Пароль має складатись з 8 символів, серед них букви нижнього регістру, верхнього регістру, цифри (PassWord123).
// Якщо задаємо пароль, що не містить чогось з переліченого вище - клас викидає виключення.
// Логін може бути будь-яким, але починатись має не на цифри.
// Капчу можна згенерувати за допомогою System.Random
// Інтерфейс: запитати у користувача логін. Якщо його введений логін вже не співпадає з умовами задання логіну (згенерувалось виключення)
// то видається повідомлення і робота завершується
// Якщо логін введено за шаблоном, запитати пароль. Якщо пароль введено за шаблоном - згенерувати і запитати капчу. Якщо користувач все ввів вірно
// вивести відповідне повідомлення



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registr
{

    class Program
    {
        static void Main(string[] args)
        {
            RegistrationForm admin = new RegistrationForm();
            admin.Login = "Admin";
            admin.Password = "Admin1234";
            for (;;)
            {
                RegistrationForm form = new RegistrationForm();
                Console.WriteLine("Enter login:");
                try
                {
                    form.Login = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                Console.WriteLine("Enter password:");

                try
                {
                    form.Password = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                string capcha = form.Capcha;
                Console.WriteLine("Enter capcha:");
                Console.WriteLine(capcha);
                while (capcha != Console.ReadLine())
                {
                    Console.WriteLine("Wrong capcha input");
                    capcha = form.Capcha;
                    Console.WriteLine(capcha);
                }
                if (admin.Login != form.Login || admin.Password != form.Password)
                {
                    Console.WriteLine("Autentification declined");
                }
                else
                {
                    Console.WriteLine("Autentification accept");
                }
            }
            Console.ReadKey();
        }
    }
}
