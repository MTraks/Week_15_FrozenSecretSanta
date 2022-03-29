using System;
using System.Collections.Generic;
using System.IO;

namespace OOPandFiles
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            //getters for SecretSanta

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift;  }
            }



        }
        static void Main(string[] args)
        {
            List<SecretSanta> mySantas = new List<SecretSanta>();
            string[] santasFromFile = GetDataFromFile();

            foreach(string line in santasFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newSanta = new SecretSanta(tempArray[0], tempArray[1]);
                mySantas.Add(newSanta);

            }

            foreach(SecretSanta santaFromList in mySantas)
            {
                Console.WriteLine($"{santaFromList.Name} wants {santaFromList.Gift}.");
            }



        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Matu\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }



    }



}
