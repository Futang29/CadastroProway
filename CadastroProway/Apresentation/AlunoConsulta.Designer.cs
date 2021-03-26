
namespace CadastroProway.Apresentation
{
    partial class AlunoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlunoConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.txbConAluno = new System.Windows.Forms.TextBox();
            this.btnConAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Aluno";
            // 
            // txbConAluno
            // 
            this.txbConAluno.Location = new System.Drawing.Point(255, 60);
            this.txbConAluno.Name = "txbConAluno";
            this.txbConAluno.Size = new System.Drawing.Size(277, 23);
            this.txbConAluno.TabIndex = 1;
            // 
            // btnConAluno
            // 
            this.btnConAluno.Location = new System.Drawing.Point(97, 115);
            this.btnConAluno.Name = "btnConAluno";
            this.btnConAluno.Size = new System.Drawing.Size(113, 62);
            this.btnConAluno.TabIndex = 2;
            this.btnConAluno.Text = "Consultar";
            this.btnConAluno.UseVisualStyleBackColor = true;
            this.btnConAluno.Click += new System.EventHandler(this.btnConAluno_Click);
            // 
            // AlunoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 287);
            this.Controls.Add(this.btnConAluno);
            this.Controls.Add(this.txbConAluno);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlunoConsulta";
            this.ShowIcon = false;
            this.Text = "AlunoConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbConAluno;
        private System.Windows.Forms.Button btnConAluno;
    }
}