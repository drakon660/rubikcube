using FastEndpoints;
using FastEndpoints.Swagger;

var  developmentCorsPolicy = "developmentCorsPolicy";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: developmentCorsPolicy,
        policy  =>
        {
            policy.AllowAnyOrigin();
            policy.AllowAnyMethod();
            policy.AllowAnyHeader();
        });
});

builder.Services.AddOpenApi();
builder.Services.AddFastEndpoints().SwaggerDocument();;
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseCors(developmentCorsPolicy);
}

app.UseFastEndpoints().UseSwaggerGen();
app.Run();
