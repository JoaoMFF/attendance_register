namespace Metro_TG2
{
    partial class ESS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESS));
            this.but_docente = new MetroFramework.Controls.MetroButton();
            this.but_aluno = new MetroFramework.Controls.MetroButton();
            this.but_sair = new MetroFramework.Controls.MetroButton();
            this.but_voltar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // but_docente
            // 
            this.but_docente.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.but_docente.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_docente.Location = new System.Drawing.Point(440, 210);
            this.but_docente.Name = "but_docente";
            this.but_docente.Size = new System.Drawing.Size(200, 72);
            this.but_docente.TabIndex = 5;
            this.but_docente.Text = "Docente";
            this.but_docente.UseSelectable = true;
            // 
            // but_aluno
            // 
            this.but_aluno.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.but_aluno.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_aluno.Location = new System.Drawing.Point(160, 210);
            this.but_aluno.Name = "but_aluno";
            this.but_aluno.Size = new System.Drawing.Size(200, 72);
            this.but_aluno.TabIndex = 4;
            this.but_aluno.Text = "Aluno";
            this.but_aluno.UseSelectable = true;
            // 
            // but_sair
            // 
            this.but_sair.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_sair.Location = new System.Drawing.Point(522, 395);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(118, 47);
            this.but_sair.TabIndex = 9;
            this.but_sair.Text = "Sair";
            this.but_sair.UseSelectable = true;
            this.but_sair.UseStyleColors = true;
            this.but_sair.Click += new System.EventHandler(this.but_sair_Click);
            // 
            // but_voltar
            // 
            this.but_voltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_voltar.Location = new System.Drawing.Point(165, 395);
            this.but_voltar.Name = "but_voltar";
            this.but_voltar.Size = new System.Drawing.Size(118, 47);
            this.but_voltar.TabIndex = 8;
            this.but_voltar.Text = "Voltar";
            this.but_voltar.UseSelectable = true;
            this.but_voltar.Click += new System.EventHandler(this.but_voltar_Click);
            // 
            // ESS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 480);
            this.ControlBox = false;
            this.Controls.Add(this.but_sair);
            this.Controls.Add(this.but_voltar);
            this.Controls.Add(this.but_docente);
            this.Controls.Add(this.but_aluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ESS";
            this.Resizable = false;
            this.Text = "ESS";
            this.Load += new System.EventHandler(this.ESS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton but_docente;
        private MetroFramework.Controls.MetroButton but_aluno;
        private MetroFramework.Controls.MetroButton but_sair;
        private MetroFramework.Controls.MetroButton but_voltar;
    }
}