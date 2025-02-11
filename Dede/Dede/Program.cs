using System;

namespace Random
{
    class allan
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter Username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: \xA" + userName);

            Console.Clear();
            Console.WriteLine("Enter Password: ");
            string Password = (Console.ReadLine());
            Console.WriteLine("Your Password is : " + Password);
        

            Console.Clear();
            Console.WriteLine("Username:" + userName);
            Console.WriteLine("Password:" + Password);


            Console.ReadKey();
            string name = "SHeila";
            string message = "My name is " + name;
            string interMessage = $"My name is {name}";

            Console.WriteLine(message);
            Console.WriteLine(interMessage);
            Console.ReadKey();

            Console.Write("Enter a number: ");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            Console.ReadKey();
        }

    }
}

