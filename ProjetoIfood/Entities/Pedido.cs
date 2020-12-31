using System;
using System.Collections.Generic;
using System.Text;
using ProjetoIfood.Entities.Enums;

namespace ProjetoIfood.Entities
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusDoPedido Status { get; set; }
        public Cliente Cliente { get; set; }

        public List<ItemPedido> Item { get; set; } = new List<ItemPedido>();

        public Pedido() { }

        public Pedido(DateTime momento, StatusDoPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AdicionarItem(ItemPedido item)
        {
            Item.Add(item);
        }

        public void RemoveItem(ItemPedido item)
        {
            Item.Remove(item);
        }

        public double ValorTotal()
        {
            double soma = 0;

            foreach(ItemPedido item in Item)
            {

                soma += item.ValorParcial();

            }

            return soma;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Momento do pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));

            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Nome do Cliente: " + Cliente);
            sb.AppendLine("Itens Pedidos: ");
            foreach(ItemPedido item in Item)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine(" Total a pagar: R$ " + ValorTotal().ToString("F2"));
            return sb.ToString();

        }


    }
}
