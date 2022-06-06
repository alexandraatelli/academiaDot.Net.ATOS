namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbCadastrar = new System.Windows.Forms.Button();
            this.tbLimpar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbTiposUsuarios = new System.Windows.Forms.CheckedListBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(189, 27);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(570, 22);
            this.tbNome.TabIndex = 0;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(189, 53);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(570, 22);
            this.tbTelefone.TabIndex = 1;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(189, 80);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(570, 22);
            this.tbCpf.TabIndex = 2;
            // 
            // tbCadastrar
            // 
            this.tbCadastrar.Location = new System.Drawing.Point(453, 388);
            this.tbCadastrar.Name = "tbCadastrar";
            this.tbCadastrar.Size = new System.Drawing.Size(151, 44);
            this.tbCadastrar.TabIndex = 9;
            this.tbCadastrar.Text = "Cadastrar";
            this.tbCadastrar.UseVisualStyleBackColor = true;
            // 
            // tbLimpar
            // 
            this.tbLimpar.Location = new System.Drawing.Point(622, 388);
            this.tbLimpar.Name = "tbLimpar";
            this.tbLimpar.Size = new System.Drawing.Size(151, 44);
            this.tbLimpar.TabIndex = 10;
            this.tbLimpar.Text = "Limpar";
            this.tbLimpar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(55, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(55, 58);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 16);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(55, 86);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(36, 16);
            this.lblCpf.TabIndex = 13;
            this.lblCpf.Text = "CPF:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(55, 139);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "Senha:";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(189, 136);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(570, 22);
            this.tbSenha.TabIndex = 8;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(55, 114);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 16);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Login:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(189, 175);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 20);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(285, 175);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 20);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Inativo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbTiposUsuarios
            // 
            this.cbTiposUsuarios.FormattingEnabled = true;
            this.cbTiposUsuarios.Items.AddRange(new object[] {
            "Usuário",
            "Administrador"});
            this.cbTiposUsuarios.Location = new System.Drawing.Point(189, 220);
            this.cbTiposUsuarios.Name = "cbTiposUsuarios";
            this.cbTiposUsuarios.Size = new System.Drawing.Size(163, 38);
            this.cbTiposUsuarios.TabIndex = 18;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(55, 229);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(107, 16);
            this.lblTipo.TabIndex = 19;
            this.lblTipo.Text = "Tipo de Usuário:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(189, 109);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(570, 22);
            this.tbLogin.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbTiposUsuarios);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbLimpar);
            this.Controls.Add(this.tbCadastrar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.Button tbCadastrar;
        private System.Windows.Forms.Button tbLimpar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckedListBox cbTiposUsuarios;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox tbLogin;
    }
}

