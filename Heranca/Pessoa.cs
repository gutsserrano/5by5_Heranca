using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Pessoa
    {
        public string nome;
        public string endereco;
        public string sexo;
        public string telefone;
        public float salario;
        public DateOnly nascimento;

        public Pessoa()
        {

        }

        public void DefinirNome(string n)
        {
            this.nome = n;
        }

        public void DefinirEndereco(string e)
        {
            this.endereco = e;
        }

        public void DefinirSexo(string s)
        {
            this.sexo = s;
        }

        public void DefinirTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public void DefinirSalario(float salario)
        {
            this.salario = salario;
        }

        public void DefinirNascimento(DateOnly n)
        {
            this.nascimento = n;
        }

        public void ImprimirPessoa()
        {
            Console.WriteLine("\n==========================================");
            Console.WriteLine();
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Endereço: {this.endereco}");
            Console.WriteLine($"Sexo: {this.sexo}");
            Console.WriteLine($"Telefone: {this.telefone}");
            Console.WriteLine($"Salario: {this.salario}");
            Console.WriteLine($"Data de nascimento: {this.nascimento}");
        }
    }
}
