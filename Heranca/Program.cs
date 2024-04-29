namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = CadastrarCliente();
            Funcionario f = new Funcionario();
            f = (Funcionario) CadastrarFuncionario();
            

            Cliente CadastrarCliente()
            {
                Console.WriteLine("\nCadastrar Cliente\n");
                Cliente c = (Cliente) CadastrarPessoa(2);

                Console.WriteLine("\nInforme a conta do cliente:");
                c.DefinirConta(int.Parse(Console.ReadLine()));

                c.ImprimirCliente();

                return c;
            }

            Funcionario CadastrarFuncionario()
            {
                Console.WriteLine("\nCadastrar Funcionário\n");
                Funcionario p = (Funcionario) CadastrarPessoa(1);

                Console.WriteLine("\nInforme o cargo do funcionário:");
                f.DefinirCargo(Console.ReadLine());

                Console.WriteLine("\nInforme o código do funcionário:");
                f.DefinirCodigo(int.Parse(Console.ReadLine()));

                f.ImprimirFuncionario();

                return f;
            }

            Pessoa CadastrarPessoa(int t)
            {
                Pessoa p = new Pessoa();
                switch (t)
                {
                    case 1:
                        p = new Funcionario();
                        break;
                    case 2:
                        p = new Cliente();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Informe o nome:");
                p.DefinirNome(Console.ReadLine());

                Console.WriteLine("\nInforme o endereço:");
                p.DefinirEndereco(Console.ReadLine());

                Console.WriteLine("\nInforme o sexo:");
                p.DefinirSexo(Console.ReadLine());

                Console.WriteLine("\nInforme o telefone:");
                p.DefinirTelefone(Console.ReadLine());

                Console.WriteLine("\nInforme o salário:");
                p.DefinirSalario(float.Parse(Console.ReadLine()));

                Console.WriteLine("\nInforme a data de nascimento (dd/mm/aaaa):");
                p.DefinirNascimento(DateOnly.Parse(Console.ReadLine()));

                return p;
            }
        }
    }
}