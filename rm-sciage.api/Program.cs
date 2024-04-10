using rm_sciage.api.Configuration;
using rm_sciage.api.Middleware;
using rm_sciage.application;
using rm_sciage.persistance;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c => c.EnableAnnotations());
builder.Services.ConfigureCorsServices(builder.Configuration);
builder.Services.AddPersistanceServices(builder.Configuration);
builder.Services.AddApplication();

var app = builder.Build();

app.UseSwagger(); 
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseDefaultCors();
app.UseCustomExceptionHandler();
app.MapControllers();

app.Run();