using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP3_BD.Model;
using MySql.Data.MySqlClient;

namespace EP3_BD.DAO {
    class AgendaDAO {
        public static List<Agenda> ConsultarDisponibilidadeDias(String nomeMedico) {
            List<Agenda> agendas = new List<Agenda>();
            BDConnection bDConnection = new BDConnection("localhost", "mydb", "root", "123456");
            MySqlConnection connection = bDConnection.connect();
            var command = connection.CreateCommand();

            try {
                connection.Open();
                command.CommandText =
                    "SELECT DIASEMANA, HORAINICIO, HORAFIM, MEDICO_CRM  " +
                    "FROM AGENDA A, MEDICO M " +
                    "WHERE M.CRM = A.MEDICO_CRM " +
                    "AND M.NOME = '" + nomeMedico + "'";
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        var dia = Convert.ToString(reader["DIASEMANA"]);
                        var horaInicio = Convert.ToInt16(reader["HORAINICIO"]);
                        var horaFim = Convert.ToInt16(reader["HORAFIM"]);
                        var crm = Convert.ToInt32(reader["MEDICO_CRM"]);
                        Agenda agenda = new Agenda(dia, horaInicio, horaFim, crm);
                        agendas.Add(agenda);
                    }
                }

            } finally {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }



            return agendas;
        }
    }
}
