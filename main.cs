using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
  .AddControllers()
  .AddJsonOptions(options =>
     options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())
  );

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
