//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace sistema
{
    class Banco
    {
        private static SQLiteConnection conexao;

        
        private static SQLiteConnection ConexaoBanco()//metodo que retorna a conexao ao banco
        {
            //conexao = new SQLiteConnection("Data Source=D:\\programação\\c#\\sistema de vendas\\sistema\\sistema\\banco\\bd_super_bem.db");
            conexao = new SQLiteConnection("Data Source="+globais.caminhoBanco+globais.nomeBanco);
            conexao.Open();

            return conexao;
        }

        
        public static DataTable ObterTodosUsuarios()//metodo que retorna a tabela funcionarios
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try 
            {
                using (var cmd= ConexaoBanco().CreateCommand()) 
                {
                    cmd.CommandText = "select * from tb_funcionarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch(Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }


        public static DataTable ObterTodosProdutos()//metodo que retorna a tabela produtos
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "select * from tb_produtos";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }

        public static DataTable consulta(string sql)//metodo para consultas
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        //funções de frm_Funcionario

        public static void NovoFuncionario(Funcionario f)
        {
            if(existeUsername(f))
            {
                MessageBox.Show("Esse user name já está sendo usado.");
                return;
            }
            
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_funcionarios (Nome,User_name,Senha,CPF,Telefone,Email,Endereco,Nascimento) VALUES (@nome,@username,@senha,@cpf,@telefone,@email,@endereco,@data)";
                cmd.Parameters.AddWithValue("@nome", f.getNome());
                cmd.Parameters.AddWithValue("@username", f.getUser());
                cmd.Parameters.AddWithValue("@senha", f.getSenha());
                cmd.Parameters.AddWithValue("@cpf", f.getCpf());
                cmd.Parameters.AddWithValue("@telefone", f.getTelefone());
                cmd.Parameters.AddWithValue("@email", f.getEmail());
                cmd.Parameters.AddWithValue("@endereco", f.getEndereco());
                cmd.Parameters.AddWithValue("@data", f.getData());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo funcionario cadastrado!");
                ConexaoBanco().Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO no cadastro!");
                ConexaoBanco().Close();
                throw ex;
            }

        }


        public static DataTable ObterUsuarios()//metodo que retorna a tabela funcionarios
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "select Nome,CPF,Email from tb_funcionarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }

        //funções de frm_Produt
        public static void NovoProduto(Produto p)
        {
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_produtos (Nome,Valor,Descricao,Quantidade,Fornecedor,Categoria) VALUES (@nome,@valor,@descricao,@quantidade,@fornecedor,@categoria)";
                cmd.Parameters.AddWithValue("@nome", p.getNome());
                cmd.Parameters.AddWithValue("@valor", p.getValor());
                cmd.Parameters.AddWithValue("@descricao", p.getDescri());
                cmd.Parameters.AddWithValue("@quantidade", p.getQuantidade());
                cmd.Parameters.AddWithValue("@fornecedor", p.getFornecedor());
                cmd.Parameters.AddWithValue("@categoria", p.getCategoria());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo produto cadastrado!");
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO no cadastro!");
                ConexaoBanco().Close();
                throw ex;
            }

        }

        public static void excluirProduto(Produto p)
        {
            if (existeProduto(p)==false)
            {
                MessageBox.Show("Esse produto não existe!");
                return;
            }
            else
            {
                try
                {
                    var cmd = ConexaoBanco().CreateCommand();
                    cmd.CommandText = "DELETE FROM tb_produtos WHERE nome='" + p.getNome() + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto:" + p.getNome() + " excluido!");
                    ConexaoBanco().Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO ao excluir!");
                    ConexaoBanco().Close();
                    throw ex;
                }
            }
            
        }


        //rotinas gerais
        public static bool existeUsername(Funcionario f)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT user_name FROM tb_funcionarios WHERE user_name='" + f.getUser() + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            
            return res;
        }


        public static bool existeProduto(Produto p)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT nome FROM tb_produtos WHERE nome='" + p.getNome() + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }



    }
}