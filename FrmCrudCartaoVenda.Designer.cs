namespace LojaCL
{
    partial class FrmCrudCartaoVenda
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
            this.components = new System.ComponentModel.Container();
            this.txtId = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.DgvCartao = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCartao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(62, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(62, 67);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(62, 109);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbxUsuario.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(279, 109);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(279, 80);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(279, 51);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(279, 20);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 30;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(13, 112);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 70);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 35;
            this.lblNumero.Text = "Numero";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(38, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "ID";
            // 
            // DgvCartao
            // 
            this.DgvCartao.AllowUserToAddRows = false;
            this.DgvCartao.AllowUserToDeleteRows = false;
            this.DgvCartao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCartao.Location = new System.Drawing.Point(12, 148);
            this.DgvCartao.Name = "DgvCartao";
            this.DgvCartao.ReadOnly = true;
            this.DgvCartao.Size = new System.Drawing.Size(360, 150);
            this.DgvCartao.TabIndex = 37;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(168, 20);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 38;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click_1);
            // 
            // FrmCrudCartaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 310);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.DgvCartao);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtId);
            this.Name = "FrmCrudCartaoVenda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCrudCartaoVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCartao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView DgvCartao;
        private System.Windows.Forms.Button btnPesquisa;
    }
}