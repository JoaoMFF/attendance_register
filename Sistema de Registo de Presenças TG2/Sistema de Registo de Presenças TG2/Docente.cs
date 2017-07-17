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
    public partial class Docente : MetroFramework.Forms.MetroForm
    {
        public Docente()
        {
            InitializeComponent();
        }

        private void Docente_Load(object sender, EventArgs e)
        {
            this.StyleManager = msmDocente;
        }

        private void but_logOut_Click(object sender, EventArgs e)
        {
            foreach (Form unhide in Application.OpenForms)
                if (unhide is Login)
                {
                    unhide.Show();
                    break;
                }
            this.Close();
        }

        private void but_sair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void but_inscAluno_Click(object sender, EventArgs e)
        {
            Inscrição _insc = new Inscrição();

            _insc.StyleManager = this.StyleManager;
            this.Hide();
            _insc.ShowDialog();
            _insc.Dispose();
        }

        private void but_consulta_Click(object sender, EventArgs e)
        {
            Consulta _cons = new Consulta();

            _cons.StyleManager = this.StyleManager;
            this.Hide();
            _cons.ShowDialog();
            _cons.Dispose();
        }
    }
}
