
namespace CadastroProway
{
    partial class cadAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadAluno));
            this.label1 = new System.Windows.Forms.Label();
            this.txbAluno = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVoltar1 = new System.Windows.Forms.Button();
            this.btnMenu1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(145, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txbAluno
            // 
            this.txbAluno.Location = new System.Drawing.Point(238, 57);
            this.txbAluno.Name = "txbAluno";
            this.txbAluno.Size = new System.Drawing.Size(227, 23);
            this.txbAluno.TabIndex = 1;
            this.txbAluno.TextChanged += new System.EventHandler(this.txbAluno_TextChanged);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(145, 121);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(160, 54);
            this.btnCadastro.TabIndex = 4;
            this.btnCadastro.Text = "Cadastrar Aluno";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnVoltar1
            // 
            this.btnVoltar1.Location = new System.Drawing.Point(425, 227);
            this.btnVoltar1.Name = "btnVoltar1";
            this.btnVoltar1.Size = new System.Drawing.Size(131, 39);
            this.btnVoltar1.TabIndex = 5;
            this.btnVoltar1.Text = "Voltar";
            this.btnVoltar1.UseVisualStyleBackColor = true;
            this.btnVoltar1.Click += new System.EventHandler(this.btnVoltar1_Click);
            // 
            // btnMenu1
            // 
            this.btnMenu1.Location = new System.Drawing.Point(591, 227);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(131, 39);
            this.btnMenu1.TabIndex = 6;
            this.btnMenu1.Text = "Menu Inicial";
            this.btnMenu1.UseVisualStyleBackColor = true;
            this.btnMenu1.Click += new System.EventHandler(this.button2_Click);
            // 
            // cadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 287);
            this.Controls.Add(this.btnMenu1);
            this.Controls.Add(this.btnVoltar1);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txbAluno);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "cadAluno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAluno;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnVoltar1;
        private System.Windows.Forms.Button btnMenu1;
    }
}