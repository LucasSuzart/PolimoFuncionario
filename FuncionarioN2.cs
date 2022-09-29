using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliFuncionario
{
    class FuncionarioN2:Funcionario
    {
        // public String Nome { get; set; }
        // public Char Sexo { get; set; }


        //public double ParticipacaoLucro()
        //{
        //    return 1200 * 0.02;
        //}
        public override double ParticipacaoLucro()
        {
            return base.ParticipacaoLucro() * 0.02;
        }
    }
}
