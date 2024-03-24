using System;
using System.Collections.Generic;
using System.Text;

namespace SalarioFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public Funcionario (string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;

        }

        public double CalcularSalarioLIquido()
        {
            double SalarioLiquido = SalarioBruto - (SalarioBruto * Imposto / 100);
            return SalarioLiquido;

            






    }


        public override string ToString()
        {
            return $"Nome: {Nome} \n Salario Bruto: {SalarioBruto} \n Imposto {Imposto}";
        }


        public void AumentarSalario(  double Imposto)
        {


            double aumento = (SalarioBruto * Imposto / 100) - SalarioBruto;
            SalarioBruto += aumento;

        }

    }
    }

