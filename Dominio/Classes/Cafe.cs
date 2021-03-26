using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domínio.Classes
{
    public class Cafe : Entidade
    {
        public string cafe { get; protected set; }

        public Cafe(string cafe)
        {
            this.cafe = cafe;
        }
    }
}
