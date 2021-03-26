using DataBase.Repositórios;
using Dominio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Serviços
{
    public class ServiçoCadastro
    {
        public string Cadastrar(FinalizarCadastro cadastro)
        {
            RepositórioCadastro repositório = new RepositórioCadastro();

            var resposta = repositório.Create(cadastro);

            return resposta;

        }
    }
}
