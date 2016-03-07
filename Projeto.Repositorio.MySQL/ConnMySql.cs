using MySql.Data.MySqlClient;
using System.Configuration;

namespace Projeto.Repositorio.MySQL
{
    public class ConnMySql
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString); //Conectar ao MySql
        }
    }
}
