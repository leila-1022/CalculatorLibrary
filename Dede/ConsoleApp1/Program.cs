using System;

namespace Allan
{
    class ten
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: \xA" + userName);

            Console.WriteLine("Enter Password: ");
            int Password = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Password is : " + Password);

          
        }
    }
}
