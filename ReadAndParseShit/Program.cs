using System;
using System.IO;
using System.Text;

namespace ReadAndParseShit
{
    class Program
    {
        public static string filepath = "C:\\Projects\\Towns\\DataSwe.csv";


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReadListFromFile();
            Console.ReadKey();
        }
        private static void ReadListFromFile()
        {
            using (StreamReader reader = new StreamReader(filepath, Encoding.GetEncoding("iso-8859-1")))
            {
                string line = "";
                line = reader.ReadLine();
                while (line != null)
                {
                    string[] lineData = line.Split(';');
                    Console.Write("No: " + lineData[0]);
                    Console.Write(" Name: " + lineData[1]);
                    Console.Write(" Reg: " + lineData[2]);
                    Console.Write(" Pop: " + lineData[3]);
                    Console.Write(" TotArea: " + lineData[4]);
                    Console.Write(" LandArea: " + lineData[5]);
                    Console.Write(" Sjöarea1: " + lineData[6]);
                    Console.Write(" Sjöarea2: " + lineData[7]);
                    Console.Write(" HavArea: " + lineData[8]);
                    Console.Write(DateTime.Now);




                    Console.WriteLine();


                    line = reader.ReadLine();
                }

            }
        }
    }

}

