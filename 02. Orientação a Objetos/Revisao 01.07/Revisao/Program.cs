using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Mae isadora = new Mae();
             * Paizao lucas = new Paizao();
             * Filho filho = isadora.EngravidarDe(lucas);
            
             * Console.WriteLine("Hello World!");
             */
            bool continuar = true;
            string nome = "";

            while(continuar)
            {
                nome = RandomizeString().ToLower();
                continuar = !(nome == "milena");
            }
            Console.WriteLine(nome);
        }
        public static string RandomizeString()
        {
            bool _continue = true;
            var random = new Random();
            string id = "";

            while (_continue)
            {
               id = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", 6).Select(s => s[random.Next(s.Length)]).ToArray());
               _continue = !Regex.IsMatch(id, @"^[a-z]{1}[aeiou]{1}[bcdfghjklmnpqrstvwxyz]{1}[aeiou]{1}[bcdfghjklmnpqrstvwxyz]{1}[aeiou]{1}$");
            }
            return id;
        }

    }
}
