using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird
{
    class Bird
    {   //Properties
        public string Name { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }
        public string Weight { get; set; }
        public string BandNum  { get; set; }
        //Constructor
        public Bird(string name, string species, string sex, string weight, string bandnum)
        {
            Name = name;
            Species = species;
            Sex = sex;
            Weight = weight;
            BandNum = bandnum;
        }              
        //Method
        public string DisplayBird()
        {
            return Name + "\n" + Species + "\n" + Sex + "\n" + Weight + "\n" + BandNum;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please update the Bird Data: \n");

            Console.WriteLine("Enter Bird name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Species: ");
            string species = Console.ReadLine();
            Console.WriteLine("Enter Sex of Bird: ");
            string sex = Console.ReadLine();
            Console.WriteLine("Enter weight of the Bird: ");
            string weight = Console.ReadLine();
            Console.WriteLine("Enter BandNumber: ");
            string bandnum = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Bird of prey output data");
            Console.WriteLine("");
            //Method being called
            Bird b1 = new Bird(name,species,sex,weight,bandnum);
            Console.WriteLine(b1.DisplayBird());


        }
    }
}
