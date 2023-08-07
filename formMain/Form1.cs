using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formMain
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            /*if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }*/
            appLogin.Show();
        }



    }
}
