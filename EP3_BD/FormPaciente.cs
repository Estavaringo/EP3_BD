﻿using EP3_BD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EP3_BD.DAO;

namespace EP3_BD {
    public partial class FormPaciente : Form {
        private FormAgendar formAgendar;
        private string especialidade;
        private string medico;
        private int horario;
        private DateTime data;


        public FormPaciente(FormAgendar formAgendar, string especialidade, string medico, int horario, DateTime data) {
            this.formAgendar = formAgendar;
            this.especialidade = especialidade;
            this.medico = medico;
            this.horario = horario;
            this.data = data;
            InitializeComponent();
        }

        private void FormPaciente_FormClosed(object sender, FormClosedEventArgs e) {
            formAgendar.Show();
        }

        private void FormPaciente_Load(object sender, EventArgs e) {
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
        }

        private void btnAgendar_Click(object sender, EventArgs e) {
            bool ok = true;
            txtCPF.Text = txtCPF.Text.Trim();
            txtIdade.Text = txtIdade.Text.Trim();
            txtNome.Text = txtNome.Text.Trim();
            txtTelefone.Text = txtTelefone.Text.Trim();
            if (txtCPF.Text.Equals("")) {
                ok = false;
            }
            if (txtIdade.Text.Equals("")) {
                ok = false;
            }
            if (txtNome.Text.Equals("")) {
                ok = false;
            }
            if (txtTelefone.Text.Equals("")) {
                ok = false;
            }

            if (!cmbSexo.SelectedItem.ToString().Equals("M")) {
                if (!cmbSexo.SelectedItem.ToString().Equals("F")) {
                    ok = false;
                }
            }

            if (ok) {
                String cpf = txtCPF.Text;
                String nome = txtNome.Text;
                int idade = int.Parse(txtIdade.Text);
                String telefone = txtTelefone.Text;
                String sexo = cmbSexo.SelectedItem.ToString();
                Paciente paciente = new Paciente(cpf, nome, idade, telefone, sexo);

                ConsultaDAO.inserirConsulta(paciente, medico, especialidade, horario, data);

                formAgendar.Show();
                this.Hide();

            }

        }
    }
}
