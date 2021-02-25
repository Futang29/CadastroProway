
namespace CadastroProway
{
    partial class cadCafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadCafe));
            this.label1 = new System.Windows.Forms.Label();
            this.txbCoffee = new System.Windows.Forms.TextBox();
            this.btnCadCafe = new System.Windows.Forms.Button();
            this.btnVoltar3 = new System.Windows.Forms.Button();
            this.btnMeun3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Café";
            // 
            // txbCoffee
            // 
            this.txbCoffee.Location = new System.Drawing.Point(295, 88);
            this.txbCoffee.Name = "txbCoffee";
            this.txbCoffee.Size = new System.Drawing.Size(260, 23);
            this.txbCoffee.TabIndex = 1;
            // 
            // btnCadCafe
            // 
            this.btnCadCafe.Location = new System.Drawing.Point(154, 130);
            this.btnCadCafe.Name = "btnCadCafe";
            this.btnCadCafe.Size = new System.Drawing.Size(130, 54);
            this.btnCadCafe.TabIndex = 2;
            this.btnCadCafe.Text = "Cadastrar";
            this.btnCadCafe.UseVisualStyleBackColor = true;
            this.btnCadCafe.Click += new System.EventHandler(this.btnCadCafe_Click);
            // 
            // btnVoltar3
            // 
            this.btnVoltar3.Location = new System.Drawing.Point(483, 216);
            this.btnVoltar3.Name = "btnVoltar3";
            this.btnVoltar3.Size = new System.Drawing.Size(108, 41);
            this.btnVoltar3.TabIndex = 3;
            this.btnVoltar3.Text = "Voltar";
            this.btnVoltar3.UseVisualStyleBackColor = true;
            this.btnVoltar3.Click += new System.EventHandler(this.btnVoltar3_Click);
            // 
            // btnMeun3
            // 
            this.btnMeun3.Location = new System.Drawing.Point(625, 216);
            this.btnMeun3.Name = "btnMeun3";
            this.btnMeun3.Size = new System.Drawing.Size(108, 41);
            this.btnMeun3.TabIndex = 4;
            this.btnMeun3.Text = "Menu Inicial";
            this.btnMeun3.UseVisualStyleBackColor = true;
            this.btnMeun3.Click += new System.EventHandler(this.btnMeun3_Click);
            // 
            // cadCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 287);
            this.Controls.Add(this.btnMeun3);
            this.Controls.Add(this.btnVoltar3);
            this.Controls.Add(this.btnCadCafe);
            this.Controls.Add(this.txbCoffee);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "cadCafe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Café";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCoffee;
        private System.Windows.Forms.Button btnCadCafe;
        private System.Windows.Forms.Button btnVoltar3;
        private System.Windows.Forms.Button btnMeun3;
    }
}