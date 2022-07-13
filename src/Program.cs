using System;
using System.IO;

namespace DungeonsAndDragons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Second Edition Advanced Dungeons and Dragons Assistant");
            /*
            Would you like to make a new player character?
            yay or nay
            if yay then open a file and begin writing to it.
            */
            
            PlayerCharacter EddieMunson = new PlayerCharacter();

            EddieMunson.m_CharAge = 16;
            EddieMunson.m_CharName = "Voldric";

            Console.WriteLine($"My Character is {EddieMunson.m_CharAge} years old");
            Console.WriteLine($"My Character is named {EddieMunson.m_CharName}");



        }
    }
}