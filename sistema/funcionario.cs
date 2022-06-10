using System;
using System.Collections.Generic;
using System.Text;

namespace sistema
{
    class Funcionario
    {
        public Int32 ID;
        string nome;
        string user_name;
        string senha;
        string cpf;
        string telefone;
        string email;
        string endereco;
        string data;

        public Funcionario(
            string nome,
            string user_name,
            string senha,
            string cpf,
            string telefone,
            string email,
            string endereco,
            string data)
        {
            setNome(nome);
            setUser(user_name);
            setSenha(senha);
            setCpf(cpf);
            setTelefone(telefone);
            setEmail(email);
            setEndereco(endereco);
            setData(data);
        }

        Int32 getID()
        {
            return ID;
        }
        void setID(Int32 ID)
        {
            this.ID = ID;
        }

       public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }


        public string getUser()
        {
            return user_name;
        }
        public void setUser(string user_name)
        {
            this.user_name = user_name;
        }


        public string getSenha()
        {
            return senha;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public string getCpf()
        {
            return cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getTelefone()
        {
            return telefone;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEndereco()
        {
            return endereco;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string getData()
        {
            return data;
        }
        public void setData(string data)
        {
            this.data = data;
        }
    }
}
