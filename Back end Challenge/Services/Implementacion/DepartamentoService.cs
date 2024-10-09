using Microsoft.EntityFrameworkCore;
using Back_end_Challenge.Models;
using Back_end_Challenge.Services.Contrato;
using Microsoft.AspNetCore.Identity;

namespace Back_end_Challenge.Services.Implementacion
{
    public class DepartamentoService:IDepartamentoService
    {
        private DBempleadoContext _dbContext;
     
        public DepartamentoService(DBempleadoContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Departamento>>GetList()
        {
            try
            {
                List<Departamento> lista = new List<Departamento>();
                lista = await _dbContext.Empleados.Include(dpt => dpt.IdDepartamentoNavigation).ToListAsync();
                return lista;
                
            }catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<Departamento>Get(int idEmpleado)
        {
            try
            {
                Departamento? encontrado = new Departamento();
                encontrado = await _dbContext.Empleados.Include(dpl => dpl.IdDepartamentoNavigation).Where(encontrado => idEmpleado).FirstOrDefaultAsync();
                return encontrado;

            }catch (Exception)
            {
                throw;
            }

        }
        public Task<Departamento>Add(Departamento models)
        {
            try
            {

            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
