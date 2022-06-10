
namespace sistema
{
    partial class frm_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.logar = new System.Windows.Forms.Button();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(79, 27);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(289, 23);
            this.tb_username.TabIndex = 1;
            // 
            // logar
            // 
            this.logar.Location = new System.Drawing.Point(79, 132);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(289, 23);
            this.logar.TabIndex = 2;
            this.logar.Text = "Logar";
            this.logar.UseVisualStyleBackColor = true;
            this.logar.Click += new System.EventHandler(this.logar_Click);
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(79, 92);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(289, 23);
            this.tb_senha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(79, 174);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(289, 23);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 222);
            this.ControlBox = false;
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logar);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button logar;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelar;
    }
}