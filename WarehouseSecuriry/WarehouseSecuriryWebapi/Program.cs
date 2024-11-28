using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var servicename = "Security";

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen( c => {
    c.SwaggerDoc("v1",new OpenApiInfo{
        Version = "v1",
        Title = $"{servicename} WebApi",
        Description = $"Backend {servicename} WebApi"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI( options => //UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    }
    );
}
// Add swagger 

app.MapControllers();
app.Run();


