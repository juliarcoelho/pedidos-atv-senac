using System;
using System.Collections.Generic;

namespace prova
{
    class ItemPedido
    {
        public String descricao;
        public double valorUnitario, quantidade;
        public ItemPedido(double q, double v)
        {
            valorUnitario = v;
            quantidade = q;
        }
    }
    class Pedido
    {
        public List<ItemPedido> itemPedido;
        public Pedido()
        {
            itemPedido = new List<ItemPedido>();
        }
        public void AdicionaPedido(ItemPedido item)
        {
            itemPedido.Add(item);
        }
        public double TotalizaPedido()
        {
            double total = 0;
            foreach (var item in itemPedido)
            {
                
                total = total + item.valorUnitario * item.quantidade;
            }
            
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String descricao;
            double valorUnitario, quantidade;
            char fim = 's';

            Pedido novoPedido = new Pedido();

            do
            {
                Console.Clear();
                Console.WriteLine("Olá");
               
                Console.WriteLine("Digite a descrição: ");
                descricao = Console.ReadLine();
                Console.WriteLine("Digite o valor unitário: ");
                valorUnitario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quantidade: ");
                quantidade = Convert.ToDouble(Console.ReadLine());

                ItemPedido novoItemPedido = new ItemPedido(quantidade, valorUnitario);
                novoPedido.AdicionaPedido(novoItemPedido);

                Console.WriteLine("Digite s caso queira adicionar mais pedidos ");
                fim = Convert.ToChar(Console.ReadLine());

            } while(fim == 's');

            Console.WriteLine("Total: " + novoPedido.TotalizaPedido());
        }
    }
}