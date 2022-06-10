using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sistema
{
    public partial class frm_Produtos : Form
    {
        public frm_Produtos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_descricao.Clear();
            num_valor.Value=0;
            num_quantidade.Value = 0;
            tb_fornecedor.Clear();
            tb_categoria.Clear();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.setNome(tb_nome.Text);
            produto.setValor(num_valor.Value);
            produto.setDescricao(tb_descricao.Text);
            produto.setQuantidade(num_quantidade.Value);
            produto.setFornecedor(tb_fornecedor.Text);
            produto.setCategoria(tb_categoria.Text);


            Banco.NovoProduto(produto);

            dgv_produtos.DataSource = Banco.ObterTodosProdutos();
        }

        private void num_valor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_Produtos_Load(object sender, EventArgs e)
        {
            dgv_produtos.DataSource = Banco.ObterTodosProdutos();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.setNome(tb_nome.Text);

            Banco.excluirProduto(produto);
            dgv_produtos.DataSource = Banco.ObterTodosProdutos();
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dgv_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
