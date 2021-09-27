using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    class SealedClass
    {
        static void Main()
        {
            Pen pen = new Pen();
            Console.WriteLine(pen.StartWriting());
            Console.WriteLine(pen.StopWriting());
            Console.ReadLine();

        }

        
    }
    sealed class Pen
        {
        public String StartWriting()
        {
            return "start Writing";
        }
        public String StopWriting()
        {
            return "stop Writing";
        }

    }

}
