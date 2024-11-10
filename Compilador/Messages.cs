using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Compilador
{
    class Messages
    {
        public static readonly string success = "Éxito";
        public static string failure = "¡Error! Este caracter no está definido en el lenguaje: ";
        public static List<string> errormessages = new List<string>();

        public string compile_message(string response)
        {
            string message = "good";

            if (response != "good")
            {
                errormessages.Add("* "+failure + response);
                message = response;
            }     
            return message;
        }

        public string error_tostring()
        {
            string message = "";
            foreach (var item in errormessages)
            {
                message += item + "\n";
            }
            return message;
        }

        public void clear()
        {
            errormessages.Clear();
        }
    }
}
