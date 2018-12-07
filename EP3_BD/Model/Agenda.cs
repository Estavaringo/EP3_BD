using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP3_BD.Model {
    class Agenda {
        public int codigo { get; set; }
        public String diaDaSemana { get; set; }
        public int horaInicio { get; set; }
        public int horaFim { get; set; }
        public int crm { get; set; }

        public Agenda(String diaDaSemana, int horaInicio, int horaFim, int crm) {
            this.diaDaSemana = diaDaSemana;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.crm = crm;
        }
    }
}
