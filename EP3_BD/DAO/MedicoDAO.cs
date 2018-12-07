using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP3_BD.Model;
using MySql.Data.MySqlClient;

namespace EP3_BD.DAO {
    class MedicoDAO {
        public static List<Medico> ConsultarEspecialidade(String especialidade) {
            List<Medico> medicos = new List<Medico>();
            BDConnection bDConnection = new BDConnection("localhost", "mydb", "root", "123456");
            MySqlConnection connection = bDConnection.connect();
            var command = connection.CreateCommand();

            try {
                connection.Open();
                command.CommandText = 
                    "SELECT M.CRM,M.NOME,M.TELEFONE " +
                    "FROM MEDICO M, EXERCE EX, ESPECIALIDADE ES " +
                    "WHERE M.CRM = EX.CRM " +
                    "AND EX.ESPECIALIDADE_CODIGO = ES.CODIGO " +
                    "AND ES.NOME = '" + especialidade + "'";
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        var crm = Convert.ToInt32(reader["CRM"]);
                        var nome = Convert.ToString(reader["NOME"]);
                        var telefone = Convert.ToString(reader["TELEFONE"]);
                        var medico = new Medico(crm, nome, telefone);
                        medicos.Add(medico);
                    }
                }

            } finally {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }



            return medicos;
        }
    }
}
