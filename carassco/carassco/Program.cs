using System;

class Program
{
    static void Main(string[] args)
    {
        string username, password;
        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter username: ");
            username = Console.ReadLine();

            Console.Write("Enter password: ");
            password = Console.ReadLine();

            if (username == "Admin" && password == "Admin1234!")
            {
                Console.WriteLine("Login successful");
                return;
            }
            else
            {
                Console.WriteLine("Incorrect credentials. Please try again.");
                attempts--;
            }
        }

        if (attempts == 0)
        {
            Console.WriteLine("Too many failed attempts. Please try again later.");
        }
    }
}
