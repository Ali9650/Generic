using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Messages
    {
        public static void SuccesMessage(string title)
        {
            Console.WriteLine($"{title}  succesfully added");
        }

        public static void AlreadyExistMessage(string title)
        {
            Console.WriteLine($"{title} is already exist");
        }
        public static void SuccesDeleteMessage(string title)
        {
            Console.WriteLine($"{title} succesfully deleted");
        }
        public static void NotFoundMessage(string title)
        {
            Console.WriteLine($"{title} not found");
        }
        public static void InvalidInputMessage(string title)
        {
            Console.WriteLine($"{title} is invalid, please try again");
        }
    }
}
