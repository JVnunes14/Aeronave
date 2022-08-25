namespace VoeAirlinesViewModels {

    public class AdicionarCancelamentoViewModels 
    {
        public AdicionarCancelamentoViewModels(string motivo, DateTime dataHoraNotificacao, int vooId)
        {
            Motivo = motivo;
            DataHoraNotificacao = dataHoraNotificacao;
            VooId = vooId;
        }

        public string Motivo { get; set;}
        public DateTime DataHoraNotificacao { get; set;}
        public int VooId {get; set;}
    }

}