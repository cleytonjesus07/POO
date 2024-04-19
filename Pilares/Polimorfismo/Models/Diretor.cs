using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar(){
            /* Polimorfismo */
            Console.WriteLine($"Olá meu nome é {Nome}, e sou uma pessoa e também sou Diretor!");
        }
    }
}