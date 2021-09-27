using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    class MicroComputer:MainframeComputer
    {
        public MicroComputer(int modelNo, string modelName, string year) : base(modelNo, modelName, year)
        {

        }
        public string Processor()
        {
            return "Processor() calling from MicroComputer";
        }
    }
}
