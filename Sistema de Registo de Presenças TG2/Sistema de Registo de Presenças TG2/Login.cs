using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
using MetroFramework;


namespace Metro_TG2
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Docente_Load(object sender, EventArgs e)
        {
            this.StyleManager = msmLogin;
        }

        private void but_voltar_Click(object sender, EventArgs e)
        {
            foreach (Form unhide in Application.OpenForms)
                if (unhide is ESTIG)
                {
                    unhide.Show();
                    break;
                }
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            String username = "Docente@gmail.com";
            String password = "ESTIG";

            if ((Username.Text == username) && (Pass.Text == password))
            {                
                Docente _docente = new Docente();

                _docente.StyleManager = this.StyleManager;
                this.Hide();
                _docente.ShowDialog();
                _docente.Dispose();

                Username.Clear();
                Pass.Clear();

            }
            
            else if ((string.IsNullOrWhiteSpace(Username.Text)) || (string.IsNullOrWhiteSpace(Pass.Text)))
            {
                MetroFramework.MetroMessageBox.Show(this,"\r\n" + "Campo(s) Vazios", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if ((Username.Text != username) && (Pass.Text != password))
            {
                MetroFramework.MetroMessageBox.Show(this,"\r\n" + "E-mail ou Password incorrectos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }
    }
}
