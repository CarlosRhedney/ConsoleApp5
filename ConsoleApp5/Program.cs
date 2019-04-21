using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, materia, ra;
            int faltas;
            double notap1, notap2, media;
            Console.WriteLine("Digite o nome do aluno:");
            nome = Console.ReadLine();
            Console.WriteLine("\nDigite a matéria do aluno:");
            materia = Console.ReadLine();
            Console.WriteLine("\nDigite o ra do aluno:");
            ra = Console.ReadLine();
            Console.WriteLine("\nDigite a quantidade de faltas do aluno:");
            faltas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite a nota p1 do aluno:");
            notap1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite a nota p2 do aluno:");
            notap2 = Convert.ToDouble(Console.ReadLine());
            media = (notap1 + notap2) / 2;
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\nNome: {0}\tMateria: {1}", nome, materia);
            Console.WriteLine("\nRA: {0}\tNúmero de faltas: {1}", ra, faltas);
            Console.WriteLine("\nNotas: \tNota p1: {0}\tNota p2: {1}\tMédia: {2}", notap1, notap2, media);
            if (media >= 7 && faltas <= 10)
            {
                Console.WriteLine("\nStatus do Aluno: \tAluno Aprovado!");
            }
            else
            {
                Console.WriteLine("\nStatus do Aluno: \tAluno Reprovado!");
            }
            Console.WriteLine("\n************************************************************************");
            Console.WriteLine("\nPressione qualquer tecla para sair.....");
            Console.ReadKey();

        }
    }
}
