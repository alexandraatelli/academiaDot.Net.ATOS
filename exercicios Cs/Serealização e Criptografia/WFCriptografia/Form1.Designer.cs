namespace WFCriptografia
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
            this.Tb_Frase = new System.Windows.Forms.TextBox();
            this.Bt_CriptoAssimetrica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Cripto = new System.Windows.Forms.Label();
            this.Bt_DescriptoAssimetrica = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Descripto = new System.Windows.Forms.Label();
            this.Bt_CriptoSimetrica = new System.Windows.Forms.Button();
            this.Tb_Chave = new System.Windows.Forms.TextBox();
            this.Bt_DescriptoSimetrica = new System.Windows.Forms.Button();
            this.Bt_CriptoAES = new System.Windows.Forms.Button();
            this.Bt_DescriptoAES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase:";
            // 
            // Tb_Frase
            // 
            this.Tb_Frase.Location = new System.Drawing.Point(120, 50);
            this.Tb_Frase.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Frase.Name = "Tb_Frase";
            this.Tb_Frase.Size = new System.Drawing.Size(629, 27);
            this.Tb_Frase.TabIndex = 1;
            // 
            // Bt_CriptoAssimetrica
            // 
            this.Bt_CriptoAssimetrica.Location = new System.Drawing.Point(120, 118);
            this.Bt_CriptoAssimetrica.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_CriptoAssimetrica.Name = "Bt_CriptoAssimetrica";
            this.Bt_CriptoAssimetrica.Size = new System.Drawing.Size(206, 34);
            this.Bt_CriptoAssimetrica.TabIndex = 2;
            this.Bt_CriptoAssimetrica.Text = "Cripto Assimétrica";
            this.Bt_CriptoAssimetrica.UseVisualStyleBackColor = true;
            this.Bt_CriptoAssimetrica.Click += new System.EventHandler(this.Bt_Criptografar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frase Criptografada:";
            // 
            // Lbl_Cripto
            // 
            this.Lbl_Cripto.AutoSize = true;
            this.Lbl_Cripto.Location = new System.Drawing.Point(250, 288);
            this.Lbl_Cripto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cripto.Name = "Lbl_Cripto";
            this.Lbl_Cripto.Size = new System.Drawing.Size(21, 20);
            this.Lbl_Cripto.TabIndex = 4;
            this.Lbl_Cripto.Text = "--";
            // 
            // Bt_DescriptoAssimetrica
            // 
            this.Bt_DescriptoAssimetrica.Location = new System.Drawing.Point(120, 182);
            this.Bt_DescriptoAssimetrica.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_DescriptoAssimetrica.Name = "Bt_DescriptoAssimetrica";
            this.Bt_DescriptoAssimetrica.Size = new System.Drawing.Size(206, 34);
            this.Bt_DescriptoAssimetrica.TabIndex = 5;
            this.Bt_DescriptoAssimetrica.Text = "Descripto Assimétrica";
            this.Bt_DescriptoAssimetrica.UseVisualStyleBackColor = true;
            this.Bt_DescriptoAssimetrica.Click += new System.EventHandler(this.Bt_Descriptografar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frase Descriptografada:";
            // 
            // Lbl_Descripto
            // 
            this.Lbl_Descripto.AutoSize = true;
            this.Lbl_Descripto.Location = new System.Drawing.Point(250, 350);
            this.Lbl_Descripto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Descripto.Name = "Lbl_Descripto";
            this.Lbl_Descripto.Size = new System.Drawing.Size(21, 20);
            this.Lbl_Descripto.TabIndex = 7;
            this.Lbl_Descripto.Text = "--";
            // 
            // Bt_CriptoSimetrica
            // 
            this.Bt_CriptoSimetrica.Location = new System.Drawing.Point(442, 118);
            this.Bt_CriptoSimetrica.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_CriptoSimetrica.Name = "Bt_CriptoSimetrica";
            this.Bt_CriptoSimetrica.Size = new System.Drawing.Size(206, 34);
            this.Bt_CriptoSimetrica.TabIndex = 8;
            this.Bt_CriptoSimetrica.Text = "Cripto Simétrica";
            this.Bt_CriptoSimetrica.UseVisualStyleBackColor = true;
            this.Bt_CriptoSimetrica.Click += new System.EventHandler(this.Bt_CriptoSimetrica_Click);
            // 
            // Tb_Chave
            // 
            this.Tb_Chave.Location = new System.Drawing.Point(775, 50);
            this.Tb_Chave.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Chave.Name = "Tb_Chave";
            this.Tb_Chave.Size = new System.Drawing.Size(209, 27);
            this.Tb_Chave.TabIndex = 9;
            // 
            // Bt_DescriptoSimetrica
            // 
            this.Bt_DescriptoSimetrica.Location = new System.Drawing.Point(442, 182);
            this.Bt_DescriptoSimetrica.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_DescriptoSimetrica.Name = "Bt_DescriptoSimetrica";
            this.Bt_DescriptoSimetrica.Size = new System.Drawing.Size(206, 34);
            this.Bt_DescriptoSimetrica.TabIndex = 10;
            this.Bt_DescriptoSimetrica.Text = "Descripto Simétrica";
            this.Bt_DescriptoSimetrica.UseVisualStyleBackColor = true;
            this.Bt_DescriptoSimetrica.Click += new System.EventHandler(this.Bt_DescriptoSimetrica_Click);
            // 
            // Bt_CriptoAES
            // 
            this.Bt_CriptoAES.Location = new System.Drawing.Point(775, 118);
            this.Bt_CriptoAES.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_CriptoAES.Name = "Bt_CriptoAES";
            this.Bt_CriptoAES.Size = new System.Drawing.Size(206, 34);
            this.Bt_CriptoAES.TabIndex = 11;
            this.Bt_CriptoAES.Text = "Cripto AES";
            this.Bt_CriptoAES.UseVisualStyleBackColor = true;
            // 
            // Bt_DescriptoAES
            // 
            this.Bt_DescriptoAES.Location = new System.Drawing.Point(775, 182);
            this.Bt_DescriptoAES.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_DescriptoAES.Name = "Bt_DescriptoAES";
            this.Bt_DescriptoAES.Size = new System.Drawing.Size(206, 34);
            this.Bt_DescriptoAES.TabIndex = 12;
            this.Bt_DescriptoAES.Text = "Descripto AES";
            this.Bt_DescriptoAES.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1044, 486);
            this.Controls.Add(this.Bt_DescriptoAES);
            this.Controls.Add(this.Bt_CriptoAES);
            this.Controls.Add(this.Bt_DescriptoSimetrica);
            this.Controls.Add(this.Tb_Chave);
            this.Controls.Add(this.Bt_CriptoSimetrica);
            this.Controls.Add(this.Lbl_Descripto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bt_DescriptoAssimetrica);
            this.Controls.Add(this.Lbl_Cripto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bt_CriptoAssimetrica);
            this.Controls.Add(this.Tb_Frase);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Frase;
        private System.Windows.Forms.Button Bt_CriptoAssimetrica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Cripto;
        private System.Windows.Forms.Button Bt_DescriptoAssimetrica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Descripto;
        private System.Windows.Forms.Button Bt_CriptoSimetrica;
        private System.Windows.Forms.TextBox Tb_Chave;
        private System.Windows.Forms.Button Bt_DescriptoSimetrica;
        private System.Windows.Forms.Button Bt_CriptoAES;
        private System.Windows.Forms.Button Bt_DescriptoAES;
    }
}

