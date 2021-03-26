using DataBase.Repositórios;
using Dominio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Serviços
{
    public class ServiçoConAluno
    {
        public string Consultar(consultaAluno2 aluno2)
        {
            RepositórioConAluno repositório = new RepositórioConAluno();

            var resposta = repositório.Create(aluno2);

            return resposta;
        }
    }
}
