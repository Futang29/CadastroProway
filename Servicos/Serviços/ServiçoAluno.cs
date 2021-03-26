using Database.Repositórios;
using Domínio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços.Serviços
{
    public class ServiçoAluno
    {
        public string Cadastrar(Aluno aluno)
        {
            RepositórioAluno repositório = new RepositórioAluno();

            var resposta = repositório.Create(aluno);

            return resposta;
        }
    }
}
