using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R12.ExtractClass.depois
{
    class Empresa
    {
        public Empresa(RazaoSocial razaoSocial, CNPJ cnpj, Endereco enderecoComercial, Endereco enderecoEntrega)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            EnderecoEntrega = enderecoComercial;
            EnderecoComercial = enderecoEntrega;
        }

        public RazaoSocial RazaoSocial { get; private set; }

        public CNPJ CNPJ { get; private set; }

        public Endereco EnderecoComercial { get; private set; }
        public Endereco EnderecoEntrega { get; private set; }
    }
    class CNPJ
    {
        public string Codigo { get; private set; }

        public CNPJ(string codigo)
        {
            this.Codigo = codigo;
        }
    }

    class RazaoSocial
    {
        public string Nome { get; private set; }

        public RazaoSocial(string nome)
        {
            Nome = nome;
        }
    }

    class Endereco
    {
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Municipio { get; private set; }
        public string UF { get; private set; }


        public Endereco(string logradouro, string numero, string complemento, string bairro, string cep, string municipio, string uf)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cep;
            Municipio = municipio;
            UF = uf;
        }
        public string GetTextoEndereco()
        {
            return $"Endereço: {Logradouro} {Numero} {Complemento} - {Bairro} - CEP {CEP} - {Municipio} - {UF}";
        }

        public void Update(string logradouro, string numero, string complemento, string bairro, string cep, string municipio, string uf)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cep;
            Municipio = municipio;
            UF = uf;
        }

    }
}
