using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace testedobuilder
{
     class Programa
     {
        static void Main()
        {
            //Escrevendo uma cadeia sem ocupar espaço na memória
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i< 10; i ++)
            {
                builder.Append(i ) ;
                builder.Append(" ") ;
                
            }
                string numeros = builder.ToString();
                Console.WriteLine(numeros);          
        }
        
     }
}
