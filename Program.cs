using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliFuncionario
{
 class Program
    {
        static void Main(string[]args)
        {
            FuncionarioN1 n1 = new FuncionarioN1();
            n1.Nome = "João";

            FuncionarioN2 n2 = new FuncionarioN2();
            n2.Nome = "Miguel";

            FuncionarioN3 n3 = new FuncionarioN3();
            n3.Nome = "Pedro";

            Console.WriteLine($"Nome: {n1.Nome}\n Participação: { n1.ParticipacaoLucro().ToString("F2")}\n");

            Console.WriteLine($"Nome: {n2.Nome}\n Participação: { n2.ParticipacaoLucro().ToString("F2")}\n");

            Console.WriteLine($"Nome: {n3.Nome}\n Participação: { n3.ParticipacaoLucro().ToString("F2")}\n");

            Console.ReadKey();
        }

    }











}