using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP3_BD.Model
{
    class Consulta
    {
        public int id_consulta { get; set; }
        public DateTime inicio { get; set; }
        public DateTime Fim { get; set; }
        public DateTime data { get; set; }
        public bool pagou { get; set; }
        public string valor_Pago { get; set; }
        public string forma_Pagamento { get; set; }
        public int id_paciente { get; set; }
        public int id_diagnostico { get; set; }
        public int CRM { get; set; }
        public int Especialidade_Codigo { get; set; }

        public Consulta(DateTime inicio, DateTime Fim, DateTime data, bool pagou, string valor_Pago, string forma_Pagamento, int id_paciente, int id_diagnostico, int CRM,int Especialidade_Codigo)
        {
            this.inicio = inicio;
            this.Fim = Fim;
            this.data = data;
            this.pagou = pagou;
            this.valor_Pago = valor_Pago;
            this.forma_Pagamento = forma_Pagamento;
            this.id_paciente = id_paciente;
            this.id_diagnostico = id_diagnostico;
            this.CRM = CRM;
            this.Especialidade_Codigo = Especialidade_Codigo;
        }

        public Consulta()
        {
        }
    }
}
