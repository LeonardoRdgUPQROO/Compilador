using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Compilador
{
    class LexicCompilator
    {
        private readonly List<string[]> Language;

        public LexicCompilator()
        {
            Language = new List<string[]>
            {
                new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
                new string[] { "a", "b", "c", "d", "e", "f", "g","h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"},
                new string[] { "á", "é", "í", "ó", "ú", "ü"},
                new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"},
                new string[] { "Á", "É", "Í", "Ó", "Ú", "Ü"},
                new string[] { "\"", "'", "`", ".", ",", ";", ":", "\\", "#", "@", "?", "(", ")", "[", "]", "{", "}", "_"},
                new string[] {"+", "-", "*", "/", "^", "%"},
                new string[] {">", "<", "=", "&", "|", "!"},
            };
        }

        public string evaluate(char a)
        {
            string c = a.ToString();
            foreach(var array in Language)
            {
                if (array.Contains(c))
                    return "good";
            }
            return c;
        }
    }
}

