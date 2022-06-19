namespace WindowsFormsApp_ADO_DB
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
            this.button_Conectar = new System.Windows.Forms.Button();
            this.listView_medidasGlicemias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.textBox_idGlicemia = new System.Windows.Forms.TextBox();
            this.textBox_valorGlicemia = new System.Windows.Forms.TextBox();
            this.textBox_DataMedicao = new System.Windows.Forms.TextBox();
            this.textBox_idPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Conectar
            // 
            this.button_Conectar.Location = new System.Drawing.Point(486, 295);
            this.button_Conectar.Name = "button_Conectar";
            this.button_Conectar.Size = new System.Drawing.Size(131, 44);
            this.button_Conectar.TabIndex = 0;
            this.button_Conectar.Text = "Conectar";
            this.button_Conectar.UseVisualStyleBackColor = true;
            this.button_Conectar.Click += new System.EventHandler(this.button_Conectar_Click_1);
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_medidasGlicemias.HideSelection = false;
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(34, 22);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(583, 258);
            this.listView_medidasGlicemias.TabIndex = 1;
            this.listView_medidasGlicemias.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Glicêmia";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Glicêmico";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Medição";
            this.columnHeader3.Width = 201;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID Paciente";
            this.columnHeader4.Width = 132;
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(182, 487);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(131, 44);
            this.button_Adicionar.TabIndex = 2;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // textBox_idGlicemia
            // 
            this.textBox_idGlicemia.Location = new System.Drawing.Point(142, 345);
            this.textBox_idGlicemia.Name = "textBox_idGlicemia";
            this.textBox_idGlicemia.Size = new System.Drawing.Size(171, 22);
            this.textBox_idGlicemia.TabIndex = 3;
            // 
            // textBox_valorGlicemia
            // 
            this.textBox_valorGlicemia.Location = new System.Drawing.Point(142, 376);
            this.textBox_valorGlicemia.Name = "textBox_valorGlicemia";
            this.textBox_valorGlicemia.Size = new System.Drawing.Size(171, 22);
            this.textBox_valorGlicemia.TabIndex = 4;
            // 
            // textBox_DataMedicao
            // 
            this.textBox_DataMedicao.Location = new System.Drawing.Point(142, 404);
            this.textBox_DataMedicao.Name = "textBox_DataMedicao";
            this.textBox_DataMedicao.Size = new System.Drawing.Size(171, 22);
            this.textBox_DataMedicao.TabIndex = 5;
            // 
            // textBox_idPaciente
            // 
            this.textBox_idPaciente.Location = new System.Drawing.Point(142, 437);
            this.textBox_idPaciente.Name = "textBox_idPaciente";
            this.textBox_idPaciente.Size = new System.Drawing.Size(171, 22);
            this.textBox_idPaciente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Medição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor Glicêmico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data Medição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID Paciente:";
            // 
            // button_Remover
            // 
            this.button_Remover.Location = new System.Drawing.Point(486, 382);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(131, 44);
            this.button_Remover.TabIndex = 11;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = true;
            this.button_Remover.Click += new System.EventHandler(this.button_Remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 575);
            this.Controls.Add(this.button_Remover);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_idPaciente);
            this.Controls.Add(this.textBox_DataMedicao);
            this.Controls.Add(this.textBox_valorGlicemia);
            this.Controls.Add(this.textBox_idGlicemia);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.Controls.Add(this.button_Conectar);
            this.Name = "Form1";
            this.Text = "Gerenciador de medidas glicêmicas";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Conectar;
        private System.Windows.Forms.ListView listView_medidasGlicemias;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.TextBox textBox_idGlicemia;
        private System.Windows.Forms.TextBox textBox_valorGlicemia;
        private System.Windows.Forms.TextBox textBox_DataMedicao;
        private System.Windows.Forms.TextBox textBox_idPaciente;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Remover;
    }
}

