using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> gsFutbolcu = new MyDictionary<string, string>();

            gsFutbolcu.Add("Fernando Muslera", " " + "34");
            gsFutbolcu.Add("Mostafa Muhammed", " " + "23");
            gsFutbolcu.Add("Henry Onyekuru", " " + "23");
            gsFutbolcu.Add("Radamel Falcao"," " + "35");

            Console.WriteLine(gsFutbolcu.Count);
            gsFutbolcu.List();

        }
    }
}
