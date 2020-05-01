namespace LojaCL
{
    partial class FrmVenda
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
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnEcluirItem = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.Location = new System.Drawing.Point(374, 19);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(92, 23);
            this.btnNovaVenda.TabIndex = 0;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(80, 19);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(279, 21);
            this.cbxCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(80, 97);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(15, 172);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.Size = new System.Drawing.Size(451, 125);
            this.dgvVenda.TabIndex = 4;
            this.dgvVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellClick);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(12, 66);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 5;
            this.lblProduto.Text = "Produto";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 104);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 138);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(290, 309);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(69, 13);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(80, 58);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(279, 21);
            this.cbxProduto.TabIndex = 9;
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(80, 138);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(366, 306);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 11;
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Location = new System.Drawing.Point(209, 136);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(75, 23);
            this.btnNovoItem.TabIndex = 12;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.Location = new System.Drawing.Point(299, 136);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(75, 23);
            this.btnEditarItem.TabIndex = 13;
            this.btnEditarItem.Text = "Editar Item";
            this.btnEditarItem.UseVisualStyleBackColor = true;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnEcluirItem
            // 
            this.btnEcluirItem.Location = new System.Drawing.Point(391, 136);
            this.btnEcluirItem.Name = "btnEcluirItem";
            this.btnEcluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnEcluirItem.TabIndex = 14;
            this.btnEcluirItem.Text = "Excluir Item";
            this.btnEcluirItem.UseVisualStyleBackColor = true;
            this.btnEcluirItem.Click += new System.EventHandler(this.btnEcluirItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(284, 345);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(366, 345);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 23);
            this.btnFinalizar.TabIndex = 16;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(209, 97);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 17;
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 375);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEcluirItem);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.btnNovoItem);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.btnNovaVenda);
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnEcluirItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtId;
    }
}