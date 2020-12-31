using System;
using System.Collections.Generic;
using System.Text;
using ProjetoIfood.Entities;

namespace ProjetoIfood.Entities
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preço { get; set; }

        public Produto Produto { get; set; }

        public ItemPedido() {}

        public ItemPedido(int quantidade, double preço, Produto produto)
        {
            Quantidade = quantidade;
            Preço = preço;
            Produto = produto;
        }

        public double ValorParcial()
        {
            return Preço * Quantidade;
        }

        public override string ToString()
        {
            return Produto.Nome
                + " R$ "
                + Preço.ToString("F2")
                + Quantidade
                + ", Parcial: R$ "
                + ValorParcial().ToString("F2");
        }


    }
}
