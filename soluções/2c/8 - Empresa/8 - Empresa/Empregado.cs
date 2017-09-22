using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Empresa
{
    class Empregado: Funcionario
    {
        public string Entrada { get; set; }
        public Gerente gerente { get; set; }

        public Empregado(int reg, string data, string cp) : base(reg, cp)
        {
            this.Entrada = data;
        }
    }
}
