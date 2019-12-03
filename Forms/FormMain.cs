using Painel_Pacientes.Forms;
using Painel_Pacientes.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painel_Pacientes
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ButtonP1_Click(object sender, EventArgs e)
        {
            GerenciamentoPainel1 nextScreen = new GerenciamentoPainel1();
            nextScreen.ShowDialog();
            //this.Close();
        }

        private void ButtonP2_Click(object sender, EventArgs e)
        {
            GerenciamentoPainel2 nextScreen = new GerenciamentoPainel2();
            nextScreen.ShowDialog();
            //this.Close();
        }

        private void ButtonP3_Click(object sender, EventArgs e)
        {
            GerenciamentoPainel3 nextScreen = new GerenciamentoPainel3();
            nextScreen.ShowDialog();
            //this.Close();
        }
    }
}
