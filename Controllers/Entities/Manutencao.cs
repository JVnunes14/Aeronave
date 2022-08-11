using VoeAirlines.Entitites.Enums;

namespace VoeAirline.Entitites {
    public class Manutencao {
    public Manutencao (DateTime DataHora, TipoManutencao tipo, int aeronaveId ,string? Observacoes=null )
    {
       DateTime = datetime;
       Observacoes = observacoes;
       Tipo = tipo;
       AeronaveId = aeronaveId;
    }
    public int Id {get; set; }
    public DateTime  DataHora { get; set;}
    public string Observacoes { get; set;}
    public TipoManutencao Tipo {get; set;}
    
    public int AeronaveId {get; set;}

    public Aeronave Aeronave {get; set;}=null!;
    
    }
}
