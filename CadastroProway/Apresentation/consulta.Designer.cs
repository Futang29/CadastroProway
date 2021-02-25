
namespace CadastroProway
{
    partial class consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consulta));
            this.conAlunos = new System.Windows.Forms.Button();
            this.conSala = new System.Windows.Forms.Button();
            this.conCafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conAlunos
            // 
            this.conAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conAlunos.Location = new System.Drawing.Point(59, 107);
            this.conAlunos.Name = "conAlunos";
            this.conAlunos.Size = new System.Drawing.Size(175, 70);
            this.conAlunos.TabIndex = 0;
            this.conAlunos.Text = "Consultar Alunos";
            this.conAlunos.UseVisualStyleBackColor = true;
            // 
            // conSala
            // 
            this.conSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conSala.Location = new System.Drawing.Point(294, 107);
            this.conSala.Name = "conSala";
            this.conSala.Size = new System.Drawing.Size(175, 70);
            this.conSala.TabIndex = 1;
            this.conSala.Text = "Consultar Salas";
            this.conSala.UseVisualStyleBackColor = true;
            // 
            // conCafe
            // 
            this.conCafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conCafe.Location = new System.Drawing.Point(529, 107);
            this.conCafe.Name = "conCafe";
            this.conCafe.Size = new System.Drawing.Size(175, 70);
            this.conCafe.TabIndex = 2;
            this.conCafe.Text = "consultar Cafés";
            this.conCafe.UseVisualStyleBackColor = true;
            // 
            // consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 285);
            this.Controls.Add(this.conCafe);
            this.Controls.Add(this.conSala);
            this.Controls.Add(this.conAlunos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "consulta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button conAlunos;
        private System.Windows.Forms.Button conSala;
        private System.Windows.Forms.Button conCafe;
    }
}