using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class FormJogos : Form
    {
        public FormJogos()
        {
            InitializeComponent();
            MontarCatalogo();
        }

        private void MontarCatalogo()
        {
            Text = "Loja de Games Retrô";
            Size = new Size(820, 520);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.MidnightBlue;

            // Estrutura principal
            TableLayoutPanel layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1
            };

            layout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 70));

            layout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100));

            // Título
            Label titulo = new Label
            {
                Text = "CATÁLOGO DE JOGOS",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            // Área dos cards
            FlowLayoutPanel painelJogos = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(20),
                WrapContents = true
            };

            layout.Controls.Add(titulo, 0, 0);
            layout.Controls.Add(painelJogos, 0, 1);

            Controls.Add(layout);

            // Jogos disponíveis
            CriarCard(painelJogos, "Super Mario Bros.", 59.90m);
            CriarCard(painelJogos, "Sonic", 49.90m);
            CriarCard(painelJogos, "Pac-Man", 29.90m);
            CriarCard(painelJogos, "Street Fighter II", 69.90m);
        }

        private void CriarCard(
            FlowLayoutPanel painel,
            string nome,
            decimal preco)
        {
            Panel card = new Panel
            {
                Size = new Size(340, 160),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            Label lblNome = new Label
            {
                Text = nome,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(15, 12),
                Size = new Size(310, 30)
            };

            Label lblPreco = new Label
            {
                Text = "Preço: " + preco.ToString(
                    "C2", CultureInfo.GetCultureInfo("pt-BR")),
                Location = new Point(15, 50),
                AutoSize = true
            };

            Label lblQuantidade = new Label
            {
                Text = "Quantidade:",
                Location = new Point(15, 80),
                AutoSize = true
            };

            NumericUpDown numQuantidade = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 20,
                Value = 1,
                Location = new Point(15, 110),
                Width = 70
            };

            Button btnComprar = new Button
            {
                Text = "Comprar",
                Location = new Point(180, 105),
                Size = new Size(130, 40),
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            card.Controls.Add(lblNome);
            card.Controls.Add(lblPreco);
            card.Controls.Add(lblQuantidade);
            card.Controls.Add(numQuantidade);
            card.Controls.Add(btnComprar);

            painel.Controls.Add(card);
        }
    }
}