using Academia;
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
    public partial class formMain2 : Form
    {
        public formMain2()
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
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar ventana para cargar alunmno
            //MessageBox.show();
        }
    }
}
