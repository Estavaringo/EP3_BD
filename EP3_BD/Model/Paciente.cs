using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP3_BD.Model {
    class Paciente {
        public int id { get; set; }
        public String CPF { get; set; }
        public String nome { get; set; }
        public int idade { get; set; }
        public String telefone { get; set; }
        public String sexo { get; set; }

        public Paciente(String CPF, String nome, int idade, String telefone, String sexo) {
            this.CPF = CPF;
            this.nome = nome;
            this.idade = idade;
            this.telefone = telefone;
            this.sexo = sexo;
        }
    }
}
