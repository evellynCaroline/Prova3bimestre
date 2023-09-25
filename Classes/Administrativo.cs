using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Terceiro_Bimestre.Classes
{
    internal class Administrativo:Funcionario
    {
        /* 
          Esse tipo de funcionário tem no seu salário um acréscimo de
        R$ 150 de vale transporte e 15% a mais do salário de vale alimentação (sobre o salário sem
        conta o vale transporte).
        */

        public override double Salario(double Salario)
        {
            return (base.Salario(Salario) * 0.15) + 150;
        }
    }
}
