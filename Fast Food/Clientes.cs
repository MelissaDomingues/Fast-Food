using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food
{
    public class Clientes
    {
        public string nome;
        public string cpf;
        public string email;
        public Endereco endereço;
    }

    public class Endereco
    {
        public string rua;
        public string numero;
        public string complemento;
        public string bairro;
        public string cidade;
        public string cep;
        

    }
}
