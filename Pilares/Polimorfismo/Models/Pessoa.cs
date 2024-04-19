using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Models
{
    public class Pessoa
    {
        public string Nome {get;set;}
        public int Idade {get;set;}

        /* virtual = disponibiliza as classes filhas de sobrescreverem o método caso necessite(polimorfismo)  */
        public virtual void Apresentar(){
            Console.WriteLine($"Olá meu nome é {Nome}, e sou uma pessoa!");
        }
    }
}