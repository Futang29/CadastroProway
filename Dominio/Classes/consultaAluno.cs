using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class consultaAluno
    { 
        public string nomeSala { get; protected set; }

        public consultaAluno(string nomeSala)
        {

            this.nomeSala = nomeSala;
        }

    }
}
