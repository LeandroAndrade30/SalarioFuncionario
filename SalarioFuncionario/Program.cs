using System;

namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Informe os dados do Funcionário:\n");
            Console.WriteLine("Informe o nome do Funcionário:");
             string nome = Console.ReadLine();
            Console.WriteLine("Informe o salário bruto  do Funcionário:");
             double  salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a porcentagem de imposto sobre o salário bruto  do Funcionário:");
             double imposto = double.Parse(Console.ReadLine());

            Funcionario Funcionario = new Funcionario(nome,salarioBruto, imposto);
            Console.WriteLine(Funcionario);

            double SalarioLiquido = Funcionario.CalcularSalarioLIquido(); 
            Console.WriteLine($"O funcionário {Funcionario.Nome} tem um salário Líquido de R$ {SalarioLiquido.ToString("F2")}");
            Console.WriteLine("Informe a porcentagem de aumento que será dado sobre seu salário bruto");
            double AumentoSalario = double.Parse(Console.ReadLine());
             Funcionario.AumentarSalario(AumentoSalario);
            Console.WriteLine($"O Funcionário {Funcionario.Nome} tem um salário líquido de: R$ {SalarioLiquido} e seu salário aumentado é : R$ {Funcionario.SalarioBruto + SalarioLiquido}");

            

        }
    }
}
