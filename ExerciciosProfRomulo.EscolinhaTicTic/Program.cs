using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercício 4- Crie um programa para a escolinha Tic Tic
            calcular 3 notas de um aluno.
            Entrar com o nome do aluno e as três notas
            Mostrar a soma das notas e a média.
            */

            //declaração de variáveis
            string nome;
            double n1;
            double n2;
            double n3;
            double media;

            Console.WriteLine("Coloque o nome do aluno:");


            //Entrada de Dados
            nome = Console.ReadLine();
            Console.WriteLine("Coloque a nota do 1° Bimestre do Aluno:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque a nota do 2° Bimestre do Aluno:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque a nota do 3° Bimestre do Aluno:");
            n3 = double.Parse(Console.ReadLine());
            media = (n1 + n2 + n3) / 3; // cálculo da média

            // mostrar para o usuário

            Console.WriteLine($"A média do Aluno {nome} é {media}");

            if (media > 7)
            {
                Console.ForegroundColor = ConsoleColor.Green; //cor letras do console
                Console.WriteLine($"o aluno está aprovado!");
            }
            else if (media >= 5 && media < 7)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"O aluno está de recuperação...");
            }
            else if (media < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Aluno está reprovado.");
                
            }
            Console.ReadKey();
        }
    }
}
