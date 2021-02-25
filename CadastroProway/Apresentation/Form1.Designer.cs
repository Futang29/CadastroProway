
namespace CadastroProway
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cadastro = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastro
            // 
            this.cadastro.AllowDrop = true;
            this.cadastro.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.cadastro, "cadastro");
            this.cadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastro.Name = "cadastro";
            this.cadastro.UseVisualStyleBackColor = false;
            this.cadastro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.consultar, "consultar");
            this.consultar.Cursor = System.Windows.Forms.Cursors.Default;
            this.consultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consultar.Name = "consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.cadastro);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadastro;
        private System.Windows.Forms.Button consultar;
    }
}

