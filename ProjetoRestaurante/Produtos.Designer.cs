namespace ProjetoRestaurante
{
    partial class Produtos
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
            this.btnexcluirproduto = new System.Windows.Forms.Button();
            this.btnvoltarproduto = new System.Windows.Forms.Button();
            this.btneditarproduto = new System.Windows.Forms.Button();
            this.btnnovoproduto = new System.Windows.Forms.Button();
            this.dataGridView_produtos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexcluirproduto
            // 
            this.btnexcluirproduto.Location = new System.Drawing.Point(1017, 320);
            this.btnexcluirproduto.Name = "btnexcluirproduto";
            this.btnexcluirproduto.Size = new System.Drawing.Size(138, 64);
            this.btnexcluirproduto.TabIndex = 10;
            this.btnexcluirproduto.Text = "Excluir";
            this.btnexcluirproduto.UseVisualStyleBackColor = true;
            // 
            // btnvoltarproduto
            // 
            this.btnvoltarproduto.Location = new System.Drawing.Point(1020, 462);
            this.btnvoltarproduto.Name = "btnvoltarproduto";
            this.btnvoltarproduto.Size = new System.Drawing.Size(138, 62);
            this.btnvoltarproduto.TabIndex = 9;
            this.btnvoltarproduto.Text = "Voltar";
            this.btnvoltarproduto.UseVisualStyleBackColor = true;
            // 
            // btneditarproduto
            // 
            this.btneditarproduto.Location = new System.Drawing.Point(1017, 175);
            this.btneditarproduto.Name = "btneditarproduto";
            this.btneditarproduto.Size = new System.Drawing.Size(141, 62);
            this.btneditarproduto.TabIndex = 8;
            this.btneditarproduto.Text = "Editar";
            this.btneditarproduto.UseVisualStyleBackColor = true;
            // 
            // btnnovoproduto
            // 
            this.btnnovoproduto.Location = new System.Drawing.Point(1017, 42);
            this.btnnovoproduto.Name = "btnnovoproduto";
            this.btnnovoproduto.Size = new System.Drawing.Size(138, 62);
            this.btnnovoproduto.TabIndex = 7;
            this.btnnovoproduto.Text = "Novo";
            this.btnnovoproduto.UseVisualStyleBackColor = true;
            // 
            // dataGridView_produtos
            // 
            this.dataGridView_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_produtos.Location = new System.Drawing.Point(36, 20);
            this.dataGridView_produtos.Name = "dataGridView_produtos";
            this.dataGridView_produtos.RowTemplate.Height = 24;
            this.dataGridView_produtos.Size = new System.Drawing.Size(930, 526);
            this.dataGridView_produtos.TabIndex = 6;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 558);
            this.Controls.Add(this.btnexcluirproduto);
            this.Controls.Add(this.btnvoltarproduto);
            this.Controls.Add(this.btneditarproduto);
            this.Controls.Add(this.btnnovoproduto);
            this.Controls.Add(this.dataGridView_produtos);
            this.Name = "Produtos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexcluirproduto;
        private System.Windows.Forms.Button btnvoltarproduto;
        private System.Windows.Forms.Button btneditarproduto;
        private System.Windows.Forms.Button btnnovoproduto;
        private System.Windows.Forms.DataGridView dataGridView_produtos;
    }
}