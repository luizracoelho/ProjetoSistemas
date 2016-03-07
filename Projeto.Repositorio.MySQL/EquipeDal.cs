using MySql.Data.MySqlClient;
using Projeto.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Repositorio.MySQL
{
    public class EquipeDal
    {
        public static IList<Equipe> Listar()
        {
            using (var conn = ConnMySql.GetConnection())
            {
                try
                {
                    var sql = "SELECT * FROM cadequip where cequ_delete = ''";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        conn.Open();

                        var equipes = new List<Equipe>();

                        var reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                equipes.Add(new Equipe
                                {
                                    Codigo = (string)reader["cequ_cod"],
                                    Nome = (string)reader["cequ_nome"]
                                });
                            }

                        return equipes;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Clone();
                }
            }
        }

        public static Equipe Encontrar(string codigo)
        {
            try
            {
                return Listar().FirstOrDefault(x => x.Codigo.Equals(codigo));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
