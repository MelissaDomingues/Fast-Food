using Fast_Food;
using System;
using System.Runtime.InteropServices;

namespace Fast_Food
{
    public class Program
    {
        public static void Main( )
        {

            Clientes cliente = new Clientes();
            cliente.endereço = new Endereco();
            cliente.nome = "Maria Joaquina";
            cliente.cpf = "45874636877";
            cliente.email = "fulanodetal@gmail.com";
            cliente.endereço.rua = "Rua dos Bobos";
            cliente.endereço.numero = "N° 0";
            cliente.endereço.bairro = "Bairro das Flores";
            cliente.endereço.cidade = "Taboão da Serra";
            cliente.endereço.cep = "55555555";
            cliente.endereço.complemento = "Apto 12A";

            Pedidos pedido = new Pedidos();
            pedido.item = new ItemPedido();         
            pedido.numero_Pedido = 07;
            pedido.cliente = cliente;
            pedido.item.quantidade = 03;           

           
            Produtos produtos = new Produtos();
            produtos.lanches = new Produtos.Lanches();
            produtos.bebidas = new Produtos.Bebidas();
            produtos.acompanhamento = new Produtos.Acompanhamento();
            produtos.lanches.XBacon = "Lanche: X-Bacon";
            produtos.bebidas.refrigerante = "Bebida: Coca-Cola";
            produtos.acompanhamento.cebola_Frita = "Acompanhamento: Cebola Frita";
          

            Produtos valor = new Produtos();
            valor.valor = new Produtos.valor_Unitario();
            valor.valor.valor_XBacon = 18.50;
            valor.valor.valor_Refri = 7.50;
            valor.valor.valor_cebola_Frita = 14.99;

            Console.WriteLine("Para o Motoboy");
            Console.WriteLine("Pedido do cliente: ");
            Console.WriteLine("");
            Console.WriteLine("Número do pedido: " +pedido.numero_Pedido);
            Console.WriteLine("Quantidade de pedido: " +pedido.item.quantidade);
            Console.WriteLine(produtos.lanches.XBacon);
            Console.WriteLine(produtos.bebidas.refrigerante);
            Console.WriteLine(produtos.acompanhamento.cebola_Frita);
            Console.WriteLine("total a pagar = R$ " + (valor.valor.valor_XBacon + valor.valor.valor_Refri + valor.valor.valor_cebola_Frita));
            Console.WriteLine("Forma de pagamento: Cartão/Débito");

            Console.WriteLine("");
            Console.WriteLine("Endereço para entrega: ");
            Console.WriteLine(cliente.endereço.rua);
            Console.WriteLine(cliente.endereço.numero);
            Console.WriteLine(cliente.endereço.bairro);
            Console.WriteLine("Cidade:" +cliente.endereço.cidade);
            Console.WriteLine("CEP: " +cliente.endereço.cep);
            Console.WriteLine(cliente.endereço.complemento);
            Console.WriteLine("Lembrete para o motoboy: O prazo de entrega é de 30min contando do tempo em que você retirou o pedido");

            Console.WriteLine("");
            Console.WriteLine("Para o cozinheiro");
            Console.WriteLine("Número do pedido : " +pedido.numero_Pedido);
            Console.WriteLine("Quantidade de pedido: " + pedido.item.quantidade);
            Console.WriteLine(produtos.lanches.XBacon);
            Console.WriteLine(produtos.bebidas.refrigerante);
            Console.WriteLine(produtos.acompanhamento.cebola_Frita);

            Console.WriteLine("");
            Console.WriteLine("Para o Atendente: ");
            Console.WriteLine("Foi solicitado o pedido: ");
            Console.WriteLine(produtos.lanches.XBacon);
            Console.WriteLine(produtos.bebidas.refrigerante);
            Console.WriteLine(produtos.acompanhamento.cebola_Frita);          
            Console.WriteLine("total a pagar = R$ " + (valor.valor.valor_XBacon + valor.valor.valor_Refri + valor.valor.valor_cebola_Frita));
            Console.WriteLine("Forma de pagamento: Cartão/Débito");

            Console.WriteLine("");
            Console.WriteLine("Cadastro do Cliente: ");
            Console.WriteLine("Nome: " +cliente.nome);
            Console.WriteLine("CPF: " +cliente.cpf);
            Console.WriteLine("E-mail: " +cliente.email);
            Console.WriteLine(cliente.endereço.rua);
            Console.WriteLine(cliente.endereço.numero);
            Console.WriteLine(cliente.endereço.bairro);
            Console.WriteLine("Cidade:" + cliente.endereço.cidade);
            Console.WriteLine("CEP: " + cliente.endereço.cep);
            Console.WriteLine(cliente.endereço.complemento);

            Console.WriteLine("");
            Console.WriteLine("Prezado(a) " + cliente.nome +",");
            Console.WriteLine("O seu pedido: ");
            Console.WriteLine(produtos.lanches.XBacon);
            Console.WriteLine(produtos.bebidas.refrigerante);
            Console.WriteLine(produtos.acompanhamento.cebola_Frita);
            Console.WriteLine("Ja saiu para entrega!");
            Console.WriteLine("o valor total foi de: R$" + (valor.valor.valor_XBacon + valor.valor.valor_Refri + valor.valor.valor_cebola_Frita));
            Console.WriteLine("Lembre-se de estar no endereço que você solicitou para a retirada. Segue endereço:");
            Console.WriteLine(cliente.endereço.rua);
            Console.WriteLine(cliente.endereço.numero);
            Console.WriteLine(cliente.endereço.bairro);
            Console.WriteLine("Cidade:" + cliente.endereço.cidade);
            Console.WriteLine("CEP: " + cliente.endereço.cep);
            Console.WriteLine(cliente.endereço.complemento);

            Console.WriteLine("");
            Console.WriteLine("Tenha um bom apetite! =D");


        }

    }
}
