using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliFuncionario
{
     class Funcionario
    {
        public String Nome { get; set; }
        public Char Sexo { get; set; }

        public virtual double ParticipacaoLucro()
        {
            return 1200 ;
        }
    }
}
