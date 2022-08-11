namespace VoeAirlines.Entities;

public class Voo{
     public int Id {get; set;}
     public string Origem {get; set;}
     public string Destino {get; set;}

     public DateTime DataHoraPartida {get; set;}

     public DateTime DataHoraChegada {get; set;}

     public int AeronaveId {get; set;}

     public int PilotoId { get; set;}

    public Aeronave Aeronave {get; set;}=null!;
    public Piloto Piloto {get; set;}=null!;

    public Cancelamento? Cancelamento {get; set;}

    public int MyProperty { get; set; }

    public int MyProperty { get; set; }
}