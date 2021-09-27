using System;

namespace assignment5
{
    class Abstract
    {
        static void Main(string[] args)
        {
            SuperComputer sp = new SuperComputer(123,"Dell","1995");
            Console.WriteLine(sp.AboutComputer());
            Console.WriteLine(sp.BootUp());
            Console.WriteLine(sp.Shutdown());
            Console.ReadLine();
        }
    }
}
