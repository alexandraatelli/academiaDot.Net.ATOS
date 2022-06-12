namespace WindowsFormsGaragem
{
    partial class FormGaragem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPlacas = new System.Windows.Forms.TextBox();
            this.textBoxDataEntrada = new System.Windows.Forms.TextBox();
            this.textBoxHoraEntrada = new System.Windows.Forms.TextBox();
            this.textBoxDataSaida = new System.Windows.Forms.TextBox();
            this.textBoxHoraSaida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonFecharConta = new System.Windows.Forms.Button();
            this.textBoxVeiculosPatio = new System.Windows.Forms.TextBox();
            this.textBoxListaVeiculosAtual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(739, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Entrada:";
            // 
            // textBoxPlacas
            // 
            this.textBoxPlacas.Location = new System.Drawing.Point(139, 27);
            this.textBoxPlacas.Name = "textBoxPlacas";
            this.textBoxPlacas.Size = new System.Drawing.Size(206, 22);
            this.textBoxPlacas.TabIndex = 3;
            // 
            // textBoxDataEntrada
            // 
            this.textBoxDataEntrada.Location = new System.Drawing.Point(531, 31);
            this.textBoxDataEntrada.Name = "textBoxDataEntrada";
            this.textBoxDataEntrada.Size = new System.Drawing.Size(169, 22);
            this.textBoxDataEntrada.TabIndex = 4;
            // 
            // textBoxHoraEntrada
            // 
            this.textBoxHoraEntrada.Location = new System.Drawing.Point(844, 29);
            this.textBoxHoraEntrada.Name = "textBoxHoraEntrada";
            this.textBoxHoraEntrada.Size = new System.Drawing.Size(167, 22);
            this.textBoxHoraEntrada.TabIndex = 5;
            // 
            // textBoxDataSaida
            // 
            this.textBoxDataSaida.Location = new System.Drawing.Point(534, 76);
            this.textBoxDataSaida.Name = "textBoxDataSaida";
            this.textBoxDataSaida.Size = new System.Drawing.Size(166, 22);
            this.textBoxDataSaida.TabIndex = 6;
            // 
            // textBoxHoraSaida
            // 
            this.textBoxHoraSaida.Location = new System.Drawing.Point(844, 76);
            this.textBoxHoraSaida.Name = "textBoxHoraSaida";
            this.textBoxHoraSaida.Size = new System.Drawing.Size(167, 22);
            this.textBoxHoraSaida.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Saída:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora Saída:";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(70, 136);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(186, 47);
            this.buttonCadastrar.TabIndex = 10;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(308, 135);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(178, 47);
            this.buttonRemover.TabIndex = 11;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonFecharConta
            // 
            this.buttonFecharConta.Location = new System.Drawing.Point(837, 137);
            this.buttonFecharConta.Name = "buttonFecharConta";
            this.buttonFecharConta.Size = new System.Drawing.Size(174, 46);
            this.buttonFecharConta.TabIndex = 12;
            this.buttonFecharConta.Text = "Fechar Conta";
            this.buttonFecharConta.UseVisualStyleBackColor = true;
            // 
            // textBoxVeiculosPatio
            // 
            this.textBoxVeiculosPatio.Location = new System.Drawing.Point(79, 252);
            this.textBoxVeiculosPatio.Multiline = true;
            this.textBoxVeiculosPatio.Name = "textBoxVeiculosPatio";
            this.textBoxVeiculosPatio.Size = new System.Drawing.Size(464, 255);
            this.textBoxVeiculosPatio.TabIndex = 13;
            // 
            // textBoxListaVeiculosAtual
            // 
            this.textBoxListaVeiculosAtual.Location = new System.Drawing.Point(626, 259);
            this.textBoxListaVeiculosAtual.Multiline = true;
            this.textBoxListaVeiculosAtual.Name = "textBoxListaVeiculosAtual";
            this.textBoxListaVeiculosAtual.Size = new System.Drawing.Size(419, 247);
            this.textBoxListaVeiculosAtual.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Veículos no Pátio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lista Veículos Atual:";
            // 
            // FormGaragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1098, 547);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxListaVeiculosAtual);
            this.Controls.Add(this.textBoxVeiculosPatio);
            this.Controls.Add(this.buttonFecharConta);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHoraSaida);
            this.Controls.Add(this.textBoxDataSaida);
            this.Controls.Add(this.textBoxHoraEntrada);
            this.Controls.Add(this.textBoxDataEntrada);
            this.Controls.Add(this.textBoxPlacas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGaragem";
            this.Text = "Garagem: Estacionamento para Veículos";
            this.Click += new System.EventHandler(this.FormGaragem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPlacas;
        private System.Windows.Forms.TextBox textBoxDataEntrada;
        private System.Windows.Forms.TextBox textBoxHoraEntrada;
        private System.Windows.Forms.TextBox textBoxDataSaida;
        private System.Windows.Forms.TextBox textBoxHoraSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonFecharConta;
        private System.Windows.Forms.TextBox textBoxVeiculosPatio;
        private System.Windows.Forms.TextBox textBoxListaVeiculosAtual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

