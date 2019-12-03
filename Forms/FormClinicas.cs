using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painel_Pacientes.Screens
{
    public partial class FormClinicas : Form
    {
        public FormClinicas()
        {
            InitializeComponent();
        }

        private void FormPacientes1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelHours.Text = DateTime.Now.ToString("HH:mm");
            labelSeconds.Text = DateTime.Now.ToString("ss");
            labelDateTime.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }
    }
}
