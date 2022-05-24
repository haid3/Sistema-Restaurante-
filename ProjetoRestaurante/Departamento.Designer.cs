namespace ProjetoRestaurante
{
    partial class Departamento
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnnovodepto = new System.Windows.Forms.Button();
            this.btneditardepto = new System.Windows.Forms.Button();
            this.btnvoltardepto = new System.Windows.Forms.Button();
            this.btn_excluirdepto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 526);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnnovodepto
            // 
            this.btnnovodepto.Location = new System.Drawing.Point(1004, 58);
            this.btnnovodepto.Name = "btnnovodepto";
            this.btnnovodepto.Size = new System.Drawing.Size(138, 62);
            this.btnnovodepto.TabIndex = 1;
            this.btnnovodepto.Text = "Novo";
            this.btnnovodepto.UseVisualStyleBackColor = true;
            // 
            // btneditardepto
            // 
            this.btneditardepto.Location = new System.Drawing.Point(1004, 191);
            this.btneditardepto.Name = "btneditardepto";
            this.btneditardepto.Size = new System.Drawing.Size(141, 62);
            this.btneditardepto.TabIndex = 2;
            this.btneditardepto.Text = "Editar";
            this.btneditardepto.UseVisualStyleBackColor = true;
            // 
            // btnvoltardepto
            // 
            this.btnvoltardepto.Location = new System.Drawing.Point(1007, 478);
            this.btnvoltardepto.Name = "btnvoltardepto";
            this.btnvoltardepto.Size = new System.Drawing.Size(138, 62);
            this.btnvoltardepto.TabIndex = 4;
            this.btnvoltardepto.Text = "Voltar";
            this.btnvoltardepto.UseVisualStyleBackColor = true;
            this.btnvoltardepto.Click += new System.EventHandler(this.btnexcluirdepto_Click);
            // 
            // btn_excluirdepto
            // 
            this.btn_excluirdepto.Location = new System.Drawing.Point(1004, 336);
            this.btn_excluirdepto.Name = "btn_excluirdepto";
            this.btn_excluirdepto.Size = new System.Drawing.Size(138, 64);
            this.btn_excluirdepto.TabIndex = 5;
            this.btn_excluirdepto.Text = "Excluir";
            this.btn_excluirdepto.UseVisualStyleBackColor = true;
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 586);
            this.Controls.Add(this.btn_excluirdepto);
            this.Controls.Add(this.btnvoltardepto);
            this.Controls.Add(this.btneditardepto);
            this.Controls.Add(this.btnnovodepto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Departamento";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnovodepto;
        private System.Windows.Forms.Button btneditardepto;
        private System.Windows.Forms.Button btnvoltardepto;
        private System.Windows.Forms.Button btn_excluirdepto;
    }
}