﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf)
            : base(salario, cpf)
        {
        }

        public override void AumentarSalario()
        {
            //qualquer coisa aqui
        }

        protected internal override double GetBonificacao()
        {
            throw new NotImplementedException();
        }

    }
}
