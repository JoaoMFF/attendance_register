namespace Metro_TG2
{
    partial class ESTIG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESTIG));
            this.but_aluno = new MetroFramework.Controls.MetroButton();
            this.but_docente = new MetroFramework.Controls.MetroButton();
            this.but_menuInicial = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.msmESTIG = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.msmESTIG)).BeginInit();
            this.SuspendLayout();
            // 
            // but_aluno
            // 
            this.but_aluno.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.but_aluno.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_aluno.Location = new System.Drawing.Point(165, 209);
            this.but_aluno.Name = "but_aluno";
            this.but_aluno.Size = new System.Drawing.Size(197, 60);
            this.but_aluno.TabIndex = 0;
            this.but_aluno.Text = "Aluno";
            this.but_aluno.UseSelectable = true;
            this.but_aluno.Click += new System.EventHandler(this.but_aluno_Click);
            // 
            // but_docente
            // 
            this.but_docente.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.but_docente.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_docente.Location = new System.Drawing.Point(443, 209);
            this.but_docente.Name = "but_docente";
            this.but_docente.Size = new System.Drawing.Size(197, 60);
            this.but_docente.TabIndex = 1;
            this.but_docente.Text = "Docente";
            this.but_docente.UseSelectable = true;
            this.but_docente.Click += new System.EventHandler(this.but_docente_Click);
            // 
            // but_menuInicial
            // 
            this.but_menuInicial.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.but_menuInicial.Location = new System.Drawing.Point(165, 395);
            this.but_menuInicial.Name = "but_menuInicial";
            this.but_menuInicial.Size = new System.Drawing.Size(118, 47);
            this.but_menuInicial.TabIndex = 2;
            this.but_menuInicial.Text = "Menu Inicial";
            this.but_menuInicial.UseSelectable = true;
            this.but_menuInicial.Click += new System.EventHandler(this.but_menuInicial_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(522, 395);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 47);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Sair";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // msmESTIG
            // 
            this.msmESTIG.Owner = this;
            this.msmESTIG.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // ESTIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(805, 480);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.but_menuInicial);
            this.Controls.Add(this.but_docente);
            this.Controls.Add(this.but_aluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ESTIG";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "ESTIG";
            this.Load += new System.EventHandler(this.ESTIG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmESTIG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton but_aluno;
        private MetroFramework.Controls.MetroButton but_docente;
        private MetroFramework.Controls.MetroButton but_menuInicial;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Components.MetroStyleManager msmESTIG;
    }
}