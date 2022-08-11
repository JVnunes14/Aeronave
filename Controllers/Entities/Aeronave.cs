namespace VoeAirline.Entitites{
  public class Aeronave {
    public Aeronave (string fabricante, string modelo, string coigo){
        Fabricante = fabricante;
        Modelo = modelo;
        Codigo = codigo;
    }
    public  int Id {get; set;}
    public string Fabricante {get; set;}
    public string Modelo { get; set;}
    public string Codigo {get; set;}

    public ICollection<Manutencao> Manutencoes {get; set; }=null!;

    public ICollection<Voo> Voos { get; set; }
  }

}
