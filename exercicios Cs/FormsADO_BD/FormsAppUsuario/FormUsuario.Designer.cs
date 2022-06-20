namespace WindowsFormsAppUsuario
{
    partial class FormUsuario
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
            this.Bt_Conectar = new System.Windows.Forms.Button();
            this.Bt_Adicionar = new System.Windows.Forms.Button();
            this.Bt_Remover = new System.Windows.Forms.Button();
            this.Tb_id_usuario = new System.Windows.Forms.TextBox();
            this.Tb_nomeCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Usuario = new System.Windows.Forms.ListView();
            this.id_usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Bt_Conectar
            // 
            this.Bt_Conectar.Location = new System.Drawing.Point(28, 374);
            this.Bt_Conectar.Name = "Bt_Conectar";
            this.Bt_Conectar.Size = new System.Drawing.Size(157, 34);
            this.Bt_Conectar.TabIndex = 1;
            this.Bt_Conectar.Text = "Conectar";
            this.Bt_Conectar.UseVisualStyleBackColor = true;
            this.Bt_Conectar.Click += new System.EventHandler(this.Bt_Conectar_Click);
            // 
            // Bt_Adicionar
            // 
            this.Bt_Adicionar.Location = new System.Drawing.Point(315, 374);
            this.Bt_Adicionar.Name = "Bt_Adicionar";
            this.Bt_Adicionar.Size = new System.Drawing.Size(157, 34);
            this.Bt_Adicionar.TabIndex = 2;
            this.Bt_Adicionar.Text = "Adicionar";
            this.Bt_Adicionar.UseVisualStyleBackColor = true;
            this.Bt_Adicionar.Click += new System.EventHandler(this.Bt_Adicionar_Click);
            // 
            // Bt_Remover
            // 
            this.Bt_Remover.Location = new System.Drawing.Point(611, 374);
            this.Bt_Remover.Name = "Bt_Remover";
            this.Bt_Remover.Size = new System.Drawing.Size(157, 34);
            this.Bt_Remover.TabIndex = 3;
            this.Bt_Remover.Text = "Remover";
            this.Bt_Remover.UseVisualStyleBackColor = true;
            this.Bt_Remover.Click += new System.EventHandler(this.Bt_Remover_Click);
            // 
            // Tb_id_usuario
            // 
            this.Tb_id_usuario.Location = new System.Drawing.Point(151, 267);
            this.Tb_id_usuario.Name = "Tb_id_usuario";
            this.Tb_id_usuario.Size = new System.Drawing.Size(180, 22);
            this.Tb_id_usuario.TabIndex = 4;
            // 
            // Tb_nomeCompleto
            // 
            this.Tb_nomeCompleto.Location = new System.Drawing.Point(151, 299);
            this.Tb_nomeCompleto.Name = "Tb_nomeCompleto";
            this.Tb_nomeCompleto.Size = new System.Drawing.Size(462, 22);
            this.Tb_nomeCompleto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "id_Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome Completo:";
            // 
            // listView_Usuario
            // 
            this.listView_Usuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_usuario,
            this.nomeCompleto,
            this.email});
            this.listView_Usuario.HideSelection = false;
            this.listView_Usuario.Location = new System.Drawing.Point(28, 12);
            this.listView_Usuario.Name = "listView_Usuario";
            this.listView_Usuario.Size = new System.Drawing.Size(740, 224);
            this.listView_Usuario.TabIndex = 8;
            this.listView_Usuario.UseCompatibleStateImageBehavior = false;
            // 
            // id_usuario
            // 
            this.id_usuario.Text = "id_usuario";
            this.id_usuario.Width = 20;
            // 
            // nomeCompleto
            // 
            this.nomeCompleto.Text = "nomeCompleto";
            this.nomeCompleto.Width = 150;
            // 
            // email
            // 
            this.email.Text = "email";
            this.email.Width = 150;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.listView_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_nomeCompleto);
            this.Controls.Add(this.Tb_id_usuario);
            this.Controls.Add(this.Bt_Remover);
            this.Controls.Add(this.Bt_Adicionar);
            this.Controls.Add(this.Bt_Conectar);
            this.Name = "FormUsuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Conectar;
        private System.Windows.Forms.Button Bt_Adicionar;
        private System.Windows.Forms.Button Bt_Remover;
        private System.Windows.Forms.TextBox Tb_id_usuario;
        private System.Windows.Forms.TextBox Tb_nomeCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Usuario;
        private System.Windows.Forms.ColumnHeader id_usuario;
        private System.Windows.Forms.ColumnHeader nomeCompleto;
        private System.Windows.Forms.ColumnHeader email;
    }
}

