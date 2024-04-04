using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroAluno
{
    public static class Repositorio
    {
        private static int id = 1;
        private static Aluno[] alunos = new Aluno[100];
        private static int indice = 0;

        public void AdcionarAluno(string nome, string turma)
        {
            aluno aluno = newAluno(id, nome, turma);
            alunos[indice] = aluno;
            indice++;
            id++;
        }


    }
}
