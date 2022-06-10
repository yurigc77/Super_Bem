using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sistema
{
    public partial class frm_login : Form
    {
        frm_Menu f_menu;
        DataTable dt = new DataTable();
        public frm_login(frm_Menu f)
        {
            InitializeComponent();
            f_menu = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void logar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string senha = tb_senha.Text;

            if(username==""||senha=="")
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                tb_username.Focus();
                return;
            }

            string sql = "select * from tb_funcionarios where user_name='"+username+"'and senha='"+senha+"'";
            
            dt = Banco.consulta(sql);
            
            if(dt.Rows.Count==1)
            {
                globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
