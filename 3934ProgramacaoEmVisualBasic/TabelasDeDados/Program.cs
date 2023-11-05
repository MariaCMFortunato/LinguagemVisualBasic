using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelasDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("DECLARAÇÃO DE TABELAS UNIDIMENSIONAIS");
            Console.WriteLine("------------------------------------------");
            Console.ReadKey();

            string[] alunos = new string[7];
            alunos[0] = "João";
            alunos[1] = "Susana";
            alunos[2] = "Maria";
            alunos[3] = "Carlos";
            alunos[4] = "Rui";
            alunos[5] = "Ana";
            alunos[6] = "Renato";
            
            Console.WriteLine("Declaração de string com 7 posições: \n\tstring[] alunos = new string[7];");
            Console.WriteLine("Declaração do elemento da primeira posição: \n\talunos[0] = \"João\";");
            Console.WriteLine("Declaração do elemento da segunda posição: \n\talunos[1] = \"Susana\";");
            Console.WriteLine("Declaração do elemento da terceira posição: \n\talunos[2] = \"Maria\";");
            Console.WriteLine("Declaração do elemento da quarta posição: \n\talunos[3] = \"Carlos\";");
            Console.WriteLine("Declaração do elemento da quinta posição: \n\talunos[4] = \"Rui\";");
            Console.WriteLine("Declaração do elemento da sexta posição:  \n\talunos[5] = \"Ana\";");
            Console.WriteLine("Declaração do elemento da sétima posição: \n\talunos[6] = \"Renato\";");
            Console.WriteLine("");

            for (int i = 0; i < alunos.Length;i++)
            {
                Console.WriteLine("Aluno " + (i + 1) +" " + alunos[i]);
            }
            Console.WriteLine("");
            Console.ReadKey();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("DECLARAÇÃO TABELAS MULTIDIMENSIONAIS");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Exemplos em desenvolvimento");
            Console.WriteLine("VER Página 35 do Manual 1-5091-3935");
            Console.ReadKey();



            Console.WriteLine("-----------------------------------------");


            Console.ReadKey();
        }
    }
}
