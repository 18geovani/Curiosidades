using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;


namespace testeDoThread
{
    public class Program
    {      
            public static void Main()
            {
                  Thread thread1 = new Thread(ImprimeK19);
                  Thread thread2 = new Thread(ImprimeK31);
                  thread1.Start();
                  thread2.Start();
            }

            public static void ImprimeK19()
            {
                 for (int i = 0; i < 10; i++)
                 {
                     Console.WriteLine("Geovani ");
                
                 }
            }
            public static void ImprimeK31()
            {
                for (int i = 0; i < 10; i++)
                {
                Console.WriteLine("K31 ");
                }
            }



        /*
       static void Main()
       {
           TextReader teclado = Console.In;
           TextWriter arquivo = new StreamWriter(" saida . txt ");
           string linha = teclado.ReadLine();
           while (linha != null)
           {
               arquivo.WriteLine(linha);
               linha = teclado.ReadLine();
           }
           arquivo.Close();
       }
         */

    }
}


