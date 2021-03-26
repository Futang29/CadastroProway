
namespace CadastroProway.Apresentation
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
            this.btnConAluno = new System.Windows.Forms.Button();
            this.btnConSala = new System.Windows.Forms.Button();
            this.btnConCafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConAluno
            // 
            this.btnConAluno.Location = new System.Drawing.Point(106, 99);
            this.btnConAluno.Name = "btnConAluno";
            this.btnConAluno.Size = new System.Drawing.Size(183, 80);
            this.btnConAluno.TabIndex = 0;
            this.btnConAluno.Text = "Consultar Aluno";
            this.btnConAluno.UseVisualStyleBackColor = true;
            this.btnConAluno.Click += new System.EventHandler(this.btnConAluno_Click);
            // 
            // btnConSala
            // 
            this.btnConSala.Location = new System.Drawing.Point(317, 99);
            this.btnConSala.Name = "btnConSala";
            this.btnConSala.Size = new System.Drawing.Size(183, 80);
            this.btnConSala.TabIndex = 1;
            this.btnConSala.Text = "Consultar Sala";
            this.btnConSala.UseVisualStyleBackColor = true;
            // 
            // btnConCafe
            // 
            this.btnConCafe.Location = new System.Drawing.Point(528, 99);
            this.btnConCafe.Name = "btnConCafe";
            this.btnConCafe.Size = new System.Drawing.Size(183, 80);
            this.btnConCafe.TabIndex = 2;
            this.btnConCafe.Text = "Consultar Café";
            this.btnConCafe.UseVisualStyleBackColor = true;
            // 
            // consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 287);
            this.Controls.Add(this.btnConCafe);
            this.Controls.Add(this.btnConSala);
            this.Controls.Add(this.btnConAluno);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "consulta";
            this.ShowIcon = false;
            this.Text = "consulta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConAluno;
        private System.Windows.Forms.Button btnConSala;
        private System.Windows.Forms.Button btnConCafe;
    }
}