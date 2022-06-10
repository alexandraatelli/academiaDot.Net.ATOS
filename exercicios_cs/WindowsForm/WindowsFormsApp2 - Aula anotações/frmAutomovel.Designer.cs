namespace WindowsFormsApp2
{
    partial class frmAutomovel
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
            this.dgAutomoveis = new System.Windows.Forms.DataGridView();
            this.dg_ModeloCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_FabricCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_arCond = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dg_dirHidr = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dg_abs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dg_airBg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dg_vidElet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dg_portas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_CarregarDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomoveis)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSalvar
            // 
            this.tbSalvar.Location = new System.Drawing.Point(52, 403);
            this.tbSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.tbSalvar.Name = "tbSalvar";
            this.tbSalvar.Size = new System.Drawing.Size(201, 59);
            this.tbSalvar.TabIndex = 0;
            this.tbSalvar.Text = "Salvar";
            this.tbSalvar.UseVisualStyleBackColor = true;
            this.tbSalvar.Click += new System.EventHandler(this.tbSalvar_Click_1);
            // 
            // tbLimpar
            // 
            this.tbLimpar.Location = new System.Drawing.Point(317, 403);
            this.tbLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.tbLimpar.Name = "tbLimpar";
            this.tbLimpar.Size = new System.Drawing.Size(201, 59);
            this.tbLimpar.TabIndex = 1;
            this.tbLimpar.Text = "Limpar";
            this.tbLimpar.UseVisualStyleBackColor = true;
            this.tbLimpar.Click += new System.EventHandler(this.tbLimpar_Click_1);
            // 
            // ModeloCarro
            // 
            this.ModeloCarro.Location = new System.Drawing.Point(211, 23);
            this.ModeloCarro.Margin = new System.Windows.Forms.Padding(4);
            this.ModeloCarro.Name = "ModeloCarro";
            this.ModeloCarro.Size = new System.Drawing.Size(307, 22);
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
            this.FabricCarro.Size = new System.Drawing.Size(307, 22);
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
            this.lbOpcionais.Size = new System.Drawing.Size(303, 89);
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
            // dgAutomoveis
            // 
            this.dgAutomoveis.AllowUserToOrderColumns = true;
            this.dgAutomoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutomoveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_ModeloCarro,
            this.dg_FabricCarro,
            this.dg_arCond,
            this.dg_dirHidr,
            this.dg_abs,
            this.dg_airBg,
            this.dg_vidElet,
            this.dg_portas});
            this.dgAutomoveis.Location = new System.Drawing.Point(544, 24);
            this.dgAutomoveis.Name = "dgAutomoveis";
            this.dgAutomoveis.RowHeadersWidth = 51;
            this.dgAutomoveis.RowTemplate.Height = 24;
            this.dgAutomoveis.Size = new System.Drawing.Size(516, 505);
            this.dgAutomoveis.TabIndex = 10;
            // 
            // dg_ModeloCarro
            // 
            this.dg_ModeloCarro.HeaderText = "Modelo do Carro";
            this.dg_ModeloCarro.MinimumWidth = 6;
            this.dg_ModeloCarro.Name = "dg_ModeloCarro";
            this.dg_ModeloCarro.Width = 125;
            // 
            // dg_FabricCarro
            // 
            this.dg_FabricCarro.HeaderText = "Fabricante";
            this.dg_FabricCarro.MinimumWidth = 6;
            this.dg_FabricCarro.Name = "dg_FabricCarro";
            this.dg_FabricCarro.Width = 125;
            // 
            // dg_arCond
            // 
            this.dg_arCond.HeaderText = "Ar Condicionado";
            this.dg_arCond.MinimumWidth = 6;
            this.dg_arCond.Name = "dg_arCond";
            this.dg_arCond.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_arCond.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dg_arCond.Width = 125;
            // 
            // dg_dirHidr
            // 
            this.dg_dirHidr.HeaderText = "Direção Hidráulica";
            this.dg_dirHidr.MinimumWidth = 6;
            this.dg_dirHidr.Name = "dg_dirHidr";
            this.dg_dirHidr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_dirHidr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dg_dirHidr.Width = 125;
            // 
            // dg_abs
            // 
            this.dg_abs.HeaderText = "Freios ABS";
            this.dg_abs.MinimumWidth = 6;
            this.dg_abs.Name = "dg_abs";
            this.dg_abs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_abs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dg_abs.Width = 125;
            // 
            // dg_airBg
            // 
            this.dg_airBg.HeaderText = "AirBag";
            this.dg_airBg.MinimumWidth = 6;
            this.dg_airBg.Name = "dg_airBg";
            this.dg_airBg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_airBg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dg_airBg.Width = 125;
            // 
            // dg_vidElet
            // 
            this.dg_vidElet.HeaderText = "Vidros Elétricos";
            this.dg_vidElet.MinimumWidth = 6;
            this.dg_vidElet.Name = "dg_vidElet";
            this.dg_vidElet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_vidElet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dg_vidElet.Width = 125;
            // 
            // dg_portas
            // 
            this.dg_portas.HeaderText = "Portas";
            this.dg_portas.MinimumWidth = 6;
            this.dg_portas.Name = "dg_portas";
            this.dg_portas.Width = 125;
            // 
            // bt_CarregarDados
            // 
            this.bt_CarregarDados.Location = new System.Drawing.Point(171, 486);
            this.bt_CarregarDados.Name = "bt_CarregarDados";
            this.bt_CarregarDados.Size = new System.Drawing.Size(211, 43);
            this.bt_CarregarDados.TabIndex = 11;
            this.bt_CarregarDados.Text = "Carregar Lista";
            this.bt_CarregarDados.UseVisualStyleBackColor = true;
            this.bt_CarregarDados.Click += new System.EventHandler(this.bt_CarregarDados_Click);
            // 
            // frmAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 554);
            this.Controls.Add(this.bt_CarregarDados);
            this.Controls.Add(this.dgAutomoveis);
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
            this.Name = "frmAutomovel";
            this.Text = "Fom2";
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomoveis)).EndInit();
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
        private System.Windows.Forms.DataGridView dgAutomoveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_ModeloCarro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_FabricCarro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dg_arCond;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dg_dirHidr;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dg_abs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dg_airBg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dg_vidElet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_portas;
        private System.Windows.Forms.Button bt_CarregarDados;
    }
}

