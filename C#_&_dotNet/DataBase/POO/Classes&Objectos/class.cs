using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objectos
{
    //Classes
    public class @class
    {
        public int num { get; set; }
        public string nome { get; set; }
        public string turma { get; set; }

        //Métodos
        public int Add(int num)
        {
            num += 10;
            return num;
        }

        //Passagem de parâmetro por referência
        public int AddRef(ref int num)
        {
            num += 10;
            return num;
        }

        //Delegates
        public void Soma(int num, int num2)
        {
            Console.WriteLine("A soma: " + (num + num2));
        }
        public void Subtracao(int num, int num2)
        {
            Console.WriteLine("A subtracao: " + (num - num2));
        }
        public void Divisao(int num, int num2)
        {
            Console.WriteLine("A divisao: " + (num / num2));
        }
        public void Multiplicacao(int num, int num2)
        {
            Console.WriteLine("A Multiplicação: " + (num * num2));
        }
    }
}