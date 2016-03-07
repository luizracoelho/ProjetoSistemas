using Projeto.Dominio;
using Projeto.Repositorio.MySQL;
using System;
using System.Collections.Generic;

namespace Projeto.App
{
    public class ClienteApp
    {
        public static IList<Cliente> Listar()
        {
            try
            {
                return ClienteDal.Listar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Cliente Encontrar(string codigo)
        {
            try
            {
                return ClienteDal.Encontrar(codigo);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
