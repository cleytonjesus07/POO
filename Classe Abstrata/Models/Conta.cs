using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_Abstrata.Models
{
    /* 
        Serve apenas como modelo
        Não pode ser instânciada.
     */
    public abstract class Conta
    {
        /* protected = 
            Apenas as classes filhas podem alterar! 
            Classes externas(fora da herança) não podem alterar.
        */
        protected decimal saldo;

        /* Método abstrato: apenas a assinatura para que as classes filhas implementem do jeito que quiserem */
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine($"O seu saldo é: {saldo}");
        }
    }
}