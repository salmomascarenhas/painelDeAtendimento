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
    public partial class GerenciamentoPainel3 : Form
    {
        Paciente[] pacientes;
        Painel3 painel3;
        public GerenciamentoPainel3()
        {
            InitializeComponent();

            this.pacientes = new Paciente[15];

            for (int i = 0; i < 15; i++)
            {
                this.pacientes[i] = new Paciente();
            }
        }

        private void GerenciamentoPainel3_Load(object sender, EventArgs e)
        {
            comboBoxStatus1.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus2.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus3.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus4.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus5.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus6.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus7.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus8.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus9.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus10.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus11.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus12.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus13.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus14.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });
            comboBoxStatus15.Items.AddRange(new string[] { "Livre", "Aguardando atendimento", "Em atendimento", "Emergência" });

            comboBoxTitleL.Items.AddRange(new string[] { "GED", "Sorriso Aberto", "Sorriso Positivo" });
            comboBoxTitleC.Items.AddRange(new string[] { "GED", "Sorriso Aberto", "Sorriso Positivo" });
            comboBoxTitleR.Items.AddRange(new string[] { "GED", "Sorriso Aberto", "Sorriso Positivo" });

            comboBoxStatus1.SelectedIndex = 0;
            comboBoxStatus2.SelectedIndex = 0;
            comboBoxStatus3.SelectedIndex = 0;
            comboBoxStatus4.SelectedIndex = 0;
            comboBoxStatus5.SelectedIndex = 0;
            comboBoxStatus6.SelectedIndex = 0;
            comboBoxStatus7.SelectedIndex = 0;
            comboBoxStatus8.SelectedIndex = 0;
            comboBoxStatus9.SelectedIndex = 0;
            comboBoxStatus10.SelectedIndex = 0;
            comboBoxStatus11.SelectedIndex = 0;
            comboBoxStatus12.SelectedIndex = 0;
            comboBoxStatus13.SelectedIndex = 0;
            comboBoxStatus14.SelectedIndex = 0;
            comboBoxStatus15.SelectedIndex = 0;

           

            this.painel3 = new Painel3();
            this.painel3.Show();
        }

        #region "Atualizações do título"
        private void comboBoxTitleL_SelectedIndexChanged(object sender, EventArgs e)
        {
            painel3.RefreshTitle(1, this.comboBoxTitleL.Text);
        }

        private void comboBoxTitleC_SelectedIndexChanged(object sender, EventArgs e)
        {
            painel3.RefreshTitle(2, this.comboBoxTitleC.Text);
        }

        private void comboBoxTitleR_SelectedIndexChanged(object sender, EventArgs e)
        {
            painel3.RefreshTitle(3, this.comboBoxTitleR.Text);
        }
        
        #endregion

        #region "métodos coluna esquerda"
        private void textBoxPaciente1_TextChanged(object sender, EventArgs e)
        {
            pacientes[0].Nome = textBoxPaciente1.Text.ToUpper();
        }

        private void textBoxAtendente1_TextChanged(object sender, EventArgs e)
        {
            pacientes[0].Atendente = textBoxAtendente1.Text.ToUpper();
        }

        private void comboBoxStatus1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacientes[0].Status = comboBoxStatus1.SelectedIndex;
        }

        private void textBoxPaciente2_TextChanged(object sender, EventArgs e)
        {
            pacientes[1].Nome = textBoxPaciente2.Text.ToUpper();
        }

        private void textBoxAtendente2_TextChanged(object sender, EventArgs e)
        {
            pacientes[1].Atendente = textBoxAtendente2.Text.ToUpper();
        }

        private void comboBoxStatus2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacientes[1].Status = comboBoxStatus2.SelectedIndex;
        }

        private void textBoxPaciente3_TextChanged(object sender, EventArgs e)
        {
            pacientes[2].Nome = textBoxPaciente3.Text.ToUpper();
        }

        private void textBoxAtendente3_TextChanged(object sender, EventArgs e)
        {
            pacientes[2].Atendente = textBoxAtendente3.Text.ToUpper();
        }

        private void comboBoxStatus3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacientes[2].Status = comboBoxStatus3.SelectedIndex;
        }

        private void textBoxPaciente4_TextChanged(object sender, EventArgs e)
        {
            pacientes[3].Nome = textBoxPaciente4.Text.ToUpper();
        }

        private void textBoxAtendente4_TextChanged(object sender, EventArgs e)
        {
            pacientes[3].Atendente = textBoxAtendente4.Text.ToUpper();
        }

        private void comboBoxStatus4_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacientes[3].Status = comboBoxStatus4.SelectedIndex;
        }

        private void textBoxPaciente5_TextChanged(object sender, EventArgs e)
        {
            pacientes[4].Nome = textBoxPaciente5.Text.ToUpper();
        }

        private void textBoxAtendente5_TextChanged(object sender, EventArgs e)
        {
            pacientes[4].Atendente = textBoxAtendente5.Text.ToUpper();
        }

        private void comboBoxStatus5_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacientes[4].Status = comboBoxStatus5.SelectedIndex;
        }

        private void textBoxPaciente1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente1.Focus();
        }

        private void textBoxAtendente1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus1.Focus();
        }

        private void comboBoxStatus1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelL_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente2.Focus();
        }

        private void textBoxAtendente2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus2.Focus();
        }

        private void comboBoxStatus2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelL_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente3.Focus();
        }

        private void textBoxAtendente3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus3.Focus();
        }

        private void comboBoxStatus3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelL_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente4.Focus();
        }

        private void textBoxAtendente4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus4.Focus();
        }

        private void comboBoxStatus4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelL_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente5.Focus();
        }

        private void textBoxAtendente5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus5.Focus();
        }

        private void comboBoxStatus5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelL_Click(new object(), new EventArgs());
        }

        private void buttonUpdatePanelL_Click(object sender, EventArgs e)
        {
            painel3.RefreshPanel(1, this.pacientes);
        }

        #endregion

        #region "métodos coluna central"
        private void textBoxPaciente6_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[5].Nome = textBoxPaciente6.Text.ToUpper();    
        }

        private void textBoxAtendente6_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[5].Atendente = textBoxAtendente6.Text.ToUpper();        }

        private void comboBoxStatus6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pacientes[5].Status = comboBoxStatus6.SelectedIndex;        }

        private void textBoxPaciente7_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[6].Nome = textBoxPaciente7.Text.ToUpper();        }

        private void textBoxAtendente7_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[6].Atendente = textBoxAtendente7.Text.ToUpper();        }

        private void comboBoxStatus7_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pacientes[6].Status = comboBoxStatus7.SelectedIndex;
        }

        private void textBoxPaciente8_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[7].Nome = textBoxPaciente8.Text.ToUpper();
        }

        private void textBoxAtendente8_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[7].Atendente = textBoxAtendente8.Text.ToUpper();
        }

        private void comboBoxStatus8_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pacientes[7].Status = comboBoxStatus8.SelectedIndex;
        }

        private void textBoxPaciente9_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[8].Nome = textBoxPaciente9.Text.ToUpper();
        }

        private void textBoxAtendente9_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[8].Atendente = textBoxAtendente9.Text.ToUpper();
        }

        private void comboBoxStatus9_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pacientes[8].Status = comboBoxStatus9.SelectedIndex;
        }

        private void textBoxPaciente10_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[9].Nome = textBoxPaciente10.Text.ToUpper();
        }

        private void textBoxAtendente10_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[9].Atendente = textBoxAtendente10.Text.ToUpper();
        }

        private void comboBoxStatus10_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pacientes[9].Status = comboBoxStatus10.SelectedIndex;
        }

        private void textBoxPaciente6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente6.Focus();
        }

        

        private void textBoxAtendente6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus6.Focus();
        }

        private void comboBoxStatus6_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelC_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente7.Focus();
        }

        private void textBoxAtendente7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus7.Focus();
        }

        private void comboBoxStatus7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelC_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente8.Focus();
        }

        private void textBoxAtendente8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus8.Focus();
        }

        private void comboBoxStatus8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelC_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente9.Focus();
        }

        private void textBoxAtendente9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus9.Focus();
        }

        private void comboBoxStatus9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelC_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente10.Focus();
        }

        private void textBoxAtendente10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus10.Focus();
        }

        private void comboBoxStatus10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelC_Click(new object(), new EventArgs());
        }

        private void buttonUpdatePanelC_Click(object sender, EventArgs e)
        {
            painel3.RefreshPanel(2, this.pacientes);
        }


        #endregion

        #region "métodos coluna direita"
        private void textBoxPaciente11_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[10].Nome = textBoxPaciente11.Text.ToUpper();
        }

        private void textBoxAtendente11_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[10].Atendente= textBoxAtendente11.Text.ToUpper();
        }

        private void comboBoxStatus11_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pacientes[10].Status = comboBoxStatus11.SelectedIndex;

        }

        private void textBoxPaciente12_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[11].Nome = textBoxPaciente12.Text.ToUpper();

        }

        private void textBoxAtendente12_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[11].Atendente = textBoxAtendente12.Text.ToUpper();

        }

        private void comboBoxStatus12_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pacientes[11].Status = comboBoxStatus12.SelectedIndex;

        }

        private void textBoxPaciente13_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[12].Nome = textBoxPaciente13.Text.ToUpper();

        }

        private void textBoxAtendente13_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[12].Atendente = textBoxAtendente13.Text.ToUpper();

        }

        private void comboBoxStatus13_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pacientes[12].Status = comboBoxStatus13.SelectedIndex;

        }

        private void textBoxPaciente14_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[13].Nome = textBoxPaciente14.Text.ToUpper();

        }

        private void textBoxAtendente14_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[13].Atendente = textBoxAtendente14.Text.ToUpper();

        }

        private void comboBoxStatus14_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pacientes[13].Status = comboBoxStatus14.SelectedIndex;

        }

        private void textBoxPaciente15_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[14].Nome = textBoxPaciente15.Text.ToUpper();

        }

        private void textBoxAtendente15_TextChanged(object sender, EventArgs e)
        {
            this.pacientes[14].Atendente = textBoxAtendente15.Text.ToUpper();

        }

        private void comboBoxStatus15_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pacientes[14].Status = comboBoxStatus15.SelectedIndex;

        }
        

        private void textBoxPaciente11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente11.Focus();
        }

        private void textBoxAtendente11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus11.Focus();
        }

        private void comboBoxStatus11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelR_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente12.Focus();
        }

        private void textBoxAtendente12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus12.Focus();
        }

        private void comboBoxStatus12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelR_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente13.Focus();
        }

        private void textBoxAtendente13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus13.Focus();
        }

        private void comboBoxStatus13_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelR_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente14.Focus();
        }

        private void textBoxAtendente14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus14.Focus();
        }

        private void comboBoxStatus14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelR_Click(new object(), new EventArgs());
        }

        private void textBoxPaciente15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente15.Focus();
        }

        private void textBoxAtendente15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus15.Focus();
        }

        private void comboBoxStatus15_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                this.buttonUpdatePanelR_Click(new object(), new EventArgs());
        }

        private void buttonUpdatePanelR_Click(object sender, EventArgs e)
        {
            painel3.RefreshPanel(3, this.pacientes);

        }

        #endregion

        
    }
}
