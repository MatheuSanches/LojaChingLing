using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCL
{
    public class Cripto
    {
        //Método usado para criptografar, pode ser internal, public, private...
        public string Base64Encode(string texto)
        {
            var textoencode = System.Text.Encoding.UTF8.GetBytes(texto);
            return System.Convert.ToBase64String(textoencode);
        }

        //Método usado para descriptografar, pode ser internal, public, private...
        public string Base64Decode(string textodata)
        {
            var textodecode = System.Convert.FromBase64String(textodata);
            return System.Text.Encoding.UTF8.GetString(textodecode);
        }
    }
}
