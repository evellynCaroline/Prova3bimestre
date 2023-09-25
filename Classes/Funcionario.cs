using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Terceiro_Bimestre.Classes
{
    internal class Funcionario
    {
        //nome, CPF, matrícula, data de nascimento, sexo, salário.

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public string DataNasc { get; set; }
        public string Sexo { get; set; }

        public virtual double Salario(double Salario)
        {
             Salario = 20000.00;
            return Salario;
        }
       



    }
}
