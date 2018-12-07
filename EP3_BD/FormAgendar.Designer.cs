namespace EP3_BD {
    partial class FormAgendar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmbEspecialidade = new System.Windows.Forms.ComboBox();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbEspecialidade
            // 
            this.cmbEspecialidade.FormattingEnabled = true;
            this.cmbEspecialidade.Location = new System.Drawing.Point(12, 55);
            this.cmbEspecialidade.Name = "cmbEspecialidade";
            this.cmbEspecialidade.Size = new System.Drawing.Size(215, 21);
            this.cmbEspecialidade.TabIndex = 0;
            this.cmbEspecialidade.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidade_SelectedIndexChanged);
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEspecialidade.Location = new System.Drawing.Point(9, 35);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(196, 17);
            this.lblEspecialidade.TabIndex = 1;
            this.lblEspecialidade.Text = "Selecione uma especialidade:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMedico.Location = new System.Drawing.Point(9, 106);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(146, 17);
            this.lblMedico.TabIndex = 4;
            this.lblMedico.Text = "Selecione um médico:";
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(12, 126);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(215, 21);
            this.cmbMedico.TabIndex = 3;
            this.cmbMedico.SelectedIndexChanged += new System.EventHandler(this.cmbMedico_SelectedIndexChanged);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDia.Location = new System.Drawing.Point(271, 35);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(109, 17);
            this.lblDia.TabIndex = 6;
            this.lblDia.Text = "Selecione o dia:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHorario.Location = new System.Drawing.Point(271, 106);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(135, 17);
            this.lblHorario.TabIndex = 8;
            this.lblHorario.Text = "Selecione o horário:";
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(274, 126);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(106, 21);
            this.cmbHorario.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirmar.Location = new System.Drawing.Point(132, 182);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 47);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(274, 56);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(210, 20);
            this.dtPicker.TabIndex = 10;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // FormAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 249);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.cmbEspecialidade);
            this.Name = "FormAgendar";
            this.Text = "Agendar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAgendar_FormClosed);
            this.Load += new System.EventHandler(this.FormAgendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEspecialidade;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DateTimePicker dtPicker;
    }
}