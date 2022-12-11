using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIHelpers
{
    public class InputString
    {
        bool isVarParsed = false;
        string? varReaded;
        public string InputStringFromUser(string question)
        {
            while (isVarParsed is false)
            {
                Console.WriteLine(question);
                varReaded = Console.ReadLine();
                isVarParsed = varReaded is string;

                if (isVarParsed is false)
                {
                    Console.WriteLine("Ups, não entendi valor...");
                    Console.WriteLine("Tenta de novo?");
                    Console.WriteLine("");
                }
            }
            isVarParsed = false;
            return varReaded;
        }
    }
}