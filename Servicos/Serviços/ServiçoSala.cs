using DataBase.Repositórios;
using Domínio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Serviços
{
    public class ServiçoSala
    {
        public string Cadastrar(Sala sala)
        {
            RepositorioSala repositório = new RepositorioSala();

            var resposta = repositório.Create(sala);

            return resposta;
        }
    }
}
