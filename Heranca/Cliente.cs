using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Cliente : Pessoa
    {
        public int conta;

        public Cliente()
        {
            
        }

        public void DefinirConta(int c)
        {
            this.conta = c;
        }

        public void ImprimirCliente()
        {
            ImprimirPessoa();
            Console.WriteLine($"Conta: {this.conta}");
            Console.WriteLine();
        }
    }
}
