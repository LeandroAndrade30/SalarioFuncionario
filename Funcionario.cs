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

        public double CalcularSalarioLIquido()
        {
            double SalarioLiquido = SalarioBruto - (SalarioBruto * Imposto / 100);
            return SalarioLiquido;




        }
        public void AumentarSalario(  double Imposto)
        {


            double aumento = (SalarioBruto * Imposto / 100) - SalarioBruto;
            SalarioBruto += aumento;

        }

    }
    }

