using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            using (FormJogos jogos = new FormJogos())
            {
                jogos.ShowDialog();
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            using (FormRelatorio relatorio = new FormRelatorio())
            {
                relatorio.ShowDialog();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente sair da loja?",
                "Confirmar saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
