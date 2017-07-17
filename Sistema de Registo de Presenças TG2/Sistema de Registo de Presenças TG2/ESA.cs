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
    public partial class ESA : MetroFramework.Forms.MetroForm

    {
        public ESA()
        {
            InitializeComponent();

            this.StyleManager = msmESA;
        }

        private void but_aluno_Click(object sender, EventArgs e)
        {

        }

        private void but_voltar_Click(object sender, EventArgs e)
        {
            foreach (Form unhide in Application.OpenForms)
                if (unhide is Main)
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
    }
}
