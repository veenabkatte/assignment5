using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    class MainframeComputer : SuperComputer
    {
        public MainframeComputer(int modelNo, string modelName, string year) : base(modelNo, modelName, year)
        {
            Console.WriteLine("Default constucter Mainframe");
        }
        public string Windows()
        {
            return "Windows() calling from MainframeComputer";
        }
    }
}
