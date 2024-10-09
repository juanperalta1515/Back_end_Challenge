using Back_end_Challenge.Models;

namespace Back_end_Challenge.Services.Contrato
{
    public interface IEmpleadoService
    {
        Task<List<Empleado>> GetList();
        Task<Empleado> Get(int IdEmpleado);
        Task<Empleado> Add(Empleado modelo);
        Task<bool> Update(Empleado modelo);
        Task<bool> Delete(Empleado modelo);

    }
}
