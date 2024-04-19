using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario {get;set;}

        public void mostrarSalario(){
            Console.WriteLine($"O Professor {Nome} possui R${Salario}");
        }
    }
}