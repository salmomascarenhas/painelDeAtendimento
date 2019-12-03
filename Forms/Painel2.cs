using Painel_Pacientes.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painel_Pacientes.Forms
{
    public partial class Painel2 : Form
    {
        public Painel2()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelHours.Text = DateTime.Now.ToString("HH:mm");
            labelSeconds.Text = DateTime.Now.ToString("ss");
            labelDateTime.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void Painel2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void RefreshTitle(int div,string title)
        {
            //div = 1 para atualizar titulo do lado esquerdo, 2 para lado direito.

            if(div == 1)
            {
                this.labelTitleL.Text = title.ToUpper();
            }
            else
            {
                this.labelTitleR.Text = title.ToUpper();
            }
        }
        public void RefreshPanel(int div,Paciente[] pacientes)
        {
            //Se div = 1 então atualiza as informações do lado esquerdo, se nao atualiza do lado direito.

            if(div == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            labelPaciente0.Text = pacientes[i].Nome;
                            labelAtendente0.Text = pacientes[i].Atendente;

                            if (pacientes[i].Status == 0)
                            {
                                labelStatus0.Text = "Livre";
                                panelStatus0.BackColor = Color.FromArgb(34, 238, 91);
                            }

                            else if (pacientes[i].Status == 1)
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
            else
            {
                for (int i = 5; i < pacientes.Length; i++)
                {
                    switch (i)
                    {
                        case 5:
                            labelPaciente5.Text = pacientes[i].Nome;
                            labelAtendente5.Text = pacientes[i].Atendente;

                            if (pacientes[i].Status == 0)
                            {
                                labelStatus5.Text = "Livre";
                                panelStatus5.BackColor = Color.FromArgb(34, 238, 91);
                            }

                            else if (pacientes[i].Status == 1)
                            {

                                labelStatus5.Text = "Aguarda.";
                                panelStatus5.BackColor = Color.Gold;

                            }
                            else
                            {
                                labelStatus5.Text = "Atendim.";
                                panelStatus5.BackColor = Color.FromArgb(255, 144, 72);
                            }
                            break;
                        case 6:
                            labelPaciente6.Text = pacientes[i].Nome;
                            labelAtendente6.Text = pacientes[i].Atendente;

                            if (pacientes[i].Status == 0)
                            {
                                labelStatus6.Text = "Livre";
                                panelStatus6.BackColor = Color.FromArgb(34, 238, 91);
                            }

                            else if (pacientes[i].Status == 1)
                            {

                                labelStatus6.Text = "Aguarda.";
                                panelStatus6.BackColor = Color.Gold;

                            }
                            else
                            {
                                labelStatus6.Text = "Atendim.";
                                panelStatus6.BackColor = Color.FromArgb(255, 144, 72);
                            }
                            break;
                        case 7:
                            labelPaciente7.Text = pacientes[i].Nome;
                            labelAtendente7.Text = pacientes[i].Atendente;

                            if (pacientes[i].Status == 0)
                            {
                                labelStatus7.Text = "Livre";
                                panelStatus7.BackColor = Color.FromArgb(34, 238, 91);
                            }

                            else if (pacientes[i].Status == 1)
                            {

                                labelStatus7.Text = "Aguarda.";
                                panelStatus7.BackColor = Color.Gold;

                            }
                            else
                            {
                                labelStatus7.Text = "Atendim.";
                                panelStatus7.BackColor = Color.FromArgb(255, 144, 72);
                            }
                            break;
                        case 8:
                            labelPaciente8.Text = pacientes[i].Nome;
                            labelAtendente8.Text = pacientes[i].Atendente;

                            if (pacientes[i].Status == 0)
                            {
                                labelStatus8.Text = "Livre";
                                panelStatus8.BackColor = Color.FromArgb(34, 238, 91);
                            }

                            else if (pacientes[i].Status == 1)
                            {

                                labelStatus8.Text = "Aguarda.";
                                panelStatus8.BackColor = Color.Gold;

                            }
                            else
                            {
                                labelStatus8.Text = "Atendim.";
                                panelStatus8.BackColor = Color.FromArgb(255, 144, 72);
                            }
                            break;
                        case 9:
                            labelPaciente9.Text = pacientes[i].Nome;
                            labelAtendente9.Text = pacientes[i].Atendente;

                            if (pacientes[i].Status == 0)
                            {
                                labelStatus9.Text = "Livre";
                                panelStatus9.BackColor = Color.FromArgb(34, 238, 91);
                            }

                            else if (pacientes[i].Status == 1)
                            {

                                labelStatus9.Text = "Aguarda.";
                                panelStatus9.BackColor = Color.Gold;

                            }
                            else
                            {
                                labelStatus9.Text = "Atendim.";
                                panelStatus9.BackColor = Color.FromArgb(255, 144, 72);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

            
    }
}
