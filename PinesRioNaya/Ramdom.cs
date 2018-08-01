using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinesRioNaya
{
    class Ramdom
    {
        public  string combinar()
        {
            int longitud = 7;
            const string alfabeto = "abcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder token = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }

            return token.ToString();

        }
    }
}
