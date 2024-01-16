using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff
    {

        private string language;

        //Constructor

        public PrintStuff()
        {
            //Nothing passed in
            language = "ENG";
        }
        public PrintStuff(string temp)
        {
            language = temp;
        }
        public void PrintName(string name)
        {
            if (language == "ENG")
            {
                System.Console.WriteLine("Hello, " + name, "!");
            }
            

            if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + name, "!");
            }
        }
    }
}
