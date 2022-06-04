namespace WindowsFormsApp2
{
    partial class Form2
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
            this.tbSalvar = new System.Windows.Forms.Button();
            this.tbLimpar = new System.Windows.Forms.Button();
            this.ModeloCarro = new System.Windows.Forms.TextBox();
            this.lblModCarro = new System.Windows.Forms.Label();
            this.lblFabricCarro = new System.Windows.Forms.Label();
            this.FabricCarro = new System.Windows.Forms.TextBox();
            this.lblOpcionais = new System.Windows.Forms.Label();
            this.lbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.cbQuantPortas = new System.Windows.Forms.ComboBox();
            this.lblPortas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSalvar
            // 
            this.tbSalvar.Location = new System.Drawing.Point(616, 459);
            this.tbSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.tbSalvar.Name = "tbSalvar";
            this.tbSalvar.Size = new System.Drawing.Size(201, 59);
            this.tbSalvar.TabIndex = 0;
            this.tbSalvar.Text = "Salvar";
            this.tbSalvar.UseVisualStyleBackColor = true;
            // 
            // tbLimpar
            // 
            this.tbLimpar.Location = new System.Drawing.Point(825, 459);
            this.tbLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.tbLimpar.Name = "tbLimpar";
            this.tbLimpar.Size = new System.Drawing.Size(201, 59);
            this.tbLimpar.TabIndex = 1;
            this.tbLimpar.Text = "Limpar";
            this.tbLimpar.UseVisualStyleBackColor = true;
            // 
            // ModeloCarro
            // 
            this.ModeloCarro.Location = new System.Drawing.Point(211, 23);
            this.ModeloCarro.Margin = new System.Windows.Forms.Padding(4);
            this.ModeloCarro.Name = "ModeloCarro";
            this.ModeloCarro.Size = new System.Drawing.Size(528, 22);
            this.ModeloCarro.TabIndex = 2;
            // 
            // lblModCarro
            // 
            this.lblModCarro.AutoSize = true;
            this.lblModCarro.Location = new System.Drawing.Point(49, 31);
            this.lblModCarro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModCarro.Name = "lblModCarro";
            this.lblModCarro.Size = new System.Drawing.Size(111, 16);
            this.lblModCarro.TabIndex = 3;
            this.lblModCarro.Text = "Modelo do Carro:";
            // 
            // lblFabricCarro
            // 
            this.lblFabricCarro.AutoSize = true;
            this.lblFabricCarro.Location = new System.Drawing.Point(53, 68);
            this.lblFabricCarro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFabricCarro.Name = "lblFabricCarro";
            this.lblFabricCarro.Size = new System.Drawing.Size(127, 16);
            this.lblFabricCarro.TabIndex = 4;
            this.lblFabricCarro.Text = "Fabricante do carro:";
            // 
            // FabricCarro
            // 
            this.FabricCarro.Location = new System.Drawing.Point(211, 59);
            this.FabricCarro.Margin = new System.Windows.Forms.Padding(4);
            this.FabricCarro.Name = "FabricCarro";
            this.FabricCarro.Size = new System.Drawing.Size(528, 22);
            this.FabricCarro.TabIndex = 5;
            // 
            // lblOpcionais
            // 
            this.lblOpcionais.AutoSize = true;
            this.lblOpcionais.Location = new System.Drawing.Point(53, 98);
            this.lblOpcionais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpcionais.Name = "lblOpcionais";
            this.lblOpcionais.Size = new System.Drawing.Size(71, 16);
            this.lblOpcionais.TabIndex = 6;
            this.lblOpcionais.Text = "Opcionais:";
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.FormattingEnabled = true;
            this.lbOpcionais.Items.AddRange(new object[] {
            "Ar Condicionado",
            "Direção Hidráulica",
            "Freios ABS",
            "Air bag",
            "Vidros Elétricos"});
            this.lbOpcionais.Location = new System.Drawing.Point(215, 98);
            this.lbOpcionais.Margin = new System.Windows.Forms.Padding(4);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(300, 89);
            this.lbOpcionais.TabIndex = 7;
            // 
            // cbQuantPortas
            // 
            this.cbQuantPortas.FormattingEnabled = true;
            this.cbQuantPortas.Items.AddRange(new object[] {
            "2 Portas",
            "4 Portas",
            "6 Portas"});
            this.cbQuantPortas.Location = new System.Drawing.Point(215, 212);
            this.cbQuantPortas.Margin = new System.Windows.Forms.Padding(4);
            this.cbQuantPortas.Name = "cbQuantPortas";
            this.cbQuantPortas.Size = new System.Drawing.Size(303, 24);
            this.cbQuantPortas.TabIndex = 8;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(49, 220);
            this.lblPortas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(141, 16);
            this.lblPortas.TabIndex = 9;
            this.lblPortas.Text = "Quantidade de Portas:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.cbQuantPortas);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.lblOpcionais);
            this.Controls.Add(this.FabricCarro);
            this.Controls.Add(this.lblFabricCarro);
            this.Controls.Add(this.lblModCarro);
            this.Controls.Add(this.ModeloCarro);
            this.Controls.Add(this.tbLimpar);
            this.Controls.Add(this.tbSalvar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Fom2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbSalvar;
        private System.Windows.Forms.Button tbLimpar;
        private System.Windows.Forms.TextBox ModeloCarro;
        private System.Windows.Forms.Label lblModCarro;
        private System.Windows.Forms.Label lblFabricCarro;
        private System.Windows.Forms.TextBox FabricCarro;
        private System.Windows.Forms.Label lblOpcionais;
        private System.Windows.Forms.CheckedListBox lbOpcionais;
        private System.Windows.Forms.ComboBox cbQuantPortas;
        private System.Windows.Forms.Label lblPortas;
    }
}

