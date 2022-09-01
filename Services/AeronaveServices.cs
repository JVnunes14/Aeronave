using VoeAirlines.Entities;
using VoeAirlines.Contexts;
using VoeAirlines.ViewModels;
using VoeAirlines.Entities.Enums;

namespace VoeAirlines.Services;

public class AeronaveServices{
    
    
    //propriedade para injeção de dependência
    private readonly VoeAirlinesContext _context;

    public AeronaveServices(VoeAirlinesContext context)
    {
        _context = context;
    }

    public DetalhesAeronaveViewModels AdicionarAeronave(AdicionarAeronaveViewModels dados)
    {
        

        var aeronave = new Aeronave(dados.Fabricante, dados.Modelo, dados.Codigo,dados.Tipo);

        _context.Add(aeronave);
        _context.SaveChanges();

        return new DetalhesAeronaveViewModels
        (
            aeronave.Id,
            aeronave.Fabricante,
            aeronave.Modelo,
            aeronave.Codigo,
            aeronave.Tipo
        );
    } 

    public IEnumerable<ListarAeronaveViewModels> ListarAeronave() {
  
       return _context.Aeronaves.Select(a=>new ListarAeronaveViewModels(a.Id,a.Modelo,a.Tipo));

    }


}