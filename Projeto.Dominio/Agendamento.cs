using System;
using System.Collections.Generic;

namespace Projeto.Dominio
{
    public class Agendamento
    {
        public int AgendamentoId { get; set; }
        public Equipe Equipe { get; set; }
        public int EquipeId { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public DateTime Data { get; set; }
        public Periodo Periodo { get; set; }
        public string Reclamacao { get; set; }
        public IList<Atualizacao> Atualizacoes { get; set; }
    }

    public enum Periodo
    {
        Manha,
        Tarde,
        Noite
    }
}
