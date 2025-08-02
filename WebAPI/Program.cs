using Domain.Services;
using Domain.Model ;
using DTOs;
using Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

    


app.MapGet("/materias/{id}", (int id) =>
{
    MateriaService materiaService = new MateriaService();

    MateriaDTO dto= materiaService.getOne(id);

    if (dto == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(dto);
})
.WithName("GetMateria")
.Produces<DTOs.MateriaDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/materias", () =>
{
    MateriaService materiaService = new MateriaService();


    var dtos = materiaService.getAll();

    return Results.Ok(dtos);

})
.WithName("GetAllMaterias")
.Produces<List<DTOs.MateriaDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/materias", (MateriaDTO dto) =>
{
    try
    {
        MateriaService materiaService = new MateriaService();

        MateriaDTO materiaDto = materiaService.add(dto);

        return Results.Created($"/materias/{materiaDto.Id}", materiaDto);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddMateria")
.Produces<DTOs.MateriaDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/materias", (DTOs.MateriaDTO dto) =>
{
    try
    {
        MateriaService materiaService = new MateriaService();

        var found = materiaService.update(dto);

        if (found == null)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateMateria")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/materias/{id}", (int id) =>
{
    MateriaService materiaService = new MateriaService();

    var deleted = materiaService.delete(id);

    if (deleted != null)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
        
})
.WithName("DeleteMateria")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/usuarios/{id}", (int id) =>
{
    UsuarioService usuarioService = new UsuarioService();

    UsuarioDTO dto = usuarioService.GetOne(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetUsuario")
.Produces<UsuarioDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/usuarios", () =>
{
    UsuarioService usuarioService = new UsuarioService();

    var dtos = usuarioService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllUsuarios")
.Produces<List<UsuarioDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/usuarios", (UsuarioDTO dto) =>
{
    try
    {
        UsuarioService usuarioService = new UsuarioService();

        UsuarioDTO clienteDTO = usuarioService.Add(dto);

        return Results.Created($"/usuarios/{clienteDTO.Id}", clienteDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddUsuario")
.Produces<UsuarioDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/usuarios", (UsuarioDTO dto) =>
{
    try
    {
        UsuarioService usuarioService = new UsuarioService();

        var found = usuarioService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateUsuario")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/usuarios/{id}", (int id) =>
{
    UsuarioService usuarioService = new UsuarioService();

    var deleted = usuarioService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeleteUsuario")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();


app.Run();
