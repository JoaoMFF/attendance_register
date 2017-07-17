namespace Metro_TG2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.but_sair = new MetroFramework.Controls.MetroButton();
            this.but_voltar = new MetroFramework.Controls.MetroButton();
            this.msmLogin = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Username = new MetroFramework.Controls.MetroTextBox();
            this.Pass = new MetroFramework.Controls.MetroTextBox();
            this.but_entrar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msmLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // but_sair
            // 
            this.but_sair.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_sair.Location = new System.Drawing.Point(522, 395);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(118, 47);
            this.but_sair.TabIndex = 7;
            this.but_sair.Text = "Sair";
            this.but_sair.UseSelectable = true;
            this.but_sair.UseStyleColors = true;
            this.but_sair.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // but_voltar
            // 
            this.but_voltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_voltar.Location = new System.Drawing.Point(165, 395);
            this.but_voltar.Name = "but_voltar";
            this.but_voltar.Size = new System.Drawing.Size(118, 47);
            this.but_voltar.TabIndex = 6;
            this.but_voltar.Text = "Voltar";
            this.but_voltar.UseSelectable = true;
            this.but_voltar.Click += new System.EventHandler(this.but_voltar_Click);
            // 
            // msmLogin
            // 
            this.msmLogin.Owner = this;
            this.msmLogin.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // Username
            // 
            this.Username.Lines = new string[0];
            this.Username.Location = new System.Drawing.Point(350, 155);
            this.Username.MaxLength = 32767;
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Username.SelectedText = "";
            this.Username.Size = new System.Drawing.Size(290, 25);
            this.Username.TabIndex = 8;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Username.UseSelectable = true;
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // Pass
            // 
            this.Pass.Lines = new string[0];
            this.Pass.Location = new System.Drawing.Point(350, 218);
            this.Pass.MaxLength = 32767;
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '●';
            this.Pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Pass.SelectedText = "";
            this.Pass.Size = new System.Drawing.Size(290, 25);
            this.Pass.TabIndex = 9;
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pass.UseSelectable = true;
            this.Pass.UseSystemPasswordChar = true;
            this.Pass.Click += new System.EventHandler(this.password_Click);
            // 
            // but_entrar
            // 
            this.but_entrar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.but_entrar.Location = new System.Drawing.Point(539, 264);
            this.but_entrar.Name = "but_entrar";
            this.but_entrar.Size = new System.Drawing.Size(101, 44);
            this.but_entrar.TabIndex = 10;
            this.but_entrar.Text = "Entrar";
            this.but_entrar.UseSelectable = true;
            this.but_entrar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(165, 153);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "E-mail:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(165, 215);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 25);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(805, 480);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.but_entrar);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.but_sair);
            this.Controls.Add(this.but_voltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Docente: Login";
            this.Load += new System.EventHandler(this.Docente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton but_sair;
        private MetroFramework.Controls.MetroButton but_voltar;
        private MetroFramework.Components.MetroStyleManager msmLogin;
        private MetroFramework.Controls.MetroTextBox Pass;
        private MetroFramework.Controls.MetroTextBox Username;
        private MetroFramework.Controls.MetroButton but_entrar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}