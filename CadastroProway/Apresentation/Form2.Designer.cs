﻿
namespace CadastroProway
{
    partial class cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrar));
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.cadSala = new System.Windows.Forms.Button();
            this.cadCafe = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnFinCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadAluno.Location = new System.Drawing.Point(42, 79);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(192, 70);
            this.btnCadAluno.TabIndex = 0;
            this.btnCadAluno.Text = "Cadastrar Aluno";
            this.btnCadAluno.UseVisualStyleBackColor = true;
            this.btnCadAluno.Click += new System.EventHandler(this.cadAluno_Click);
            // 
            // cadSala
            // 
            this.cadSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadSala.Location = new System.Drawing.Point(280, 79);
            this.cadSala.Name = "cadSala";
            this.cadSala.Size = new System.Drawing.Size(192, 70);
            this.cadSala.TabIndex = 1;
            this.cadSala.Text = "Cadastrar Sala";
            this.cadSala.UseVisualStyleBackColor = true;
            this.cadSala.Click += new System.EventHandler(this.cadSala_Click);
            // 
            // cadCafe
            // 
            this.cadCafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadCafe.Location = new System.Drawing.Point(518, 79);
            this.cadCafe.Name = "cadCafe";
            this.cadCafe.Size = new System.Drawing.Size(192, 70);
            this.cadCafe.TabIndex = 2;
            this.cadCafe.Text = "Cadastrar Café";
            this.cadCafe.UseVisualStyleBackColor = true;
            this.cadCafe.Click += new System.EventHandler(this.cadCafe_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(552, 221);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(158, 54);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFinCadastro
            // 
            this.btnFinCadastro.Location = new System.Drawing.Point(42, 221);
            this.btnFinCadastro.Name = "btnFinCadastro";
            this.btnFinCadastro.Size = new System.Drawing.Size(158, 54);
            this.btnFinCadastro.TabIndex = 4;
            this.btnFinCadastro.Text = "Finalizar Cadastro";
            this.btnFinCadastro.UseVisualStyleBackColor = true;
            this.btnFinCadastro.Click += new System.EventHandler(this.btnFinCadastro_Click);
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 287);
            this.Controls.Add(this.btnFinCadastro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cadCafe);
            this.Controls.Add(this.cadSala);
            this.Controls.Add(this.btnCadAluno);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "cadastrar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.cadastrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadAluno;
        private System.Windows.Forms.Button cadSala;
        private System.Windows.Forms.Button cadCafe;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnFinCadastro;
    }
}