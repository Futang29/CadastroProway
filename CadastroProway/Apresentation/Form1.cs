using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CadastroProway.Apresentation;

namespace CadastroProway
{
    public partial class Form1 : Form
    {
        Thread thConsulta;
        Thread thCadastro;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            thCadastro = new Thread(abrirCadastro);
            thCadastro.SetApartmentState(ApartmentState.STA);
            thCadastro.Start();
        }

        protected void abrirCadastro(object obj)
        {
            Application.Run(new cadastrar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            thConsulta = new Thread(abrirConsulta);
            thConsulta.SetApartmentState(ApartmentState.STA);
            thConsulta.Start();
        }

        protected void abrirConsulta(object obj)
        {
            Application.Run(new consulta());
        }

    }
}
