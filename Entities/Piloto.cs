namespace VoeAirlines.Entities;

public class Piloto{

    public Piloto(string nome, int vooId, string matricula)
    {
        Nome = nome;
        VooId = vooId;
        Matricula = matricula;
    }

    public int Id {get; set;}
    public string Nome {get; set;}
    public int VooId { get; set; }
    public string Matricula {get; set;}

    public ICollection<Voo> Voos { get; set; }=null!;

    
}