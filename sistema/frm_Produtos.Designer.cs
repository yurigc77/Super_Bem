
namespace sistema
{
    partial class frm_Produtos
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
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.num_valor = new System.Windows.Forms.NumericUpDown();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.tb_fornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_categoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num_quantidade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(37, 37);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(40, 15);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome";
            this.lb_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(83, 34);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(154, 23);
            this.tb_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(415, 173);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 6;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(509, 173);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 7;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(608, 173);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(713, 173);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // num_valor
            // 
            this.num_valor.DecimalPlaces = 2;
            this.num_valor.Location = new System.Drawing.Point(319, 34);
            this.num_valor.Name = "num_valor";
            this.num_valor.Size = new System.Drawing.Size(120, 23);
            this.num_valor.TabIndex = 12;
            this.num_valor.ValueChanged += new System.EventHandler(this.num_valor_ValueChanged);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(522, 34);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(225, 23);
            this.tb_descricao.TabIndex = 11;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Location = new System.Drawing.Point(12, 202);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowTemplate.Height = 25;
            this.dgv_produtos.Size = new System.Drawing.Size(776, 216);
            this.dgv_produtos.TabIndex = 13;
            this.dgv_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellContentClick);
            // 
            // tb_fornecedor
            // 
            this.tb_fornecedor.Location = new System.Drawing.Point(83, 100);
            this.tb_fornecedor.Name = "tb_fornecedor";
            this.tb_fornecedor.Size = new System.Drawing.Size(154, 23);
            this.tb_fornecedor.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fornecedor";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quantidade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_categoria
            // 
            this.tb_categoria.Location = new System.Drawing.Point(553, 100);
            this.tb_categoria.Name = "tb_categoria";
            this.tb_categoria.Size = new System.Drawing.Size(225, 23);
            this.tb_categoria.TabIndex = 19;
            this.tb_categoria.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Categoria";
            // 
            // num_quantidade
            // 
            this.num_quantidade.Location = new System.Drawing.Point(348, 100);
            this.num_quantidade.Name = "num_quantidade";
            this.num_quantidade.Size = new System.Drawing.Size(120, 23);
            this.num_quantidade.TabIndex = 21;
            // 
            // frm_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.num_quantidade);
            this.Controls.Add(this.tb_categoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_fornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.num_valor);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Name = "frm_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frm_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.NumericUpDown num_valor;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.TextBox tb_fornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_quantidade;
    }
}