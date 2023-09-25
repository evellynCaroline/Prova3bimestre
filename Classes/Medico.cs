using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Terceiro_Bimestre.Classes
{
    internal class Medico:Funcionario
    {
        // CRM (registro no conselho), valor de hora extra e especialidade.

        public string CRM { get; set; }
        public DateTime HoraExtra { get; set; }
        public string especialidade { get; set; }

        public Medico(string CRM, DateTime HoraExtra, string Especialidade) 
        { 
            this.CRM = CRM;
            this.HoraExtra = HoraExtra;
            this.HoraExtra = HoraExtra;
        
        }

        public override double Salario(double Salario)
        {
            return base.Salario(Salario) * 0.20;
        }
    }
}
