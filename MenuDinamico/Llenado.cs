using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MenuDinamico
{
    public partial class Llenado : Form
    {
        public Llenado()
        {
            InitializeComponent();
        }

        private void Llenado_Load(object sender, EventArgs e)
        {

        }

        private void Llenado_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuDinamico V_MenuDinamico = new MenuDinamico();
            V_MenuDinamico.Show();
        }

        private void btnLlenado_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 2000;
            Tanque.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
