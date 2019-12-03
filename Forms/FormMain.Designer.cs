namespace Painel_Pacientes
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonP1 = new System.Windows.Forms.Button();
            this.buttonP2 = new System.Windows.Forms.Button();
            this.buttonP3 = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonP1
            // 
            this.buttonP1.Location = new System.Drawing.Point(12, 69);
            this.buttonP1.Name = "buttonP1";
            this.buttonP1.Size = new System.Drawing.Size(75, 23);
            this.buttonP1.TabIndex = 1;
            this.buttonP1.Text = "Painel 1";
            this.buttonP1.UseVisualStyleBackColor = true;
            this.buttonP1.Click += new System.EventHandler(this.ButtonP1_Click);
            // 
            // buttonP2
            // 
            this.buttonP2.Location = new System.Drawing.Point(157, 69);
            this.buttonP2.Name = "buttonP2";
            this.buttonP2.Size = new System.Drawing.Size(75, 23);
            this.buttonP2.TabIndex = 2;
            this.buttonP2.Text = "Painel 2";
            this.buttonP2.UseVisualStyleBackColor = true;
            this.buttonP2.Click += new System.EventHandler(this.ButtonP2_Click);
            // 
            // buttonP3
            // 
            this.buttonP3.Location = new System.Drawing.Point(307, 69);
            this.buttonP3.Name = "buttonP3";
            this.buttonP3.Size = new System.Drawing.Size(75, 23);
            this.buttonP3.TabIndex = 3;
            this.buttonP3.Text = "Painel 3";
            this.buttonP3.UseVisualStyleBackColor = true;
            this.buttonP3.Click += new System.EventHandler(this.ButtonP3_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelWelcome.Location = new System.Drawing.Point(31, 18);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(325, 26);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Selecione o painel a ser exibido:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 112);
            this.Controls.Add(this.buttonP3);
            this.Controls.Add(this.buttonP2);
            this.Controls.Add(this.buttonP1);
            this.Controls.Add(this.labelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de atendimento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonP1;
        private System.Windows.Forms.Button buttonP2;
        private System.Windows.Forms.Button buttonP3;
        private System.Windows.Forms.Label labelWelcome;
    }
}

