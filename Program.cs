using System;

namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do Funcionário:\n");
            Console.WriteLine("Informe o nome do Funcionário:");
            string Nome = Console.ReadLine();
            Console.WriteLine("Informe o salário bruto  do Funcionário:");
            double SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a porcentagem de imposto sobre o salário bruto  do Funcionário:");
            double Imposto = double.Parse(Console.ReadLine());
            double SalarioLiquido = SalarioBruto - (SalarioBruto * Imposto / 100); 
            Console.WriteLine($"O funcionário {Nome} tem um salário Líquido de R$ {SalarioLiquido.ToString("F2")}");
            Console.WriteLine("Informe a porcentagem de aumento que será dada sobre seu salário liquido");
            double AumentoSalario = double.Parse(Console.ReadLine());
            double NovoSalario = SalarioLiquido + (SalarioLiquido * AumentoSalario / 100); 
            Console.WriteLine($"O Funcionário {Nome} tem um aumento no seu salário de: R$ {NovoSalario.ToString("F2")}");




        }
    }
}
