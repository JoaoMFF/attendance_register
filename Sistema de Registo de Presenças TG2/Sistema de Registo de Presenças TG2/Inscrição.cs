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
    public partial class Inscrição : MetroFramework.Forms.MetroForm
    {
        public Inscrição()
        {
            InitializeComponent();
        }

        private void Incrição_Load(object sender, EventArgs e)
        {
            this.StyleManager = msmInsc;
        }

        private void but_voltar_Click(object sender, EventArgs e)
        {
            foreach (Form unhide in Application.OpenForms)
                if (unhide is Docente)
                {
                    unhide.Show();
                    break;
                }
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBox79_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void but_concluir_Click(object sender, EventArgs e)
        {

        }

        private void but_concluir_Click_1(object sender, EventArgs e)
        {
            string classes = "";
            classes = classes + "Nome: " + textBox_nome.Text + "\r\n";
            classes = classes + "\r\n";

            classes = classes + "Número de Aluno: " + textBox_nr.Text + "\r\n";
            classes = classes + "\r\n";

            if (metroToggle1.Checked)
            {
                classes = classes + "Trabalhador Estudante: Sim" + "\r\n";
            }
            classes = classes + "\r\n";

            classes = classes + "Disciplinas: " + "\r\n";

            if(metroCheckBox1.Checked)
            {
                classes = classes + metroCheckBox1.Text + "\r\n";

            }
            if (metroCheckBox2.Checked)
            {
                classes = classes + metroCheckBox2.Text + "\r\n";

            }
            if (metroCheckBox3.Checked)
            {
                classes = classes + metroCheckBox3.Text + "\r\n";

            }
            if (metroCheckBox4.Checked)
            {
                classes = classes + metroCheckBox4.Text + "\r\n";

            }
            if (metroCheckBox5.Checked)
            {
                classes = classes + metroCheckBox5.Text + "\r\n";

            }
            if (metroCheckBox6.Checked)
            {
                classes = classes + metroCheckBox6.Text + "\r\n";

            }
            if (metroCheckBox7.Checked)
            {
                classes = classes + metroCheckBox7.Text + "\r\n";

            }
            if (metroCheckBox8.Checked)
            {
                classes = classes + metroCheckBox8.Text + "\r\n";

            }
            if (metroCheckBox9.Checked)
            {
                classes = classes + metroCheckBox9.Text + "\r\n";

            }
            if (metroCheckBox10.Checked)
            {
                classes = classes + metroCheckBox10.Text + "\r\n";

            }
            if (metroCheckBox11.Checked)
            {
                classes = classes + metroCheckBox11.Text + "\r\n";

            }
            if (metroCheckBox12.Checked)
            {
                classes = classes + metroCheckBox12.Text + "\r\n";

            }
            if (metroCheckBox13.Checked)
            {
                classes = classes + metroCheckBox13.Text + "\r\n";

            }
            if (metroCheckBox14.Checked)
            {
                classes = classes + metroCheckBox14.Text + "\r\n";

            }
            if (metroCheckBox15.Checked)
            {
                classes = classes + metroCheckBox15.Text + "\r\n";

            }
            if (metroCheckBox16.Checked)
            {
                classes = classes + metroCheckBox16.Text + "\r\n";

            }
            if (metroCheckBox17.Checked)
            {
                classes = classes + metroCheckBox17.Text + "\r\n";

            }
            if (metroCheckBox18.Checked)
            {
                classes = classes + metroCheckBox18.Text + "\r\n";

            }
            if (metroCheckBox19.Checked)
            {
                classes = classes + metroCheckBox19.Text + "\r\n";

            }
            if (metroCheckBox20.Checked)
            {
                classes = classes + metroCheckBox20.Text + "\r\n";

            }
            if (metroCheckBox21.Checked)
            {
                classes = classes + metroCheckBox21.Text + "\r\n";

            }
            if (metroCheckBox22.Checked)
            {
                classes = classes + metroCheckBox22.Text + "\r\n";

            }
            if (metroCheckBox23.Checked)
            {
                classes = classes + metroCheckBox23.Text + "\r\n";

            }
            if (metroCheckBox24.Checked)
            {
                classes = classes + metroCheckBox24.Text + "\r\n";

            }
            if (metroCheckBox25.Checked)
            {
                classes = classes + metroCheckBox25.Text + "\r\n";

            }
            if (metroCheckBox26.Checked)
            {
                classes = classes + metroCheckBox26.Text + "\r\n";

            }
            if (metroCheckBox27.Checked)
            {
                classes = classes + metroCheckBox27.Text + "\r\n";

            }
            if (metroCheckBox28.Checked)
            {
                classes = classes + metroCheckBox28.Text + "\r\n";

            }
            if (metroCheckBox29.Checked)
            {
                classes = classes + metroCheckBox29.Text + "\r\n";

            }
            if (metroCheckBox30.Checked)
            {
                classes = classes + metroCheckBox30.Text + "\r\n";
            }
        
            var msg = MessageBox.Show(classes, "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          
            if (msg == DialogResult.Yes)
            {
                MetroFramework.MetroMessageBox.Show(this, "\r\n" + "Incrição concluida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                metroCheckBox1.Checked = false;
                metroCheckBox2.Checked = false;
                metroCheckBox3.Checked = false;
                metroCheckBox4.Checked = false;
                metroCheckBox5.Checked = false;
                metroCheckBox6.Checked = false;
                metroCheckBox7.Checked = false;
                metroCheckBox8.Checked = false;
                metroCheckBox9.Checked = false;
                metroCheckBox10.Checked = false;
                metroCheckBox11.Checked = false;
                metroCheckBox12.Checked = false;
                metroCheckBox13.Checked = false;
                metroCheckBox14.Checked = false;
                metroCheckBox15.Checked = false;
                metroCheckBox16.Checked = false;
                metroCheckBox17.Checked = false;
                metroCheckBox18.Checked = false;
                metroCheckBox19.Checked = false;
                metroCheckBox20.Checked = false;
                metroCheckBox21.Checked = false;
                metroCheckBox22.Checked = false;
                metroCheckBox23.Checked = false;
                metroCheckBox24.Checked = false;
                metroCheckBox25.Checked = false;
                metroCheckBox26.Checked = false;
                metroCheckBox27.Checked = false;
                metroCheckBox28.Checked = false;
                metroCheckBox29.Checked = false;
                metroCheckBox30.Checked = false;
                textBox_nome.Clear();
                textBox_nr.Clear();
                metroToggle1.Checked = false;
            }
            
        }
    }
}
