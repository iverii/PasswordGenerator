using System;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Generator Is Working...");

            while (true)
            {
                Console.WriteLine("Enter the length of the password: ");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Include special characters in the password like (#$%^&)?  (y/n)");
                bool includeSpecial = (Console.ReadLine() == "y");

                Console.WriteLine("Your password is: " + GeneratePassword(length, includeSpecial));

                Console.WriteLine("Generate another password? (y/n)");
                string again = Console.ReadLine();
                if (again != "y")
                {
                    break;
                }
            }
            Console.WriteLine("Hope You Done");
        }
        static string GeneratePassword(int length, bool includeSpecial)
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int characterType = random.Next(3);

                if (characterType == 0)
                {
                    password.Append((char)random.Next('a', 'z' + 1));
                }
                else if (characterType == 1)
                {
                    password.Append((char)random.Next('A', 'Z' + 1));
                }
                else if (includeSpecial && characterType == 2)
                {
                    password.Append((char)random.Next('!', '/' + 1));
                }
                else
                {
                    password.Append((char)random.Next('0', '9' + 1));
                }
            }
            return password.ToString();
        }
    }
}
