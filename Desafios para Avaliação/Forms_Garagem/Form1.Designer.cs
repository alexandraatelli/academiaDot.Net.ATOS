namespace Forms_Garagem
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
            this.tb_Placas = new System.Windows.Forms.TextBox();
            this.lbl_PlacasVeiculos = new System.Windows.Forms.Label();
            this.dateTime_Entrada = new System.Windows.Forms.DateTimePicker();
            this.lbl_Entrada = new System.Windows.Forms.Label();
            this.tb_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Remover = new System.Windows.Forms.Button();
            this.dateTime_Saida = new System.Windows.Forms.DateTimePicker();
            this.lbl_Saida = new System.Windows.Forms.Label();
            this.tb_VeiculosEstacionados = new System.Windows.Forms.TextBox();
            this.lbl_VeiculosEstacionados = new System.Windows.Forms.Label();
            this.lbl_HistoricoVeiculos = new System.Windows.Forms.Label();
            this.tb_HistoricoVeiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Placas
            // 
            this.tb_Placas.Location = new System.Drawing.Point(195, 23);
            this.tb_Placas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Placas.Name = "tb_Placas";
            this.tb_Placas.Size = new System.Drawing.Size(175, 30);
            this.tb_Placas.TabIndex = 0;
            // 
            // lbl_PlacasVeiculos
            // 
            this.lbl_PlacasVeiculos.AutoSize = true;
            this.lbl_PlacasVeiculos.CausesValidation = false;
            this.lbl_PlacasVeiculos.Location = new System.Drawing.Point(13, 28);
            this.lbl_PlacasVeiculos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PlacasVeiculos.Name = "lbl_PlacasVeiculos";
            this.lbl_PlacasVeiculos.Size = new System.Drawing.Size(174, 25);
            this.lbl_PlacasVeiculos.TabIndex = 1;
            this.lbl_PlacasVeiculos.Text = "Placas do Veículo:";
            // 
            // dateTime_Entrada
            // 
            this.dateTime_Entrada.Location = new System.Drawing.Point(621, 23);
            this.dateTime_Entrada.Name = "dateTime_Entrada";
            this.dateTime_Entrada.Size = new System.Drawing.Size(475, 30);
            this.dateTime_Entrada.TabIndex = 2;
            // 
            // lbl_Entrada
            // 
            this.lbl_Entrada.AutoSize = true;
            this.lbl_Entrada.Enabled = false;
            this.lbl_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Entrada.Location = new System.Drawing.Point(393, 28);
            this.lbl_Entrada.Name = "lbl_Entrada";
            this.lbl_Entrada.Size = new System.Drawing.Size(222, 25);
            this.lbl_Entrada.TabIndex = 3;
            this.lbl_Entrada.Text = "Data e Hora de Entrada:";
            // 
            // tb_Cadastrar
            // 
            this.tb_Cadastrar.Enabled = false;
            this.tb_Cadastrar.Location = new System.Drawing.Point(381, 469);
            this.tb_Cadastrar.Name = "tb_Cadastrar";
            this.tb_Cadastrar.Size = new System.Drawing.Size(153, 71);
            this.tb_Cadastrar.TabIndex = 4;
            this.tb_Cadastrar.Text = "Cadastrar";
            this.tb_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // bt_Remover
            // 
            this.bt_Remover.Enabled = false;
            this.bt_Remover.Location = new System.Drawing.Point(580, 469);
            this.bt_Remover.Name = "bt_Remover";
            this.bt_Remover.Size = new System.Drawing.Size(153, 71);
            this.bt_Remover.TabIndex = 5;
            this.bt_Remover.Text = "Remover";
            this.bt_Remover.UseVisualStyleBackColor = true;
            // 
            // dateTime_Saida
            // 
            this.dateTime_Saida.Location = new System.Drawing.Point(224, 69);
            this.dateTime_Saida.Name = "dateTime_Saida";
            this.dateTime_Saida.Size = new System.Drawing.Size(415, 30);
            this.dateTime_Saida.TabIndex = 6;
            // 
            // lbl_Saida
            // 
            this.lbl_Saida.AutoSize = true;
            this.lbl_Saida.Enabled = false;
            this.lbl_Saida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saida.Location = new System.Drawing.Point(13, 74);
            this.lbl_Saida.Name = "lbl_Saida";
            this.lbl_Saida.Size = new System.Drawing.Size(205, 25);
            this.lbl_Saida.TabIndex = 7;
            this.lbl_Saida.Text = "Data e Hora de Saída:";
            // 
            // tb_VeiculosEstacionados
            // 
            this.tb_VeiculosEstacionados.Enabled = false;
            this.tb_VeiculosEstacionados.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_VeiculosEstacionados.Location = new System.Drawing.Point(18, 165);
            this.tb_VeiculosEstacionados.Multiline = true;
            this.tb_VeiculosEstacionados.Name = "tb_VeiculosEstacionados";
            this.tb_VeiculosEstacionados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_VeiculosEstacionados.Size = new System.Drawing.Size(516, 277);
            this.tb_VeiculosEstacionados.TabIndex = 8;
            // 
            // lbl_VeiculosEstacionados
            // 
            this.lbl_VeiculosEstacionados.AutoSize = true;
            this.lbl_VeiculosEstacionados.Enabled = false;
            this.lbl_VeiculosEstacionados.Location = new System.Drawing.Point(13, 125);
            this.lbl_VeiculosEstacionados.Name = "lbl_VeiculosEstacionados";
            this.lbl_VeiculosEstacionados.Size = new System.Drawing.Size(216, 25);
            this.lbl_VeiculosEstacionados.TabIndex = 9;
            this.lbl_VeiculosEstacionados.Text = "Veículos Estacionados:";
            // 
            // lbl_HistoricoVeiculos
            // 
            this.lbl_HistoricoVeiculos.AutoSize = true;
            this.lbl_HistoricoVeiculos.Enabled = false;
            this.lbl_HistoricoVeiculos.Location = new System.Drawing.Point(575, 125);
            this.lbl_HistoricoVeiculos.Name = "lbl_HistoricoVeiculos";
            this.lbl_HistoricoVeiculos.Size = new System.Drawing.Size(200, 25);
            this.lbl_HistoricoVeiculos.TabIndex = 10;
            this.lbl_HistoricoVeiculos.Text = "Histórico de Veículos:";
            // 
            // tb_HistoricoVeiculos
            // 
            this.tb_HistoricoVeiculos.Enabled = false;
            this.tb_HistoricoVeiculos.Location = new System.Drawing.Point(580, 165);
            this.tb_HistoricoVeiculos.Multiline = true;
            this.tb_HistoricoVeiculos.Name = "tb_HistoricoVeiculos";
            this.tb_HistoricoVeiculos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_HistoricoVeiculos.Size = new System.Drawing.Size(516, 277);
            this.tb_HistoricoVeiculos.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1106, 548);
            this.Controls.Add(this.tb_HistoricoVeiculos);
            this.Controls.Add(this.lbl_HistoricoVeiculos);
            this.Controls.Add(this.lbl_VeiculosEstacionados);
            this.Controls.Add(this.tb_VeiculosEstacionados);
            this.Controls.Add(this.lbl_Saida);
            this.Controls.Add(this.dateTime_Saida);
            this.Controls.Add(this.bt_Remover);
            this.Controls.Add(this.tb_Cadastrar);
            this.Controls.Add(this.lbl_Entrada);
            this.Controls.Add(this.dateTime_Entrada);
            this.Controls.Add(this.lbl_PlacasVeiculos);
            this.Controls.Add(this.tb_Placas);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Controle de Veículos:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Placas;
        private System.Windows.Forms.Label lbl_PlacasVeiculos;
        private System.Windows.Forms.DateTimePicker dateTime_Entrada;
        private System.Windows.Forms.Label lbl_Entrada;
        private System.Windows.Forms.Button tb_Cadastrar;
        private System.Windows.Forms.Button bt_Remover;
        private System.Windows.Forms.DateTimePicker dateTime_Saida;
        private System.Windows.Forms.Label lbl_Saida;
        private System.Windows.Forms.TextBox tb_VeiculosEstacionados;
        private System.Windows.Forms.Label lbl_VeiculosEstacionados;
        private System.Windows.Forms.Label lbl_HistoricoVeiculos;
        private System.Windows.Forms.TextBox tb_HistoricoVeiculos;
    }
}

