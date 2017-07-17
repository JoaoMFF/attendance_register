namespace Metro_TG2
{
    partial class Aluno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aluno));
            this.but_sair = new MetroFramework.Controls.MetroButton();
            this.but_voltar = new MetroFramework.Controls.MetroButton();
            this.msmAluno = new MetroFramework.Components.MetroStyleManager(this.components);
            this.textBox_nrAluno = new MetroFramework.Controls.MetroTextBox();
            this.label_nrAluno = new MetroFramework.Controls.MetroLabel();
            this.but_marcarPresenca = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // but_sair
            // 
            this.but_sair.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_sair.Location = new System.Drawing.Point(522, 395);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(118, 47);
            this.but_sair.TabIndex = 5;
            this.but_sair.Text = "Sair";
            this.but_sair.UseSelectable = true;
            this.but_sair.UseStyleColors = true;
            this.but_sair.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // but_voltar
            // 
            this.but_voltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_voltar.Location = new System.Drawing.Point(165, 395);
            this.but_voltar.Name = "but_voltar";
            this.but_voltar.Size = new System.Drawing.Size(118, 47);
            this.but_voltar.TabIndex = 4;
            this.but_voltar.Text = "Voltar";
            this.but_voltar.UseSelectable = true;
            this.but_voltar.Click += new System.EventHandler(this.but_voltar_Click);
            // 
            // msmAluno
            // 
            this.msmAluno.Owner = this;
            this.msmAluno.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // textBox_nrAluno
            // 
            this.textBox_nrAluno.Lines = new string[0];
            this.textBox_nrAluno.Location = new System.Drawing.Point(417, 191);
            this.textBox_nrAluno.MaxLength = 32767;
            this.textBox_nrAluno.Name = "textBox_nrAluno";
            this.textBox_nrAluno.PasswordChar = '\0';
            this.textBox_nrAluno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_nrAluno.SelectedText = "";
            this.textBox_nrAluno.Size = new System.Drawing.Size(223, 30);
            this.textBox_nrAluno.TabIndex = 6;
            this.textBox_nrAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_nrAluno.UseCustomBackColor = true;
            this.textBox_nrAluno.UseSelectable = true;
            this.textBox_nrAluno.Click += new System.EventHandler(this.textBox_nrAluno_Click);
            // 
            // label_nrAluno
            // 
            this.label_nrAluno.AutoSize = true;
            this.label_nrAluno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_nrAluno.Location = new System.Drawing.Point(165, 188);
            this.label_nrAluno.Name = "label_nrAluno";
            this.label_nrAluno.Size = new System.Drawing.Size(160, 25);
            this.label_nrAluno.TabIndex = 7;
            this.label_nrAluno.Text = "Número de Aluno:";
            this.label_nrAluno.Click += new System.EventHandler(this.label_nrAluno_Click);
            // 
            // but_marcarPresenca
            // 
            this.but_marcarPresenca.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.but_marcarPresenca.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_marcarPresenca.Location = new System.Drawing.Point(312, 265);
            this.but_marcarPresenca.Name = "but_marcarPresenca";
            this.but_marcarPresenca.Size = new System.Drawing.Size(183, 44);
            this.but_marcarPresenca.TabIndex = 8;
            this.but_marcarPresenca.Text = "Marcar Presença";
            this.but_marcarPresenca.UseSelectable = true;
            this.but_marcarPresenca.Click += new System.EventHandler(this.but_marcarPresenca_Click);
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(805, 480);
            this.ControlBox = false;
            this.Controls.Add(this.but_marcarPresenca);
            this.Controls.Add(this.label_nrAluno);
            this.Controls.Add(this.textBox_nrAluno);
            this.Controls.Add(this.but_sair);
            this.Controls.Add(this.but_voltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aluno";
            this.Resizable = false;
            this.Text = "Aluno: Presenças";
            this.Load += new System.EventHandler(this.Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton but_sair;
        private MetroFramework.Controls.MetroButton but_voltar;
        private MetroFramework.Components.MetroStyleManager msmAluno;
        private MetroFramework.Controls.MetroLabel label_nrAluno;
        private MetroFramework.Controls.MetroTextBox textBox_nrAluno;
        private MetroFramework.Controls.MetroButton but_marcarPresenca;
    }
}