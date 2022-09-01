using  VoeAirlines.Entities.Enums;
namespace VoeAirlines.ViewModels;

public class ListarAeronaveViewModels {
    public ListarAeronaveViewModels(int id, string modelo,TipoAeronave tipo){
        Id = id;
        Modelo = modelo;
        Tipo = tipo;
    }

    public int Id {get; set;}
    public string Modelo { get; set;}
    public TipoAeronave Tipo { get; set; }  
}