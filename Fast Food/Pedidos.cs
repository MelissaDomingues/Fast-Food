using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food
{
    public class Pedidos
    {
        public int numero_Pedido;
        public Clientes cliente;
        public ItemPedido item;
        public float total_Pedido;
    }

    public class ItemPedido
    {
        public int quantidade;
        public int numero_Pedido;
        public Produtos produto1;
        public Produtos produto2;
        public Produtos produto3;
    }
}
