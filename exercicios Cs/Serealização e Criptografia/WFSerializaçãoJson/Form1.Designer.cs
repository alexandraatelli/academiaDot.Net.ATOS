namespace WFSerializaçãoJson
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
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Gravar = new System.Windows.Forms.Button();
            this.Tb_NomePaciente = new System.Windows.Forms.TextBox();
            this.Mtb_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.Bt_Serializar = new System.Windows.Forms.Button();
            this.Bt_Deserializar = new System.Windows.Forms.Button();
            this.Tb_ConteudoArquivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Paciente:";
            // 
            // Bt_Gravar
            // 
            this.Bt_Gravar.Location = new System.Drawing.Point(28, 151);
            this.Bt_Gravar.Name = "Bt_Gravar";
            this.Bt_Gravar.Size = new System.Drawing.Size(120, 47);
            this.Bt_Gravar.TabIndex = 1;
            this.Bt_Gravar.Text = "Gravar";
            this.Bt_Gravar.UseVisualStyleBackColor = true;
            this.Bt_Gravar.Click += new System.EventHandler(this.Bt_Gravar_Click);
            // 
            // Tb_NomePaciente
            // 
            this.Tb_NomePaciente.Location = new System.Drawing.Point(152, 17);
            this.Tb_NomePaciente.Name = "Tb_NomePaciente";
            this.Tb_NomePaciente.Size = new System.Drawing.Size(517, 22);
            this.Tb_NomePaciente.TabIndex = 2;
            // 
            // Mtb_DataNascimento
            // 
            this.Mtb_DataNascimento.Location = new System.Drawing.Point(152, 55);
            this.Mtb_DataNascimento.Mask = "00/00/0000";
            this.Mtb_DataNascimento.Name = "Mtb_DataNascimento";
            this.Mtb_DataNascimento.Size = new System.Drawing.Size(81, 22);
            this.Mtb_DataNascimento.TabIndex = 3;

            // 
            // Mtb_Cpf
            // 
            this.Mtb_Cpf.Location = new System.Drawing.Point(152, 94);
            this.Mtb_Cpf.Mask = "000.000.000-00";
            this.Mtb_Cpf.Name = "Mtb_Cpf";
            this.Mtb_Cpf.Size = new System.Drawing.Size(101, 22);
            this.Mtb_Cpf.TabIndex = 4;
            // 
            // Bt_Serializar
            // 
            this.Bt_Serializar.Location = new System.Drawing.Point(172, 151);
            this.Bt_Serializar.Name = "Bt_Serializar";
            this.Bt_Serializar.Size = new System.Drawing.Size(122, 47);
            this.Bt_Serializar.TabIndex = 5;
            this.Bt_Serializar.Text = "Serializar";
            this.Bt_Serializar.UseVisualStyleBackColor = true;
            this.Bt_Serializar.Click += new System.EventHandler(this.Bt_Serializar_Click);
            // 
            // Bt_Deserializar
            // 
            this.Bt_Deserializar.Location = new System.Drawing.Point(315, 151);
            this.Bt_Deserializar.Name = "Bt_Deserializar";
            this.Bt_Deserializar.Size = new System.Drawing.Size(122, 47);
            this.Bt_Deserializar.TabIndex = 6;
            this.Bt_Deserializar.Text = "Deserializar";
            this.Bt_Deserializar.UseVisualStyleBackColor = true;
            this.Bt_Deserializar.Click += new System.EventHandler(this.Bt_Deserializar_Click);
            // 
            // Tb_ConteudoArquivo
            // 
            this.Tb_ConteudoArquivo.Location = new System.Drawing.Point(28, 219);
            this.Tb_ConteudoArquivo.Multiline = true;
            this.Tb_ConteudoArquivo.Name = "Tb_ConteudoArquivo";
            this.Tb_ConteudoArquivo.Size = new System.Drawing.Size(656, 204);
            this.Tb_ConteudoArquivo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "CPF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_ConteudoArquivo);
            this.Controls.Add(this.Bt_Deserializar);
            this.Controls.Add(this.Bt_Serializar);
            this.Controls.Add(this.Mtb_Cpf);
            this.Controls.Add(this.Mtb_DataNascimento);
            this.Controls.Add(this.Tb_NomePaciente);
            this.Controls.Add(this.Bt_Gravar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form SerializarJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Gravar;
        private System.Windows.Forms.TextBox Tb_NomePaciente;
        private System.Windows.Forms.MaskedTextBox Mtb_DataNascimento;
        private System.Windows.Forms.MaskedTextBox Mtb_Cpf;
        private System.Windows.Forms.Button Bt_Serializar;
        private System.Windows.Forms.Button Bt_Deserializar;
        private System.Windows.Forms.TextBox Tb_ConteudoArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

