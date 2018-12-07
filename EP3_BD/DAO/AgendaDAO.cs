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
        public static List<Agenda> ConsultarDisponibilidadeDias(String nomeMedico, String especialidade) {
            List<Agenda> agendas = new List<Agenda>();
            BDConnection bDConnection = new BDConnection("localhost", "mydb", "root", "123456");
            MySqlConnection connection = bDConnection.connect();
            var command = connection.CreateCommand();

            try {
                connection.Open();
                command.CommandText =
                    "SELECT DIASEMANA, HORAINICIO, HORAFIM, MEDICO_CRM  " +
                    "FROM AGENDA A, MEDICO M, EXERCE E, ESPECIALIDADE EP " +
                    "WHERE M.CRM = A.MEDICO_CRM " +
                    "AND M.NOME = '" + nomeMedico + "' " +
                    "AND M.CRM = E.CRM " +
                    "AND E.ESPECIALIDADE_CODIGO = EP.CODIGO " +
                    "AND EP.Nome = '" + especialidade + "'";
               
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

        public static List<Agenda> ConsultarDisponibilidadeDias(String especialidade) {
            List<Agenda> agendas = new List<Agenda>();
            BDConnection bDConnection = new BDConnection("localhost", "mydb", "root", "123456");
            MySqlConnection connection = bDConnection.connect();
            var command = connection.CreateCommand();

            try {
                connection.Open();
                command.CommandText =
                    "SELECT DIASEMANA, HORAINICIO, HORAFIM  " +
                    "FROM AGENDA A, MEDICO M, EXERCE E, ESPECIALIDADE EP " +
                    "WHERE M.CRM = A.MEDICO_CRM " +
                    "AND M.CRM = E.CRM " +
                    "AND E.ESPECIALIDADE_CODIGO = EP.CODIGO " +
                    "AND EP.Nome = '" + especialidade + "'";
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        var dia = Convert.ToString(reader["DIASEMANA"]);
                        var horaInicio = Convert.ToInt16(reader["HORAINICIO"]);
                        var horaFim = Convert.ToInt16(reader["HORAFIM"]);
                        Agenda agenda = new Agenda(dia, horaInicio, horaFim, 0);
                        agendas.Add(agenda);
                    }
                }

            } finally {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }



            return agendas;
        }

        internal static List<int> ConsultarDisponibilidadeHorarios(DateTime data, String medico) {
            List<int> horarios = new List<int>();
            BDConnection bDConnection = new BDConnection("localhost", "mydb", "root", "123456");
            MySqlConnection connection = bDConnection.connect();
            var command = connection.CreateCommand();

            try {
                connection.Open();
                command.CommandText =
                    "SELECT INICIO  " +
                    "FROM CONSULTA C, MEDICO M " +
                    "WHERE M.CRM = C.CRM " +
                    "AND M.NOME = '" + medico + "' " +
                    "AND C.DATA = '" + data + "' ";
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        horarios.Add(Convert.ToInt32(reader["INICIO"]));
                    }
                }

            } finally {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
                        
            return horarios;
        }

    }
}
