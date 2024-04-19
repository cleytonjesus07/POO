using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario {get;set;}

    public override void Apresentar(){
         /* Polimorfismo */
        Console.WriteLine($"Olá meu nome é {Nome}, e sou uma pessoa e também sou Professor!");
    }

        public void mostrarSalario(){
            Console.WriteLine($"O Professor {Nome} possui R${Salario}");
        }
    }
}