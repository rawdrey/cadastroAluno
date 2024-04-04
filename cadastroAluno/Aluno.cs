using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroAluno
{
public Class Aluno
    {
public int Id{get;}
public string Nome {get;}
public string Turma {get;}
publicAluno(int id, string nome, string turma)
{
    Id = id;
Nome = nome;
Turma = turma;
}
public override string toString()
{
 return $"ID: {Id}, Nome: {nome}, Turma: {Turma}";
}
    }
}
