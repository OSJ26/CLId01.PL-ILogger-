using CLId01.BLL.Interfcae;
using CLId01.BLL.Service;
using CLId01.DAL.Interface;
using CLId01.DAL.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClid01Get, sClid01Get>();
builder.Services.AddTransient<IClid01Bll, sGetBll>();

/*builder.Services.AddTransient<ILogger,Log>();*/
builder.Services.AddLogging(config =>
{
    config.AddDebug();
    config.AddConsole();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
