using System;

namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario Funcionario = new Funcionario();
            Console.WriteLine("Informe os dados do Funcionário:\n");
            Console.WriteLine("Informe o nome do Funcionário:");
             Funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salário bruto  do Funcionário:");
             Funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a porcentagem de imposto sobre o salário bruto  do Funcionário:");
             Funcionario.Imposto = double.Parse(Console.ReadLine());
            double SalarioLiquido = Funcionario.CalcularSalarioLIquido(); 
            Console.WriteLine($"O funcionário {Funcionario.Nome} tem um salário Líquido de R$ {SalarioLiquido.ToString("F2")}");
            Console.WriteLine("Informe a porcentagem de aumento que será dado sobre seu salário bruto");
            double AumentoSalario = double.Parse(Console.ReadLine());
             Funcionario.AumentarSalario(AumentoSalario);
            Console.WriteLine($"O Funcionário {Funcionario.Nome} tem um aumento no seu salário bruto de: R$ {Funcionario.SalarioBruto.ToString("F2")}");



        }
    }
}
