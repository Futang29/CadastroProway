
namespace CadastroProway
{
    partial class cadSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadSala));
            this.label1 = new System.Windows.Forms.Label();
            this.txbSala = new System.Windows.Forms.TextBox();
            this.btnCadSala = new System.Windows.Forms.Button();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Sala";
            // 
            // txbSala
            // 
            this.txbSala.Location = new System.Drawing.Point(261, 70);
            this.txbSala.Name = "txbSala";
            this.txbSala.Size = new System.Drawing.Size(212, 23);
            this.txbSala.TabIndex = 1;
            // 
            // btnCadSala
            // 
            this.btnCadSala.Location = new System.Drawing.Point(150, 112);
            this.btnCadSala.Name = "btnCadSala";
            this.btnCadSala.Size = new System.Drawing.Size(105, 39);
            this.btnCadSala.TabIndex = 2;
            this.btnCadSala.Text = "Cadastrar";
            this.btnCadSala.UseVisualStyleBackColor = true;
            this.btnCadSala.Click += new System.EventHandler(this.btnCadSala_Click);
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Location = new System.Drawing.Point(488, 238);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(103, 37);
            this.btnVoltar2.TabIndex = 3;
            this.btnVoltar2.Text = "Voltar";
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // btnMenu2
            // 
            this.btnMenu2.Location = new System.Drawing.Point(616, 238);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(103, 37);
            this.btnMenu2.TabIndex = 4;
            this.btnMenu2.Text = "Menu Inicial";
            this.btnMenu2.UseVisualStyleBackColor = true;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // cadSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 287);
            this.Controls.Add(this.btnMenu2);
            this.Controls.Add(this.btnVoltar2);
            this.Controls.Add(this.btnCadSala);
            this.Controls.Add(this.txbSala);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "cadSala";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Sala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSala;
        private System.Windows.Forms.Button btnCadSala;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.Button btnMenu2;
    }
}