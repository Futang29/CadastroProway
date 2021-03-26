using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CadastroProway.Apresentation
{
    public partial class consulta : Form
    {
        Thread thConAluno;
        public consulta()
        {
            InitializeComponent();
        }

        private void btnConAluno_Click(object sender, EventArgs e)
        {
            this.Close();
            thConAluno = new Thread(abrirConsultaAluno);
            thConAluno.SetApartmentState(ApartmentState.STA);
            thConAluno.Start();
        }
        protected void abrirConsultaAluno(object obj)
        {
            Application.Run(new AlunoConsulta());
        }
    }
}
