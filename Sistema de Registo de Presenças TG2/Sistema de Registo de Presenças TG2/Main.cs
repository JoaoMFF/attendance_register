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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();

            this.StyleManager = msmMain;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void tile_Estig_Click(object sender, EventArgs e)
        {
            msmMain.Style = MetroFramework.MetroColorStyle.Red;
            ESTIG _estig = new ESTIG();

            _estig.StyleManager = this.StyleManager;
            this.Hide();
            _estig.ShowDialog();
            _estig.Dispose();
        }

        private void tile_ESS_Click(object sender, EventArgs e)
        {
            msmMain.Style = MetroFramework.MetroColorStyle.Teal;

            ESS _ess = new ESS();

            _ess.StyleManager = this.StyleManager;
            this.Hide();
            _ess.ShowDialog();
            _ess.Dispose();
        }

        private void tile_ESE_Click(object sender, EventArgs e)
        {
            msmMain.Style = MetroFramework.MetroColorStyle.Orange;

            ESE _ese = new ESE();

            _ese.StyleManager = this.StyleManager;
            this.Hide();
            _ese.ShowDialog();

            _ese.Dispose();
        }

        private void tile_esa_Click(object sender, EventArgs e)
        {
            msmMain.Style = MetroFramework.MetroColorStyle.Green;

            ESA _esa = new ESA();

            _esa.StyleManager = this.StyleManager;
            this.Hide();
            _esa.ShowDialog();
            _esa.Dispose();
        }

    }
}
