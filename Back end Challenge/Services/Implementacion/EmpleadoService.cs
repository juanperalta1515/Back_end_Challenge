using Microsoft.EntityFrameworkCore;
using Back_end_Challenge.Models;
using Back_end_Challenge.Services.Contrato;


namespace Back_end_Challenge.Services.Implementacion
{
    public class EmpleadoService : IEmpleadoService
    {
        private DBempleadoContext _dbContext;

        public EmpleadoService(DBempleadoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Empleado> Add(Empleado modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Empleado modelo)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> Get(int IdEmpleado)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Empleado>> GetList()
        {
        try{
                List<Empleado> lista = new List<Empleado>();
                lista = await _dbContext.Empleados.ToListAsync();
                return lista;
            }
            catch (Exception ex)
            {
                throw ;

            }
        }

        public Task<bool> Update(Empleado modelo)
        {
            throw new NotImplementedException();
        }
    }
}
