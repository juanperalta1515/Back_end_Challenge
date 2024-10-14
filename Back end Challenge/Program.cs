using Back_end_Challenge.Models;

using Microsoft.EntityFrameworkCore;
using Back_end_Challenge.Services.Contrato;
using Back_end_Challenge.Services.Implementacion;
using AutoMapper;
using Back_end_Challenge.DTOS;
using Back_end_Challenge.Utilidades;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//"Server=(local); DataBase=DBEmpleados; Trusted_Connection=true;TrustServerCertificate=true;"

builder.Services.AddDbContext<DBempleadoContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL")); });
builder.Services.AddScoped<IDepartamentoService, DepartamentoService>();
builder.Services.AddScoped<IEmpleadoService, EmpleadoService>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


#region Peticiones Api Rest
app.MapGet("/departamento/lista", async(
    IDepartamentoService _departamentoServicio, IMapper _mapper) =>
{
    var listaDepartamento = await _departamentoServicio.GetList();
    var listaDepartamentoDTO = _mapper.Map<List<DepartamentoDTO>>(listaDepartamento);

    if (listaDepartamentoDTO.Count > 0)
        return Results.Ok(listaDepartamentoDTO);
    else
        return Results.NotFound();

});



app.MapGet("/empleado/lista", async (
    IEmpleadoService _empleadoServicio, IMapper _mapper) =>
{
    var listaEmpleado = await _empleadoServicio.GetList();
    var listaEmpleadoDTO = _mapper.Map<List<DepartamentoDTO>>(listaEmpleado);

    if (listaEmpleadoDTO.Count > 0)
        return Results.Ok(listaEmpleadoDTO);
    else
        return Results.NotFound();

});
app.MapPost("/empleado/guardar", async (
    EmpleadoDTO modelo,
 IEmpleadoService _empleadoServicio, IMapper _mapper) =>
{

     var _empleado = _mapper.Map<Empleado>(modelo);
    var _empleadoCreado = await _empleadoServicio.Add(_empleado);

    if (_empleadoCreado.IdEmpleado != 0)
        return Results.Ok(_mapper.Map<EmpleadoDTO>(_empleadoCreado));
    else
        return Results.StatusCode(StatusCodes.Status500InternalServerError
            );

 });
app.MapPut("/empleado/actualizar/{IdEmpleado}", async (
    int idEmpleado,
       EmpleadoDTO modelo,
 IEmpleadoService _empleadoServicio, IMapper _mapper

    )=>
{
    var _encontrado = await _empleadoServicio.Get(idEmpleado);

    if (_encontrado is null)return Results.NotFound();
    var _empleado = _mapper.Map<Empleado>(modelo);
    _encontrado.NombreCompleto = _empleado.NombreCompleto;
    _encontrado.IdDepartamento = _empleado.IdDepartamento;
    _encontrado.Sueldo = _empleado.Sueldo;
    _encontrado.FechaContrato = _empleado.FechaContrato;
    var _respuesta = await _empleadoServicio.Update(_encontrado);

    if (_respuesta)
        return Results.Ok(_mapper.Map<EmpleadoDTO>(_encontrado));
    else
        return Results.StatusCode(StatusCodes.Status500InternalServerError);


});
app.MapDelete("/empleado/eliminar/{IdEmpleado}", async (
    int idEmpleado,
 IEmpleadoService _empleadoServicio, IMapper _mapper
    ) => {
        var _encontrado = await _empleadoServicio.Get(idEmpleado);

        if (_encontrado is null) return Results.NotFound();
        var respuesta = await _empleadoServicio.Delete(_encontrado);

        if (respuesta)
            return Results.Ok();
        else
            return Results.StatusCode(StatusCodes.Status500InternalServerError);

    });
#endregion
app.Run();
