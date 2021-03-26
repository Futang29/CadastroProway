using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class FinalizarCadastro
    {
        public string cadastrar { get; protected set; }

        public FinalizarCadastro(string cadastrar)
        {
            this.cadastrar = cadastrar;
        }
    }
}
