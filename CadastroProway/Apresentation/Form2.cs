using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CadastroProway
{
    public partial class cadastrar : Form
    {
        Thread thCadAluno;
        Thread thCadSala;
        Thread thCadCafe;
        public cadastrar()
        {
            InitializeComponent();
        }

        private void cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void cadAluno_Click(object sender, EventArgs e)
        {
            this.Close();
            thCadAluno = new Thread(abrirCadAluno);
            thCadAluno.SetApartmentState(ApartmentState.STA);
            thCadAluno.Start();
        }
        protected void abrirCadAluno(object obj)
        {
            Application.Run(new cadAluno());
        }

        private void cadSala_Click(object sender, EventArgs e)
        {
            this.Close();
            thCadSala = new Thread(abrirCadSala);
            thCadSala.SetApartmentState(ApartmentState.STA);
            thCadSala.Start();
        }
        private void abrirCadSala(object obj)
        {
            Application.Run(new cadSala());
        }

        private void cadCafe_Click(object sender, EventArgs e)
        {
            this.Close();
            thCadCafe = new Thread(abrirCadCafe);
            thCadCafe.SetApartmentState(ApartmentState.STA);
            thCadCafe.Start();
        }
        private void abrirCadCafe(object obj)
        {
            Application.Run(new cadCafe());
        }
    }
}
