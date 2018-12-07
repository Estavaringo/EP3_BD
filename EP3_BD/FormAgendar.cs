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
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {

        }

        private void FormAgendar_Load(object sender, EventArgs e) {
            lblDia.Hide();
            lblMedico.Hide();
            lblHorario.Hide();
            cmbDia.Hide();
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
                cmbDia.Hide();
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
            if (cmbMedico.SelectedItem != null) {
                if (cmbMedico.SelectedItem.ToString().Equals(" ")) {
                    lblDia.Hide();
                    lblHorario.Hide();
                    cmbDia.Hide();
                    cmbHorario.Hide();
                } else {
                    lblDia.Show();
                    cmbDia.Show();
                    cmbDia.Items.Clear();
                    cmbDia.Items.Add(" ");
                    agendas = AgendaDAO.ConsultarDisponibilidadeDias(cmbMedico.SelectedItem.ToString());
                    foreach (Agenda agenda in agendas) {
                        cmbDia.Items.Add(agenda.diaDaSemana);
                    }
                }
            } else {
                lblDia.Hide();
                lblHorario.Hide();
                cmbDia.Hide();
                cmbHorario.Hide();
            }
        }
    }
}
