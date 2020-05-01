namespace LojaCL
{
    partial class FrmCrudProduto
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
            this.DgvProduto = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProduto
            // 
            this.DgvProduto.AllowUserToAddRows = false;
            this.DgvProduto.AllowUserToDeleteRows = false;
            this.DgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduto.Location = new System.Drawing.Point(9, 207);
            this.DgvProduto.Name = "DgvProduto";
            this.DgvProduto.ReadOnly = true;
            this.DgvProduto.Size = new System.Drawing.Size(423, 150);
            this.DgvProduto.TabIndex = 31;
            this.DgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduto_CellClick);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(194, 23);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 30;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(347, 112);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(347, 83);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(347, 54);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(84, 169);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(118, 20);
            this.txtValor.TabIndex = 26;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(84, 129);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(118, 20);
            this.txtQuantidade.TabIndex = 25;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(57, 90);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(212, 20);
            this.txtTipo.TabIndex = 24;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 20);
            this.txtNome.TabIndex = 23;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(16, 172);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 13);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "Valor (R$)";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(16, 132);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 21;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(16, 97);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 20;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(57, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(122, 20);
            this.txtId.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(24, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(347, 23);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 16;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // FrmCrudProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 367);
            this.Controls.Add(this.DgvProduto);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCadastro);
            this.Name = "FrmCrudProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmCrudProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProduto;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCadastro;
    }
}