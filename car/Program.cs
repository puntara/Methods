using System;

namespace car
{
    class car
    {
        public string model;
        public string color;
        public int year;
        public car (string modelName, string colorType, int Year )
        {
            model = modelName;
            color = colorType;
            year = Year;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            car mycar = new car("Mustang", "red", 1995);
            Console.Write( mycar.model+" "+mycar.color+" "+mycar.year);
        }
    }
}
