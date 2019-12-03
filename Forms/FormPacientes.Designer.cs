namespace Painel_Pacientes.Screens
{
    partial class FormPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacientes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelNomePaciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.labelHours.Location = new System.Drawing.Point(51, 12);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(103, 39);
            this.labelHours.TabIndex = 2;
            this.labelHours.Text = "00:00";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.labelSeconds.Location = new System.Drawing.Point(144, 17);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(47, 33);
            this.labelSeconds.TabIndex = 3;
            this.labelSeconds.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelNomePaciente
            // 
            this.labelNomePaciente.AutoSize = true;
            this.labelNomePaciente.BackColor = System.Drawing.Color.Transparent;
            this.labelNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomePaciente.ForeColor = System.Drawing.Color.Silver;
            this.labelNomePaciente.Location = new System.Drawing.Point(48, 206);
            this.labelNomePaciente.Name = "labelNomePaciente";
            this.labelNomePaciente.Size = new System.Drawing.Size(487, 59);
            this.labelNomePaciente.TabIndex = 4;
            this.labelNomePaciente.Text = "Salmo Mascarenhas";
            this.labelNomePaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(140, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "aguardando";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(583, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 606);
            this.panel1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(13, 446);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 123);
            this.panel5.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(13, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 33);
            this.label9.TabIndex = 10;
            this.label9.Text = "aguardando";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 37);
            this.label10.TabIndex = 9;
            this.label10.Text = "Leandro Faustino";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(13, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 123);
            this.panel4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(13, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 33);
            this.label7.TabIndex = 10;
            this.label7.Text = "aguardando";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 37);
            this.label8.TabIndex = 9;
            this.label8.Text = "Leandro Faustino";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(13, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 123);
            this.panel3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(13, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "em atendimento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Leandro Faustino";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(13, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 123);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "aguardando";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Leandro Faustino";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "histórico de chamadas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(939, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNomePaciente);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelNomePaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}