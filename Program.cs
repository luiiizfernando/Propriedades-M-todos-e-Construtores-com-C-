using System.Runtime.Serialization;
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Luiz", sobrenome: "Fernando");

Pessoa p2 = new Pessoa(nome: "Luis",sobrenome: "Eduardo");

Pessoa p3 = new Pessoa(nome: "José", sobrenome: "Eduardo");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();


/*
Pessoa p1 = new Pessoa();

p1.Nome = "Luiz";
p1.Sobrenome = "Fernando";
p1.Idade = 30;

p1.Apresentar();
*/