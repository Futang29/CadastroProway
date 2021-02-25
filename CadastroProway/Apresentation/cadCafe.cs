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
    public partial class cadCafe : Form
    {
        Thread thVoltar;
        Thread thMenu;
        public cadCafe()
        {
            InitializeComponent();
        }

        private void btnVoltar3_Click(object sender, EventArgs e)
        {
            this.Close();
            thVoltar = new Thread(abrirCad);
            thVoltar.SetApartmentState(ApartmentState.STA);
            thVoltar.Start();
        }
        private void abrirCad(object obj)
        {
            Application.Run(new cadastrar());
        }

        private void btnMeun3_Click(object sender, EventArgs e)
        {
            this.Close();
            thMenu = new Thread(abrirMenu);
            thMenu.SetApartmentState(ApartmentState.STA);
            thMenu.Start();
        }
        private void abrirMenu(object obj)
        {
            Application.Run(new Form1());
        }

        private void btnCadCafe_Click(object sender, EventArgs e)
        {
            cadastroCafe cadC = new cadastroCafe();
            cadC.Coffee(txbCoffee.Text);

        }
    }
}
