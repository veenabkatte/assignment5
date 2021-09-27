using System;



namespace assignment5
{
    class Inheritance
    {
        static void Main()
        {
            MicroComputer mp = new MicroComputer(123, "Dell","2008");
            
            Console.WriteLine(mp.AboutComputer());
            Console.WriteLine(mp.Windows());
            Console.WriteLine(mp.Processor());
            Console.WriteLine(mp.BootUp());
            Console.WriteLine(mp.Shutdown());
            Console.ReadLine();
        }
    }
}
