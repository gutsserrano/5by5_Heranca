using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Funcionario : Pessoa
    {
        public string cargo;
        public int codigo;

        public Funcionario()
        {
            
        }

        public void DefinirCargo(string c)
        {
            this.cargo = c;
        }

        public void DefinirCodigo(int c)
        {
            this.codigo = c;
        }

        public void ImprimirFuncionario()
        {
            ImprimirPessoa();
            Console.WriteLine($"Cargo: {this.cargo}");
            Console.WriteLine($"Codigo: {this.codigo}");
            Console.WriteLine();
        }
    }
}
