using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_TG2
{
    public partial class ESTIG : MetroFramework.Forms.MetroForm
    {
        public ESTIG()
        {
            InitializeComponent();

            this.StyleManager = msmESTIG;
        }

        private void ESTIG_Load(object sender, EventArgs e)
        {
            this.StyleManager = msmESTIG;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void but_menuInicial_Click(object sender, EventArgs e)
        {
            foreach (Form unhide in Application.OpenForms)
                if (unhide is Main)
                {
                    unhide.Show();
                    break;
                }
            this.Close();
        }

        private void but_aluno_Click(object sender, EventArgs e)
        {
            Aluno _aluno = new Aluno();

            _aluno.StyleManager = this.StyleManager;
            this.Hide();
            _aluno.ShowDialog();
            _aluno.Dispose();
        }

        private void but_docente_Click(object sender, EventArgs e)
        {
            Login _login = new Login();

            _login.StyleManager = this.StyleManager;
            this.Hide();
            _login.ShowDialog();
            _login.Dispose();
        }
    }
}
