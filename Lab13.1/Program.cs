using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string adress1 = Console.ReadLine();
            string length1 = Console.ReadLine();
            string width1 = Console.ReadLine();
            string height1 = Console.ReadLine();
            string etag1 = Console.ReadLine();
            Building build = new Building(adress1, length1, width1, height1);
            MultiBuilding multi = new MultiBuilding(adress1, length1, width1, height1, etag1);
            Console.WriteLine(build.Print());
            Console.WriteLine(multi.Print());
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public Building(string adress, string lenght, string width, string height)
        {
            Adress = adress;
            Length = lenght;
            Width = width;
            Height = height;
        }
        public string Print()
        {
            return $"{ Adress} { Length} { Width} { Height}";
        }


    }
    sealed class MultiBuilding : Building
    {
        public string Etag { get; set; }
        public MultiBuilding(string adress, string lenght, string width, string height, string etag)
            : base(adress, lenght, width, height)
        {
            Etag = etag;
        }
        public string Print()
        {
            string result = base.Print();
            result += $" {Etag}";
            return result;
        }
    }




}
