
using  VoeAirlines.Entities.Enums;
namespace VoeAirlines.ViewModels;



public class AdicionarAeronaveViewModels 
{


     public AdicionarAeronaveViewModels(string fabricante, string modelo, string codigo,TipoAeronave tipo )
     {
      Fabricante = fabricante;
      Modelo = modelo;
      Codigo = codigo;
      Tipo = tipo;
     }

     public string Fabricante {get; set;}
     public string Modelo {get; set;}
     public string Codigo {get; set;}
     public TipoAeronave Tipo { get; set; }
}




