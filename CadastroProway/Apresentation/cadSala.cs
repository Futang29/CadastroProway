using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using CadastroProway.Services;

namespace CadastroProway
{
    public partial class cadSala : Form
    {
        Thread thVoltar;
        Thread thMenu;
        public cadSala()
        {
            InitializeComponent();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
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

        private void btnMenu2_Click(object sender, EventArgs e)
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

        private void btnCadSala_Click(object sender, EventArgs e)
        {
            cadastroSala cadS = new cadastroSala();
            cadS.Room(txbSala.Text);
        }
    }
}
