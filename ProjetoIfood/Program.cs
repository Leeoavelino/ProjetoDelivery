using System;
using ProjetoIfood.Entities;
using ProjetoIfood.Entities.Enums;


namespace ProjetoIfood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia, Bem vindo ao nosso Delivery.");
            Console.WriteLine("Para que possamos melhor atender:");

            Console.WriteLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Data de nascimento (DD/MM/AAAA): ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            Cliente cliente = new Cliente(nome, email, nascimento);

            Console.WriteLine("Dados do Pedido.");

            Console.Write("Status do pedido( PENDENTE/PROCESSANDO/ENVIADO/ENTREGUE ): ");
            StatusDoPedido status = Enum.Parse<StatusDoPedido>(Console.ReadLine());

            Console.WriteLine();

            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("Quantos Pedidos adicionados no carrinho: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Infomações do Pedido {i}: ");
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();


                Console.Write("Preço do Produto: ");
                double preço = double.Parse(Console.ReadLine());


                Produto produto = new Produto();

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine();

                ItemPedido itemPedido = new ItemPedido(quantidade, preço, produto);

                pedido.AdicionarItem(itemPedido);

            }


            Console.WriteLine("     **Resumo do pedido do Cliente**     ");

            Console.WriteLine();

            Console.WriteLine(pedido);


        }
    }
}
