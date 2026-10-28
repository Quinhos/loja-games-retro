using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class FormRelatorio : Form
    {
        private readonly DataGridView tabela = new DataGridView();
        private readonly TableLayoutPanel layout = new TableLayoutPanel();

        public FormRelatorio()
        {
            InitializeComponent();
            MontarTela();
        }

        private void MontarTela()
        {
            Text = "Relatório de Vendas";
            Size = new Size(850, 500);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.MidnightBlue;

            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 1;
            layout.RowCount = 3;

            layout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 70));
            layout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100));
            layout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 70));

            Label titulo = new Label
            {
                Text = "RELATÓRIO DE VENDAS",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            tabela.Dock = DockStyle.Fill;
            tabela.ReadOnly = true;
            tabela.AllowUserToAddRows = false;
            tabela.AllowUserToDeleteRows = false;
            tabela.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            tabela.BackgroundColor = Color.White;
            tabela.RowHeadersVisible = false;
            tabela.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            tabela.MultiSelect = false;

            tabela.Columns.Add("Data", "Data");
            tabela.Columns.Add("Jogo", "Jogo");
            tabela.Columns.Add("Quantidade", "Qtd.");
            tabela.Columns.Add("Preco", "Preço Unit.");
            tabela.Columns.Add("Total", "Total");

            layout.Controls.Add(titulo, 0, 0);
            layout.Controls.Add(tabela, 0, 1);

            Controls.Add(layout);
        }
    }
}