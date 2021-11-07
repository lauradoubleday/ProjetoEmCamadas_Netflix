using System;

namespace ProjetoEmCamadas
{
    partial class Frm_Netflix
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblFilmes = new System.Windows.Forms.Label();
            this.lblProdutor = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtFilmes = new System.Windows.Forms.TextBox();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvNetflix = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNetflix)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(23, 60);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "LOGIN";
            this.lblLogin.Click += new System.EventHandler(this.lblid_Click);
            // 
            // lblFilmes
            // 
            this.lblFilmes.AutoSize = true;
            this.lblFilmes.Location = new System.Drawing.Point(184, 60);
            this.lblFilmes.Name = "lblFilmes";
            this.lblFilmes.Size = new System.Drawing.Size(111, 13);
            this.lblFilmes.TabIndex = 1;
            this.lblFilmes.Text = "GERENCIAR FILMES";
            // 
            // lblProdutor
            // 
            this.lblProdutor.AutoSize = true;
            this.lblProdutor.Location = new System.Drawing.Point(347, 60);
            this.lblProdutor.Name = "lblProdutor";
            this.lblProdutor.Size = new System.Drawing.Size(135, 13);
            this.lblProdutor.TabIndex = 2;
            this.lblProdutor.Text = "GERENCIAR PRODUTOR";
            this.lblProdutor.Click += new System.EventHandler(this.lblComposicao_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(26, 92);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(132, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // txtFilmes
            // 
            this.txtFilmes.Location = new System.Drawing.Point(187, 92);
            this.txtFilmes.Name = "txtFilmes";
            this.txtFilmes.Size = new System.Drawing.Size(132, 20);
            this.txtFilmes.TabIndex = 4;
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(350, 92);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(132, 20);
            this.txtSeries.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(26, 140);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(187, 140);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(350, 140);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(132, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvNetflix
            // 
            this.dgvNetflix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNetflix.Location = new System.Drawing.Point(26, 199);
            this.dgvNetflix.Name = "dgvNetflix";
            this.dgvNetflix.Size = new System.Drawing.Size(456, 180);
            this.dgvNetflix.TabIndex = 9;
            // 
            // Frm_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvNetflix);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.txtFilmes);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblProdutor);
            this.Controls.Add(this.lblFilmes);
            this.Controls.Add(this.lblLogin);
            this.Name = "Frm_Medicamentos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNetflix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Frm_Medicamentos_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblComposicao_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblid_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblFilmes;
        private System.Windows.Forms.Label lblProdutor;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtFilmes;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvNetflix;
    }
}

