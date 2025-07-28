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

    Materia materia = materiaService.getOne(id);

    if (materia == null)
    {
        return Results.NotFound();
    }

    var dto = new DTOs.MateriaDTO
    {
        Descripcion = materia.Descripcion,
        HsTotales = materia.HsTotales,
        HsSemanales = materia.HsSemanales,
        IDPlan = materia.IDPlan,
        Id = materia.Id
    };

    return Results.Ok(dto);
})
.WithName("GetMateria")
.Produces<DTOs.MateriaDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/materias", () =>
{
    MateriaService materiaService = new MateriaService();

    var materias = materiaService.getAll();

    var dtos = materias.Select(materia=> new DTOs.MateriaDTO
    {
        Descripcion = materia.Descripcion,
        HsTotales = materia.HsTotales,
        HsSemanales = materia.HsSemanales,
        IDPlan = materia.IDPlan,
        Id = materia.Id
    }).ToList();

    return Results.Ok(dtos);
})
.WithName("GetAllMaterias")
.Produces<List<DTOs.MateriaDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/materias", (DTOs.MateriaDTO dto) =>
{
    try
    {
        MateriaService materiaService = new MateriaService();

        Materia materia = new Materia(dto.HsSemanales, dto.Descripcion, dto.HsTotales, dto.IDPlan, dto.Id);

        materiaService.add(materia);

        var dtoResultado = new DTOs.MateriaDTO
        {
            Descripcion = materia.Descripcion,
            HsTotales = materia.HsTotales,
            HsSemanales = materia.HsSemanales,
            IDPlan = materia.IDPlan,
            Id = materia.Id
        };

        return Results.Created($"/materias/{dtoResultado.Id}", dtoResultado);
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

        Materia materia = new Materia(dto.HsSemanales, dto.Descripcion, dto.HsTotales, dto.IDPlan, dto.Id);

        var found = materiaService.update(materia);

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

app.Run();
