using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP3_BD.Model;
using MySql.Data.MySqlClient;

namespace EP3_BD.DAO {
    static class EspecialidadeDAO {

        public static List<Especialidade> Consultar() {
            List<Especialidade> especialidades = new List<Especialidade>();
            BDConnection bDConnection = new BDConnection("sql9.freemysqlhosting.net", "sql9268839", "sql9268839", "123456789");
            MySqlConnection connection = bDConnection.connect();
            var command = connection.CreateCommand();

            try {
                connection.Open();
                command.CommandText = "SELECT INDICE,CODIGO,NOME FROM ESPECIALIDADE";
                using (var reader = command.ExecuteReader()){
                        while (reader.Read()) {
                        var indice = Convert.ToInt32(reader["INDICE"]);
                        var codigo = Convert.ToInt32(reader["CODIGO"]);
                        var nome = Convert.ToString(reader["NOME"]);
                        var especialidade = new Especialidade(indice, codigo, nome);
                        especialidades.Add(especialidade);
                    }
                }

            } finally {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }



            return especialidades;
        }

    }
}
