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
using EP3_BD.Model;

namespace EP3_BD {
    public partial class FormAgendar : Form {

        Form formMain;
        List<Especialidade> especialidades;
        List<Medico> medicos;
        List<Agenda> agendas;

        public FormAgendar(Form formMain) {
            InitializeComponent();
            this.formMain = formMain;
            //dtPicker.MinDate = DateTime.Now;
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {

            if (cmbHorario.SelectedItem != null) {
                if (!cmbHorario.SelectedItem.ToString().Equals(" ")){
                    new FormPaciente(this, cmbEspecialidade.SelectedItem.ToString(), cmbMedico.SelectedItem.ToString(), Int16.Parse(cmbHorario.SelectedItem.ToString()), dtPicker.Value.Date).Show();
                    this.Hide();
                }
            }

        }

        private void FormAgendar_Load(object sender, EventArgs e) {
            lblDia.Hide();
            lblMedico.Hide();
            lblHorario.Hide();
            dtPicker.Hide();
            cmbMedico.Hide();
            cmbHorario.Hide();

            cmbEspecialidade.Items.Add(" ");
            


            especialidades = EspecialidadeDAO.Consultar();
            foreach (Especialidade especialidade in especialidades) {
                cmbEspecialidade.Items.Add(especialidade.nome);
            }

        }

        private void FormAgendar_FormClosed(object sender, FormClosedEventArgs e) {
            formMain.Show();
        }

        private void cmbEspecialidade_SelectedIndexChanged(object sender, EventArgs e) {
            cmbMedico.SelectedItem = null;
            cmbMedico.Items.Clear();
            cmbMedico.Items.Add(" ");
            if (cmbEspecialidade.SelectedItem.ToString().Equals(" ")) {
                lblDia.Hide();
                lblMedico.Hide();
                lblHorario.Hide();
                dtPicker.Hide();
                cmbMedico.Hide();
                cmbHorario.Hide();
            } else {
                lblMedico.Show();
                cmbMedico.Show();
                medicos = MedicoDAO.ConsultarEspecialidade(cmbEspecialidade.SelectedItem.ToString());
                foreach (Medico medico in medicos) {
                    cmbMedico.Items.Add(medico.nome);
                }
            }
        }

        private void cmbMedico_SelectedIndexChanged(object sender, EventArgs e) {
            dtPicker.Hide();
            cmbHorario.SelectedItem = null;
            cmbHorario.Items.Clear();
            cmbHorario.Items.Add(" ");
            if (cmbMedico.SelectedItem != null) {
                if (cmbMedico.SelectedItem.ToString().Equals(" ")) {
                    lblDia.Hide();
                    lblHorario.Hide();
                    dtPicker.Hide();
                    cmbHorario.Hide();
                } else {
                    lblDia.Show();
                    dtPicker.Show();
                    agendas = AgendaDAO.ConsultarDisponibilidadeDias(cmbMedico.SelectedItem.ToString(),cmbEspecialidade.SelectedItem.ToString());
                }
            } else {
                lblDia.Hide();
                lblHorario.Hide();
                dtPicker.Hide();
                cmbHorario.Hide();
            }
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e) {
            List<int> horarios;
             cmbHorario.SelectedItem = null;
             cmbHorario.Items.Clear();
             cmbHorario.Items.Add(" ");


            var culture = new System.Globalization.CultureInfo("pt-BR");

            if (dtPicker.Value != null) {
                 lblHorario.Show();
                 cmbHorario.Show();
                 cmbHorario.Items.Clear();
                 cmbHorario.Items.Add(" ");
                 horarios = AgendaDAO.ConsultarDisponibilidadeHorarios(dtPicker.Value, cmbMedico.SelectedItem.ToString());
                 foreach (Agenda agenda in agendas) {
                    if (agenda.diaDaSemana.Equals(culture.DateTimeFormat.GetDayName(dtPicker.Value.DayOfWeek).ToString())) {
                        for (int i = agenda.horaInicio; i <= agenda.horaFim; i++) {
                            if (horarios.Contains(i)) continue;
                            cmbHorario.Items.Add(i.ToString());
                        }
                    }
                 }

             } else {
                 lblHorario.Hide();
                 cmbHorario.Hide();
             }
        }
    }
}
