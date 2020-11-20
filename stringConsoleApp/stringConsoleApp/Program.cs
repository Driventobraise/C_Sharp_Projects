using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "sake";
            string name2 = "pickle";
            string name3 = name.ToUpper();
            string name4 = name2.ToUpper();
            string part = " are the best Cats!!";
            Console.WriteLine(name3 + " and " + name4 + part);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append(" Today, the people who make things change, the people who have that knowledge,\n are the scientists and the technologists,\n who are the true driving force of humanity.");
            sb.AppendLine("And before you say what about the Beethovens and the Michelangelos?");
            sb.AppendLine(" Let me suggest something with which you may disagree violently:\n that at best, the products of human emotion, art, philosophy, politics, music,\n literature, are interpretations of the world,\n that tell you more about the guy who's talking, than about the world he's talking about.");
            sb.AppendLine(" Second hand views of the world, made third hand by your interpretation of them.");
            sb.AppendLine(" James Burke, Connections");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
