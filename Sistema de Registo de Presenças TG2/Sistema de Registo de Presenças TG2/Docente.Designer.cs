namespace Metro_TG2
{
    partial class Docente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docente));
            this.but_sair = new MetroFramework.Controls.MetroButton();
            this.but_logOut = new MetroFramework.Controls.MetroButton();
            this.msmDocente = new MetroFramework.Components.MetroStyleManager(this.components);
            this.but_consulta = new MetroFramework.Controls.MetroButton();
            this.but_inscAluno = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmDocente)).BeginInit();
            this.SuspendLayout();
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
            // but_logOut
            // 
            this.but_logOut.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_logOut.Location = new System.Drawing.Point(165, 395);
            this.but_logOut.Name = "but_logOut";
            this.but_logOut.Size = new System.Drawing.Size(118, 47);
            this.but_logOut.TabIndex = 8;
            this.but_logOut.Text = "Log Out";
            this.but_logOut.UseSelectable = true;
            this.but_logOut.Click += new System.EventHandler(this.but_logOut_Click);
            // 
            // msmDocente
            // 
            this.msmDocente.Owner = this;
            this.msmDocente.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // but_consulta
            // 
            this.but_consulta.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.but_consulta.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_consulta.Location = new System.Drawing.Point(443, 209);
            this.but_consulta.Name = "but_consulta";
            this.but_consulta.Size = new System.Drawing.Size(197, 60);
            this.but_consulta.TabIndex = 13;
            this.but_consulta.Text = "Consulta de Presenças";
            this.but_consulta.UseSelectable = true;
            this.but_consulta.Click += new System.EventHandler(this.but_consulta_Click);
            // 
            // but_inscAluno
            // 
            this.but_inscAluno.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.but_inscAluno.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_inscAluno.Location = new System.Drawing.Point(165, 209);
            this.but_inscAluno.Name = "but_inscAluno";
            this.but_inscAluno.Size = new System.Drawing.Size(197, 60);
            this.but_inscAluno.TabIndex = 12;
            this.but_inscAluno.Text = "Inscrição Aluno";
            this.but_inscAluno.UseSelectable = true;
            this.but_inscAluno.Click += new System.EventHandler(this.but_inscAluno_Click);
            // 
            // Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 480);
            this.ControlBox = false;
            this.Controls.Add(this.but_consulta);
            this.Controls.Add(this.but_inscAluno);
            this.Controls.Add(this.but_sair);
            this.Controls.Add(this.but_logOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Docente";
            this.Resizable = false;
            this.Text = "Docente";
            this.Load += new System.EventHandler(this.Docente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmDocente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton but_sair;
        private MetroFramework.Controls.MetroButton but_logOut;
        private MetroFramework.Components.MetroStyleManager msmDocente;
        private MetroFramework.Controls.MetroButton but_consulta;
        private MetroFramework.Controls.MetroButton but_inscAluno;
    }
}