using System;
using System.Collections.Generic;

namespace LojaGames
{
    public class Venda
    {
        public string NomeJogo { get; set; } = "";
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;

        public decimal Total => Quantidade * PrecoUnitario;
    }

    public static class LojaDados
    {
        public static List<Venda> Vendas { get; } = new List<Venda>();
    }
}