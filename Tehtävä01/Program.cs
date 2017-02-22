using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä01
{
    class Program
    {
        static void Main(string[] args)
        {
            string teksti = "oletus";

            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("file.txt"); // luo tekstitiedoston ohjelman kansioon

            // kysyy käyttäjältä tekstiä kunnes tämä syöttää q
            while (teksti != "q") {

                Console.Write("Give a text line ('q' to exit):  ");
                teksti = Console.ReadLine();
                outputFile.WriteLine(teksti);
            }
            
            outputFile.Close(); // sulkee tiedoston

            // tulostaa tiedoston sisukset komentoriville
            string text = System.IO.File.ReadAllText("file.txt");
            System.Console.WriteLine("\nContents of file.txt:\n\n" + text);
        } 
    }
}
