using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Models
{
    public class Aluno : Pessoa 
    {
        public double Nota {get;set;}

    public override void Apresentar(){
         /* Polimorfismo */
        Console.WriteLine($"Olá meu nome é {Nome}, e sou uma pessoa e também sou Aluno!");
    }

        public void mostrarNota(){
            Console.WriteLine($"A nota do Aluno {Nome} é {Nota}");
        }
    }
}