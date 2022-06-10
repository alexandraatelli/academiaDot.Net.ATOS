namespace WindowsFormsApp3
{
    partial class FormularioCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCadastro));
            this.tipo = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbCadastrar = new System.Windows.Forms.Button();
            this.tbCancelar = new System.Windows.Forms.Button();
            this.statusAtivOrInat = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedFone = new System.Windows.Forms.MaskedTextBox();
            this.admUser = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.BackColor = System.Drawing.Color.Transparent;
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(220, 57);
            this.tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(46, 20);
            this.tipo.TabIndex = 0;
            this.tipo.Text = "Tipo:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(220, 107);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(62, 20);
            this.status.TabIndex = 1;
            this.status.Text = "Status:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.Color.Transparent;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(43, 222);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(58, 20);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome:";
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.BackColor = System.Drawing.Color.Transparent;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(43, 250);
            this.telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(78, 20);
            this.telefone.TabIndex = 3;
            this.telefone.Text = "Telefone:";
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.BackColor = System.Drawing.Color.Transparent;
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(43, 278);
            this.cpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(47, 20);
            this.cpf.TabIndex = 4;
            this.cpf.Text = "CPF:";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Location = new System.Drawing.Point(43, 351);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(55, 20);
            this.login.TabIndex = 12;
            this.login.Text = "Login:";
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.BackColor = System.Drawing.Color.Transparent;
            this.senha.Location = new System.Drawing.Point(43, 382);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(61, 20);
            this.senha.TabIndex = 13;
            this.senha.Text = "Senha:";
            // 
            // tbNome
            // 
            this.tbNome.AcceptsReturn = true;
            this.tbNome.AcceptsTab = true;
            this.tbNome.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNome.Location = new System.Drawing.Point(117, 216);
            this.tbNome.MaxLength = 60;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(629, 26);
            this.tbNome.TabIndex = 14;
            // 
            // tbLogin
            // 
            this.tbLogin.AcceptsReturn = true;
            this.tbLogin.AcceptsTab = true;
            this.tbLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbLogin.Location = new System.Drawing.Point(116, 345);
            this.tbLogin.MaxLength = 50;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(380, 26);
            this.tbLogin.TabIndex = 17;
            // 
            // tbSenha
            // 
            this.tbSenha.AcceptsReturn = true;
            this.tbSenha.AcceptsTab = true;
            this.tbSenha.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbSenha.Location = new System.Drawing.Point(116, 376);
            this.tbSenha.MaxLength = 15;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(380, 26);
            this.tbSenha.TabIndex = 18;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // tbCadastrar
            // 
            this.tbCadastrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tbCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadastrar.Location = new System.Drawing.Point(49, 191);
            this.tbCadastrar.Name = "tbCadastrar";
            this.tbCadastrar.Size = new System.Drawing.Size(195, 51);
            this.tbCadastrar.TabIndex = 21;
            this.tbCadastrar.Text = "Cadastrar";
            this.tbCadastrar.UseVisualStyleBackColor = false;
            this.tbCadastrar.Click += new System.EventHandler(this.tbCadastrar_Click_1);
            // 
            // tbCancelar
            // 
            this.tbCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tbCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCancelar.Location = new System.Drawing.Point(49, 320);
            this.tbCancelar.Name = "tbCancelar";
            this.tbCancelar.Size = new System.Drawing.Size(195, 51);
            this.tbCancelar.TabIndex = 22;
            this.tbCancelar.Text = "Cancelar";
            this.tbCancelar.UseVisualStyleBackColor = false;
            this.tbCancelar.Click += new System.EventHandler(this.tbCancelar_Click);
            // 
            // statusAtivOrInat
            // 
            this.statusAtivOrInat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusAtivOrInat.DropDownHeight = 100;
            this.statusAtivOrInat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusAtivOrInat.FormattingEnabled = true;
            this.statusAtivOrInat.IntegralHeight = false;
            this.statusAtivOrInat.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.statusAtivOrInat.Location = new System.Drawing.Point(313, 104);
            this.statusAtivOrInat.Name = "statusAtivOrInat";
            this.statusAtivOrInat.Size = new System.Drawing.Size(157, 28);
            this.statusAtivOrInat.Sorted = true;
            this.statusAtivOrInat.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tbCadastrar);
            this.panel1.Controls.Add(this.tbCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(805, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 554);
            this.panel1.TabIndex = 25;
            // 
            // maskedCpf
            // 
            this.maskedCpf.BackColor = System.Drawing.SystemColors.Highlight;
            this.maskedCpf.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskedCpf.Location = new System.Drawing.Point(119, 281);
            this.maskedCpf.Mask = "000,000,000-00";
            this.maskedCpf.Name = "maskedCpf";
            this.maskedCpf.Size = new System.Drawing.Size(129, 26);
            this.maskedCpf.TabIndex = 28;
            this.maskedCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedFone
            // 
            this.maskedFone.BackColor = System.Drawing.SystemColors.Highlight;
            this.maskedFone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskedFone.Location = new System.Drawing.Point(119, 250);
            this.maskedFone.Mask = "000 (00) 00000-0000";
            this.maskedFone.Name = "maskedFone";
            this.maskedFone.Size = new System.Drawing.Size(163, 26);
            this.maskedFone.TabIndex = 29;
            this.maskedFone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // admUser
            // 
            this.admUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admUser.DropDownHeight = 100;
            this.admUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admUser.FormattingEnabled = true;
            this.admUser.IntegralHeight = false;
            this.admUser.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.admUser.Location = new System.Drawing.Point(313, 49);
            this.admUser.Name = "admUser";
            this.admUser.Size = new System.Drawing.Size(157, 28);
            this.admUser.Sorted = true;
            this.admUser.TabIndex = 30;
            // 
            // FormularioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 554);
            this.Controls.Add(this.admUser);
            this.Controls.Add(this.maskedFone);
            this.Controls.Add(this.maskedCpf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusAtivOrInat);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.login);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tipo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulário de Cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulario_FormClosing);
            this.Shown += new System.EventHandler(this.Formulario_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button tbCadastrar;
        private System.Windows.Forms.Button tbCancelar;
        private System.Windows.Forms.ComboBox statusAtivOrInat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedCpf;
        private System.Windows.Forms.MaskedTextBox maskedFone;
        private System.Windows.Forms.ComboBox admUser;
    }
}

