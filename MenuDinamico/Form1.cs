using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace MenuDinamico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("GIT VUELTA");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SeleccionarBtnCatalogos(object sender, EventArgs e)
        {
            PanelCatalogos.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(2000));
            //t.add(PanelCatalogos, "Left", 300);
            t.add(PanelCatalogos, "Top", 75);
            t.run();
            
        }

        private void OcultarMenu(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SeleccionarBtnUtilerias(object sender, EventArgs e)
        {
            PanelCatalogos.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(2000));
            //t.add(PanelCatalogos, "Left", 300);
            t.add(panel1, "Top", 75);
            t.run();
        }

        private void SeleccionarBtnOperacion(object sender, EventArgs e)
        {
            PanelCatalogos.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(2000));
            //t.add(PanelCatalogos, "Left", 300);
            t.add(panel2, "Top", 75);
            t.run();
        }
    }
}
