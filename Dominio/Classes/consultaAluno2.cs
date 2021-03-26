using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class consultaAluno2
    {
        public string nome { get; protected set; }

        public consultaAluno2(string nome)
        {
            this.nome = nome;
        }
    }
}
