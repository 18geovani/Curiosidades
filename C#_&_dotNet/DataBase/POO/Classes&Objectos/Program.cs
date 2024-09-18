using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Classes_Objectos
{
    internal class Program
    {
        //Delegate instanciado
        delegate void Calcular(int n1, int n2);


        static void Main(string[] args)
        {
            //Objectos
            /* @class Professor2 = new @class();
             @class Professor1 = new @class();


             @class Aluno4 = new @class();
             @class Aluno3 = new @class();
             @class Aluno2 = new @class();
             @class Aluno1 = new @class();




             Aluno1.nome = "Geovani";

             Aluno2.nome = "Fábio";
                      Aluno2.num = 2;
             Aluno3.nome = "Jacinto";
                      Aluno3.num = 3;
             Aluno4.nome = "Ismael";
                      Aluno4.num = 4;

             Professor1.nome = "Lucas Pazito";
             Professor2.nome = "Suzarith Sebastião";
            */

            @class Aluno1 = new @class()
            {
                nome = "Geovani Arlindo",
                num = 16,
                turma = "IG12B"
            };

            @class Aluno2 = new @class()
            {
                nome = "Fábio Dos Santos",
                num = 9,
                turma = "IG12B"
            };

            @class Professor1 = new @class()
            {
                nome = "Lucas Pazito",
                turma = "IG12B"
            };
            //Transformando um objecto em JSON
            string JSONaluno1 = JsonSerializer.Serialize<@class>(Aluno1);
            /*
            Console.WriteLine("Configurações: \n 1- Nome de aluno; \t 2- Nome de professor; \n 3- Número de aluno \t 4- Turma  \n Escolha uma opção:");
            
            int conf = 1;
 
            switch (conf)
            {
                case 1:
                        Console.WriteLine("Alterar nome de aluno: \n");
                        Aluno1.nome = Console.ReadLine();
                    Console.WriteLine("Novos dados: " + JSONaluno1);
                    break;
                case 2:
                        Console.WriteLine("Alterar nome de professor: \n"); 
                        Professor1.nome = Console.ReadLine();
                    Console.WriteLine("Prof Nome " + Professor1.nome);
                    break;
                case 3:
                        Console.WriteLine("Alterar número de aluno: \n");
                        Aluno1.num = Console.Read();
                    break;
                default:
                        Console.WriteLine("Nome da turma: \n");
                        Aluno1.turma = Console.ReadLine();
                    Console.WriteLine("Aluno Nome "+ Aluno2.nome);
                    break;
                 }

            */

            //Passagem de Parâmetro por referência
            /*
            @class Aum = new @class();

            int n = 90;
            Console.WriteLine(Aum.Add(n));
            */



            //Delegates
            @class Calculos = new @class();

            Calcular operacao = null;

            operacao += Calculos.Soma;
            operacao += Calculos.Divisao;
            operacao += Calculos.Subtracao;
            operacao += Calculos.Multiplicacao;

            operacao(20, 2);

            Console.ReadKey();
        }
    }
}
