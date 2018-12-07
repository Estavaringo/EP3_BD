using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP3_BD.Model {
    class Medico {
        public int crm { get; set; }
        public String nome { get; set; }
        public String telefone { get; set; }

        public Medico(int crm, String nome, String telefone) {
            this.crm = crm;
            this.nome = nome;
            this.telefone = telefone;
        }
    }
}
