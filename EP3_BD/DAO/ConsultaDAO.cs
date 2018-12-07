using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP3_BD.Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace EP3_BD.DAO
{
    class ConsultaDAO
    {
        public static List<Consulta> GetConsultas(int id)
        {
            List<Consulta> lista = new List<Consulta>();
            BDConnection bDConnection = new BDConnection("sql9.freemysqlhosting.net", "sql9268839", "sql9268839", "fIvFmkmzgc");
            MySqlConnection connection = bDConnection.connect();
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText =
                    "SELECT Inicio, Fim, data, pagou, valor_Pago, forma_Pagamento, id_paciente, id_diagnostico, CRM, Especialidade_Codigo " +
                    "FROM Consulta " +
                    "WHERE id_Consulta = " +id ;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Consulta consulta = new Consulta();
                        consulta.inicio = Convert.ToDateTime(reader["inicio"]);
                        consulta.Fim = Convert.ToDateTime(reader["Fim"]);
                        consulta.data = Convert.ToDateTime(reader["data"]);
                        consulta.pagou = Convert.ToBoolean(reader["pagou"]);
                        consulta.valor_Pago = Convert.ToString(reader["valor_Pago"]);
                        consulta.forma_Pagamento = Convert.ToString(reader["forma_Pagamento"]);
                        consulta.id_paciente = Convert.ToInt32(reader["id_paciente"]);
                        consulta.id_diagnostico = Convert.ToInt32(reader["id_diagnostico"]);
                        consulta.CRM = Convert.ToInt32(reader["CRM"]);
                        consulta.Especialidade_Codigo = Convert.ToInt32(reader["Especialidade_Codigo"]);

                        lista.Add(consulta);
                    }
                }

            }
            finally
            {
                if (connection.State == ConnectionState.Open) { }
                    connection.Close();

            }
            return lista;
             
        }
    }
}
