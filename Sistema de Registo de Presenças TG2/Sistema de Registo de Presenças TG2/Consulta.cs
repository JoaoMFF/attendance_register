using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Metro_TG2
{
    public partial class Consulta : MetroFramework.Forms.MetroForm
    {
        public Consulta()
        {
            InitializeComponent();

          
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            this.StyleManager = msmCons;

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(Application.StartupPath + @"\XML.xml");
            metroGrid1.DataSource = dataSet.Tables[0];

            DataSet dataSet1 = new DataSet();
            dataSet1.ReadXml(Application.StartupPath + @"\XML.xml");
            metroGrid2.DataSource = dataSet1.Tables[0];

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

        private void but_sair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            XDocument doc = XDocument.Load(Application.StartupPath + @"\XML.xml");
            var records = (from data in doc.Root.Elements("Presença")
                           where metroTextBox1.Text == "" ? true : data.Element("NrAluno").Value.ToUpper().Contains(metroTextBox1.Text.ToUpper())
                           select data);
            if (records != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("NrAluno", typeof(string));
                dt.Columns.Add("Data", typeof(string));

                foreach (var item in records)
                {
                    DataRow dr = dt.NewRow();
                    dr["NrAluno"] = (string)item.Element("NrAluno");
                    dr["Data"] = (string)item.Element("Data");
                    dt.Rows.Add(dr);
                }
                metroGrid2.DataSource = dt;

            }
            else
            {

            }
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
