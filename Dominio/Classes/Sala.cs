using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domínio.Classes
{
    public class Sala : Entidade
    {
        public string sala { get; protected set; }

        public Sala(string sala)
        {
            this.sala = sala;
        }
    }
}
