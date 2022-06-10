using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sistema
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
            frm_login f_login = new frm_login(this);
            f_login.ShowDialog();   
            if(globais.logado==false)
            {
                this.Close();
            }
        }

        private void btn_cad_produtos_Click(object sender, EventArgs e)
        {
            frm_Produtos frm = new frm_Produtos();
            frm.Show();
        }

        private void bnt_cad_categorias_Click(object sender, EventArgs e)
        {
            frm_Cad_Funcionario frm = new frm_Cad_Funcionario();
            frm.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            frm_sobre frm = new frm_sobre();
            frm.Show();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
