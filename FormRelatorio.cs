
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

        // Monta a interface do relatório
        private void MontarTela()
        {
            Text = "Relatório de Vendas";
            Size = new Size(850, 500);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.MidnightBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // Layout principal
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 1;
            layout.RowCount = 3;

            layout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100));

            layout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 70));

            layout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100));

            layout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 70));

            // Título
            Label titulo = new Label
            {
                Text = "RELATÓRIO DE VENDAS",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            // Configuração da tabela
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

            // Colunas
            tabela.Columns.Add("Data", "Data");
            tabela.Columns.Add("Jogo", "Jogo");
            tabela.Columns.Add("Quantidade", "Qtd.");
            tabela.Columns.Add("Preco", "Preço Unit.");
            tabela.Columns.Add("Total", "Total");

            // Adicionar componentes ao layout
            layout.Controls.Add(titulo, 0, 0);
            layout.Controls.Add(tabela, 0, 1);

            Controls.Add(layout);

            // Carregar dados e rodapé
            CarregarVendas();
            MontarRodape();
        }

        // Carrega as vendas registradas
        private void CarregarVendas()
        {
            CultureInfo cultura =
                CultureInfo.GetCultureInfo("pt-BR");

            tabela.Rows.Clear();

            foreach (Venda venda in LojaDados.Vendas)
            {
                tabela.Rows.Add(
                    venda.Data.ToString("dd/MM/yyyy HH:mm"),
                    venda.NomeJogo,
                    venda.Quantidade,
                    venda.PrecoUnitario.ToString("C2", cultura),
                    venda.Total.ToString("C2", cultura)
                );
            }
        }

        // Cria o rodapé com faturamento e botão Voltar
        private void MontarRodape()
        {
            decimal faturamento = 0;

            foreach (Venda venda in LojaDados.Vendas)
            {
                faturamento += venda.Total;
            }

            CultureInfo cultura =
                CultureInfo.GetCultureInfo("pt-BR");

            // Painel inferior
            TableLayoutPanel rodape = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(10)
            };

            rodape.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100));

            rodape.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 130));

            // Resumo das vendas
            Label lblResumo = new Label
            {
                Text = $"Pedidos: {LojaDados.Vendas.Count} | " +
                       $"Faturamento: {faturamento.ToString("C2", cultura)}",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Botão Voltar
            Button btnVoltar = new Button
            {
                Text = "Voltar",
                Dock = DockStyle.Fill,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Evento do botão
            btnVoltar.Click += (sender, e) =>
            {
                this.Close();
            };

            rodape.Controls.Add(lblResumo, 0, 0);
            rodape.Controls.Add(btnVoltar, 1, 0);

            layout.Controls.Add(rodape, 0, 2);
        }
    }
}
