using System;
using System.Collections.Generic;
using System.Text;

namespace sistema
{
    class Produto
    {
        public Int32 codigo;
        string nome;
        decimal valor;
        string descricao;
        decimal quantidade;
        string fornecedor;
        string categoria;

        Int32 getCodigo()
        {
            return codigo;
        }
        void setCodigo(Int32 codigo)
        {
            this.codigo = codigo;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }


        public decimal getValor()
        {
            return valor;
        }
        public void setValor(decimal valor)
        {
            this.valor = valor;
        }


        public string getDescri()
        {
            return descricao;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }


        public decimal getQuantidade()
        {
            return quantidade;
        }
        public void setQuantidade(decimal quantidade)
        {
            this.quantidade = quantidade;
        }


        public string getFornecedor()
        {
            return fornecedor;
        }
        public void setFornecedor(string fornecedor)
        {
            this.fornecedor = fornecedor;
        }

        public string getCategoria()
        {
            return categoria;
        }
        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }
    }
}
