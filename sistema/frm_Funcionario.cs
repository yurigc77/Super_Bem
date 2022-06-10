using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sistema
{
    public partial class frm_Cad_Funcionario : Form
    {
        public frm_Cad_Funcionario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {

        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void text_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Cad_Funcionario_Load(object sender, EventArgs e)
        {
        
                dgv_funcionarios.DataSource = Banco.ObterUsuarios();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            tb_cpf.Clear();
            tb_data.Clear();
            tb_endereco.Clear();
            tb_email.Clear();
            tb_telefone.Clear();

           
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            /*
Funcionario funcionario = new Funcionario();
funcionario.setNome(tb_nome.Text);
funcionario.setUser(tb_username.Text);
funcionario.setSenha(tb_senha.Text);
funcionario.setCpf(tb_cpf.Text);
funcionario.setTelefone(tb_telefone.Text);
funcionario.setEmail(tb_email.Text);
funcionario.setEndereco(tb_endereco.Text);
funcionario.setData(tb_data.Text);
*/

            Funcionario funcionario = new Funcionario(
               tb_nome.Text,
               tb_username.Text,
               tb_senha.Text,
               tb_cpf.Text,
               tb_telefone.Text,
               tb_email.Text,
               tb_endereco.Text,
               tb_data.Text);

            Banco.NovoFuncionario(funcionario);

            dgv_funcionarios.DataSource = Banco.ObterUsuarios();

        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tb_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_funcionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
