
namespace sistema
{
    partial class frm_Cad_Funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_funcionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(252, 274);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(137, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(398, 274);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(137, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Cadastrar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(12, 9);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(40, 15);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 27);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(523, 23);
            this.tb_nome.TabIndex = 3;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(237, 227);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(137, 23);
            this.tb_username.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(380, 227);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(155, 23);
            this.tb_senha.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(12, 83);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(523, 23);
            this.tb_cpf.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(12, 131);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(250, 23);
            this.tb_telefone.TabIndex = 11;
            this.tb_telefone.TextChanged += new System.EventHandler(this.tb_telefone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefone";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(12, 179);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(114, 23);
            this.tb_endereco.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cidade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 227);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(208, 23);
            this.tb_data.TabIndex = 15;
            this.tb_data.Text = "00/00/00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data de Nascimento";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(268, 131);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(267, 23);
            this.tb_email.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "E-mail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 23);
            this.textBox1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 23);
            this.textBox2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Bairro";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(372, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 23);
            this.textBox3.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Rua e N°";
            // 
            // dgv_funcionarios
            // 
            this.dgv_funcionarios.AllowUserToAddRows = false;
            this.dgv_funcionarios.AllowUserToDeleteRows = false;
            this.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionarios.Location = new System.Drawing.Point(3, 303);
            this.dgv_funcionarios.Name = "dgv_funcionarios";
            this.dgv_funcionarios.ReadOnly = true;
            this.dgv_funcionarios.RowTemplate.Height = 25;
            this.dgv_funcionarios.Size = new System.Drawing.Size(551, 246);
            this.dgv_funcionarios.TabIndex = 24;
            this.dgv_funcionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_funcionarios_CellContentClick);
            // 
            // frm_Cad_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 561);
            this.Controls.Add(this.dgv_funcionarios);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Cad_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de funcionario";
            this.Load += new System.EventHandler(this.frm_Cad_Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_funcionarios;
    }
}