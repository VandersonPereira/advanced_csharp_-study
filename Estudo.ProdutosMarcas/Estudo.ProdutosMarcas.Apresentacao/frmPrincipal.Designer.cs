namespace Estudo.ProdutosMarcas.Apresentacao
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizarMarca = new System.Windows.Forms.Button();
            this.BtnCadastrarMarca = new System.Windows.Forms.Button();
            this.grdMarcas = new System.Windows.Forms.DataGridView();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAtualizarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMarcaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMarcca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirMarca = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarcas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluirMarca);
            this.groupBox1.Controls.Add(this.btnAtualizarMarca);
            this.groupBox1.Controls.Add(this.BtnCadastrarMarca);
            this.groupBox1.Controls.Add(this.grdMarcas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcas Cadastradas";
            // 
            // btnAtualizarMarca
            // 
            this.btnAtualizarMarca.Location = new System.Drawing.Point(927, 49);
            this.btnAtualizarMarca.Name = "btnAtualizarMarca";
            this.btnAtualizarMarca.Size = new System.Drawing.Size(170, 23);
            this.btnAtualizarMarca.TabIndex = 2;
            this.btnAtualizarMarca.Text = "Atualizar marca";
            this.btnAtualizarMarca.UseVisualStyleBackColor = true;
            this.btnAtualizarMarca.Click += new System.EventHandler(this.btnAtualizarMarca_Click);
            // 
            // BtnCadastrarMarca
            // 
            this.BtnCadastrarMarca.Location = new System.Drawing.Point(927, 20);
            this.BtnCadastrarMarca.Name = "BtnCadastrarMarca";
            this.BtnCadastrarMarca.Size = new System.Drawing.Size(170, 23);
            this.BtnCadastrarMarca.TabIndex = 1;
            this.BtnCadastrarMarca.Text = "Cadastrar marca";
            this.BtnCadastrarMarca.UseVisualStyleBackColor = true;
            this.BtnCadastrarMarca.Click += new System.EventHandler(this.BtnCadastrarMarca_Click);
            // 
            // grdMarcas
            // 
            this.grdMarcas.AllowUserToAddRows = false;
            this.grdMarcas.AllowUserToDeleteRows = false;
            this.grdMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMarca,
            this.NomeMarca});
            this.grdMarcas.Location = new System.Drawing.Point(6, 19);
            this.grdMarcas.MultiSelect = false;
            this.grdMarcas.Name = "grdMarcas";
            this.grdMarcas.ReadOnly = true;
            this.grdMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMarcas.Size = new System.Drawing.Size(915, 246);
            this.grdMarcas.TabIndex = 0;
            // 
            // IdMarca
            // 
            this.IdMarca.DataPropertyName = "Id";
            this.IdMarca.HeaderText = "Id";
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.ReadOnly = true;
            this.IdMarca.Visible = false;
            // 
            // NomeMarca
            // 
            this.NomeMarca.DataPropertyName = "Nome";
            this.NomeMarca.HeaderText = "Nome da Marca";
            this.NomeMarca.Name = "NomeMarca";
            this.NomeMarca.ReadOnly = true;
            this.NomeMarca.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluirProduto);
            this.groupBox2.Controls.Add(this.btnAtualizarProduto);
            this.groupBox2.Controls.Add(this.btnCadastrarProduto);
            this.groupBox2.Controls.Add(this.grdProdutos);
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1103, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos Cadastrados";
            // 
            // btnAtualizarProduto
            // 
            this.btnAtualizarProduto.Location = new System.Drawing.Point(927, 48);
            this.btnAtualizarProduto.Name = "btnAtualizarProduto";
            this.btnAtualizarProduto.Size = new System.Drawing.Size(170, 23);
            this.btnAtualizarProduto.TabIndex = 3;
            this.btnAtualizarProduto.Text = "Atualizar produto";
            this.btnAtualizarProduto.UseVisualStyleBackColor = true;
            this.btnAtualizarProduto.Click += new System.EventHandler(this.btnAtualizarProduto_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(927, 19);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(170, 23);
            this.btnCadastrarProduto.TabIndex = 2;
            this.btnCadastrarProduto.Text = "Cadastrar produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.IdMarcaProduto,
            this.NomeProduto,
            this.NomeMarcca});
            this.grdProdutos.Location = new System.Drawing.Point(6, 19);
            this.grdProdutos.MultiSelect = false;
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProdutos.Size = new System.Drawing.Size(915, 236);
            this.grdProdutos.TabIndex = 0;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "Id";
            this.IdProduto.HeaderText = "Id";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Visible = false;
            // 
            // IdMarcaProduto
            // 
            this.IdMarcaProduto.DataPropertyName = "IdMarca";
            this.IdMarcaProduto.HeaderText = "IdMarcaProduto";
            this.IdMarcaProduto.Name = "IdMarcaProduto";
            this.IdMarcaProduto.ReadOnly = true;
            this.IdMarcaProduto.Visible = false;
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "Nome";
            this.NomeProduto.HeaderText = "Nome do Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 300;
            // 
            // NomeMarcca
            // 
            this.NomeMarcca.DataPropertyName = "Marca";
            this.NomeMarcca.HeaderText = "Nome da Marca";
            this.NomeMarcca.Name = "NomeMarcca";
            this.NomeMarcca.ReadOnly = true;
            this.NomeMarcca.Width = 300;
            // 
            // btnExcluirMarca
            // 
            this.btnExcluirMarca.Location = new System.Drawing.Point(927, 78);
            this.btnExcluirMarca.Name = "btnExcluirMarca";
            this.btnExcluirMarca.Size = new System.Drawing.Size(170, 23);
            this.btnExcluirMarca.TabIndex = 3;
            this.btnExcluirMarca.Text = "Excluir marca";
            this.btnExcluirMarca.UseVisualStyleBackColor = true;
            this.btnExcluirMarca.Click += new System.EventHandler(this.btnExcluirMarca_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(927, 77);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(170, 23);
            this.btnExcluirProduto.TabIndex = 4;
            this.btnExcluirProduto.Text = "Excluir produto";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudo - Cadastro de Produtos e Marcas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMarcas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.Button BtnCadastrarMarca;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnAtualizarMarca;
        private System.Windows.Forms.Button btnAtualizarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarcaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMarcca;
        private System.Windows.Forms.Button btnExcluirMarca;
        private System.Windows.Forms.Button btnExcluirProduto;
    }
}

