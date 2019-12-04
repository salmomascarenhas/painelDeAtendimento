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
using Painel_Pacientes.Classes;

namespace Painel_Pacientes.Forms
{
    public partial class GerenciamentoPainel1 : Form
    {
        Paciente[] pacientes;
        Painel1 painel1;

        public GerenciamentoPainel1()
        {
            InitializeComponent();

            this.pacientes = new Paciente[5];

            for(int i=0;i<5; i++)
            {
                this.pacientes[i] = new Paciente();
            }

        }

        private void GerenciamentoPainel1_Load(object sender, EventArgs e)
        {
            comboBoxStatus1.Items.AddRange(new string[] { "Livre","Aguardando atendimento","Em atendimento","Emergência"});
            comboBoxStatus2.Items.AddRange(new string[] { "Livre","Aguardando atendimento","Em atendimento", "Emergência" });
            comboBoxStatus3.Items.AddRange(new string[] { "Livre","Aguardando atendimento","Em atendimento", "Emergência" });
            comboBoxStatus4.Items.AddRange(new string[] { "Livre","Aguardando atendimento","Em atendimento", "Emergência" });
            comboBoxStatus5.Items.AddRange(new string[] { "Livre","Aguardando atendimento","Em atendimento", "Emergência" });

            comboBoxTitle.Items.AddRange(new string[] { "GED", "Sorriso Aberto", "Sorriso Positivo" });

            comboBoxStatus1.SelectedIndex = 0;
            comboBoxStatus2.SelectedIndex = 0;
            comboBoxStatus3.SelectedIndex= 0;
            comboBoxStatus4.SelectedIndex = 0;
            comboBoxStatus5.SelectedIndex= 0;

            this.painel1 = new Painel1();
            this.painel1.Show();
        }

        #region "Atualização do painel"
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            painel1.RefreshPanel(this.pacientes);           
        }

        #endregion

        #region "Atualização do título"
        private void comboBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            painel1.RefreshTitle(this.comboBoxTitle.Text);
        }

        #endregion

        #region "métodos dos pacientes"

        private void TextBoxPaciente1_TextChanged(object sender, EventArgs e)
        {
            
            pacientes[0].Nome = textBoxPaciente1.Text.ToUpper();
        }

        private void TextBoxAtendente1_TextChanged(object sender, EventArgs e)
        {
            pacientes[0].Atendente = textBoxAtendente1.Text.ToUpper();
        }

        private void ComboBoxStatus1_SelectedIndexChanged(object sender, EventArgs e)
        {
           pacientes[0].Status = comboBoxStatus1.SelectedIndex;
        }

        private void TextBoxPaciente2_TextChanged(object sender, EventArgs e)
        {
            pacientes[1].Nome = textBoxPaciente2.Text.ToUpper();
        }

        private void TextBoxAtendente2_TextChanged(object sender, EventArgs e)
        {
            pacientes[1].Atendente = textBoxAtendente2.Text.ToUpper();
        }

        private void ComboBoxStatus2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacientes[1].Status = comboBoxStatus2.SelectedIndex;
        }

        private void TextBoxPaciente3_TextChanged(object sender, EventArgs e)
        {
            pacientes[2].Nome = textBoxPaciente3.Text.ToUpper();
        }

        private void TextBoxAtendente3_TextChanged(object sender, EventArgs e)
        {
            pacientes[2].Atendente = textBoxAtendente3.Text.ToUpper();
        }

        private void ComboBoxStatus3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacientes[2].Status = comboBoxStatus3.SelectedIndex;
        }

        private void TextBoxPaciente4_TextChanged(object sender, EventArgs e)
        {
            pacientes[3].Nome = textBoxPaciente4.Text.ToUpper();
        }

        private void TextBoxAtendente4_TextChanged(object sender, EventArgs e)
        {
            pacientes[3].Atendente = textBoxAtendente4.Text.ToUpper();
        }

        private void ComboBoxStatus4_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacientes[3].Status = comboBoxStatus4.SelectedIndex;
        }

        private void TextBoxPaciente5_TextChanged(object sender, EventArgs e)
        {
            pacientes[4].Nome = textBoxPaciente5.Text.ToUpper();
        }

        private void TextBoxAtendente5_TextChanged(object sender, EventArgs e)
        {
            pacientes[4].Atendente = textBoxAtendente5.Text.ToUpper();
        }

        private void ComboBoxStatus5_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacientes[4].Status = comboBoxStatus5.SelectedIndex;
        }

        

        private void TextBoxPaciente1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.textBoxAtendente1.Focus();
            }
        }

        private void TextBoxAtendente1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.comboBoxStatus1.Focus();
            }
        }

        private void ComboBoxStatus1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.ButtonUpdate_Click(new object(), new EventArgs());
        }

        private void TextBoxPaciente2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente2.Focus();
        }

        private void TextBoxAtendente2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus2.Focus();
        }

        private void ComboBoxStatus2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.ButtonUpdate_Click(new object(), new EventArgs());
        }

        private void TextBoxPaciente3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente3.Focus();
        }

        private void TextBoxAtendente3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus3.Focus();
        }

        private void ComboBoxStatus3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.ButtonUpdate_Click(new object(), new EventArgs());
        }

        private void TextBoxPaciente4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente4.Focus();
        }

        private void TextBoxAtendente4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus4.Focus();
        }

        private void ComboBoxStatus4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.ButtonUpdate_Click(new object(), new EventArgs());
        }

        private void TextBoxPaciente5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxAtendente5.Focus();
        }

        private void TextBoxAtendente5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxStatus5.Focus();
        }

        private void ComboBoxStatus5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.ButtonUpdate_Click(new object(), new EventArgs());
        }
        #endregion

    }
}
