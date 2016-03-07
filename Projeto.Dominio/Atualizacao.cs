using System;

namespace Projeto.Dominio
{
    public class Atualizacao
    {
        public int AtualizacaoId { get; set; }
        public Agendamento Agendamento { get; set; }
        public int AgendamentoId { get; set; }
        public Status Status { get; set; }
        public DateTime DataHora { get; set; }
        public string Solucao { get; set; }
    }

    public enum Status
    {
        Agendado,
        Executado,
        NaoExecutado
    }
}
