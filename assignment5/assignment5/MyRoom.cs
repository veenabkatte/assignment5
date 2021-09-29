using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class MyRoom

    {
        static void Main()
        {
            Room room = new Room(101, 2, "3BH", 6, "26-09-2021", 35000);
            Console.WriteLine(room.ToString());
            Console.ReadLine();

        }
    }
}
