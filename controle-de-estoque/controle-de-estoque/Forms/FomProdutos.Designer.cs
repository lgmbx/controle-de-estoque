namespace controle_de_estoque.Forms {
    partial class FomProdutos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TxtNome_Produtos = new System.Windows.Forms.TextBox();
            this.TxtValor_Produtos = new System.Windows.Forms.TextBox();
            this.TxtQuantidade_Produtos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNovo_Produtos = new System.Windows.Forms.Button();
            this.BtnCadastrar_Produtos = new System.Windows.Forms.Button();
            this.BtnExcluir_Produtos = new System.Windows.Forms.Button();
            this.BtnCancelar_Produtos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNome_Produtos
            // 
            this.TxtNome_Produtos.Location = new System.Drawing.Point(128, 23);
            this.TxtNome_Produtos.Name = "TxtNome_Produtos";
            this.TxtNome_Produtos.Size = new System.Drawing.Size(100, 20);
            this.TxtNome_Produtos.TabIndex = 0;
            // 
            // TxtValor_Produtos
            // 
            this.TxtValor_Produtos.Location = new System.Drawing.Point(315, 23);
            this.TxtValor_Produtos.Name = "TxtValor_Produtos";
            this.TxtValor_Produtos.Size = new System.Drawing.Size(100, 20);
            this.TxtValor_Produtos.TabIndex = 1;
            // 
            // TxtQuantidade_Produtos
            // 
            this.TxtQuantidade_Produtos.Location = new System.Drawing.Point(566, 23);
            this.TxtQuantidade_Produtos.Name = "TxtQuantidade_Produtos";
            this.TxtQuantidade_Produtos.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantidade_Produtos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // BtnNovo_Produtos
            // 
            this.BtnNovo_Produtos.Location = new System.Drawing.Point(128, 78);
            this.BtnNovo_Produtos.Name = "BtnNovo_Produtos";
            this.BtnNovo_Produtos.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo_Produtos.TabIndex = 6;
            this.BtnNovo_Produtos.Text = "Novo";
            this.BtnNovo_Produtos.UseVisualStyleBackColor = true;
            // 
            // BtnCadastrar_Produtos
            // 
            this.BtnCadastrar_Produtos.Location = new System.Drawing.Point(278, 78);
            this.BtnCadastrar_Produtos.Name = "BtnCadastrar_Produtos";
            this.BtnCadastrar_Produtos.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar_Produtos.TabIndex = 7;
            this.BtnCadastrar_Produtos.Text = "Cadastrar";
            this.BtnCadastrar_Produtos.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir_Produtos
            // 
            this.BtnExcluir_Produtos.Location = new System.Drawing.Point(416, 78);
            this.BtnExcluir_Produtos.Name = "BtnExcluir_Produtos";
            this.BtnExcluir_Produtos.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir_Produtos.TabIndex = 8;
            this.BtnExcluir_Produtos.Text = "Excluir";
            this.BtnExcluir_Produtos.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar_Produtos
            // 
            this.BtnCancelar_Produtos.Location = new System.Drawing.Point(566, 78);
            this.BtnCancelar_Produtos.Name = "BtnCancelar_Produtos";
            this.BtnCancelar_Produtos.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar_Produtos.TabIndex = 9;
            this.BtnCancelar_Produtos.Text = "Cancelar";
            this.BtnCancelar_Produtos.UseVisualStyleBackColor = true;
            // 
            // FomProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar_Produtos);
            this.Controls.Add(this.BtnExcluir_Produtos);
            this.Controls.Add(this.BtnCadastrar_Produtos);
            this.Controls.Add(this.BtnNovo_Produtos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtQuantidade_Produtos);
            this.Controls.Add(this.TxtValor_Produtos);
            this.Controls.Add(this.TxtNome_Produtos);
            this.Name = "FomProdutos";
            this.Text = "FomProdutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome_Produtos;
        private System.Windows.Forms.TextBox TxtValor_Produtos;
        private System.Windows.Forms.TextBox TxtQuantidade_Produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNovo_Produtos;
        private System.Windows.Forms.Button BtnCadastrar_Produtos;
        private System.Windows.Forms.Button BtnExcluir_Produtos;
        private System.Windows.Forms.Button BtnCancelar_Produtos;
    }
}