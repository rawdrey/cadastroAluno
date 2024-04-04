using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroAluno
{
    class Program
    {
        static void Main(string[] args)
        {
        while(true)
            {
                Console.WriteLine("Escolha uma opção!");
                Console.WriteLine("1. Adcionar aluno.");
                Console.WriteLine("2. Buscar aluno pelo índice.");
                Console.WriteLine("3. Exibir todos alunos..");
                Console.WriteLine("4. Sair.");
                Console.Write("Opção");
                string opcao = Console.ReadLine();
                switch(opcao)
                {
                    case "1":
                        AdcionarAluno();
                        break;

                    case "2":
                        BuscarAluno();
                        break;
                    case "3":
                        ExibirTodosAlunos;
                        break;
                    case "4":
                        Console.WriteLine("Saindo do programa.");
                        return;
                }
            }        
        }
        static void AdcionarAluno()
        {
            Console.WriteLine("Informe o nome do aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a turma do aluno:");
            string turma = Console
                .ReadLine();
            Repositorio.AdcionarAluno(nome, turma);
            Console.WriteLine("Aluno adcionado com sucesso!");
        }
        static void BuscarAluno()
        {
            Console.WriteLine("Informe o índice do aluno:");
            int indice = int.Parse(Console.ReadLine());
            Aluno aluno = Repositorio.BuscarAluno(indice);
            if (aluno != null)
            {
                Console.WriteLine($"Aluno encontrado: {aluno}");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }
        static void ExibirTodosAlunos()
        {
            Console.WriteLine("Lista de todos alunos");
            foreach (Aluno aluno in Repositorio.GetTodosAlunos())
            {
                Console.WriteLine("aluno");
            }
        }

    }
