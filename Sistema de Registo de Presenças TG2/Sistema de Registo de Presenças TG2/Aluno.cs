using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Metro_TG2
{
    public partial class Aluno : MetroFramework.Forms.MetroForm
    {
        public Aluno()
        {
            InitializeComponent();
        }

        private void Aluno_Load(object sender, EventArgs e)
        {
            this.StyleManager = msmAluno;
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Application.Exit();
        }

        private void textBox_nrAluno_Click(object sender, EventArgs e)
        {

        }

        private void but_marcarPresenca_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            XmlDocument doc = new XmlDocument();
            doc.Load("XML.xml");

            //Create a new element
            XmlNode presença = doc.CreateElement("Presença");
            XmlNode nr = doc.CreateElement("NrAluno");
            nr.InnerText = textBox_nrAluno.Text;
            presença.AppendChild(nr);

            XmlNode data = doc.CreateElement("Data");
            data.InnerText = now.ToString("yyyy-MM-dd HH:mm");
            presença.AppendChild(data);
            doc.DocumentElement.AppendChild(presença);

            doc.Save("XML.xml");

            MetroFramework.MetroMessageBox.Show(this, "\r\n" + "Presença Marcada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);
            textBox_nrAluno.Clear();

        }
        public class Alunos
        {
            public string NrAluno { get; set; }
            public DateTime Date { get; set; }
        }
        public class Presenças
        {
            public Presenças()
            {
                PList = new List<Alunos>();
            }
            public List<Alunos> PList { get; set;}
        }
        private void label_nrAluno_Click(object sender, EventArgs e)
        {

        }
    }
}
