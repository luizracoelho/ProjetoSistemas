using Projeto.Dominio;
using Projeto.Repositorio.MySQL;
using System;
using System.Collections.Generic;

namespace Projeto.App
{
    public class EquipeApp
    {
        public static IList<Equipe> Listar()
        {
            try
            {
                return EquipeDal.Listar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Equipe Encontrar(string codigo)
        {
            try
            {
                return EquipeDal.Encontrar(codigo);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
