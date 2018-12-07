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

namespace EP3_BD
{
    public partial class FormConsultar : Form
    {
        Form formMain;
        DataTable dt = new DataTable();
        List<Consulta> consultas = new List<Consulta>();
        
        public FormConsultar(Form formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultas = ConsultaDAO.GetConsultas(Convert.ToInt32(idConsulta.Text));
            foreach ( var x in consultas)
            {
                DataRow dr = dt.NewRow();
                dr["inicio"] = x.inicio;
                dr["Fim"] = x.Fim;
                dr["data"] = x.data;
                dr["pagou"] = x.pagou;
                dr["valor_Pago"] = x.valor_Pago;
                dr["forma_Pagamento"] = x.forma_Pagamento;
                dr["id_paciente"] = x.id_paciente;
                dr["id_diagnostico"] = x.id_diagnostico;
                dr["CRM"] = x.CRM;
                dr["Especialidade_Codigo"] = x.Especialidade_Codigo;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("inicio");
            dt.Columns.Add("Fim");
            dt.Columns.Add("data");
            dt.Columns.Add("pagou");
            dt.Columns.Add("valor_Pago");
            dt.Columns.Add("forma_Pagamento");
            dt.Columns.Add("id_paciente");
            dt.Columns.Add("id_diagnostico");
            dt.Columns.Add("CRM");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
