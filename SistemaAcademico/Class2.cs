using Oracle.ManagedDataAccess.Client;

namespace SistemaAcademico
{
    public class Conexao
    {
        public OracleConnection GetConnection()
        {
            string conexao =
                "User Id=system;" +
                "Password=coins321;" +
                "Data Source=localhost:1521/XE;";

            OracleConnection conn =
                new OracleConnection(conexao);

            return conn;
        }
    }
}