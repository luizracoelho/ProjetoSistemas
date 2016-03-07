using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace Projeto.Repositorio.Oracle
{
    public class ConnOracle
    {
        public static OracleConnection GetConnection()
        {
            return new OracleConnection(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString); //Conectar ao MySql
        }
    }
}
