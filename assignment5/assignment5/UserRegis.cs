using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    class UserRegis
    {
        static void Main()
        {
            User user = new User();

            Console.WriteLine("Do u wanna register:");
            string hen = Console.ReadLine();
            if (hen == "yes")
            {
                Console.WriteLine("Enter your id:");
                long Id = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Please Enter Your Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter your Mail ID:");
                string EmailId = Console.ReadLine();
                Console.WriteLine("Enter your Date Of Birth:");
                string DateOfBirth = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Thank You");


            }
            Console.WriteLine(user.ToString());
            Console.ReadLine();


        }
    }
}
