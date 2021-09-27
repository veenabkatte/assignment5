using System;



namespace assignment5
{
    public abstract class Computer
    {
        public int ModelNo { get; set; }
        public string ModelName { get; set; }
        public string Year { get; set; }
        
        public Computer(int modelNo, string modelName, string year)
        {
            this.ModelNo = modelNo;
            this.ModelName = modelName;
            this.Year = year;
        }
        public string AboutComputer()
        {
            return $"Model No={this.ModelNo} Name={this.ModelName} Year={this.Year}";
        }
        public string BootUp()
        {
            return "BootUp() calling from Computr";
        }
        public string Shutdown()
        {
            return "Shutdown() calling from Computer";
        }

    }
    class SuperComputer : Computer
    {
        public SuperComputer(int modelNo, string modelName, string year) : base(modelNo, modelName, year)
        {

        }
        public string Windows(int window)
        {
            return $"This is {window} SuperComputer";
        }
    }

    



}



