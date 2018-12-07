using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP3_BD.Model {
    class Especialidade {

        public int indice { get; set; }
        public int codigo { get; set; }
        public String nome { get; set; }

        public Especialidade(int indice, int codigo, String nome) {
            this.indice = indice;
            this.codigo = codigo;
            this.nome = nome;
        }
    }
}
