using Back_end_Challenge.Models;

namespace Back_end_Challenge.Services.Contrato
{
    public interface IDepartamentoService
    {
        Task<Departamento> Add(Departamento models);
        Task<List<Departamento>> GetList();
    }
}
