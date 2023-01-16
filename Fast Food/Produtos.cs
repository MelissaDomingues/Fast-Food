using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food
{
    public class Produtos
    {
        public int codigo_Produto;
        public Bebidas bebidas;
        public Lanches lanches;
        public Acompanhamento acompanhamento;
        public valor_Unitario valor;
        public double quantidade;



        public class Bebidas
        {
            public string refrigerante;
            public string suco;
            public string cerveja;
        }

        public class Lanches
        {
            public string tradicional;
            public string XBacon;
            public string XSalada;
            public string XEgg;
            public string XTudo;
        }

        public class Acompanhamento
        {
            public string batata_Frita;
            public string cebola_Frita;
        }

        //public void Adicionar(double Bebidas, double Lanches, double Acompanhamento)
        //{
        //    quantidade += Bebidas;
        //    quantidade += Lanches;
        //    quantidade += Acompanhamento;
        //}

        public class valor_Unitario
        {
            public double valor_Refri;
            public double valor_Suco;
            public double valor_Cerveja;
            public double valor_tradicional;
            public double valor_XBacon;
            public double valor_XSalada;
            public double valor_Egg;
            public double valor_Xtudo;
            public double valor_batata_Frita;
            public double valor_cebola_Frita;

        }

    }
}
