using Database.Repositórios;
using DataBase.Repositórios;
using Domínio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Serviços
{
    public class ServiçoCafe : Repositório
    {
        public string Cadastrar(Cafe cafe)
        {
            RepositórioCafe repositório = new RepositórioCafe();

            var resposta = repositório.Create(cafe);

            return resposta;
        }
    }
}
