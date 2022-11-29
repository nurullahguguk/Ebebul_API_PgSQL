using Ebebul.Core.Repositories;
using Ebebul.Core.UnitofWorks;
using Ebebul.Repository.Repositories;
using Ebebul.Repository.UnitofWorks;
using Ebebul.Repository;
using Microsoft.EntityFrameworkCore;
using Ebebul.Service.Mapping;
using Ebebul.Core.Services;
using Ebebul.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitofWork, UnitofWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfile));


builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseNpgsql(builder.Configuration.GetConnectionString("ServerConnection"), option =>
    {
        option.MigrationsAssembly("Ebebul.Repository");
        //�stteki gibi yazmak yerine dinamik �ekilde vermek i�in Assembly kulland�k. B�ylece Repository ismi de�i�se de bulabilmesi i�in.
        //option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
