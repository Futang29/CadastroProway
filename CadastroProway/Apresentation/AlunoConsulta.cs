using Dominio.Classes;
using Servicos.Serviços;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroProway.Apresentation
{
    public partial class AlunoConsulta : Form
    {
        public AlunoConsulta()
        {
            InitializeComponent();
        }

        private void btnConAluno_Click(object sender, EventArgs e)
        {
            consultaAluno2 aluno2 = new consultaAluno2(txbConAluno.Text);

            ServiçoConAluno serviço = new ServiçoConAluno();

            var resposta = serviço.Consultar(aluno2);

            MessageBox.Show(resposta);
        }
    }
}
