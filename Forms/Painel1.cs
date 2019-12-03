using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Painel_Pacientes.Classes;

namespace Painel_Pacientes.Forms
{
    public partial class Painel1 : Form
    {
        public Painel1()
        {
            InitializeComponent();
        }


        private void Painel1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void RefreshTitle(string title)
        {
            this.labelTitle.Text = title.ToUpper();
        }

        public void RefreshPanel(Paciente[] pacientes)
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        labelPaciente0.Text = pacientes[i].Nome;
                        labelAtendente0.Text = pacientes[i].Atendente;

                        if(pacientes[i].Status == 0) {
                            labelStatus0.Text = "Livre";
                            panelStatus0.BackColor = Color.FromArgb(34, 238, 91);
                        }
                            
                        else if(pacientes[i].Status == 1)
                        {

                            labelStatus0.Text = "Aguarda.";
                            panelStatus0.BackColor = Color.Gold;

                        }
                        else
                        {
                            labelStatus0.Text = "Atendim.";
                            panelStatus0.BackColor = Color.FromArgb(255, 144, 72);
                        }
                        break;
                    case 1:
                        labelPaciente1.Text = pacientes[i].Nome;
                        labelAtendente1.Text = pacientes[i].Atendente;

                        if (pacientes[i].Status == 0)
                        {
                            labelStatus1.Text = "Livre";
                            panelStatus1.BackColor = Color.FromArgb(34, 238, 91);
                        }

                        else if (pacientes[i].Status == 1)
                        {

                            labelStatus1.Text = "Aguarda.";
                            panelStatus1.BackColor = Color.Gold;

                        }
                        else
                        {
                            labelStatus1.Text = "Atendim.";
                            panelStatus1.BackColor = Color.FromArgb(255, 144, 72);
                        }
                        break;
                    case 2:
                        labelPaciente2.Text = pacientes[i].Nome;
                        labelAtendente2.Text = pacientes[i].Atendente;

                        if (pacientes[i].Status == 0)
                        {
                            labelStatus2.Text = "Livre";
                            panelStatus2.BackColor = Color.FromArgb(34, 238, 91);
                        }

                        else if (pacientes[i].Status == 1)
                        {

                            labelStatus2.Text = "Aguarda.";
                            panelStatus2.BackColor = Color.Gold;

                        }
                        else
                        {
                            labelStatus2.Text = "Atendim.";
                            panelStatus2.BackColor = Color.FromArgb(255, 144, 72);
                        }
                        break;
                    case 3:
                        labelPaciente3.Text = pacientes[i].Nome;
                        labelAtendente3.Text = pacientes[i].Atendente;

                        if (pacientes[i].Status == 0)
                        {
                            labelStatus3.Text = "Livre";
                            panelStatus3.BackColor = Color.FromArgb(34, 238, 91);
                        }

                        else if (pacientes[i].Status == 1)
                        {

                            labelStatus3.Text = "Aguarda.";
                            panelStatus3.BackColor = Color.Gold;

                        }
                        else
                        {
                            labelStatus3.Text = "Atendim.";
                            panelStatus3.BackColor = Color.FromArgb(255, 144, 72);
                        }
                        break;
                    case 4:
                        labelPaciente4.Text = pacientes[i].Nome;
                        labelAtendente4.Text = pacientes[i].Atendente;

                        if (pacientes[i].Status == 0)
                        {
                            labelStatus4.Text = "Livre";
                            panelStatus4.BackColor = Color.FromArgb(34, 238, 91);
                        }

                        else if (pacientes[i].Status == 1)
                        {

                            labelStatus4.Text = "Aguarda.";
                            panelStatus4.BackColor = Color.Gold;

                        }
                        else
                        {
                            labelStatus4.Text = "Atendim.";
                            panelStatus4.BackColor = Color.FromArgb(255, 144, 72);
                        }
                        break;
                    default:
                        break;
                }
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelHours.Text = DateTime.Now.ToString("HH:mm");
            labelSeconds.Text = DateTime.Now.ToString("ss");
            labelDateTime.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }
    }
}
