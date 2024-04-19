using Heranca.Models;

Aluno a1 = new Aluno();
Professor p1 = new Professor();
Diretor d1 = new Diretor();
a1.Nome = "Cleyton";
p1.Nome = "Gildo";
d1.Nome = "Rogério Ceni";
a1.Nota = 1;
p1.Salario = 10.00M;
d1.Salario = 20.00M;

a1.Apresentar();
p1.Apresentar();
d1.Apresentar();
a1.mostrarNota();
p1.mostrarSalario();
d1.mostrarSalario();