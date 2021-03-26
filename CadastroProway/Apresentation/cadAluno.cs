using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Domínio.Classes;
using Serviços.Serviços;

namespace CadastroProway
{
    public partial class cadAluno : Form
    {
        Thread thMenu;
        Thread thVoltar;
        public cadAluno()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            thMenu = new Thread(abrirMenu);
            thMenu.SetApartmentState(ApartmentState.STA);
            thMenu.Start();
        }
        public void abrirMenu(object obj)
        {
            Application.Run(new Form1());
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            this.Close();
            thVoltar = new Thread(voltarCad);
            thVoltar.SetApartmentState(ApartmentState.STA);
            thVoltar.Start();
        }
        public void voltarCad(object obj)
        {
            Application.Run(new cadastrar());
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txbAluno.Text);

            ServiçoAluno serviço = new ServiçoAluno();

            var resposta = serviço.Cadastrar(aluno);

            MessageBox.Show(resposta);
        }
    }
}
