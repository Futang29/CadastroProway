using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class consultaAluno1
    {
        public string Sala { get; protected set; }

        public consultaAluno1(string Sala)
        {
            this.Sala = Sala;
        }
    }
}
