using MySql.Data.MySqlClient;
using Projeto.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Repositorio.MySQL
{
    public class ClienteDal
    {
        public static IList<Cliente> Listar()
        {
            using (var conn = ConnMySql.GetConnection())
            {
                try
                {
                    var sql = "SELECT * FROM cadcli where ccli_delete = ''";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        conn.Open();

                        var clientes = new List<Cliente>();

                        var reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                clientes.Add(new Cliente
                                {
                                    Codigo = (string)reader["cecli_cod"],
                                    Nome = (string)reader["ccli_nome"],
                                    Endereco = (string)reader["ccli_end"],
                                    Numero = (string)reader["ccli_num"],
                                    Complemento = (string)reader["ccli_compl"],
                                    Bairro = (string)reader["ccli_bairro"],
                                    Municipio = (string)reader["ccli_mun"],
                                    Uf = (string)reader["ccli_uf"],
                                    Latitude = 0,
                                    Longitude = 0
                                });
                            }

                        return clientes;
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

        public static Cliente Encontrar (string codigo)
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
