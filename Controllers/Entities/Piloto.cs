namespace VoeAirlines.Entities;

public class Piloto{
    public Piloto(string nome, string matricula){
        Nome = nome;
        Matricula = matricula;
    }
    public int Id {get; set;}
    public string Nome {get; set;}
    public string Matricula {get; set;}

    public ICollection<Voo> Voos { get; set; }=null!;

    public int VooId { get; set; }
    public Voo Voo {get; set;} =null!;
}